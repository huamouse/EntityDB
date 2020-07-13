
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Storm.OrderMessageCenter.Database{


    /// <summary>
	/// 订阅用户
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("account")]
    [Way.EntityDB.Attributes.Table("id")]
    public class Account :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Account()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display(Name = "创建时间")]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]//添加时自动增长
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

        String _MerchantName;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("merchantname")]
        [Way.EntityDB.WayDBColumnAttribute(Name="merchantname",Comment="",Caption="",Storage = "_MerchantName",DbType="varchar(100)")]
        public virtual String MerchantName
        {
            get
            {
                return this._MerchantName;
            }
            set
            {
                if ((this._MerchantName != value))
                {
                    this.SendPropertyChanging("MerchantName",this._MerchantName,value);
                    this._MerchantName = value;
                    this.SendPropertyChanged("MerchantName");

                }
            }
        }

        String _NotifyUrl;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("notifyurl")]
        [Way.EntityDB.WayDBColumnAttribute(Name="notifyurl",Comment="",Caption="",Storage = "_NotifyUrl",DbType="varchar(100)")]
        public virtual String NotifyUrl
        {
            get
            {
                return this._NotifyUrl;
            }
            set
            {
                if ((this._NotifyUrl != value))
                {
                    this.SendPropertyChanging("NotifyUrl",this._NotifyUrl,value);
                    this._NotifyUrl = value;
                    this.SendPropertyChanged("NotifyUrl");

                }
            }
        }
}}
namespace Storm.OrderMessageCenter.Database{


    /// <summary>
	/// 用户订阅
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("subscribe")]
    [Way.EntityDB.Attributes.Table("id")]
    public class Subscribe :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Subscribe()
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

        System.Nullable<Int32> _AccountId;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("accountid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="accountid",Comment="",Caption="",Storage = "_AccountId",DbType="int")]
        public virtual System.Nullable<Int32> AccountId
        {
            get
            {
                return this._AccountId;
            }
            set
            {
                if ((this._AccountId != value))
                {
                    this.SendPropertyChanging("AccountId",this._AccountId,value);
                    this._AccountId = value;
                    this.SendPropertyChanged("AccountId");

                }
            }
        }

        String _MessageName;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("messagename")]
        [Way.EntityDB.WayDBColumnAttribute(Name="messagename",Comment="",Caption="",Storage = "_MessageName",DbType="varchar(50)")]
        public virtual String MessageName
        {
            get
            {
                return this._MessageName;
            }
            set
            {
                if ((this._MessageName != value))
                {
                    this.SendPropertyChanging("MessageName",this._MessageName,value);
                    this._MessageName = value;
                    this.SendPropertyChanged("MessageName");

                }
            }
        }
}}
namespace Storm.OrderMessageCenter.Database{


    /// <summary>
	/// 消息列表
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("message")]
    [Way.EntityDB.Attributes.Table("id")]
    public class Message :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Message()
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

        String _Content;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("content")]
        [Way.EntityDB.WayDBColumnAttribute(Name="content",Comment="",Caption="",Storage = "_Content",DbType="varchar(1000)")]
        public virtual String Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                if ((this._Content != value))
                {
                    this.SendPropertyChanging("Content",this._Content,value);
                    this._Content = value;
                    this.SendPropertyChanged("Content");

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

        System.Nullable<DateTime> _Time;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("time")]
        [Way.EntityDB.WayDBColumnAttribute(Name="time",Comment="",Caption="",Storage = "_Time",DbType="datetime")]
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
}}
namespace Storm.OrderMessageCenter.Database{

/// <summary>
/// 
/// </summary>
public enum MessageMission_StatusEnum:int
{
    

/// <summary>
/// </summary>
None = 0,

/// <summary>
/// </summary>
Sended = 1,

/// <summary>
/// </summary>
Sending = 1<<1,

/// <summary>
/// </summary>
Failed = 1<<10
}


