
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace TDB{


    /// <summary>
	/// 
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("userinfo2")]
    [Way.EntityDB.Attributes.Table("id")]
    public class UserInfo2 :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  UserInfo2()
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

        String _Name;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="",Storage = "_Name",DbType="varchar(50)")]
        public virtual String Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.SendPropertyChanging("Name",this._Name,value);
                    this._Name = value;
                    this.SendPropertyChanged("Name");

                }
            }
        }

        String _column1;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("column1")]
        [Way.EntityDB.WayDBColumnAttribute(Name="column1",Comment="",Caption="",Storage = "_column1",DbType="varchar(50)")]
        public virtual String column1
        {
            get
            {
                return this._column1;
            }
            set
            {
                if ((this._column1 != value))
                {
                    this.SendPropertyChanging("column1",this._column1,value);
                    this._column1 = value;
                    this.SendPropertyChanged("column1");

                }
            }
        }
}}
namespace TDB{


    /// <summary>
	/// 
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("t2")]
    [Way.EntityDB.Attributes.Table("id")]
    public class t2 :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  t2()
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

        String _column1;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("column1")]
        [Way.EntityDB.WayDBColumnAttribute(Name="column1",Comment="",Caption="",Storage = "_column1",DbType="varchar(50)")]
        public virtual String column1
        {
            get
            {
                return this._column1;
            }
            set
            {
                if ((this._column1 != value))
                {
                    this.SendPropertyChanging("column1",this._column1,value);
                    this._column1 = value;
                    this.SendPropertyChanged("column1");

                }
            }
        }
}}

namespace TDB.DB{
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
            var db =  sender as TDB.DB.TestDB;
            if (db == null)
                return;


        }

        /// <summary>
	    /// 
	    /// </summary>
        /// <param name="modelBuilder"></param>
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   modelBuilder.Entity<TDB.UserInfo2>().HasKey(m => m.id);
modelBuilder.Entity<TDB.t2>().HasKey(m => m.id);
}

        System.Linq.IQueryable<TDB.UserInfo2> _UserInfo2;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TDB.UserInfo2> UserInfo2
        {
             get
            {
                if (_UserInfo2 == null)
                {
                    _UserInfo2 = this.Set<TDB.UserInfo2>();
                }
                return _UserInfo2;
            }
        }

        System.Linq.IQueryable<TDB.t2> _t2;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TDB.t2> t2
        {
             get
            {
                if (_t2 == null)
                {
                    _t2 = this.Set<TDB.t2>();
                }
                return _t2;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC91YTXPaMBD9LzpDB4sPh9wIXDzt0ExJO50JHIS9Np4ImcpyaYbxf68k29jU1IWmATUnpN2V9FbvSVqzQw9kSSFGt4+7rDkla0C3aPaNhgJQC32KtpnXEbDOWnlI6En3F0IT2bHS1t4unjdQetCYAxGg5x65IowYqsS6ERPARCV8N89wzNGtbIae/LVa");
result.Append("cx0vm3P0OQbuMD+aI2mdEEGWJAZnkoeFHyL3SbY7qeyMI5qsWSy7j0enUhbZd+JRIiKHuRzWEot0CZ6AGk/YNKFUGnxCY2Xxlg8yuWywimzlYPfrO/H9e93Jp4i4B1yvLBEVIHAVRNY4CqNYtcSRz1qB8Z1wd0W4noECC8RKm/udJnDFxCU6q0TXraIbBS8BV+xRBdh5");
result.Append("sHC6UAGTr+OI+WGgqcwsekerSvJyKRyqcqEFPBNSgRkFzTLGDTJeERacJeOP1NufqLp0p7Bt8DLYHlFvr0rNDH5cXzddTZCr98Y7gvhXMeGrqkn27oj7lGwyMr17Hm2AixAU5t0eqeKOh0HICNV0lichTXW+HlAQB/leVqZdM2XaLIXarYcNuPZeoojMZ4gkem9CEm9A");
result.Append("EbhBEmbeiuXTb+r7crlj1H/NOvZA7gL/XQXbf8UKFp9awQ6qIFwN0rqAWPCfitjLimVg5p1bkGRfh6STSvr6m2DCI2obQCg++RU1YcduLrJj+PwtKw7BTf0QYHM/m0ygdGgqpeds2f9A/7+jVHbz3JEiNWtXqVVVhkpC/bH3HEv23zlMDHp6oYPonPB6/EzwkAX1ASXr");
result.Append("p485yOm30BYqLeWdgcgH9sHt9LE9bPtet9vu+UPSJu7Abvu+BTDoWdi2PZT+BL8svBDUFAAA");
return result.ToString();}
}}
