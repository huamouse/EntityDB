
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

        System.Nullable<TimeSpan> _Time;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("time")]
        [Way.EntityDB.WayDBColumnAttribute(Name="time",Comment="",Caption="",Storage = "_Time",DbType="time")]
        public virtual System.Nullable<TimeSpan> Time
        {
            get
            {
                return this._Time;
            }
            set
            {
                if ((this._Time != value))
                {
                    this.SendPropertyChanging("Time",this._Time,value);
                    this._Time = value;
                    this.SendPropertyChanged("Time");

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
result.Append("H4sIAAAAAAAAC81WXW/aMBT9L36GKt9beaPwEm1i08KmSU0fTHwJ0YyzOU4RQvz3XTsJmNKxUlS2J+63z/U5sdiQKZ1xqMjgftOYE7oEMiDJL56AfARJeuRLuWoKYgXLxmqrCobpb5TX6Ljb3i6u1j9hnyEjCVSBGT/MVFEKYtVmpVAglFW+SRsoKRmgWTD8df1eahrQ");
result.Append("TsnXCmQs5mVKMDqmis5oBfEYcyEGio9l9gNtZ4vOqOT1UlTo3nezIseepUPox9WwVmUsMglLRIMpJWvQA6iY1JxjYE55pSNsNsX1mmZd2WvhGgAGaFx9/mC8dkYpGUhzNmLawXCfrtQ4z4Lpzt6jaUdbYB6pzBZUmgkcRK4WJhw6JyF2k/cYXQujZ2Mc5pfA6+7KgnYm");
result.Append("MG/7oAvG30elmBe5IbWJmJu1RcVaUdgCDbFdazlRKMaGitOK9t5U0cFT+odZVtbtJZ0vav8tRR28WNQHW7UbXUvXwd90fV35+Cfks6AiP0s+nzjbPc/Hb+AEVieyAlbPKMa91braddwVUi0YXV9AFN4aXPiJ+4ajzFwPs0DrKAMO6ih6PT6D/53PyOZzWlz00amu/fVc");
result.Append("Bv+QS3Tb2USz2dg2p/qB1cvqvzrrCmm/iYWKAnPQQXXL9HF9omQh8uOGPd0v7znY6Y/QHvRaOpuAeVOxgLpRGHlR0Kd+5PYD33nfpyx412fe3Mlo6N8yJyLb39y8DRXmCQAA");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC7VUW2/aMBT+K533GlCcWyEIaUC0KdpWIZVJk5Y9mNhANmNHjtMVIf77TmJiyrpNFG3wkJwcf5fz2ckeJUSTJakYiveooCgOHTRX8hvLdZqgGDvojmyhiRas0shBdLnYlaxt5FLcawWtiqkHpsZ46PVxNOi7fRziUV3QcUVG5Y/m8urNa+z5I3rUGndk
nM+J3gDFPlOZuLnJgD9DMVyTOINfs66fVxlyun5VbEvOzBr4w9MDEBUfZP4dxYFxe1+SvLOcTKH9DsxATXAURl4U9Igf4V7gu4MeocFtj3orNyehP6RuhA4O+ihpzVmF4i8mklsbwhYDW5dYkw+klVZvJacMglgRXjEHlUQx0abnHr46aEGWT8mwb9k+QXCpWMnnnMd5
3INzBAVnoEmey1rov+A63VT8Okyjb1qJKcyCpoI5H1Hsu66DdtDDw6fyJ0zwHBMOQoPxwkY6TT6ngrLHVhbqZJowzjSbSbEq1vbhTPJ6K07WItdOCWWT7KTWMhW5YltIFMVa1ZDvjIi7mnObd3ckUdFGcjZcWs3fN/cGKRXsU6Nkg43wWbDt7W+Ej0pW2dBZ4Qei8g1R
gORMrNsDHbp/snLksl6w9eJZL5P1NTbM/NbCpQY8a8D/t/kHF+R/OtjHQ/3ftiC4YAvwMLR+poXSG0p2V5ihRDczvHgn/JOP6PThLa4KRBvYiz0EzQucc1JVpZIlU7owb/HhJ1SxGuYrBgAA
<design>*/