    /// <summary>
	/// 
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("messagemission")]
    [Way.EntityDB.Attributes.Table("id")]
    public class MessageMission :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  MessageMission()
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

        System.Nullable<Int32> _AccountId;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("accountid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="accountid",Comment="",Caption="",Storage = "_AccountId",DbType="int")]
        public virtual System.Nullable<Int32> AccountId
        {
            get
            {
                return this._AccountId;
            }
            set
            {
                if ((this._AccountId != value))
                {
                    this.SendPropertyChanging("AccountId",this._AccountId,value);
                    this._AccountId = value;
                    this.SendPropertyChanged("AccountId");

                }
            }
        }

        String _Error;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("error")]
        [Way.EntityDB.WayDBColumnAttribute(Name="error",Comment="",Caption="",Storage = "_Error",DbType="varchar(100)")]
        public virtual String Error
        {
            get
            {
                return this._Error;
            }
            set
            {
                if ((this._Error != value))
                {
                    this.SendPropertyChanging("Error",this._Error,value);
                    this._Error = value;
                    this.SendPropertyChanged("Error");

                }
            }
        }

        System.Nullable<DateTime> _SendTime;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("sendtime")]
        [Way.EntityDB.WayDBColumnAttribute(Name="sendtime",Comment="",Caption="",Storage = "_SendTime",DbType="datetime")]
        public virtual System.Nullable<DateTime> SendTime
        {
            get
            {
                return this._SendTime;
            }
            set
            {
                if ((this._SendTime != value))
                {
                    this.SendPropertyChanging("SendTime",this._SendTime,value);
                    this._SendTime = value;
                    this.SendPropertyChanged("SendTime");

                }
            }
        }

        System.Nullable<MessageMission_StatusEnum> _Status=(System.Nullable<MessageMission_StatusEnum>)(0);
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("status")]
        [Way.EntityDB.WayDBColumnAttribute(Name="status",Comment="",Caption="",Storage = "_Status",DbType="int")]
        public virtual System.Nullable<MessageMission_StatusEnum> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this.SendPropertyChanging("Status",this._Status,value);
                    this._Status = value;
                    this.SendPropertyChanged("Status");

                }
            }
        }

        System.Nullable<Int32> _MessageId;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("messageid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="messageid",Comment="",Caption="",Storage = "_MessageId",DbType="int")]
        public virtual System.Nullable<Int32> MessageId
        {
            get
            {
                return this._MessageId;
            }
            set
            {
                if ((this._MessageId != value))
                {
                    this.SendPropertyChanging("MessageId",this._MessageId,value);
                    this._MessageId = value;
                    this.SendPropertyChanged("MessageId");

                }
            }
        }

        System.Nullable<Int32> _TryCount=0;
        /// <summary>
        /// 第几次尝试发送
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("trycount")]
        [Way.EntityDB.WayDBColumnAttribute(Name="trycount",Comment="",Caption="第几次尝试发送",Storage = "_TryCount",DbType="int")]
        public virtual System.Nullable<Int32> TryCount
        {
            get
            {
                return this._TryCount;
            }
            set
            {
                if ((this._TryCount != value))
                {
                    this.SendPropertyChanging("TryCount",this._TryCount,value);
                    this._TryCount = value;
                    this.SendPropertyChanged("TryCount");

                }
            }
        }

        System.Nullable<DateTime> _WhenSend;
        /// <summary>
        /// 什么时候再发送
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("whensend")]
        [Way.EntityDB.WayDBColumnAttribute(Name="whensend",Comment="",Caption="什么时候再发送",Storage = "_WhenSend",DbType="datetime")]
        public virtual System.Nullable<DateTime> WhenSend
        {
            get
            {
                return this._WhenSend;
            }
            set
            {
                if ((this._WhenSend != value))
                {
                    this.SendPropertyChanging("WhenSend",this._WhenSend,value);
                    this._WhenSend = value;
                    this.SendPropertyChanged("WhenSend");

                }
            }
        }

        public virtual Account Merchant { get; set; }

        public virtual Message MessageObject { get; set; }
}}

namespace Storm.OrderMessageCenter.Database.DB{
    /// <summary>
	/// 
	/// </summary>
    public class MessageCenterDB : Way.EntityDB.DBContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="dbType"></param>
        public MessageCenterDB(string connection, Way.EntityDB.DatabaseType dbType): base(connection, dbType)
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
            var db =  sender as Storm.OrderMessageCenter.Database.DB.MessageCenterDB;
            if (db == null)
                return;


