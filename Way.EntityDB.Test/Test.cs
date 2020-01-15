
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

        System.Nullable<DateTime> _Birthday;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("birthday")]
        [Way.EntityDB.WayDBColumnAttribute(Name="birthday",Comment="",Caption="",Storage = "_Birthday",DbType="date")]
        public virtual System.Nullable<DateTime> Birthday
        {
            get
            {
                return this._Birthday;
            }
            set
            {
                if ((this._Birthday != value))
                {
                    this.SendPropertyChanging("Birthday",this._Birthday,value);
                    this._Birthday = value;
                    this.SendPropertyChanged("Birthday");

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
result.Append("H4sIAAAAAAAAC71VXW/aMBT9L36GKd9beaPwEq1i09JNk5o+mPgSohm7c5wihPjvu3YCmNLSItY+cb99rs9xWJNbOuVQk8HdujUndAFkQLK/PAP1CIr0yA+5bAtSDYvW6qoqhulflDfo+JveLq5XD7DPkJECqsGOHxa6koI4tYUUGoR2ytd5CyUnAzQrhr9+2MttA9o5");
result.Append("+VmDSsVM5gSjY6rplNaQjjEXY6C6kcUftL0NOiPJm4Wo0b3bzko8d5YJoZ/Ww0bLVBQKFogGU1o1YAZQMWk4x8CM8tpE2PQW12ubTWWvg2sBWKBp/f2r9boZUjFQ9mzEtIPhP12pdZ4Fsz17j6Yb7YB5pKqYU2UncBClnttw7J2EuJ28x+g7GAMX47C8BN72rhxoZwIL");
result.Append("NvemYPx7JMWsKi2pbcTerCsq1onCFWiM7UbLmUYxtlScVnTwroqOntI/LArZdJd0vqjD9xR19GZRH2zVbfRRuo5e0/XHyic8IZ85FeVZ8vnG2e7zfPwNnMDyRFbA8hnF+FdGV7uO60rpOaOrC4jCW4MLn3hoOSrs9TAHtIky4KCPov+PT3S72cQw2tour+ZRmmXN3+Oq");
result.Append("Ruo/pUInkT3ooLpj+7g+06oS5XHDnvK39xzs9CK0e7OWyWZg3yEWUD+JkyCJ+jRM/H4Uel/6lEWf+yyYeQWNwyvmJWTzD0k4oKIaCAAA");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC7VUXW/TMBT9K8O8plWcr7WpKtE2AkXAVGlFQiI8eInbBlw7sp2xqup/33U+3JUBKhMkD8nN9T3n3OPrHFBCNLkjiqL4gMoCxaGDllJ8o7lOExRjB92QHSTRiiqNHFTcrfYVbRK54LdaQkpReU/lFI+9IY5GQ3eIQzypy2KqyKT6YR6v3rzGnj8pOq5p
D8bYkugtQBwymfGrqwzwMxTDM4kzuMy6Ya4y5PR5Ve4qRts1cMPXIwCVH0T+HcV+q/a2InkvOZlD+h2IgZjgKIy8KBgQP8KDwHdHA1IE14PCW7s5Cf1x4Ubo6KCPoqgZVSj+0lpybU3YYUDrHTP+gFupeitYQcGINWGKOqgikvLGPff41UErcvcUDPsW7RMYl/K1eI7Z
9eMena4oOCua5bmouf5DXc+b8p+bMfxtKmmDdoGJoM8HMNF1HbSHHB4/pT/VBM9rwlHY1nihoU6Tzykv6ENDC3EyTyijmi4EX5cb+3EhWL3jJ2mRa7uE0Dg7q7VIeS7pDhxFsZY1+Lsg/KZmzPrdjyQqG0vOmkvV8r15byuFhH0yTNbYCJ8Z27z+grhjsswtnCW+JzLf
EgmVjPJNM9Ch+zspHZbVgq0Wz2qZbV4io+3fSrhUgGcF+P/W/+AC/0+D3Q31f9uC4IItwGOY407PvJR6W5D9C8TAf8708Nc74ZvDkzOiVCVFRaUu2xN0fAR8h7HvpwUAAA==
<design>*/
