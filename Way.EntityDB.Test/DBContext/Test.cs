
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Way.EntityDB.Attributes;
namespace TestDB{


    /// <summary>
	/// 
	/// </summary>
    [Table("user")]
    [TableConfig]
    public class User :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  User()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// 
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
        [Column("id")]
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
        [Column("name")]
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

        System.Nullable<DateTime> _Birthday;
        /// <summary>
        /// 
        /// </summary>
        [Column("birthday")]
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

        System.Nullable<Int32> _IntColumn1;
        /// <summary>
        /// 
        /// </summary>
        [Column("intcolumn1")]
        public virtual System.Nullable<Int32> IntColumn1
        {
            get
            {
                return this._IntColumn1;
            }
            set
            {
                if ((this._IntColumn1 != value))
                {
                    this.SendPropertyChanging("IntColumn1",this._IntColumn1,value);
                    this._IntColumn1 = value;
                    this.SendPropertyChanged("IntColumn1");

                }
            }
        }
}}
namespace TestDB{

/// <summary>
/// 
/// </summary>
public enum Log_TypeEnum:int
{
    

/// <summary>
/// </summary>
SysLog = 1,

/// <summary>
/// </summary>
UserLog = 1<<1,

/// <summary>
/// </summary>
AdminLog = 1 << 2
}


    /// <summary>
	/// 
	/// </summary>
     [TableConfig(AutoSetPropertyNameOnInsert = "Type" , AutoSetPropertyValueOnInsert=Log_TypeEnum.AdminLog)]
    public class AdminLog :Log
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  AdminLog()
        {
        }


