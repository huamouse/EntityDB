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
using Microsoft.Data.SqlClient;

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
            SqlConnectionStringBuilder conStrBuilder = new SqlConnectionStringBuilder("server=ETHAN-20171016H;uid=sa;pwd=123;Database=TestDB");
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
        public void ConcatTest()
        {
            TestDB.DB.Test db = new TestDB.DB.Test("server=192.168.0.151;uid=sa;pwd=sa!@#123;database=Test", DatabaseType.SqlServer);
            var userinfo = from m in db.UserInfo
                           select new { 
                            myname = m.UserName,
                            id = m.id
                           };

            var accountinfo = from m in db.UserAccount
                              select new
                              {
                                  myname = m.AccountName,
                                  id = m.id
                              };

           var result =  userinfo.Concat(accountinfo);
           var ret = result.ToArray();
        }

        [TestMethod]
        public void DeleteTest()
        {
            TestDB.DB.Test db = new TestDB.DB.Test("server=192.168.0.151;uid=sa;pwd=sa!@#123;database=Test", DatabaseType.SqlServer);
            db.Delete(db.UserInfo.Where(m=>m.UserName == "way"));
        }
        [TestMethod]
        public void UpdateLockTest()
        {
            TestDB.DB.Test db = new TestDB.DB.Test("server=192.168.0.151;uid=sa;pwd=sa!@#123;database=Test", DatabaseType.SqlServer);
            db.BeginTransaction();
            try
            {
                db.UpdateLock(db.UserInfo.Where(m => m.UserName == "way"));
                db.UpdateLock(db.UserInfo.Where(m => m.UserName == "way"));
                db.CommitTransaction();
            }
            catch (Exception)
            {
                db.RollbackTransaction();
                throw;
            }
           
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
            result.Append("H4sIAAAAAAAAC+1d7XPTRhr/VxjfV7ixbNmymfYDSY6rr5TLENrpTNPpCFtJfFXkVJIbMpSZcAck0IJDSY6XXnlreDl6dVpKIdgU/hlLtv+LW60ce3clW7LslTdTf4Fo9eLnp3329zy7+zyPzkROiqdkSYsc/uSM/edxcVGKHI7MfCHndSlyMHKisGyfzejSov1X65J8");
            result.Append("Dpz+SJSL4IBLpM4ebJ/RV5akzrnIpCqJugSffiSr5wtKBLk2W1B0SdGRy8/M2pLMRg6DP/M58H/84GwkKy5Z94Kj2Ujz/qv6d+XZCGi2HgPbptXCP6SsDhunRF08JWpSZgqcioGG/LFC9nPwd/QsOJgsyMVFRQOHn+z9ABclfsFqRZ/eOs5oR4p6IaNkVWkRSA1O6WpR");
            result.Append("sp4pKseLstxpyJ06Cd6Cfa91IWj6i1JcnJLm8ordDNty0pxYlHWIvdMK8UPhLeQZbfp9eNB6dEHNSSoUG8BpI+AIBLboKIZ2ixPFnChrXjC+FNXsgqgOB8reD3awcGc/tS6Y+niyoMzl52H32C0QKKozuVb3ohoYA7dbyjqjA12z34yXyqZpqixPdIe59bN5pWxUruN9");
            result.Append("sqepWkC9jTGqt7xvvXUf29Z9LqO71RxMgYeGx6m8MQQQz/pA9MASR7Akumlx/ZeqcedrHNaeiMPuIGCLZiT1S0k98O4BwHKzim2cwBHQ/lnlgxVw/G7cHTrXH3YewZ4ksDfe3jGvPjR+ulH/36Pa7jMcO+CEGV2l2KmypMzrC/A4Fo0Oo58TCFaBwJqT5frmXXN9w/z3");
            result.Append("Wq36wth+RXS1LE+Lljhh4OWGgzeJ4E2RtGnzLMac7aYQ2CbaHxQBgZJ2oZuZJTHrwjmdZiaJJ4WiImEZmzu13VXz3lp9u0Iah78Wu5q5fmEhapfos1NCd2CSUZoODEn99V+r9erd+uYTc/0l/vo/1CQ1mPsSY9XtTvh1X2Kk2914/G3jEmEcThSsNztsJjFerxqla7VK");
            result.Append("xbh2c88yGuUHoHvqP+6Yv33d2NnqnHznHXi+bb8b5TeN8n1jd90+GTvw1QH0eda19fL9+sZF+36X+76y7gPO26xie2z1aglcbj+Odzyu75fuNr46bz3Guo+V8O0vxkgHeFrUtGVwKeEAo61MYoqHzn8cTf4j3b/2EDC//1fz1gYxjZuYLiwHZkGeURZM+mZBh7HoYiZG");
            result.Append("Nn9L+ucWR8e79Hent4dL6aWnjZ0q4FBgF2eV2tuyufnKYtRhQEQpR+im26Rnheoyi/0WPufEaHIO2S/NzVuNnR3z8kPj2mW8YyaK8wHJJsUo2Qi+yYacGoBJQfPBTRzFybw+kM81qK0UfPNNnPSBzdJGrbLdWL1ADsaZ4qnFvD5SGhV8c0ycc4Vl3njRvPHcDdfJ/EAO");
            result.Append("Gxjekr73CArQkFWxOOl9Gtvngevr0mPviUpOZre7kNWuOOmFmv9ZNTauGqUrzUfrbp12TNR0QD4sdxm6wOVY8bH7zCh/Y+5sueE7mlfy2sIwlRJZWugPB7pwxZP9ZPx+3bh0pX75hbl6jhhWwKgVteFrnj2Q69VbxAQU+iy2woCTbRZrT02RF24t3Q72ToTQDX+cpuFP");
            result.Append("uTpkjftPyGlG68Yglj/O6jQj5dfyx8lpRvtvFAbaOBrjn/Jv/JOsL2Sk/Ft80nslJg/sTCpS/k096xsFHlD40GmSp0mTjk2Bn26Y5d9IjrS5LyBJphklybRfkuSjbJBkgA3LtG/e5JmPdkn75k2enE401p4aD+40t97igBw4AmM7lR+AcdK+ydPpq5Z2atWHtd1K/b8V");
            result.Append("HFtb2nAwcf1hQuZJfNe4HpuLqMRFUNZFZJ7EOzysP7khYhsPMl/iSf/K+jmjfLv26hKOCBUjDEqMD4cSkUAA3rF4uPXWqDzCYe5JwGrXISEAPOl6Nas3G+VtY/U1MbqwX9xH5iyNYCW9jvZDsFGHNIbvNHsZZ8QFSTiWNG/uGBuPwL+13Wpzkwjc3Xsok+aMQ5yOBOl0");
            result.Append("tC9D4aCNI5gQeOGJhT4jSNCcETgCt9srJ27bdvDuAXZqE6yG28LX4Gt6kCCdMmQ/gY2tWhxLz2lAgmefN73ghD8gk1QHJEmSdnSQ6ya6HdM9yHhMsDoeOd/jkfRQ8Uh3ZgLgcUS9R6XAPMVwrI1JgeqYjLsaSfPJfeP7G+Tq2QeFXDHoFkOSY3U8+s6jSjIfWohj6TkS");
            result.Append("k/H9siTvBQpZL0uSRj+jHS3I4EJyWoG0jmBi4YUIWShLkmZsSVSBlGQnYa3sdVH4ew1Uc04deVz1yuPGuU1j/V7z1jZJmlOSLOmSDTwgdSZZpU7fqXxJYR94455JHB04jpCRC78CBQBTSxLSCUkW2YaF0ie51tSW/rMpSct2QdY5NyKj5z9pUYi69ltrff72ebfegwOS");
            result.Append("2d5D9h8E0sNqS6906T7yJJv9lwjdeFDN/nYkztpvQkGca4IQ0VN9Gw+B2XUp34lUQnwfGA//GUoC6T3Y3UviwVrZA4SYDYHU6NM4ktOMQkANA+lireAQVhiFgNI/6WLVdp+D6FWjdLO5VsLRzMni/CgJP+F701kgHS1L9JgTTYxhOMmw7ZdANfnXUfzATr8Gm6/15w+M");
            result.Append("11vEVHvq44ySk04HNF6shlzBl+DLeKWi+8B4+U+BS5FO5vvSioZjabcwU/3BCx9aosWxhGRvUNtK7qrh2odK/ouBAgz2FpPIkHfP4CQvYGi9FsdKkg2sce52/TwRCpLRJuWipkuqlAsDVbRPVKGvJglUs4kdGbITxflWRsTVi0bpWaP8s/E7oXTgEjuB6L28phfUlaCl");
            result.Append("zYRgZLrXJy780+lGiMtngbI4AW4oVNg9gwQXrSfhcY6wPqN0zby35pLSNbR9q+CCY8WmSL0yLl4wykS1npaGDiL0ojgvDSg2ylOOuDzwvq2YDbfsQEnJhZOG5QUgfEqimmzsSHQHQ7J567yx+8hcf2p898ZBRhlLCYIWqoMLQNRYyLenxkFHPkwW8u92cdAmhj1q+3Cb");
            result.Append("HGXCzKvfGhVi3glvHfFLDb0sgEA1O9BRrwH4p8aFh2AtO9eKme9sRR07lllcKqh60GGapjlMfef4c47KUACpXYuu8XLHeHMeR700vFp0LnG+3QD0HsywMhSV8J0e48IzPz/scUE1HcxRy8Kqz1j6wa5RBUYHiDsDTnW9et28QyhMBjxdnROz0iCr7hwsQ0VtsPhOi+Vg");
            result.Append("CamwVc1/kisHCxzRCJ/pVa3PS0DUsEHPr/MChxdn0fe02Etq1ImGdShoxLsMXWq0rKojpdZ4+axeLTUe/Gje3ahVKs3Nc0b5Nj5crYEIJ165kep06JuUAtXYeVhIx0mJg21FctA3o0aKvtNgOWgLaWy09dAf/wmsHNS1oe6eBZcLo8L0sLfEgsuFkV2UUgKiy1Kzfwkx");
            result.Append("YsMcvr9pBcUaPANIqUunB32DaAkcWOKnLd9yPjeQzzx476JlbWBtkrZsC1J+fkEfqXCh15cRqGZlOIqMEQ6wnZ4BHGdgeh1VZ4hrB8jX4GAFF1rGAYL0+dGBZMhrurhsvU1DPHzL5SVe6BPHFNXtbbhq3llok0VNW1ILS5KqB9xkAUsFFBUbiuuvNmIUM0IAhQw6gqrq");
            result.Append("4MK5aXbYqtNrI29BVOb7Up2/yzl4eQ9tOS4te11S0Bckdaw3/euNIi27vjZs6quEs6LgJTFaYTeKOVtzBRW4NMrn0spnLAxJxK+ORfkugmbhax+xpIh/HYvivoMGBJTBOtdgVYwCL3l4SW6vFWQh3+QQFbZaczBbhGwNkyJjVCkSLVPoIEf0ZDdaHJcqDCuucVyqkO28");
            result.Append("yD9aqULc3rNMob12fMde5v6ZnSDSjZ3KsVO5D5zK/cORvXb/xxw55khaE29se/mXO+bqYysaBBayrFUfNv/5Q233KbQ+nebdirF2EfeWxrP2P+isff8QbILuPB77OLVzJo+d7jaXH3+ievyJ6vEnqsefqHZd3hh/ohozP+NPVI8/UU3/E9X7xb0Bm+pUgwCwGJApSQMb");
            result.Append("XwNlWsaiNEMfobg+gwCwAJI2DsorbX18YjWKBT/a/Tdi8bA5ZHoUsYZeEqK7trCocFvCyYEzxXyEGnqJF3Z2JFhMpsoOgnOpWpkrBGQGWHCWGjP4/3QqnIwhGYaWpFwYoRP+E6dieJ64LWOMARmHHQMHDluqErFU3P4bVXRLzSwU4HhmBVRqWPwziMRM8vCHsKtbyu+8");
            result.Append("fkZX88q884bOCPB/D4apq2ifWrCsszOS3rpROMpP8hPJ6KFEcmLiED+Rih06ko5zh9LgGygTfFRIHBGSkbP/B5aC3kaKjgAA");
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
                conStr = new SqlConnectionStringBuilder(SqlServerConstr) { InitialCatalog = "TestingDb" }.ToString(),
                Name = "testingdb",
                dbType = EJ.Databases_dbTypeEnum.SqlServer,
            });
            dbservice = EntityDB.Design.DBHelper.CreateDatabaseDesignService(DatabaseType.SqlServer);
            db = EntityDB.DBContext.CreateDatabaseService(new SqlConnectionStringBuilder(SqlServerConstr) { InitialCatalog = "TestingDb" }.ToString(), EntityDB.DatabaseType.SqlServer);
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
