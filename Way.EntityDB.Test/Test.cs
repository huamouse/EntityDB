
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace TestDB{


    /// <summary>
	/// 
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("userinfo")]
    [Way.EntityDB.Attributes.Table("id")]
    public class UserInfo :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  UserInfo()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// 
        /// </summary>
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true,CanBeNull=false)]
        public virtual System.Nullable<Int32> id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.SendPropertyChanging("id",this._id,value);
                    this._id = value;
                    this.SendPropertyChanged("id");

                }
            }
        }

        String _UserName;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("username")]
        [Way.EntityDB.WayDBColumnAttribute(Name="username",Comment="",Caption="",Storage = "_UserName",DbType="varchar(50)")]
        public virtual String UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                if ((this._UserName != value))
                {
                    this.SendPropertyChanging("UserName",this._UserName,value);
                    this._UserName = value;
                    this.SendPropertyChanged("UserName");

                }
            }
        }

        System.Nullable<Int32> _Age;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("age")]
        [Way.EntityDB.WayDBColumnAttribute(Name="age",Comment="",Caption="",Storage = "_Age",DbType="int")]
        public virtual System.Nullable<Int32> Age
        {
            get
            {
                return this._Age;
            }
            set
            {
                if ((this._Age != value))
                {
                    this.SendPropertyChanging("Age",this._Age,value);
                    this._Age = value;
                    this.SendPropertyChanged("Age");

                }
            }
        }
}}
namespace TestDB{


    /// <summary>
	/// 
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("useraccount")]
    [Way.EntityDB.Attributes.Table("id")]
    public class UserAccount :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  UserAccount()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// 
        /// </summary>
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true,CanBeNull=false)]
        public virtual System.Nullable<Int32> id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.SendPropertyChanging("id",this._id,value);
                    this._id = value;
                    this.SendPropertyChanged("id");

                }
            }
        }

        String _AccountName;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("accountname")]
        [Way.EntityDB.WayDBColumnAttribute(Name="accountname",Comment="",Caption="",Storage = "_AccountName",DbType="varchar(50)")]
        public virtual String AccountName
        {
            get
            {
                return this._AccountName;
            }
            set
            {
                if ((this._AccountName != value))
                {
                    this.SendPropertyChanging("AccountName",this._AccountName,value);
                    this._AccountName = value;
                    this.SendPropertyChanged("AccountName");

                }
            }
        }
}}

namespace TestDB.DB{
    /// <summary>
	/// 
	/// </summary>
    public class Test : Way.EntityDB.DBContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="dbType"></param>
        public Test(string connection, Way.EntityDB.DatabaseType dbType): base(connection, dbType)
        {
            if (!setEvented)
            {
                lock (lockObj)
                {
                    if (!setEvented)
                    {
                        setEvented = true;
                        Way.EntityDB.DBContext.BeforeDelete += Database_BeforeDelete;
                    }
                }
            }
        }

        static object lockObj = new object();
        static bool setEvented = false;
 

        static void Database_BeforeDelete(object sender, Way.EntityDB.DatabaseModifyEventArg e)
        {
            var db =  sender as TestDB.DB.Test;
            if (db == null)
                return;


        }

        /// <summary>
	    /// 
	    /// </summary>
        /// <param name="modelBuilder"></param>
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   modelBuilder.Entity<TestDB.UserInfo>().HasKey(m => m.id);
modelBuilder.Entity<TestDB.UserAccount>().HasKey(m => m.id);
}

        System.Linq.IQueryable<TestDB.UserInfo> _UserInfo;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.UserInfo> UserInfo
        {
             get
            {
                if (_UserInfo == null)
                {
                    _UserInfo = this.Set<TestDB.UserInfo>();
                }
                return _UserInfo;
            }
        }

        System.Linq.IQueryable<TestDB.UserAccount> _UserAccount;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.UserAccount> UserAccount
        {
             get
            {
                if (_UserAccount == null)
                {
                    _UserAccount = this.Set<TestDB.UserAccount>();
                }
                return _UserAccount;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC72UW0/CMBTHv0ufweyu8kbgZdEQ49CYMB7KVmBxtNp1GEL47p5egAKKEMWnnVtP/6fnly1RH49KUqHWYKnNHp4R1ELJe5kQPiccNdAj+9AFsSAzbZmqIof0My5rcNxVYxMXizeyzaAOJ1gQ1b6diYJRZNVmjApChVW+TLWUFLXALHL4un4jVQfATtFT");
result.Append("RXhMxyxFEO1igUe4InEXciEEinuWvYLtrMDpsLKe0QrcwbpX5Ni9ZAj8uGrXgsU042QGaiAleE1kA0x7dVlCYIzLSkbyUR/G04dlZcPIVQKU0Lh6uFOe6cF4Tri6GzRtZLj7I2nnSzHru7dqTGtLzBzzbIq56lASOhFTFQ6doxLXnbcaXUujZ2tsT34jb/1WlrQzhXmr");
result.Append("oSzovnQYHRcTtVQdUS9rQ5UbKGxAQzguWU4EwKhXcZxo76JEB/vrb2cZq80jnQ+1f0mog5Oh3pnKTPRfXAc/cf23+IBrFoEkQNq2MZJLlFPI3+miAtKuYiqiQF20U23gOqxPBC/o5PDAlrDTz+zM9K20oRxLZhOi9gYF2I3CyIuCJvYjtxn4zk0T58F1M/fGToZD/zZ3");
result.Append("IrT6BBtaG6ZKBgAA");
return result.ToString();}
}}
