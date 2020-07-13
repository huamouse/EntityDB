
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
namespace Storm.OrderMessageCenter.Database{


    /// <summary>
	/// 订阅用户
	/// </summary>
    [Table("account")]
    [TableConfig]
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

        String _MerchantName;
        /// <summary>
        /// 
        /// </summary>
        [Column("merchantname")]
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
        [Column("notifyurl")]
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
    [Table("subscribe")]
    [TableConfig]
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

        System.Nullable<Int32> _AccountId;
        /// <summary>
        /// 
        /// </summary>
        [Column("accountid")]
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
        [Column("messagename")]
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
    [Table("message")]
    [TableConfig]
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

        String _Content;
        /// <summary>
        /// 
        /// </summary>
        [Column("content")]
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
    [Table("messagemission")]
    [TableConfig]
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

        System.Nullable<Int32> _AccountId;
        /// <summary>
        /// 
        /// </summary>
        [Column("accountid")]
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
        [Column("error")]
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
        [Column("sendtime")]
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
        [Column("status")]
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
        [Column("messageid")]
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
[Display(Name = "第几次尝试发送")]
        [Column("trycount")]
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
[Display(Name = "什么时候再发送")]
        [Column("whensend")]
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

        [ForeignKey("AccountId")]
        public virtual Account Merchant { get; set; }

