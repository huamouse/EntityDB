
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
public enum UserInfo_DiscriminatorEnum:int
{
    

/// <summary>
/// </summary>
SuperUser = 1,

/// <summary>
/// </summary>
AdminUser = SuperUser | 1<<1
}


    /// <summary>
	/// 
	/// </summary>
     [Way.EntityDB.Attributes.Table("id", AutoSetPropertyNameOnInsert = "Discriminator" , AutoSetPropertyValueOnInsert=UserInfo_DiscriminatorEnum.SuperUser)]
    public class SuperUser :UserInfo
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  SuperUser()
        {
        }


        String _SuperName;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("supername")]
        [Way.EntityDB.WayDBColumnAttribute(Name="supername",Comment="",Caption="",Storage = "_SuperName",DbType="varchar(50)")]
        public virtual String SuperName
        {
            get
            {
                return this._SuperName;
            }
            set
            {
                if ((this._SuperName != value))
                {
                    this.SendPropertyChanging("SuperName",this._SuperName,value);
                    this._SuperName = value;
                    this.SendPropertyChanged("SuperName");

                }
            }
        }
}


    /// <summary>
	/// 
	/// </summary>
     [Way.EntityDB.Attributes.Table("id", AutoSetPropertyNameOnInsert = "Discriminator" , AutoSetPropertyValueOnInsert=UserInfo_DiscriminatorEnum.AdminUser)]
    public class AdminUser :SuperUser
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  AdminUser()
        {
        }


        String _adName;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("adname")]
        [Way.EntityDB.WayDBColumnAttribute(Name="adname",Comment="",Caption="",Storage = "_adName",DbType="varchar(50)")]
        public virtual String adName
        {
            get
            {
                return this._adName;
            }
            set
            {
                if ((this._adName != value))
                {
                    this.SendPropertyChanging("adName",this._adName,value);
                    this._adName = value;
                    this.SendPropertyChanged("adName");

                }
            }
        }
}


    /// <summary>
	/// 
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("userinfo")]
    [Way.EntityDB.Attributes.Table("id", AutoSetPropertyNameOnInsert = "Discriminator" , AutoSetPropertyValueOnInsert=(UserInfo_DiscriminatorEnum)0)]
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

        String _name;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="",Storage = "_name",DbType="varchar(50)")]
        public virtual String name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.SendPropertyChanging("name",this._name,value);
                    this._name = value;
                    this.SendPropertyChanged("name");

                }
            }
        }

        System.Nullable<UserInfo_DiscriminatorEnum> _Discriminator;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("discriminator")]
        [Way.EntityDB.WayDBColumnAttribute(Name="discriminator",Comment="",Caption="",Storage = "_Discriminator",DbType="int")]
        public virtual System.Nullable<UserInfo_DiscriminatorEnum> Discriminator
        {
            get
            {
                return this._Discriminator;
            }
            set
            {
                if ((this._Discriminator != value))
                {
                    this.SendPropertyChanging("Discriminator",this._Discriminator,value);
                    this._Discriminator = value;
                    this.SendPropertyChanged("Discriminator");

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
modelBuilder.Entity<UserInfo>().HasDiscriminator<UserInfo_DiscriminatorEnum?>("Discriminator")
.HasValue<UserInfo>((UserInfo_DiscriminatorEnum)0).HasValue<AdminUser>(UserInfo_DiscriminatorEnum.AdminUser).HasValue<SuperUser>(UserInfo_DiscriminatorEnum.SuperUser);
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

        System.Linq.IQueryable<TestDB.AdminUser> _AdminUser;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.AdminUser> AdminUser
        {
             get
            {
                if (_AdminUser == null)
                {
                    _AdminUser = this.Set<TestDB.AdminUser>();
                }
                return _AdminUser;
            }
        }

        System.Linq.IQueryable<TestDB.SuperUser> _SuperUser;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.SuperUser> SuperUser
        {
             get
            {
                if (_SuperUser == null)
                {
                    _SuperUser = this.Set<TestDB.SuperUser>();
                }
                return _SuperUser;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC81XTY/aMBD9K8hnqEgIbEDbAyU9RK3oqmyrSps9mNiAtcGhjlO0ovnvHTshMeVrqaBwwp4Zj99k3oyHFXrE44gmqPe0ypdDPKeoh0Y/IyYpqqOv8TLX+pLO81Vhwgiov+MohY2V1Uu5fF3QSoMGgmJJte9+KFnMkWEbxlxSLg3zVZDjCFAPlozA7109");
result.Append("0PawDNC3hAqfT+IAgdTDEo9xQn0PdDYI2Oc4fIF1M4PNII7SOU9g+7R2ZbdMX0oEez/ppzL2eSjoHMCASoqUKgeYD9MoAsEER4mSkPEjRJcfVpb1Aq0GoHD6ycMnvSlcxIJQoa8GSCUKx0TB9WInjvW1FZDCrYHjFxbhDAvtIaJ8Kmda3G4eQrd2XMGzDHhtE57HklCw");
result.Append("OeNYxuL8OC37RKB29qwMvB+DmE/YVKc3l+iPbLKLFPQwmaqOK1KPJLAyz8phatsHqD3DfHoStb9EpKyybToP6fKAltPlLkZ3zGSN0gUVw5sglKo0P/mLPbmdzmCoPx7ZFdJF+LeuVyOkE4m3PyDQfMDhS7rIGUEeRAx5kIyquFbGnYoCgk3hdKRZUZVAZqLdaVbmJcv0");
result.Append("ByQ0onLjA/7fwmjdeGFsPBuY3HxVKAARTpISc5+AhYoUUr67Ym6BBs5+Gnga2slP/+4sXwp/+5Kji3vG0cW94OjiHh5dDrTyamroXmGocY8MNW8B3mpe8rn5yNO5RyeMGw+0IkLtfQ3QBbwschBUyt816/7eOvJeuf/yXimkRuzWVZqke5kmWYVlX2soOhKZc0JkJRuK");
result.Append("9n++lg7bosEg1RTztdkaVXNSoas/gq8JdM93PpcdR1+0YV00zG37kRSMT7cPVF3z7Wc2YtoL7VmFpbQjKouD7TEmbnfcbXRauNlw7lzc6Dphs2GHXTcMcdt1iIWyP8qYMRIEDwAA");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC8VUW2/TMBj9K5Gf0yq9bWm0Paz1QBFQVWoRSIQHx3a3gGNHtoNWdf3vfM7F7WAT4wXUB9vf5XznnNg9IEwsyYnhKDmggqFkHKK1Vt84tSlGyShEK1JCEm25sShELN/uK96UUSU3VkOKAURgVK0pv84QS7LMQvGQ5RlyHUKsib2HukOmMxkEUAKZBFYM
pVm2VIwbt7mVtrB7vHD7T2Q/7M9DN9sF3YoXkyE1GQp7MFOUleAtIPwgeoSpxXtFv6Nk1vLfVIT2IvAC0m9rpxXNcsLieT4fXExINJhexmQwn9JoMKbzmFIyi6dshI4h+qBYLbhByRdvUmdLSQoJeL2LzjNIpuaNEoyDOTsiDA9RRTSXjaPR8WuItiQ/h4s93EfDdSp3
6nfITtCpPZW/sor7DG72bbprf4BvOYN1j5LLC4eR4s+pZPyh6YczXmAuuOVLJXfFnQ8ulahLeab8xBWOTulNbVUqqeYlKESJ1TXoXRK5qoXw+vtrgwqoeUozNet3bts2Kg22uUGRy+DCUF2UhSRW9WYew47J3DORbnmGSzfck2lHeC4/iKb3REOn4PKuuaKz6AV2HZSn
N/oTvUnk6T0t+3uerWe3si4x3xXShTZ1xbW7LMF1MAozecMAvjufco/B6OpqdK7vlerGz6hzpLy40/8CYat/7/7kJfdhnCDGdNy8K/CGO+Knl9vY9B+4T1/H3X9F5F4rdZlKK4jZon2yx5/p29UqvAUAAA==
<design>*/
