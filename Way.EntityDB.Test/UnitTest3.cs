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
            var db = new TestDB.DB.Test("data source='d:\\test.db'", DatabaseType.Sqlite);
            var user = new TestDB.UserInfo();
            user.name = "jack";
            db.Insert(user);
        }
        [TestMethod]
        public void testquery()
        {
            var db = new TestDB.DB.Test("data source='d:\\test.db'", DatabaseType.Sqlite);
            var user = db.UserInfo.ToArray();
            var supers = db.SuperUser.ToArray();
        }
        [TestMethod]
        public void delete()
        {
            var db = new TestDB.DB.Test("data source='d:\\test.db'", DatabaseType.Sqlite);
            db.Delete(db.SuperUser);
        }
        [TestMethod]
        public void test()
        {
            var value = @"
hello2 = 1 << 2,
afe = hello2 | (1 << 3),
";
            var ms = Regex.Matches(value, @"(?<name>\w+)[ ]?=(?<value>[ 0-9\w\<\>\(\)\|]+)");
            List<string> names = new List<string>();
            foreach( Match m in ms )
            {
                names.Add(m.Groups["name"].Value);
            }
            foreach (Match m in ms)
            {
                var content = m.Groups["value"].Value;
                var othernameMatch = Regex.Match(content, @"\w+");
                if(othernameMatch != null && othernameMatch.Length > 0 && Regex.Match(othernameMatch.Value , @"[0-9]+").Length != othernameMatch.Length)
                {
                    var othername = othernameMatch.Value;
                    if( names.Contains(othername) == false )
                    {
                        throw new Exception("无法识别" + othername);
                    }
                    else
                    {

                    }
                }
            }


         
        }
    }
}