        String _AdminId;
        /// <summary>
        /// 
        /// </summary>
        [Column("adminid")]
        public virtual String AdminId
        {
            get
            {
                return this._AdminId;
            }
            set
            {
                if ((this._AdminId != value))
                {
                    this.SendPropertyChanging("AdminId",this._AdminId,value);
                    this._AdminId = value;
                    this.SendPropertyChanged("AdminId");

                }
            }
        }
}


    /// <summary>
	/// 
	/// </summary>
     [TableConfig(AutoSetPropertyNameOnInsert = "Type" , AutoSetPropertyValueOnInsert=Log_TypeEnum.UserLog)]
    public class UserLog :Log
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  UserLog()
        {
        }


        String _PeopleName;
        /// <summary>
        /// 
        /// </summary>
        [Column("peoplename")]
        public virtual String PeopleName
        {
            get
            {
                return this._PeopleName;
            }
            set
            {
                if ((this._PeopleName != value))
                {
                    this.SendPropertyChanging("PeopleName",this._PeopleName,value);
                    this._PeopleName = value;
                    this.SendPropertyChanged("PeopleName");

                }
            }
        }
}


    /// <summary>
	/// 
	/// </summary>
     [TableConfig(AutoSetPropertyNameOnInsert = "Type" , AutoSetPropertyValueOnInsert=Log_TypeEnum.SysLog)]
    public class SysLog :Log
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  SysLog()
        {
        }


        String _SystemPath;
        /// <summary>
        /// 
        /// </summary>
        [Column("systempath")]
        public virtual String SystemPath
        {
            get
            {
                return this._SystemPath;
            }
            set
            {
                if ((this._SystemPath != value))
                {
                    this.SendPropertyChanging("SystemPath",this._SystemPath,value);
                    this._SystemPath = value;
                    this.SendPropertyChanged("SystemPath");

                }
            }
        }

        String _SysId;
        /// <summary>
        /// 
        /// </summary>
        [Column("sysid")]
        public virtual String SysId
        {
            get
            {
                return this._SysId;
            }
            set
            {
                if ((this._SysId != value))
                {
                    this.SendPropertyChanging("SysId",this._SysId,value);
                    this._SysId = value;
                    this.SendPropertyChanged("SysId");

                }
            }
        }
}


    /// <summary>
	/// 
	/// </summary>
    [Table("log")]
    [TableConfig( AutoSetPropertyNameOnInsert = "Type" , AutoSetPropertyValueOnInsert=(Log_TypeEnum)0)]
    public class Log :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Log()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// 
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
        [Column("id")]
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
        [Column("userid")]
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

        System.Nullable<DateTime> _Time;
        /// <summary>
        /// 
        /// </summary>
        [Column("time")]
        public virtual System.Nullable<DateTime> Time
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

        System.Nullable<Log_TypeEnum> _Type;
        /// <summary>
        /// 
        /// </summary>
        [Column("type")]
        public virtual System.Nullable<Log_TypeEnum> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this.SendPropertyChanging("Type",this._Type,value);
                    this._Type = value;
                    this.SendPropertyChanged("Type");

                }
            }
        }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
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


                    if (e.DataItem is TestDB.User)
                    {
                        var deletingItem = (TestDB.User)e.DataItem;
                        
                    var items0 = (from m in db.Log
                    where m.UserId == deletingItem.id
                    select new TestDB.Log
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
                            t.ChangedProperties.Clear();
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
   modelBuilder.Entity<TestDB.User>().HasKey(m => m.id);
modelBuilder.Entity<TestDB.Log>().HasKey(m => m.id);
modelBuilder.Entity<Log>().HasDiscriminator<Log_TypeEnum?>("Type")
.HasValue<Log>((Log_TypeEnum)0).HasValue<SysLog>(Log_TypeEnum.SysLog).HasValue<UserLog>(Log_TypeEnum.UserLog).HasValue<AdminLog>(Log_TypeEnum.AdminLog);
}

        System.Linq.IQueryable<TestDB.User> _User;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.User> User
        {
             get
            {
                if (_User == null)
                {
                    _User = this.Set<TestDB.User>();
                }
                return _User;
            }
        }

        System.Linq.IQueryable<TestDB.Log> _Log;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.Log> Log
        {
             get
            {
                if (_Log == null)
                {
                    _Log = this.Set<TestDB.Log>();
                }
                return _Log;
            }
        }

        System.Linq.IQueryable<TestDB.SysLog> _SysLog;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.SysLog> SysLog
        {
             get
            {
                if (_SysLog == null)
                {
                    _SysLog = this.Set<TestDB.SysLog>();
                }
                return _SysLog;
            }
        }

        System.Linq.IQueryable<TestDB.UserLog> _UserLog;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.UserLog> UserLog
        {
             get
            {
                if (_UserLog == null)
                {
                    _UserLog = this.Set<TestDB.UserLog>();
                }
                return _UserLog;
            }
        }

        System.Linq.IQueryable<TestDB.AdminLog> _AdminLog;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<TestDB.AdminLog> AdminLog
        {
             get
            {
                if (_AdminLog == null)
                {
                    _AdminLog = this.Set<TestDB.AdminLog>();
                }
                return _AdminLog;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC82X32/aMBDH/xXkZ5gIJKQg9sBgD9EqhhY2TSp9MLED0RKnc5wihPjfe3YScAqlUKDiKfadf3zuct/YWaExnoY0QZ2HVdYc4oiiDnL/hy7lz5SjKvoVL7IBjqBR1spHBQTcf3CYQsdYVzd2sXyiWw/qc4oFVcv3PBHEDGljvZgJyoQ2fDXJUCaoA82A");
result.Append("wNMwqxM1AdoT9DuhfILAMsACT3FCnQHY5ZDgPvb+Qbu+hk4/DtOIJdB9KNZpGfo60gR9J+mlInaYx2kEJOASPKVyAcyGaRiCwcdhIi1kOobQsslyZDVHVQAK0klGP1QvXyPmhHK1d115B0Hi8SAKGBYxL1aGdBSADR0wa+xFLIi2jPmGGuIz5t4cZ6kKKZuJuTJb9YPg");
result.Append("xcpbcuMo8qZO/i3gYk7w8gx6AjUjgjwBGv6J8I2j4Ev15TCR1Y5xBn5RHx8nbx4gf5S+wd9+zPxgpko8s6ja1+VFconoUjVhulS1KyDFSizvaLtxVW1beu7v49kHpW1dU9rWBaTdev0Nc8h168u6hKxtnXpc6PG6krYuIem7ErhCODvZ31kaDagfsMzsLhOo18rXCqRy");
result.Append("wuQrzbvdrrL0CODlpkq3W2mcGfj+L4LE1eJu63EDIQh7hOV+1z9H3sE3335vkiDESaKDq0/BNjBbqkz3nyWfS8VknRdT6T4yovFTdgO7gcBaJwSWV34pstJFRgnhJt6XfUJYhXwhrs89b5sHzts5ZrOTztufIdnc7EtH7JAu9jsYXWgHrAzUU7uSV1ZCQyp2rJ+XJvOq");
result.Append("adr8ZezkaeO5lURBN18byVRlbT1h8jYlpST/7NSJ8AXuuC1TbVQanadxd7wreMBmuxO2uTx+TimmN9EeZVjS61KRT8RNYt9ZtlnzccOrmV7Lr019o1mzLWL47TbxqUnR+gXcOmtO1Q4AAA==");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC72WW2/aMBTHvwryc6i4JZQUHgrZpmxdhdZOmrRUlUkc6uHYmW26oorvvuNcoRfaQTt4SHxsn/M7x//Yvkce1niGFUHuPaIRcnsWmkrxi4Ta95DbttA5TqATXRKlkYWi2eUqJVlHKPiFltCliLwlcnQUBOo3I3epJEqdLGk0Uvgk/RON2p1uz3ZOykgj
XbhibIr1DTi4D2TAG40AvAfIhefEDeD3HRwr8/IZhwvz9IhaaJGaV4NzFKoAWeVcRZOUkXw+/MG6hiD0TISLLCuTx0WKwzIZbwzdnwAT2rgb9Y/tfq8Z407Y7IVO3JzF7W6zb0fteDCIYtIjaG2hryJaMqKQ+zMvll2VJ8GUg78yR1M7iOmrj4JFBIoUY6aIhVIsCc8q
21pfWegSzzbdtXuVP5P7Y39FNq21VUyoAc7EfMf4MpbPH6ZgYuZdXt7IB5gWOL8D26BroRVyB1tR6yn24ymO08qnDExg3/vh84jcZUGh7Y09wogmE8FjOt9B8o0wvBWnMlyDEsIqaWOeCLZMzDjH2TDwcqAppx8hg+ON8646sFOrHJpm1U6XWvg8lCSB1UKulktYuwnm
50vGqrUsPwVEYcwDdF9Nv5j3fKaQoAETCcriK4+qUNKEcqxFqYyytE6nQskeT8AU0SuaPEQFc4tleIONdhjh8+zzslvP4RW+Kr72i3zdim9Mpb6J8GoPxghrommWXgX5WsTOi4j1R+Rzna91ew/IfFX/ma/7Ip/9tmqzD1Cbs7XfwAfytmWyD1Favz56cqm8ucrsQ1R2
XOOZcPsW7gNfJh6JKTemi5WCHa0xarStgJsVKVrDoTGcRoBSWBrDYaOzT2JPydOAVXkNqryARpMkO6LfYxvaAdl7rvoQj2GlakBzAJTofdB73bOXmA+itvejrg+fKRFwg3m3fX8HuvM69EKSNXt9WmXi/P81778OvPx0sgtAaDpSKVIiNd28CYH04fbESHnH4VtXsVhI
Qud8QVbX9ShQ6oY9zA6bcmcFKsEYXKSp4OXucbX+C+NmNQRyCwAA
<design>*/
