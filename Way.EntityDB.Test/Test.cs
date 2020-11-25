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
        public void JsonTest()
        {
            var option = new System.Text.Json.JsonSerializerOptions();
            option.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            var dataitem = new TradeUser
            {
                TradeUserId = 2,
                Status = TradeUser_StatusEnum.Approved,
                NickName = "bac"
            };
            dataitem.ChangedProperties.Clear();

            var str0 = System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, TradeUser> { { "a", dataitem } }, option);

            var str = System.Text.Json.JsonSerializer.Serialize(new[] { dataitem }, option);

            var item = System.Text.Json.JsonSerializer.Deserialize<TradeUser[]>(str);

            str = Newtonsoft.Json.JsonConvert.SerializeObject(dataitem, new Newtonsoft.Json.JsonSerializerSettings() { 
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            });

            str = Newtonsoft.Json.JsonConvert.SerializeObject(dataitem);
        }

        
        [TestMethod]
        public void test()
        {

            using (var db = new TradeSystemDB("server=192.168.0.128\\sqlexpress;uid=sa;pwd=123456;Database=tradesystem", DatabaseType.SqlServer))
            {
                db.Insert(new AddOrderMarginHistory
                {
                    Amount = 100,
                    Balance = 3,
                    CreateTime = DateTime.Now,
                    MoneyAccountId = 2,
                    UserId = 11
                });
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
