﻿using Microsoft.EntityFrameworkCore;
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
using System.Linq.Expressions;
using System.Xml;
using FllowOrderSystem.DBModels;
using Npgsql;
using System.Threading;
using System.Threading.Tasks;

namespace Way.EntityDB.Test
{

    [TestClass]
    public class Test
    {
        
        [TestMethod]
        public void test()
        {

            using (var db = new FllowOrderSystem.DBModels.DB.FllowOrders("Server=127.0.0.1;Port=5432;UserId=postgres;Password=123456;Database=fllowsystem_test;", DatabaseType.PostgreSql))
            {
                var tradeUser = new TradeUser();
                tradeUser.NickName = "abc";
                db.Update(tradeUser, m => m.TradeUserId == 2);

            }
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
