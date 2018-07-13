
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace MyDB{


    /// <summary>
	/// 用户信息
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
        /// 用户名
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("username")]
        [Way.EntityDB.WayDBColumnAttribute(Name="username",Comment="",Caption="用户名",Storage = "_UserName",DbType="varchar(50)")]
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

        String _Password;
        /// <summary>
        /// 密码
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("password")]
        [Way.EntityDB.WayDBColumnAttribute(Name="password",Comment="",Caption="密码",Storage = "_Password",DbType="varchar(50)")]
        public virtual String Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if ((this._Password != value))
                {
                    this.SendPropertyChanging("Password",this._Password,value);
                    this._Password = value;
                    this.SendPropertyChanged("Password");

                }
            }
        }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("UserId")]
        public virtual ICollection<FamilyInfo> Families { get; set; }
}}
namespace MyDB{


    /// <summary>
	/// 
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("familyinfo")]
    [Way.EntityDB.Attributes.Table("id")]
    public class FamilyInfo :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  FamilyInfo()
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

        System.Nullable<Int32> _UserId;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="",Storage = "_UserId",DbType="int")]
        public virtual System.Nullable<Int32> UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                if ((this._UserId != value))
                {
                    this.SendPropertyChanging("UserId",this._UserId,value);
                    this._UserId = value;
                    this.SendPropertyChanged("UserId");

                }
            }
        }

        String _MotherName;
        /// <summary>
        /// 母亲姓名
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("mothername")]
        [Way.EntityDB.WayDBColumnAttribute(Name="mothername",Comment="",Caption="母亲姓名",Storage = "_MotherName",DbType="varchar(50)")]
        public virtual String MotherName
        {
            get
            {
                return this._MotherName;
            }
            set
            {
                if ((this._MotherName != value))
                {
                    this.SendPropertyChanging("MotherName",this._MotherName,value);
                    this._MotherName = value;
                    this.SendPropertyChanged("MotherName");

                }
            }
        }

        String _FatherName;
        /// <summary>
        /// 父亲姓名
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("fathername")]
        [Way.EntityDB.WayDBColumnAttribute(Name="fathername",Comment="",Caption="父亲姓名",Storage = "_FatherName",DbType="varchar(50)")]
        public virtual String FatherName
        {
            get
            {
                return this._FatherName;
            }
            set
            {
                if ((this._FatherName != value))
                {
                    this.SendPropertyChanging("FatherName",this._FatherName,value);
                    this._FatherName = value;
                    this.SendPropertyChanged("FatherName");

                }
            }
        }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("UserId")]
        public virtual UserInfo User { get; set; }
}}

namespace MyDB.DB{
    /// <summary>
	/// 
	/// </summary>
    public class TestDB : Way.EntityDB.DBContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="dbType"></param>
        public TestDB(string connection, Way.EntityDB.DatabaseType dbType): base(connection, dbType)
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
            var db =  sender as MyDB.DB.TestDB;
            if (db == null)
                return;


                    if (e.DataItem is MyDB.UserInfo)
                    {
                        var deletingItem = (MyDB.UserInfo)e.DataItem;
                        
                    var items0 = (from m in db.FamilyInfo
                    where m.UserId == deletingItem.id
                    select new MyDB.FamilyInfo
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items0.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                        {
                            db.Delete(t);
                        }
                    }

                    }

        }

        /// <summary>
	    /// 
	    /// </summary>
        /// <param name="modelBuilder"></param>
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   modelBuilder.Entity<MyDB.UserInfo>().HasKey(m => m.id);
modelBuilder.Entity<MyDB.FamilyInfo>().HasKey(m => m.id);
}

        System.Linq.IQueryable<MyDB.UserInfo> _UserInfo;
        /// <summary>
        /// 用户信息
        /// </summary>
        public virtual System.Linq.IQueryable<MyDB.UserInfo> UserInfo
        {
             get
            {
                if (_UserInfo == null)
                {
                    _UserInfo = this.Set<MyDB.UserInfo>();
                }
                return _UserInfo;
            }
        }

        System.Linq.IQueryable<MyDB.FamilyInfo> _FamilyInfo;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<MyDB.FamilyInfo> FamilyInfo
        {
             get
            {
                if (_FamilyInfo == null)
                {
                    _FamilyInfo = this.Set<MyDB.FamilyInfo>();
                }
                return _FamilyInfo;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC+1YzW7aQBB+lz1DhY2BhFsEimS1pVFJq0qBw2KPwep6ndpLEUIccqlyiRSpfYD21N6QemilXvoygbxGd9cGGzu4aSsokXxi53e/wfN5Rp6gU9wj4KP62SQ4trADqI7ab4jNABXQc3cUWHUGTnAKXWyTm19iMuSCMi2s9Gx8DpEFNTzADGTuI4PZLkUx");
result.Append("X8OlDCiLuU86AY4OqvOjbfJfpdBBBj4XsVzqoNsPXxaX329+flpczDqIG0UyaXnhg6dTy5XaJma4h33Qm2EO+4lrvObn0pQLDZcMHepz8Sx+zyqV0HBZ94+GzNWp4YHDgXIT84Yg4jFtDQnhCgsTX2jM3imvPAgWnoWwktX9un/yWAphCtczwZM3c0RLEOqdxc6vr9KV");
result.Append("BsKdIJeYIpThnTGQb7FnDLAnMxCgfTaQ6kopC/oycYRdibCXE9jns3e3Hy/WgZ9g3x/x6P8PXJ12hUPzVcOllt2XrRBo5BOJt6kZttJ6y3clO9qMt3fwCLM5om6TI2r8Pz7Gjk3Gf08EbYtEUO9LhEqK2P/SM0sgsX7JApbZ5tVEmy9mVzc/vs4/v0+x9KnLBjvj6W8K");
result.Append("UKMCasl3zOW3DQUc4/0poLxjvpYz+DrAtP9HfH1GzNV4TY+qFowyrLKJ8nmVzyvR7RRGsVYQGkM2o5nQmkCApbS7Y4+Wsyff9vZu23so7KlslT2J/TA1fRL2TfMnXxPzNXFf18SHQvRqPibzMZmPyQ3s4WLITCT4E5zjLBKfNsQLRHyxHPucaI90yqqapOmadzhE0/5t");
result.Append("5tm0nw6IJun9Y9beCBuhdUVZwtoGFgZWNPOwVOsZRVyzekVNOVSKByVNLVqqZihVUMtwUEbTX+YvzTWtFQAA");
return result.ToString();}
}}
