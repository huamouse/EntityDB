using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Way.EntityDB.Design;
using Way.EntityDB.Design.Actions;
using System;
using Way.EntityDB.Design.Services;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Way.EntityDB.Test
{ 
    [TestClass]
    public class UnitTest1
    {
        const string SqlServerConstr = "server=192.168.136.137;uid=sa;pwd=Sql12345678;Database=TestDB";
        const string PostgreSqlConStr = "Server=192.168.136.137;Port=5432;UserId=postgres;Password=123456;Database=TestDB;";
        const string MySqlConStr = "server=192.168.136.137;User Id=user1;password=User.123456;Database=TestDB";

        [TestMethod]
        public void ConnectionString_Check()
        {
            System.Data.SqlClient.SqlConnectionStringBuilder conStrBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder("server=ETHAN-20171016H;uid=sa;pwd=123;Database=TestDB");
            conStrBuilder.InitialCatalog = "master";
            var constr = conStrBuilder.ToString();

            //Server=;Port=5432;UserId=;Password=;Database=;
            Npgsql.NpgsqlConnectionStringBuilder conStrBuilder2 = new Npgsql.NpgsqlConnectionStringBuilder("Server=localhost;Port=5432;UserId=sa;Password=1;Database=testDB;");
            conStrBuilder2.Database = null;
            constr = conStrBuilder2.ToString();

            Pomelo.Data.MySql.MySqlConnectionStringBuilder conStrBuilder3 = new Pomelo.Data.MySql.MySqlConnectionStringBuilder("server=locahost;User Id=sa;password=12;Database=testDB");
            conStrBuilder3.Database = null;
            constr = conStrBuilder3.ToString();

            //server=;User Id=;password=;Database=
        }
        [TestMethod]
        public void SqlServer_Insert_Check()
        {

            var db = new MyDB.DB.TestDB(SqlServerConstr, Way.EntityDB.DatabaseType.SqlServer);
            db.BeginTransaction();
            //插入数据
            var user = new MyDB.UserInfo()
            {
                UserName = "Jack",
                Password = "123"
            };
            db.Update(user);
            db.RollbackTransaction();
        }

        [TestMethod]
        public void PostgreSql_Insert_Check()
        {
            var db = new MyDB.DB.TestDB(PostgreSqlConStr, Way.EntityDB.DatabaseType.PostgreSql);
            db.BeginTransaction();
            
            //插入数据
            var user = new MyDB.UserInfo()
            {
                UserName = "Jack",
                Password = "123"
            };
            db.Update(user);
            db.RollbackTransaction();
        }
        [TestMethod]
        public void UpgradeData_Check()
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            result.Append("\r\n");
            result.Append("H4sIAAAAAAAAC+1d60/bSBD/X/w5HLFjElKpHzi4k6KeKDro9aSmH0y8AauOzTlOqwhFAvXaclWrXl9HVfqi6gPdVYVeUWmL7u6fwUn4L279wHGcB3nZrJ35Avbuej2T3Z39zezMeJma4+ZFlKdOXVg2L6e5HKJOUbO/iIKKqAj1o3zFrE2pKGdeWU0EHlf/xIkFfEOX");
            result.Append("Ina5WlxCtRpqUkGcioy+JzKqIEuUo21GllQkqY7my2mTjjR1Cl8KPP5PR9JUhlvSn8V3aaryYKu8tnd474N261qawpV6Z0bNeU4UkWqUTXEqN8/lUWrK6kH4Qc5cwtfREr6ZlMVCTsrj2wvOt9gd6SX4PpWfKKhySsooKIfJxFWqUkD685w0XRBFXJDlxLxews/PYb7N");
            result.Append("h/WWEYsP+/2p/MwZ48bqQlZ4pBhvxhQdEcG4WK3uvtHu7NUzOZHJyAXrFY0EHtFTo9B6n4PAy5ySWeQUowcRSQvqolE8Fm1H9lHHNbrpGt2xRrrxEGnb1w/vva6nfhZhWgkgnqkRzzrpO4OKdB/UCTluAblp646yWI2yMRdlzMlSxpYu6g2mfp6UpaywYCwfs8SYxc6F");
            result.Append("zVvLr15IXDTkyayKBYI57dtLFcZLqeJeagdfX5Uf3dfW1qubW/VTdk7hpDxnvKU30RL3ULQwnYqWRKOgTPH9zCeLlNazielYfIw3lfDVG39qex8qj381h8b64WwezuWRog9NX1x0Kk2YjqVJ0sXL4Y27hy+fukR4rk8JzssFYzY3+f15lOUKomrMfKO0S1Yc4oeOunjR");
            result.Append("Pq9W3t6u52WyoChIyhQHNAjfSYXcFMoKklnlZpGONmeyOx5ZB49udKHt/V1+sH2w/6jZwM1wRcSTPHpjDs7cEs5kC6+nysZ7/Fe7+QJv0NXdt3hUtSc72tMV18AWl1R5UhakCZ5XUD5/8qss7mDOjTgqNz+VV1ZdWANvNIX8AGSca1KOjmr/XjN/zXRaOs8J6veygqfG");
            result.Append("abxe0tLoqDV/rm5pa9dxwQynqAInGnPnNG020a5t4Xq7jwnRqmY8mRUJnzfuWJuNe5GTFrrauM+KvK2ZNN2Pp9GV9g1kdREpsC/Dvgz7MuzLsC/DvkzWviyhK47NSS/JGJsk7yrlEdbZGkr929VZL9VxN55zotPKx/3K/nNbEWymo9tgVd/7ezQAsh6q6bFO1XR6rLld");
            result.Append("wm0FNDCOF6ovHY22o72tHk/H3SrH2t2D/XemqdYeRQc8sxhohtw8Nk4cwxTjM2LW9TZAzGDJOnEdGyxZYMkCSxZYskw4bNqwbDgMiLm7XT3u6a7uOO1uMIE56lpZv+DAGw684cC7gwPvoOjnCU+lTaOG3SB0Gpu0lD1k6NohU1c7majd2hnqxpQQgwO++5bLXCosmdOa");
            result.Append("n1HkJYRteUjncNkmXp/FirAgSJxYs9DZbJRKJRIW7Tgo/uDCAi4s4MICLizgwkKOC0sgFH8byyTcZ/srjyvPX5tehJbX0/798rMnGM2ZVc38naZlVcgWzymiHxDnWCc8ctWMJBg1jtErwIsfvPhJ9+JvIUnHg+rxSwdXoNJGE3CXhDAGOPwdGF4Mr4t/PMwu/omAuPgT");
            result.Append("px/pdsSQq0O9n8OEPqBpzGd3NdrTgG/WPX+NAxlt+4v29cHB59va77fMcdMlnBFifPDfZnl1u34YzRNwW8KlpKzco19o0sOzKvYY3OPzsDI+OCw0DkkL74XGhi2PE096iJprU0zU95hbtmNfXYYOqixkO/ZgZBifQ/vZjo0CTMxnqwDbiVWAUAXZ23hC8KOCxCHdJA4Z");
            result.Append("DBYlLOsIS6y90hnSHm7zpI8StV0sF0Rom9oAZE6BeJNulPDwmhwhqwiYHNvbaofC5GjrbmxQYcixwX8EK4HehsiG0b09wC7ew+2kT8R68zZ4DZI4QXLF7jMSBj254lhoVQTwSgAVYci8Ehz6fsg1ghZqkBtfut2J8EiWN3bLf+yU1z8dru+6fo1Jq9W5JYxX0Jygl/cu");
            result.Append("2XAX6lEXPackTpKs/3gb3gt4DPAY4DHAY+AlCl6igMcIxmORsMOvwBjIIHUDfH2EiK+PgIEMDGQQtuN12I71bY/1F+WHa/gyJV3mRIHHNclkEkJ6wHg2iKxcfWI6M/KGCCjXT46uptiUkHxdtLfpL8AM55cZDo4S4SgRApwBKcExI+FmLW1tQ9v/Sjre6Rrq9fTN07MF");
            result.Append("FSMEHk3LBFgd+oF4zo+3EoLsGEjDM8T2PKJWFqBUcHiDNDxgzwNnuMAcvgYWpdocueMstH/ua7/dPnyyUn2zqm08q+5cleqcL20GU/lphHjTM7MPFucF1SOfa3LPkJl2eZTAmgiYEzBnf6EI4QqySIQ59eP4EKR+9P0MWT+tggCMQAdgBBxz0tEBJUwKOUD1EXR6m+UR");
            result.Append("jrDB0AmGzvCATojsBdDZO5KHqF8AnYQZOt1T0jwQrL78q7L5vvr+le5i+W6z/HDHBal1cKbkOP2xQWidgxbTFs4m1M7pbQZfgJwAOQFyAuQMhJ1zGD5xA7EykGhmyOyc/QYvDwc89RFyepvifBjyhdadIX75qN3Zsd0nIYkoQUlEbdExHkzREQvut1sZyEoMUiaMqYoj");
            result.Append("QyFUWsjRJFkHNLHgfrqL8TaLNKCwFtYOSOUO8rFP+RgJtDgMShYxxtu0riAgQUACgPRDQDb1xSbT4acHAXrEaizqYsUf22ssuCE+MW/DyuHjtfDxWv8+XjvYpYNvrb4pffGY184lNIV70UUFvp8t5vEq+yYlqXHWeFFda2tdNbafVRVBWmh8oLa4On+mjqeWpF3U2dJr");
            result.Append("Z5FqPRhLRDmeRvRIgmXoEZalkyMcjeIjiQTD8FkW0XGUpUr/A9lm95SMvwAA");
            var data = result.ToString();

            Way.EntityDB.Design.DBUpgrade.Upgrade(null, data);
        }

        [TestMethod]
        public void CreateDb()
        {
            var file = $"{AppDomain.CurrentDomain.BaseDirectory}testej.db";
            if (File.Exists(file))
                File.Delete(file);
            using (var db = new TDB.DB.TestDB($"data source=\"{file}\"", DatabaseType.Sqlite))
            {

            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            using (var db = new MySqliteEmptyDBContext())
            {
                var generator = db.GetService<IMigrationsSqlGenerator>();

                List<MigrationOperation> operations = new List<MigrationOperation>();
                var _CreateTableOperation = new CreateTableOperation();
                _CreateTableOperation.Name = "table1";

                _CreateTableOperation.PrimaryKey = new AddPrimaryKeyOperation();
                _CreateTableOperation.PrimaryKey.Columns = new string[] { "id" };

                var _AddColumnOperation = new AddColumnOperation()
                {

                    Table = _CreateTableOperation.Name,
                    ClrType = typeof(int).Assembly.GetType("System.Int32"),
                    IsNullable = false,
                    Name = "id"
                };
                _CreateTableOperation.Columns.Add(_AddColumnOperation);

                _AddColumnOperation = new AddColumnOperation()
                {

                    Table = _CreateTableOperation.Name,
                    ClrType = typeof(decimal),
                    ColumnType = "DECIMAL(10,5)",
                    IsNullable = false,
                    Name = "de"
                };
                _CreateTableOperation.Columns.Add(_AddColumnOperation);

                _AddColumnOperation = new AddColumnOperation()
                {

                    Table = _CreateTableOperation.Name,
                    ClrType = typeof(System.Byte[]),
                    ColumnType = "Image",
                    IsNullable = false,
                    Name = "bs"
                };
                _CreateTableOperation.Columns.Add(_AddColumnOperation);

                _AddColumnOperation = new AddColumnOperation()
                {

                    Table = _CreateTableOperation.Name,
                    ClrType = typeof(System.String),
                    ColumnType = "varchar",
                    IsNullable = false,
                    MaxLength = 200,
                    Name = "str"
                };
                _CreateTableOperation.Columns.Add(_AddColumnOperation);

                operations.Add(_CreateTableOperation);

                var commands = generator.Generate(operations);
            }
        }

        [TestMethod]
        public void CreatTable()
        {
            EJ.DBTable table = new EJ.DBTable() {
                Name = "Table1",
                id = 1,
            };

            EJ.DBColumn[] columns = new EJ.DBColumn[3];
            columns[0] = new EJ.DBColumn() {
                Name = "Id",
                IsPKID = true,
                IsAutoIncrement = true,
                dbType = "int",
            };

            columns[1] = new EJ.DBColumn()
            {
                Name = "Name",
                dbType = "varchar",
                length = "50"
            };

            columns[2] = new EJ.DBColumn()
            {
                Name = "Age",
                dbType = "int",
                defaultValue = "10"
            };

            EJ.IDXIndex[] idxConfigs = new EJ.IDXIndex[1];
            idxConfigs[0] = new EJ.IDXIndex() {
                Keys = "Name,Age",
                IsUnique = true,
            };

            var dbfile = $"{AppDomain.CurrentDomain.BaseDirectory}test.sqlite";
            if (File.Exists(dbfile))
                File.Delete(dbfile);

            var invokeDB = EntityDB.DBContext.CreateDatabaseService($"data source=\"{dbfile}\"", EntityDB.DatabaseType.Sqlite);

            var action = new EF_CreateTable_Action(table, columns, idxConfigs);
            invokeDB.DBContext.BeginTransaction();
            try
            {
                action.Invoke(invokeDB);
            }
            catch
            {
                throw;
            }
            finally
            {
                invokeDB.DBContext.RollbackTransaction();
            }
        }

        [TestMethod]
        public void TestAll()
        {
            IDatabaseDesignService dbservice;
            IDatabaseService db;

            var dbfile = $"{AppDomain.CurrentDomain.BaseDirectory}test.sqlite";
            if (File.Exists(dbfile))
                File.Delete(dbfile);

            Test(new EJ.Databases()
            {
                conStr = $"data source=\"{dbfile}\"",
                Name = "TestingDb",
                dbType = EJ.Databases_dbTypeEnum.Sqlite,
            });
            dbservice = EntityDB.Design.DBHelper.CreateDatabaseDesignService(DatabaseType.Sqlite);
            db = EntityDB.DBContext.CreateDatabaseService($"data source=\"{dbfile}\"", EntityDB.DatabaseType.Sqlite);
            dbservice.GetCurrentTableNames(db);
            dbservice.GetCurrentColumns(db, "test3");
            dbservice.GetCurrentIndexes(db, "test3");

            Test(new EJ.Databases()
            {
                conStr = new System.Data.SqlClient.SqlConnectionStringBuilder(SqlServerConstr) { InitialCatalog = "TestingDb" }.ToString(),
                Name = "testingdb",
                dbType = EJ.Databases_dbTypeEnum.SqlServer,
            });
            dbservice = EntityDB.Design.DBHelper.CreateDatabaseDesignService(DatabaseType.SqlServer);
            db = EntityDB.DBContext.CreateDatabaseService(new System.Data.SqlClient.SqlConnectionStringBuilder(SqlServerConstr) { InitialCatalog = "TestingDb" }.ToString(), EntityDB.DatabaseType.SqlServer);
            dbservice.GetCurrentTableNames(db);
            dbservice.GetCurrentColumns(db, "test3");
            dbservice.GetCurrentIndexes(db, "test3");

            Test(new EJ.Databases()
            {
                conStr = new Npgsql.NpgsqlConnectionStringBuilder(PostgreSqlConStr) { Database = "TestingDb" }.ToString(),
                Name = "testingdb",
                dbType = EJ.Databases_dbTypeEnum.PostgreSql,
            });
            dbservice = EntityDB.Design.DBHelper.CreateDatabaseDesignService(DatabaseType.PostgreSql);
            db = EntityDB.DBContext.CreateDatabaseService(new Npgsql.NpgsqlConnectionStringBuilder(PostgreSqlConStr) { Database = "TestingDb" }.ToString(), EntityDB.DatabaseType.PostgreSql);
            object result = dbservice.GetCurrentTableNames(db);
            result = dbservice.GetCurrentColumns(db, "test3");
            result = dbservice.GetCurrentIndexes(db, "test3");

           
        }

        static void Test(EJ.Databases dbconfig)
        {
            IDatabaseDesignService dbservice = EntityDB.Design.DBHelper.CreateDatabaseDesignService((EntityDB.DatabaseType)(int)dbconfig.dbType);
            EntityDB.IDatabaseService db = null;
            dbservice.Drop(dbconfig);
            try
            {
                dbservice.Create(dbconfig);
                db = EntityDB.DBContext.CreateDatabaseService(dbconfig.conStr, (EntityDB.DatabaseType)(int)dbconfig.dbType);

                List<EJ.DBColumn> allColumns = new List<EJ.DBColumn>();
                List<EntityDB.Design.IndexInfo> allindexes = new List<EntityDB.Design.IndexInfo>();

                #region CreateTable
                if (true)
                {
                    EJ.DBTable tableUser = new EJ.DBTable();
                    tableUser.Name = "User";

                    allColumns.Add(new EJ.DBColumn()
                    {
                        IsPKID = true,
                        CanNull = false,
                        Name = "Id",
                        dbType = "int",
                        IsAutoIncrement = true,
                    });
                    allColumns.Add(new EJ.DBColumn()
                    {
                        Name = "Name",
                        dbType = "varchar",
                        length = "50",
                        defaultValue = "a'b,c"
                    });

                    CreateTableAction _CreateTableAction = new CreateTableAction(tableUser, allColumns.ToArray(), allindexes.ToArray());
                    _CreateTableAction.Invoke(db);

                    DeleteTableAction _delaction = new DeleteTableAction(tableUser.Name);
                    _delaction.Invoke(db);

                    //再次创建
                    _CreateTableAction.Invoke(db);
                }
                #endregion

                allColumns.Clear();
                allindexes.Clear();
                allColumns.Add(new EJ.DBColumn()
                {
                    IsPKID = true,
                    CanNull = false,
                    Name = "Id",
                    dbType = "int",
                    IsAutoIncrement = true,
                });
                allColumns.Add(new EJ.DBColumn()
                {
                    Name = "C1",
                    dbType = "varchar",
                    length = "50",
                    defaultValue = "a'b,c"
                });
                allColumns.Add(new EJ.DBColumn()
                {
                    Name = "C2",
                    dbType = "varchar",
                    length = "50",
                    defaultValue = "abc"
                });
                allColumns.Add(new EJ.DBColumn()
                {
                    Name = "C3",
                    dbType = "int",
                    defaultValue = "8"
                });
                allColumns.Add(new EJ.DBColumn()
                {
                    Name = "Text1",
                    dbType = "text",
                });
                //索引
                allindexes.Add(new EntityDB.Design.IndexInfo()
                {
                    ColumnNames = new string[] { "C1" },
                    IsUnique = true,
                });
                allindexes.Add(new EntityDB.Design.IndexInfo()
                {
                    ColumnNames = new string[] { "C2", "C3" },
                });


                EJ.DBTable table = new EJ.DBTable();
                table.Name = "Test";

                #region CreateTable
                if (true)
                {
                    CreateTableAction _CreateTableAction = new CreateTableAction(table, allColumns.ToArray(), allindexes.ToArray());
                    _CreateTableAction.Invoke(db);

                    foreach (var c in allColumns)
                    {
                        c.ChangedProperties.Clear();
                        c.BackupChangedProperties.Clear();
                    }

                    checkColumns(dbservice, db, table.Name, allColumns, allindexes);
                }
                #endregion

                #region 测试自增长id
                if (true)
                {
                    Way.EntityDB.CustomDataItem dataitem = new EntityDB.CustomDataItem("test", "id", null);
                    dataitem.SetValue("c1", "C1");
                    dataitem.SetValue("c2", "C2");
                    dataitem.SetValue("c3", 3);
                    db.Insert(dataitem);
                    if (dataitem.GetValue("id") == null)
                        throw new Exception("测试自增长id失败");
                    db.ExecSqlString("delete from test");
                }
                #endregion

                #region ChangeTable1
                if (true)
                {
                    EJ.DBColumn[] newcolumns = new EJ.DBColumn[2];
                    newcolumns[0] = (new EJ.DBColumn()
                    {
                        Name = "N0",
                        dbType = "varchar",
                        length = "30",
                        defaultValue = "t'b"
                    });
                    newcolumns[1] = (new EJ.DBColumn()
                    {
                        Name = "N1",
                        dbType = "int",
                        defaultValue = "18"
                    });


                    EJ.DBColumn[] changedColumns = new EJ.DBColumn[2];
                    changedColumns[0] = allColumns.FirstOrDefault(m => m.Name == "C3");
                    changedColumns[0].Name = "C3_changed";
                    changedColumns[0].dbType = "varchar";
                    changedColumns[0].defaultValue = "1'a";
                    changedColumns[0].CanNull = false;
                    changedColumns[0].length = "88";


                    changedColumns[1] = allColumns.FirstOrDefault(m => m.Name == "Id");
                    changedColumns[1].IsAutoIncrement = false;
                    changedColumns[1].IsPKID = false;
                    changedColumns[1].CanNull = true;



                    EJ.DBColumn[] deletecolumns = new EJ.DBColumn[1];
                    deletecolumns[0] = allColumns.FirstOrDefault(m => m.Name == "C2");

                    var tableColumns = allColumns.ToList();

                    allColumns.Remove(deletecolumns[0]);

                    allindexes.Clear();
                    allindexes.Add(new EntityDB.Design.IndexInfo()
                    {
                        ColumnNames = new string[] { "N0", "C3_changed" },
                        IsUnique = true,
                        IsClustered = true
                    });

                    new ChangeTableAction(table.Name, "Test2", newcolumns, changedColumns, deletecolumns, ()=> tableColumns, allindexes.ToArray())
                    .Invoke(db);
                    table.Name = "Test2";
                    allColumns.AddRange(newcolumns);

                    foreach (var c in allColumns)
                    {
                        c.ChangedProperties.Clear();
                        c.BackupChangedProperties.Clear();
                    }
                    checkColumns(dbservice, db, table.Name, allColumns, allindexes);
                }
                #endregion

                #region ChangeTable2
                if (true)
                {
                    EJ.DBColumn[] newcolumns = new EJ.DBColumn[0];
                    EJ.DBColumn[] changedColumns = new EJ.DBColumn[1];
                    changedColumns[0] = allColumns.FirstOrDefault(m => m.Name == "Id");
                    changedColumns[0].IsAutoIncrement = true;
                    changedColumns[0].IsPKID = true;
                    changedColumns[0].CanNull = false;


                    EJ.DBColumn[] deletecolumns = new EJ.DBColumn[0];

                    var tableColumns = allColumns.ToList();

                    new ChangeTableAction(table.Name, "Test3", newcolumns, changedColumns, deletecolumns, ()=>tableColumns, allindexes.ToArray())
                    .Invoke(db);
                    table.Name = "Test3";
                    allColumns.AddRange(newcolumns);

                    foreach (var c in allColumns)
                    {
                        c.ChangedProperties.Clear();
                        c.BackupChangedProperties.Clear();
                    }

                    checkColumns(dbservice, db, table.Name, allColumns, allindexes);
                }
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (db != null)
                {
                    db.DBContext.Dispose();
                }

            }
        }

        static void checkColumns(IDatabaseDesignService design, IDatabaseService db, string table, List<EJ.DBColumn> allcolumns, List<EntityDB.Design.IndexInfo> allindex)
        {
            var columns = design.GetCurrentColumns(db, table.ToLower());
            var indexes = design.GetCurrentIndexes(db, table.ToLower());

            if (allcolumns.Count != columns.Count)
            {
                throw new Exception("column 数量不一致");
            }
            foreach (var column in allcolumns)
            {
                if (column.defaultValue == null)
                    column.defaultValue = "";

                var compareColumn = columns.FirstOrDefault(m => m.Name.ToLower() == column.Name.ToLower());
                if (compareColumn == null)
                    throw new Exception("找不到字段" + column.Name);

                if (compareColumn.defaultValue == null)
                    compareColumn.defaultValue = "";

                if (column.CanNull != compareColumn.CanNull)
                    throw new Exception($"column:{column.Name} CanNull 不一致");
                if (column.dbType != compareColumn.dbType)
                    throw new Exception($"column:{column.Name} dbType 不一致");
                if (column.defaultValue != compareColumn.defaultValue)
                    throw new Exception($"column:{column.Name} defaultValue 不一致 {column.defaultValue}  vs  {compareColumn.defaultValue}");
                if (column.IsAutoIncrement != compareColumn.IsAutoIncrement)
                    throw new Exception($"column:{column.Name} IsAutoIncrement 不一致");
                if (column.IsPKID != compareColumn.IsPKID)
                    throw new Exception($"column:{column.Name} IsPKID 不一致");
                if (column.dbType.Contains("char"))
                {
                    if (column.length != compareColumn.length)
                        throw new Exception($"column:{column.Name} length 不一致 {column.length}  vs  {compareColumn.length}");
                }
            }

            if (allindex.Count != indexes.Count)
            {
                throw new Exception("index 数量不一致");
            }
            foreach (var index in allindex)
            {
                if (indexes.Any(m => m.ColumnNames.OrderBy(n => n).ToArray().ToSplitString(",").ToLower() == index.ColumnNames.OrderBy(n => n).ToArray().ToSplitString(",").ToLower()) == false)
                    throw new Exception($"index:{index.Name} ColumnNames 不一致");
                if (indexes.Any(m => m.ColumnNames.OrderBy(n => n).ToArray().ToSplitString(",").ToLower() == index.ColumnNames.OrderBy(n => n).ToArray().ToSplitString(",").ToLower() && m.IsUnique == index.IsUnique) == false)
                    throw new Exception($"index:{index.Name} IsUnique 不一致");
            }
        }

    }
    static class MyExtensions
    {

        /// <summary>
        /// 功能和ToString一样，null会返回""
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToSafeString(this object obj)
        {
            if (obj == null)
                return "";
            return obj.ToString();
        }
        /// <summary>
        /// 功能和ToString一样，null或者空字符，会返回noneString
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="noneString"></param>
        /// <returns></returns>
        public static string ToSafeString(this object obj, string noneString)
        {
            if (obj == null)
                return noneString;
            string result = obj.ToString();
            if (result.Length == 0)
                return noneString;
            return result;
        }
      

        /// <summary>
        /// 每个对象逗号隔开
        /// </summary>
        /// <param name="arrs"></param>
        /// <returns></returns>
        public static string ToSplitString(this Array arrs)
        {
            return arrs.ToSplitString(",");
        }
        /// <summary>
        /// 用制定字符串联数组
        /// </summary>
        /// <param name="arrs"></param>
        /// <param name="splitchar">间隔字符</param>
        /// <returns></returns>
        public static string ToSplitString(this Array arrs, string splitchar)
        {
            StringBuilder result = new StringBuilder();
            foreach (object str in arrs)
            {
                if (result.Length > 0)
                    result.Append(splitchar);
                result.Append(str.ToString().Trim());
            }
            return result.ToString();
        }
        public static string ToSplitString(this Array arrs, string splitchar, string itemFormat)
        {
            StringBuilder result = new StringBuilder();
            foreach (object str in arrs)
            {
                if (result.Length > 0)
                    result.Append(splitchar);
                result.Append(string.Format(itemFormat, str));
            }
            return result.ToString();
        }
    }
    class MySqlServerEmptyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("test");
            base.OnConfiguring(optionsBuilder);
        }
    }
    class MySqliteEmptyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("test");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
