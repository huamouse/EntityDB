using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Way.EntityDB.DataBaseService
{
    class SchemaManager
    {
        static System.Collections.Concurrent.ConcurrentDictionary<Type, SchemaTable> Dict = new System.Collections.Concurrent.ConcurrentDictionary<Type, SchemaTable>();
         public static SchemaTable GetSchemaTable(Type tableType)
        {
            SchemaTable ret;
            if (Dict.TryGetValue(tableType , out ret ))
            {
                return ret;
            }
            else
            {
                ret = new SchemaTable();
                var tableAttr = tableType.GetCustomAttribute<TableAttribute>();
                ret.TableName = tableAttr.Name;

                var proInfos = tableType.GetProperties();
                foreach( var pro in proInfos )
                {
                    var columnAttr = pro.GetCustomAttribute<ColumnAttribute>();
                    if(columnAttr != null)
                    {
                        var column = new SchemaColumn();
                        column.Name = columnAttr.Name;
                        column.IsKey = pro.GetCustomAttribute<KeyAttribute>() != null;
                        if (column.IsKey && ret.KeyName == null)
                            ret.KeyName = column.Name;

                        var attr = pro.GetCustomAttribute<DatabaseGeneratedAttribute>();
                        if (attr != null && attr.DatabaseGeneratedOption != DatabaseGeneratedOption.None)
                            column.IsDatabaseGenerated = true;

                        var displayAttr = pro.GetCustomAttribute<DisplayAttribute>();
                        if (displayAttr != null)
                            column.Display = displayAttr.Name;

                        ret.Columns.Add(column);
                    }
                }

                Dict.TryAdd(tableType, ret);
                return Dict[tableType];
            }
        }
    }

    class SchemaTable
    {
        public string TableName;
        public string KeyName;
        public List<SchemaColumn> Columns = new List<SchemaColumn>();
    }
    class SchemaColumn
    {
        public string Name { get; set; }
        public string Display { get; set; }
        public bool IsKey { get; set; }
        /// <summary>
        /// 自增长
        /// </summary>
        public bool IsDatabaseGenerated { get; set; }
    }
}
