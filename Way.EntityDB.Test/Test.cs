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
using Storm.OrderMessageCenter.Database.DB;
using Storm.OrderMessageCenter.Database;
using System.Linq.Expressions;

namespace Way.EntityDB.Test
{ 
    [TestClass]
    public class Test
    {
        
        static int id = 2;
        [TestMethod]
        public void BuildWhere()
        {
            string c = "abc22faew";

            Expression<Func<Account, bool>> exp = m => m.NotifyUrl == "abc" + 2;

            MessageCenterDB db = new MessageCenterDB("data source='./test.db'", DatabaseType.Sqlite);
            var messageMission = db.MessageMission.Include(m => m.Merchant).FirstOrDefault();

            var item = db.Account.FirstOrDefault();
            item.MerchantName = "Jack.T233";
            item.NotifyUrl = "urltest";
            string sql = exp.ToSql(db);
            item.SetValue<Account>(m => m.id == m.id + Test.id);
            var ret = db.Update(item, m => m.NotifyUrl != c);
        }
    }

   class TestItem:DataItem
    {

        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                }
            }
        }
    }

}