                    if (e.DataItem is Storm.OrderMessageCenter.Database.Account)
                    {
                        var deletingItem = (Storm.OrderMessageCenter.Database.Account)e.DataItem;
                        
                    var items0 = (from m in db.Subscribe
                    where m.AccountId == deletingItem.id
                    select new Storm.OrderMessageCenter.Database.Subscribe
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

                    var items1 = (from m in db.MessageMission
                    where m.AccountId == deletingItem.id
                    select new Storm.OrderMessageCenter.Database.MessageMission
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items1.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                        {
                            db.Delete(t);
                        }
                    }

                    }

                    if (e.DataItem is Storm.OrderMessageCenter.Database.Message)
                    {
                        var deletingItem = (Storm.OrderMessageCenter.Database.Message)e.DataItem;
                        
                    var items0 = (from m in db.MessageMission
                    where m.MessageId == deletingItem.id
                    select new Storm.OrderMessageCenter.Database.MessageMission
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
   modelBuilder.Entity<Storm.OrderMessageCenter.Database.Account>().HasKey(m => m.id);
modelBuilder.Entity<Storm.OrderMessageCenter.Database.Subscribe>().HasKey(m => m.id);
modelBuilder.Entity<Storm.OrderMessageCenter.Database.Message>().HasKey(m => m.id);
modelBuilder.Entity<Storm.OrderMessageCenter.Database.MessageMission>().HasKey(m => m.id);
}

        System.Linq.IQueryable<Storm.OrderMessageCenter.Database.Account> _Account;
        /// <summary>
        /// 订阅用户
        /// </summary>
        public virtual System.Linq.IQueryable<Storm.OrderMessageCenter.Database.Account> Account
        {
             get
            {
                if (_Account == null)
                {
                    _Account = this.Set<Storm.OrderMessageCenter.Database.Account>();
                }
                return _Account;
            }
        }

        System.Linq.IQueryable<Storm.OrderMessageCenter.Database.Subscribe> _Subscribe;
        /// <summary>
        /// 用户订阅
        /// </summary>
        public virtual System.Linq.IQueryable<Storm.OrderMessageCenter.Database.Subscribe> Subscribe
        {
             get
            {
                if (_Subscribe == null)
                {
                    _Subscribe = this.Set<Storm.OrderMessageCenter.Database.Subscribe>();
                }
                return _Subscribe;
            }
        }

        System.Linq.IQueryable<Storm.OrderMessageCenter.Database.Message> _Message;
        /// <summary>
        /// 消息列表
        /// </summary>
        public virtual System.Linq.IQueryable<Storm.OrderMessageCenter.Database.Message> Message
        {
             get
            {
                if (_Message == null)
                {
                    _Message = this.Set<Storm.OrderMessageCenter.Database.Message>();
                }
                return _Message;
            }
        }

        System.Linq.IQueryable<Storm.OrderMessageCenter.Database.MessageMission> _MessageMission;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<Storm.OrderMessageCenter.Database.MessageMission> MessageMission
        {
             get
            {
                if (_MessageMission == null)
                {
                    _MessageMission = this.Set<Storm.OrderMessageCenter.Database.MessageMission>();
                }
                return _MessageMission;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC+1ZT2/TSBT/KsjndhX/iZ1U2kOVgBQBXUTK7kqEw8SepKN1xqw9pooqpFYLu72wLdIi/kvAAXqoKNoDaMXXwUn7LZgZ26mduKmT2Gkr7Sme98bj93vz3u+9mWwIq6BpQkdYur3hP66ADhSWhPrvJiJQWBBuWuu+tkZgx38KpiCDqn8GpksHcuH+wkBB");
result.Append("unfhsUqo2BAQyBdf1gmysBCZq1uYQEwi0zcaviENYYk+IoP+SuJCQ9DBXfYyHTaEw4/vjp497P+z19v+0hCokq3GNcu6brmYcGEVENAEDqxVqUqlAnTN0n+jz9TYhlCxTLeDHTq8HX5HFMXoWkxGxzVn2SVWDes27FBTqYrYLmQrALzimiYVtIDpMInRXKXY/ZcDIzgW");
result.Append("bgFHUXNuXOWjYA3LNqDNP17g2ipydBt1EAbEssOVqb8GFkpRC69DW18DmPiCRFtD046NDb4csfUeYMvQz1GxCXGbrHGxWCiMhRAufYxBTIdBjmK44TZNpF+F3ewBFCcGIKUCIBWjAFYsglrdW7Z5HnZAHgPgDtNVf61YuIXaPPB9Cc+IaFIaQeLEMpy+zsigTmgy8xQ6");
result.Append("jRLEXClBGqIEnwx8YohTQt1tMm804bSkoORJClIWpFBMoMCaMUM8hoZGYnGs4VNTgRqnM8cBbV6C8iCDCRFI5yeVpFxTSR5Kpd7n7d7Wgbf99PDtXjyVgg2aNpG0PBNJziKRSlELK773cqH1wljzp06n8vBWPjvwdt97X/7tf93xHu4d/bHn7Tw+2tyKbysFZ5p1iA04");
result.Append("C2c0UTJnGLAFXJPwCOTSSbHL6YpyLLrmxSHyheEQOVcOURJo4jpyHB6IU7GFVMiTLZQM2IL3YvMuu0oWPMFL38Dyy7bNZs2heVUy6b5jxwdGW6topmSn+QVJuMT0rk9JU7FMYenrOhlEzGXsdqqwhXB4JsHw0o+XaBw3sE/sdCROSc+n4FbS4U7q9M44WYrpLC8NHzX2");
result.Append("972/3vT233qfXh8ePEmqqKt2tzK4h8gW3sz7paZDPdxKfPu6+e2/7d7Tz97mc+/PR0mof1mDPNrOPhe181N3lTF1l97dtCequz+ZxuCW7qRSuwLXT52D4Xqk5jL87B6pDY0hqQFNSEakc/ReMVfvRW8LR9wWVU7vrzChFPHMLr3KF6ZHVfPsUePXjleQSaA92pvKKXrT");
result.Append("YinH1pSbOWNrWhwm76NXm4fvt/ovH/f+/tB/8SA44e8+6n/4lHjCn9PxKY51sm52zqGpnRyaVZ70E4dmUijmZn7p/yo0g/fK8/De2OKdVRXSLuIFkXhh/vRQCucxUsLdV2NXKvM5Nc+6d2fTl9JhsLbAdtp/ju436xmYK9hf5V2HhsQPNUxUhX8oNjsIgtH5dWIj3B59");
result.Append("4TgS0r8Tw3SiaXcYLKatQ/6PMZ1QLgKgKCVtUZSAtKgUNGmxrOrSoqHJItA1qCmqKtz/DtEkGkQmIAAA");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC71YzW7bRhB+FWHPtEtSlGQJycEWk0Jt7RiR0xSoAmNFrmTWq6WwuzQiGAacQxtfgqJAi7SHAk1PORhNTymKvk6kOm/RWZIiqb/q17YP5O7szHzzzc5wV+fIxhI3sSCoco48F1XyGjrk/jfEkTUbVQwNHeAOCNE+EQK3SZUwSbi9hzTkNo96XRCZGnJ8
VpccVrlgLSf8gDvkfgO5lU9G1LbdZgMpTUoPsTyB9ecN3mC5HCwFSQWe1UoD/p4IwoV6+Qw7p+oZmVRvnHT9UCQ5dskxLDwj/PjMVFN16fPO9iPuEj7q9ylp7nY9tcTe2/ddQkMLYyFtO6KBtCEg4XW6lESg4B9mLwC594XvnELIVsRLvYsdRc5Mxwm7Gvo0UPSicgFj
y9opbRkmNrcsvWRulYuOueWW8gZ2SqRkFYvoQkMAM6BEoMrXSV7iTHSwx8De0LRKEwhr4qFPwT+qtDAVRENdzAGDkuoXWmTDSmyInpCks6SVZxo6ws0sqDKkHnel5zOwefPH7x9//vbfH98Orv5Ciaddx/EDJiddxVQm4Aw9aywyE5lMjdWDpnC41yQLmDOy5gbvrwYv
3vWvXt+8eZuai3O1gDFzXGffE0KZnq06ZKvGxlNZHkrs8D0Sx+rPwZkFTPTCZ5abREUNxnWsohXpFHayBKQ6xqSOaZqhTr5kZuNMdcxJnWK+EOnslFSANfurGnPJ8zA4GNt7NqFEkqrPWl47jXgEP4T8mFA8Ek8ycWwT4YxlWgmrPg06arWVz0yw4fJ4l9VcNDX8CZfm
FJcTmR31W17Qb36M9nUdF6xpjmMd5TjkPZJm2kU52bEwVIW9G0i/xhxOOlDQqCJ5AOVdxewgoDQp92FPR15YslkCa+Lwc/UaKfqq1ylHkLyasD2VrI7HMDTC2FjSdPRM7XDnBDMZDqdgikEkoCJXCaYzrNQ5aFLC2uH3w9D1GTBjWwlOYy5Oc6OMqV29MmVps0832PJ8
RYgSrmahW56p9DsSb8PNJbSgLwrTnAuzsNmEGmsktJhAgdYolfdNbX99Fsbl07qzWb7MNfgq33oBmGswVUhb2gPOQXwbvez/EM7d+4X04F4nzD3yVqpPOM0TGakuTWJ+LsS039YlloFYOcEPWNCxSctjaurAZyR3P6drDaYiJy4MjHjgsbYa3bunJh5ij0ZSGOtjIbqk
hQMqv8Q0UEYXTow1N+q0tR/40mv1nnB615/C+btnosHfZfkV5sJLG/utfXiMdegrjtxkrq/7L38bXL/p//nrzbuf+t//8PHyRXoHOeK9anxBWp/fVbdtcW5IpWxIH/65/PD31eD1+/7lL/3vXo2H9PSEhOV2xx2nNC+IYtq2b6shGqs0RDjAOxQL0eV+l3DpZa6KBlQi
XC8pie+NbOwerJpmy+fEa7NT0jtOlqqDU2beCW8HXngtguIBED6l8BNPmE4VY3J7AWlqBMiOHQ5P7jPcAbLp3kwgZNTbSEYM2HjT3YVd51FT/Q41K0QwPcMpWJ3m9NnFfxvtWGDvEgAA
<design>*/
