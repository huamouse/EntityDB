﻿using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Way.EntityDB.DataBaseService;

namespace Way.EntityDB
{
    [Attributes.DatabaseTypeAttribute(DatabaseType.PostgreSql)]
    class PostgreSQLService :SqliteService
    {

        public PostgreSQLService()
        {
        }
        public PostgreSQLService(DBContext dbcontext):base(dbcontext)
         {

        }

        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(this.ConnectionString);
        }
      

        public override void AllowIdentityInsert(string tablename, bool allow)
        {
           
        }
        public override WayDataTable SelectTable(string sql, int skip, int take, params object[] sqlparameters)
        {
            sql = $"select * from ({sql}) as t1 limit {take} offset {skip}";
            return SelectTable(sql, sqlparameters);
        }

        public override void UpdateLock(Type tableType, object pkValue)
        {
            var tableSchema = SchemaManager.GetSchemaTable(tableType);
            var pkColumn = tableSchema.Columns.FirstOrDefault(m => m.IsKey);
            var columnname = FormatObjectName(pkColumn.Name.ToLower());
            this.ExecSqlString($"select {FormatObjectName(columnname)} from {FormatObjectName(tableSchema.TableName.ToLower())} where {columnname}=@p0 for update", pkValue);
        }

        public override string FormatObjectName(string name)
        {
            return $"\"{name}\"";
        }
        protected override bool GetInsertIDValueSqlStringInOneSql()
        {
            return true;
        }
        protected override string GetInsertIDValueSqlString(string pkColumnName)
        {
            if (pkColumnName.IsNullOrEmpty())
                return null;
            return $"RETURNING {pkColumnName}";
        }

        protected override void ThrowSqlException(Type tableType, Exception ex)
        {
            if (!(ex is NpgsqlException))
                throw ex;
            PostgresException nerror = ex as PostgresException;
            if(nerror.SqlState != "23505" || nerror.Detail.Contains(" already exists") == false)
                throw ex;

            StringBuilder output = new StringBuilder();
            string[] captions = null;
            string[] keys = null;
            try
            {
                string msg = nerror.Detail;
                var tableSchema = SchemaManager.GetSchemaTable(tableType);


                try
                {
                    var match = Regex.Match(msg, @"Key \((?<c>(\w| |,)+)\)");
                    if (match != null && match.Length > 0)
                    {
                        string indexname = match.Groups["c"].Value;
                        keys = indexname.Split(',');
                        keys = (from m in keys
                                select m.Trim()).ToArray();

                        captions = new string[keys.Length];

                        for (int i = 0; i < keys.Length; i++)
                        {
                            var column = tableSchema.Columns.FirstOrDefault(m => m.Name == keys[i]);
                            if (column == null)
                            {
                                output.Append(keys[i]);
                                continue;
                            }

                            captions[i] = column.Display;
                            if (output.Length > 0)
                                output.Append(',');

                            output.Append(column.Display.IsNullOrEmpty() ? keys[i] : column.Display);
                        }
                    }
                }
                catch (Exception ee)
                {
                    throw ex;
                }

            }
            catch
            {
                throw ex;
            }
            throw new RepeatValueException(keys, captions, "此" + output + "已存在");
        }

        public override string ConvertConnectionString(string conStr)
        {
            Npgsql.NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder(conStr);
            if(builder.Database != null)
            {
                builder.Database = builder.Database.ToLower();
            }
           
            return builder.ToString();
        }

    }
}