        [ForeignKey("MessageId")]
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
result.Append("H4sIAAAAAAAAC+1aT2/TSBT/KsjndhX/iZ1U2kOVsFLE0kWbwq5EOEzsSTrCGYM93iqqkFrxrxcWkECwCyste4Aeqi3iAFrxdXDSfgtmxnZqJ27qJHaaij3V8954/N6b9/u9N5NuCeugaUJHWLm+5T+ugQ4UVoT6bRMRKCwJP1ubvrZGYMd/CqYgg6qvAdOlA7lwZ2mg");
result.Append("IN1b8FglVGwICOSLr+oEWViIzNUtTCAmkelbDd+QhrBCH5FB/0riUkPQwS32Mh02hMN//zl6eb//bK+3+6khUCVbjWtWdd1yMeHCKiCgCRxYq1KVSgXoR0u/SZ+psQ2hYpluBzt0eD38jiiK0bWYjI5rzqpLrBrWbdihplIVsV3IVgB4zTVNKmgB02ESo7lOffdfDozg");
result.Append("vnALuBc158olPgrWsGwD2vzjBa6tIke3UQdhQCw7XJnGa2ChFLXwMrT1DYCJL0i0NTTt2NjgyxFbfwNsGfo5KjYhbpMNLhYLhbEuhEsf+yCm80GO+nDFbZpIvwS72TtQnNgBKZUDUjHqwJpFUKt71TYXYQfkMQ7cYLrqrxULt1CbJ74v4YiIgtIIgBNDOH2dkUGdUDBz");
result.Append("CJ1GCWKulCANUYJPBj4xxCmh7jZZNJpwWlJQ8iQFKQtSKCZQYM2YIR9DQyO5ONbwqalAjdOZ44A2L0F5kMGEHkiLAyUpVyjJQ1Dqfdzt7Rx4uy8O3+zFoRRs0LRA0vIEkpwFkEpRCyt+9HKh9cJY86eGU3l4K18eeE/eep8+9D8/9u7vHd3d8x4/PdreiW8rdc406xAb");
result.Append("cBbOaKJkzjBgC7gm4RnIpZP6LqcryrHsmheHyOeGQ+RcOURJoInLyHF4Ik7FFlIhT7ZQMmAL3ovNu+wqWfAEL30Dyy/aNps1h+ZVyaT7jh0fGG2to5nATvEFSbjE9KFPSVMxpDD4uk4GGXMRu50qbCEcnkkwvPD9BZrHDewTOx2JU9LzKX4r6fxO6vTOGCzFdJaXho8a");
result.Append("+/vew797+2+8938dHjxPqqjrdrcyuIfI1r2Z90tN5/VwK/Hl8/aX/3Z7Lz562394Dx4lef3LBuTZdvZY1Ban7ipj6i69u2lPVHd/Mo3BLd1JpXYNbp46B8PNSM1l/rN7pDY0hqQGNCEZkc4xesVcoxe9LRwJW1Q5fbxCQCnimV16lc9Nj6rm2aPGrx1/QCaB9mhvKqfo");
result.Append("TYulHFtTbuaMrWlxmLyPXm8fvt3pv3ra+/1d/897wQn/yaP+u/eJJ/w5HZ/ivk7Wzc45NbWTU7PKQT9xaialYm7ml/6vQjNErzyP6I0t3llVIe08XhCJ5+ZHD6WwiJkS7r4au1KZz6l51r1bzL5UGffj1jff1dNgBjsjsPj5z9Eoso6LJRL7R4OuQwP9XQ0TVeHbFJsd");
result.Append("hHZ0fp3YCLdHXzjGUfp3Yhlxomk3WI4wbR3y39vphHIRAEUpacuiBKRlpaBJy2VVl5YNTRaBrkFNUVXhzlfUry+IZCEAAA==");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC71YzW7bRhB+FWHPtEtSpGQJySERk0Jt7RiV0xaogmBFrmTWq6WwuwwiGAacQ1tfgqBAgrSHAk1PORhNTymKvk6kOm/RWZIiqb/q17YP5O7szHzzzc5wV6fIwRK3sCCoeop8D1WLGjrkwXfElXUHVQ0NHeAuCNE+EQJ3SI0wSbhzF2nIax31eyAyNeQG
rCE5rPLAWkEEIXfJ7Sbyqp+Mqe16rSZSmpQeYnkM60+bvMkKBVgKkio8a9Um/D0UhAv18hl2T9TTIeJEBj31OgFk1xVNpI3MCL/boyQ2Bf8wewb+/C8C9wSA2nE0jR52VUgNGfDu7gPuET4OM+VEQ5+GihRUsTG2rL3yjmFic8fSy+ZOpeSaO165aGC3TMpWqYTONLQf
eCElAlW/TdlM+Otin4G9kWlFLgjr4n5AwT+qtjEVREM9zAGDkupnWmzDSm2IvpCku6KVRxo6wq08qAokDPekHzCwefXH7x9//v7fl2+HF3+h1NMd1w1CJqddJVSm4Aw9byw2E5vMjDXClnC53yJLmDPy5obvL4bP3g0uXl+9eZuZS3K1hDFzUmffF0KZnq86YqvOJlNZ
GUmc6D0WJ+pPwZkFTPSjZ56bVEUNJnWskhXr2Ht5AjIdY1rHNM1Ip1g283FmOua0Tqloxzp7ZRVg3fmmzjzyNAoOxs5dh1AiSS1gbb+TRTyGH0L+klA8Fk868Rjq053ItBLWAhp21WqrmJtgo+XJLqt7aGb4Uy7NGS6nMjvut7Kk3+IE7Zs6tq1ZjhMd5TjiPZbm2kUl
3bEwVIV9J5RBnbmcdKGgUVXyEMq7htlBSGla7qNOjPyoZPME1sXh5+o1VgxUr1OOIHl14fgqWV2fYWiEibG06ei52uHuMWYyGs7AlIBIQcWuUkxPsFLnoEkJ60Rd39D1OTATWylOYyFOc6uMqV29NmVZs8822Op8xYhSruahW52p7DuSbMPtJdTWl4VpLoRpbzehxgYJ
LaVQoDVK5X1b21+fh3H1tO5tly9zA74q114A5gZM2VlLu8c5iK+jl/0fwoV7386O2w3CvCN/rfqEMziRserKJBYXQsz6bUNiGYq1E3yPhV2HtH2mpg4CRgq3C7rWZCpy4sHASAY+66jRrVtq4j72aSyFsT4RokfaOKTyK0xDZXTpxFgLo85a+0Eg/Xb/Iac3/SlcvHum
GvxNlp+9EF7W2K/tw2NsQl9p7CZzeTn48bfh5ZvBn79evXs1ePHTx/Nn2R3kiPdryQVpc37X3balhSGV8yF9+Of8w98Xw9fvB+e/DH54PhnS18ckKrcb7jjlRUGUsrZ9XQ3RWKchwgHepViIHg96hEs/d1U0oBLheklJcm9kE/dg1TTbASd+h52Q/uN0qTo45ebd6HYQ
X4ugeABEQCn8MBOlU8WY3l6AxMwIkJ04HJ3c57gDZDO9qe/4uLOxhBhw4pjtLWo6D1rqx6N5EQLVM32q5jXL56Oz/wAMrJzhoxIAAA==
<design>*/
