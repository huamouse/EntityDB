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

namespace Way.EntityDB.Test
{ 
    [TestClass]
    public class Test
    {

        [TestMethod]
        public void BuildWhere()
        {
            MessageCenterDB db = new MessageCenterDB("data source='./test.db'", DatabaseType.Sqlite);
            var item = new Account();
            item.MerchantName = "jack";
            item.NotifyUrl = "abc";
            db.Update(item);

            item.MerchantName = "jack2";
            db.Update(item, db.Account.Where((m) => m.NotifyUrl == "abc"));

            item = db.Account.FirstOrDefault();
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
