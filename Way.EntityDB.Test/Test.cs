
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


        String _phone;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("phone")]
        [Way.EntityDB.WayDBColumnAttribute(Name="phone",Comment="",Caption="",Storage = "_phone",DbType="varchar(50)",CanBeNull=false)]
        public virtual String phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                if ((this._phone != value))
                {
                    this.SendPropertyChanging("phone",this._phone,value);
                    this._phone = value;
                    this.SendPropertyChanged("phone");

                }
            }
        }

        System.Nullable<Int32> _chance=0;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("chance")]
        [Way.EntityDB.WayDBColumnAttribute(Name="chance",Comment="",Caption="",Storage = "_chance",DbType="int")]
        public virtual System.Nullable<Int32> chance
        {
            get
            {
                return this._chance;
            }
            set
            {
                if ((this._chance != value))
                {
                    this.SendPropertyChanging("chance",this._chance,value);
                    this._chance = value;
                    this.SendPropertyChanged("chance");

                }
            }
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
}}

namespace TDB.DB{
    /// <summary>
	/// 
	/// </summary>
    public class Test2 : Way.EntityDB.DBContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="dbType"></param>
        public Test2(string connection, Way.EntityDB.DatabaseType dbType): base(connection, dbType)
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
            var db =  sender as TDB.DB.Test2;
            if (db == null)
                return;


        }

        /// <summary>
	    /// 
	    /// </summary>
        /// <param name="modelBuilder"></param>
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   modelBuilder.Entity<TDB.UserInfo>().HasKey(m => m.id);
}

        System.Linq.IQueryable<TDB.UserInfo> _UserInfo;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TDB.UserInfo> UserInfo
        {
             get
            {
                if (_UserInfo == null)
                {
                    _UserInfo = this.Set<TDB.UserInfo>();
                }
                return _UserInfo;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC81U32/aMBD+X/wMVdKSpPDWwUu0iVWjmyY1fXDiI1g1NnOcoQrxv+9sh+KIljFpD33K3Xc/8t3dl+zIAy0FNGTyuPPmnK6BTMjil+AGyIB8U1sfzQ2svdWlcIbhH1S06MT7wStuXjZwjJCpBmrA9b6rDFeSBLmVkgakCdJ3hedRkAmanOEzvkkHhatA");
result.Append("pyDfG9C5XKqCIDqjhpa0gXxmExNE+BdVPaMT7dGZKtGuZYPu46FbOs7CbpuVkmghlDd3rVG5rDSskRNGl1Q0YLtQOW+FCBBWPuCUrsFvqqsV1a6FAFmblYOTyCFuFk/OTZE395+da3RrGynNQDteyPdI8TakiO1ldTnHrnNAkdvMPj3nM1jSVhi3eof+hfPhXUfS8f7J");
result.Append("Jsx+TpVc8tot2iNuovDUrLtUTzYJ1luJLQxqxO/gvNCuzwgN11T/k9C+Cvaq+VNpzWF7Jiph+6a4xuHlLPbm1bobnRXWe1e7XFL+OlY+NbCP+ymcyipC7xOtntuNPyq712oD2nCw/HdBrb2i5jWXVBxkbNew37vRGQgwvdH/s1zR7ZoTK1hvh7K1/ye7H/tLfWlQ2Ve5");
result.Append("NOnIvamX3Yn5NH9hNJf1acFR0ZfX9IZ6l9qTHctGF2C6wjK5jhgbj4dZVibDESQ3w1uI0+GIZWkWR1FCSyz8A0tmY1tOBgAA");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC42SUWvbMBDHv8q4Z6eznThODHtYYzbMthJoNgb1HmTp0nhTJCPJoyX4u+9kJ05oM6hfzOnu/vr973SAnDlWMYuQHaAWkEVJAGujfyN3RU5hAHdsT1nYoHUxBCCqzXNDB3EAXKt7ZygnSOSd1a3h+KEEkb13vvhGVCX4DinXzO2o7kBJOstKyLOSPq95
w20JQQm23jcS+2QJHbXVXzX/09/jCe4bxj1Gfkupz61HhSqJQyGWy0maVslkhsl0ssBoPpmJdJ5GYZiwagZdAN+0aCVayB4Gj9PF6AqR5E4z6A2T/8J+0lIgOdsyaTGAhhlU/TzC7lcAG1ZdykXT+aj33aIp1FZfUT36OSsU6iVYFC9OufyoO5T40FM/0S9KA3jus16p
yH8WSuBTr0JxfpujRIcrrbb143i40rLdq/NN82U6Mjc7rfwYCvuxdbpQ3OCe7I7uV0zdtVKO8ekFwF9m+I4ZapWoHvsNJyG8dFDY9RcfHLu1ocl6hLALTiznfZCe4m+Ccaa9ZKmp5oLDPzvcsla6H0y2vuDtYPEZbDmCUXwFaoD474BeQ10nGGRGgMgvlktmbWN0g8bV
w3a7f6UcfOuvAwAA
<design>*/
