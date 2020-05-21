
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Storm.Users.Relationship.DBModels{


    /// <summary>
	/// 用户关系
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("relationship")]
    [Way.EntityDB.Attributes.Table("id")]
    public class Relationship :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Relationship()
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

        String _UserId;
        /// <summary>
        /// 用户id
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="用户id",Storage = "_UserId",DbType="varchar(50)",CanBeNull=false)]
        public virtual String UserId
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

        String _ParentId;
        /// <summary>
        /// 上级id
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("parentid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="parentid",Comment="",Caption="上级id",Storage = "_ParentId",DbType="varchar(50)")]
        public virtual String ParentId
        {
            get
            {
                return this._ParentId;
            }
            set
            {
                if ((this._ParentId != value))
                {
                    this.SendPropertyChanging("ParentId",this._ParentId,value);
                    this._ParentId = value;
                    this.SendPropertyChanged("ParentId");

                }
            }
        }

        System.Nullable<double> _RakeBack=0;
        /// <summary>
        /// 返佣比例
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("rakeback")]
        [Way.EntityDB.WayDBColumnAttribute(Name="rakeback",Comment="",Caption="返佣比例",Storage = "_RakeBack",DbType="double",CanBeNull=false)]
        public virtual System.Nullable<double> RakeBack
        {
            get
            {
                return this._RakeBack;
            }
            set
            {
                if ((this._RakeBack != value))
                {
                    this.SendPropertyChanging("RakeBack",this._RakeBack,value);
                    this._RakeBack = value;
                    this.SendPropertyChanged("RakeBack");

                }
            }
        }
}}

namespace Storm.Users.Relationship.DBModels.DB{
    /// <summary>
	/// 
	/// </summary>
    public class UserRelationship : Way.EntityDB.DBContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="dbType"></param>
        public UserRelationship(string connection, Way.EntityDB.DatabaseType dbType): base(connection, dbType)
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
            var db =  sender as Storm.Users.Relationship.DBModels.DB.UserRelationship;
            if (db == null)
                return;


        }

        /// <summary>
	    /// 
	    /// </summary>
        /// <param name="modelBuilder"></param>
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   modelBuilder.Entity<Storm.Users.Relationship.DBModels.Relationship>().HasKey(m => m.id);
}

        System.Linq.IQueryable<Storm.Users.Relationship.DBModels.Relationship> _Relationship;
        /// <summary>
        /// 用户关系
        /// </summary>
        public virtual System.Linq.IQueryable<Storm.Users.Relationship.DBModels.Relationship> Relationship
        {
             get
            {
                if (_Relationship == null)
                {
                    _Relationship = this.Set<Storm.Users.Relationship.DBModels.Relationship>();
                }
                return _Relationship;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC51UwW7TQBD9lz0nKI6dlOTWJhcLVFVNQUh1D2N7k6y6XofdNaiKckRCcM0fcIAbhx5ARcDPhIbPYHZtN07aRgknz8ybmX1vvTNTcgYhp4p0z6e5eQwJJV0yeM2ZpqRGTtO3OeprmuRWkcJihF8Cz9DxZrW7uL6a0BVCepKCprb3YaRZKkglN0qFpkJX");
result.Append("0qdBziMgXTRZjN9OLSARTEwtegFZzr/cvv/259318vpHQBA0zSxySjmYNDVmE4v0QUMIivp9xF0MsOdpdIl2Y4ZOL+VZIhS65+VZrlvtZ0Lo++ow06kvIkkTZIuQlhk1DUAcZ5xjYAhcmUgcnqH8vNhk1go5loAR4quTZ9YpWqQyptIe3bBon6lIsoQJ0KksG+ONlfy8");
result.Append("By+jIHpH/IWi0n+MfMl1K/s3IKMxIAMMcypGemzDrcY2TWWflShnJ1GtDVGL7x+WN583RZ2ARAF7yCqueGdVMR1CxrV9ija+n9bmTlrbG1r//p4vfn66/Tpf/Pq48Zrhkh6Bea7//xvjNLPDtK73YbV7/lp3i9wLg/Vf9VIxZCM7YHnETl51AcTFgFaXiYvlZu8MNC4O");
result.Append("U4BuMarE7J/crm4hM+ZGsllcVwoX1RNf6LZnD1rLLnbT/fyBlkyM7hesFtTuNWuaHqV2YWQZdEB1Udhxh04ILafuNsODuuc6jXqn6XXqcACNyGm3nkYxJbN/mLOBj7QFAAA=");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC51TTY/TMBD9K5XPabfpxy6NxIE2AkXAqqILQiJo5TjuNqxjR7ZT7arqcSUE1/4DDnDjsAcQCPgzZcvPYJyk3dBu1YrkEMfj9+bNm/EEuVjjACuKnAmKQuQ0LdSX4g0l2nORY1voGMcQRM8Vlc8owzoSXI2iBFkoDE4uE4g1LEQEH2gJx0KgqyiRSkLv
+8h1DnoipOpgHV0LAx8ZCsb6WI8AOPGlzysVH1h95MDXdXx4MrhZaIlDego0YypPxw2zNdBCxjVDrWplchNzu08ByTLoRnKifGQt86koThjNc8ILu1MQFj0R5Dxzw9Q/SDAxJmzLWFumA+Sj1NiIOs2hHeC2XW02gqNqq2nXq51Gq1PFR7hO7MP2PRJSNLUQ4FJGFXJe
rfwvHF/MPt28/fL76npx/R14l40ybYFDnnooWEjB8yFmiloowZLyrGn16WsLneCgTNuBHuHE6N1kLvKtdXctX2HILbfH16V3lhE3W+fhAn4BY2LXLXQJoYzDc196PKQXGR7+3a5LGdW0J/gwOltt9gRLY16y59Yf+DU2PEi18DiRNIbykaNlCmb0MD9OGVuZsxxVFMGZ
f2V6qv/YLHOgkOCpSQRaPeVGisgojjiGxhdkU6tQ0tq0NJNUujDenRILTVs1jrEkIywByig/y25Hu75FdYFdybZ3ym6XZc+/vlt8+1iW3c/HaC/huWU7dYd0iFOmX2CWmmN7VtLYWclhuZI/v2bzHx9uPs/mP9+XZhqf0y6Gwf2PNoQiBZXlajZr2bct2YW9sxiYcsKw
UokUCZU6yu/D9C+iBt0kmQUAAA==
<design>*/
