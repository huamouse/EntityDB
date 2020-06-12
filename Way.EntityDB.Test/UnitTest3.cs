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
    public class UnitTest3
    {
        [TestMethod]
        public void test2()
        {
            //var db = new Storm.Users.Relationship.DBModels.DB.UserRelationship("data source=./test99.db", DatabaseType.Sqlite);
            using (var db = new Storm.Users.Relationship.DBModels.DB.UserRelationship("server=.\\SQLEXPRESS;database=UserRelationshipTest;uid=sa;pwd=123456;", DatabaseType.SqlServer))
            {
                var userinfo = new Storm.Users.Relationship.DBModels.Relationship()
                {
                    UserId = "001"
                };
                db.Insert(userinfo);

                userinfo.RakeBack = 0.5;
                var ret = db.Update(userinfo, "UserId");
            }
        }
    }
}
