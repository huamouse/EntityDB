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

namespace FllowOrderSystem.DBModels
{
    [TableConfig]
    [Table("tradeuser")]
    public class TradeUser :Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _TradeUserId;
        [Key]
        [Required]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int32> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId",_TradeUserId,value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        TradeUser_StyleEnum? _Style;
        /// <summary>
        /// 风格
        /// </summary>
        [Display(Name = "风格")]
        [Column("style")]
        public virtual TradeUser_StyleEnum? Style
        {
            get
            {
                return _Style;
            }
            set
            {
                if ((_Style != value))
                {
                    SendPropertyChanging("Style",_Style,value);
                    _Style = value;
                    SendPropertyChanged("Style");
                }
            }
        }
        String _Description;
        /// <summary>
        /// 简介
        /// </summary>
        [MaxLength(200)]
        [Display(Name = "简介")]
        [Column("description")]
        public virtual String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if ((_Description != value))
                {
                    SendPropertyChanging("Description",_Description,value);
                    _Description = value;
                    SendPropertyChanged("Description");
                }
            }
        }
        System.Nullable<Boolean> _EnableSubscribe=false;
        /// <summary>
        /// 开启订阅
        /// </summary>
        [Display(Name = "开启订阅")]
        [Column("enablesubscribe")]
        public virtual System.Nullable<Boolean> EnableSubscribe
        {
            get
            {
                return _EnableSubscribe;
            }
            set
            {
                if ((_EnableSubscribe != value))
                {
                    SendPropertyChanging("EnableSubscribe",_EnableSubscribe,value);
                    _EnableSubscribe = value;
                    SendPropertyChanged("EnableSubscribe");
                }
            }
        }
        System.Nullable<Boolean> _IsVisible=false;
        /// <summary>
        /// 开启展示
        /// </summary>
        [Display(Name = "开启展示")]
        [Column("isvisible")]
        public virtual System.Nullable<Boolean> IsVisible
        {
            get
            {
                return _IsVisible;
            }
            set
            {
                if ((_IsVisible != value))
                {
                    SendPropertyChanging("IsVisible",_IsVisible,value);
                    _IsVisible = value;
                    SendPropertyChanged("IsVisible");
                }
            }
        }
        System.Nullable<double> _SubscribePrice;
        /// <summary>
        /// 订阅价格
        /// </summary>
        [Display(Name = "订阅价格")]
        [Column("subscribeprice")]
        public virtual System.Nullable<double> SubscribePrice
        {
            get
            {
                return _SubscribePrice;
            }
            set
            {
                if ((_SubscribePrice != value))
                {
                    SendPropertyChanging("SubscribePrice",_SubscribePrice,value);
                    _SubscribePrice = value;
                    SendPropertyChanged("SubscribePrice");
                }
            }
        }
        System.Nullable<double> _SpecialPrice;
        /// <summary>
        /// 优惠价
        /// </summary>
        [Display(Name = "优惠价")]
        [Column("specialprice")]
        public virtual System.Nullable<double> SpecialPrice
        {
            get
            {
                return _SpecialPrice;
            }
            set
            {
                if ((_SpecialPrice != value))
                {
                    SendPropertyChanging("SpecialPrice",_SpecialPrice,value);
                    _SpecialPrice = value;
                    SendPropertyChanged("SpecialPrice");
                }
            }
        }
        System.Nullable<Int32> _SubscribeDays;
        /// <summary>
        /// 最长订阅几天
        /// </summary>
        [Display(Name = "最长订阅几天")]
        [Column("subscribedays")]
        public virtual System.Nullable<Int32> SubscribeDays
        {
            get
            {
                return _SubscribeDays;
            }
            set
            {
                if ((_SubscribeDays != value))
                {
                    SendPropertyChanging("SubscribeDays",_SubscribeDays,value);
                    _SubscribeDays = value;
                    SendPropertyChanged("SubscribeDays");
                }
            }
        }
    }
    public enum TradeUser_StyleEnum:int
    {
        /// <summary>
        /// 短线
        /// </summary>
        Short = 1,
        /// <summary>
        /// 长线
        /// </summary>
        Long = 2,
        /// <summary>
        /// 重仓
        /// </summary>
        High = 3
    }
    /// <summary>
    /// 跟单设置
    /// </summary>
    [TableConfig]
    [Table("fllowusersetting")]
    public class FllowUserSetting :Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("id")]
        public virtual System.Nullable<Int32> id
        {
            get
            {
                return _id;
            }
            set
            {
                if ((_id != value))
                {
                    SendPropertyChanging("id",_id,value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int32> _UserId;
        [Column("userid")]
        public virtual System.Nullable<Int32> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId",_UserId,value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
        System.Nullable<Int32> _TradeUserId;
        [Column("tradeuserid")]
        public virtual System.Nullable<Int32> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId",_TradeUserId,value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Boolean> _IsEnable=true;
        [Column("isenable")]
        public virtual System.Nullable<Boolean> IsEnable
        {
            get
            {
                return _IsEnable;
            }
            set
            {
                if ((_IsEnable != value))
                {
                    SendPropertyChanging("IsEnable",_IsEnable,value);
                    _IsEnable = value;
                    SendPropertyChanged("IsEnable");
                }
            }
        }
        System.Nullable<DateTime> _StartTime;
        [Column("starttime")]
        public virtual System.Nullable<DateTime> StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                if ((_StartTime != value))
                {
                    SendPropertyChanging("StartTime",_StartTime,value);
                    _StartTime = value;
                    SendPropertyChanged("StartTime");
                }
            }
        }
        System.Nullable<DateTime> _EndTime;
        [Column("endtime")]
        public virtual System.Nullable<DateTime> EndTime
        {
            get
            {
                return _EndTime;
            }
            set
            {
                if ((_EndTime != value))
                {
                    SendPropertyChanging("EndTime",_EndTime,value);
                    _EndTime = value;
                    SendPropertyChanged("EndTime");
                }
            }
        }
        System.Nullable<Int32> _Lots;
        /// <summary>
        /// 固定跟几手
        /// null表示不固定，Lots和Multiple只能有一个有值
        /// </summary>
        [Display(Name = "固定跟几手  null表示不固定，Lots和Multiple只能有一个有值")]
        [Column("lots")]
        public virtual System.Nullable<Int32> Lots
        {
            get
            {
                return _Lots;
            }
            set
            {
                if ((_Lots != value))
                {
                    SendPropertyChanging("Lots",_Lots,value);
                    _Lots = value;
                    SendPropertyChanged("Lots");
                }
            }
        }
        System.Nullable<Int32> _Multiple;
        /// <summary>
        /// 跟几倍
        /// null表示不固定，Lots和Multiple只能有一个有值
        /// </summary>
        [Display(Name = "跟几倍  null表示不固定，Lots和Multiple只能有一个有值")]
        [Column("multiple")]
        public virtual System.Nullable<Int32> Multiple
        {
            get
            {
                return _Multiple;
            }
            set
            {
                if ((_Multiple != value))
                {
                    SendPropertyChanging("Multiple",_Multiple,value);
                    _Multiple = value;
                    SendPropertyChanged("Multiple");
                }
            }
        }
        FllowUserSetting_DirectionEnum? _Direction=(FllowUserSetting_DirectionEnum?)(1);
        /// <summary>
        /// 跟单方向
        /// </summary>
        [Display(Name = "跟单方向")]
        [Column("direction")]
        public virtual FllowUserSetting_DirectionEnum? Direction
        {
            get
            {
                return _Direction;
            }
            set
            {
                if ((_Direction != value))
                {
                    SendPropertyChanging("Direction",_Direction,value);
                    _Direction = value;
                    SendPropertyChanged("Direction");
                }
            }
        }
        System.Nullable<double> _DayTotalAmount;
        /// <summary>
        /// 单日跟单总额
        /// </summary>
        [Display(Name = "单日跟单总额")]
        [Column("daytotalamount")]
        public virtual System.Nullable<double> DayTotalAmount
        {
            get
            {
                return _DayTotalAmount;
            }
            set
            {
                if ((_DayTotalAmount != value))
                {
                    SendPropertyChanging("DayTotalAmount",_DayTotalAmount,value);
                    _DayTotalAmount = value;
                    SendPropertyChanged("DayTotalAmount");
                }
            }
        }
        System.Nullable<double> _TotalAmount;
        /// <summary>
        /// 跟单总金额
        /// </summary>
        [Display(Name = "跟单总金额")]
        [Column("totalamount")]
        public virtual System.Nullable<double> TotalAmount
        {
            get
            {
                return _TotalAmount;
            }
            set
            {
                if ((_TotalAmount != value))
                {
                    SendPropertyChanging("TotalAmount",_TotalAmount,value);
                    _TotalAmount = value;
                    SendPropertyChanged("TotalAmount");
                }
            }
        }
        System.Nullable<double> _PositionRate;
        /// <summary>
        /// 最大持仓比例
        /// 即今日跟单持仓金额占跟单金额的比例
        /// </summary>
        [Display(Name = "最大持仓比例  即今日跟单持仓金额占跟单金额的比例")]
        [Column("positionrate")]
        public virtual System.Nullable<double> PositionRate
        {
            get
            {
                return _PositionRate;
            }
            set
            {
                if ((_PositionRate != value))
                {
                    SendPropertyChanging("PositionRate",_PositionRate,value);
                    _PositionRate = value;
                    SendPropertyChanged("PositionRate");
                }
            }
        }
        System.Nullable<Boolean> _IsFllowAll=true;
        /// <summary>
        /// 是否跟随所有产品
        /// </summary>
        [Display(Name = "是否跟随所有产品")]
        [Column("isfllowall")]
        public virtual System.Nullable<Boolean> IsFllowAll
        {
            get
            {
                return _IsFllowAll;
            }
            set
            {
                if ((_IsFllowAll != value))
                {
                    SendPropertyChanging("IsFllowAll",_IsFllowAll,value);
                    _IsFllowAll = value;
                    SendPropertyChanged("IsFllowAll");
                }
            }
        }
    }
    public enum FllowUserSetting_DirectionEnum:int
    {
        /// <summary>
        /// 正向
        /// </summary>
        Forward = 1,
        /// <summary>
        /// 反向
        /// </summary>
        backward = 2
    }
    /// <summary>
    /// 设置跟随什么产品
    /// </summary>
    [TableConfig]
    [Table("fllowproduct")]
    public class FllowProduct :Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("id")]
        public virtual System.Nullable<Int32> id
        {
            get
            {
                return _id;
            }
            set
            {
                if ((_id != value))
                {
                    SendPropertyChanging("id",_id,value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int32> _FllowUserSettingId;
        [Column("fllowusersettingid")]
        public virtual System.Nullable<Int32> FllowUserSettingId
        {
            get
            {
                return _FllowUserSettingId;
            }
            set
            {
                if ((_FllowUserSettingId != value))
                {
                    SendPropertyChanging("FllowUserSettingId",_FllowUserSettingId,value);
                    _FllowUserSettingId = value;
                    SendPropertyChanged("FllowUserSettingId");
                }
            }
        }
        String _Symbol;
        [MaxLength(50)]
        [Column("symbol")]
        public virtual String Symbol
        {
            get
            {
                return _Symbol;
            }
            set
            {
                if ((_Symbol != value))
                {
                    SendPropertyChanging("Symbol",_Symbol,value);
                    _Symbol = value;
                    SendPropertyChanged("Symbol");
                }
            }
        }
        System.Nullable<Int32> _Leverage;
        [Column("leverage")]
        public virtual System.Nullable<Int32> Leverage
        {
            get
            {
                return _Leverage;
            }
            set
            {
                if ((_Leverage != value))
                {
                    SendPropertyChanging("Leverage",_Leverage,value);
                    _Leverage = value;
                    SendPropertyChanged("Leverage");
                }
            }
        }
    }
    /// <summary>
    /// 跟单记录
    /// </summary>
    [TableConfig]
    [Table("fllowhistory")]
    public class FllowHistory :Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("id")]
        public virtual System.Nullable<Int32> id
        {
            get
            {
                return _id;
            }
            set
            {
                if ((_id != value))
                {
                    SendPropertyChanging("id",_id,value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int32> _TradeUserId;
        /// <summary>
        /// 交易员
        /// </summary>
        [Display(Name = "交易员")]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int32> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId",_TradeUserId,value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int32> _UserId;
        /// <summary>
        /// 跟单人
        /// </summary>
        [Display(Name = "跟单人")]
        [Column("userid")]
        public virtual System.Nullable<Int32> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId",_UserId,value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
        System.Nullable<Int32> _OriginalOrderId;
        /// <summary>
        /// 交易员的订单号
        /// </summary>
        [Display(Name = "交易员的订单号")]
        [Column("originalorderid")]
        public virtual System.Nullable<Int32> OriginalOrderId
        {
            get
            {
                return _OriginalOrderId;
            }
            set
            {
                if ((_OriginalOrderId != value))
                {
                    SendPropertyChanging("OriginalOrderId",_OriginalOrderId,value);
                    _OriginalOrderId = value;
                    SendPropertyChanged("OriginalOrderId");
                }
            }
        }
        System.Nullable<Int32> _OrderId;
        /// <summary>
        /// 跟单的订单号
        /// </summary>
        [Display(Name = "跟单的订单号")]
        [Column("orderid")]
        public virtual System.Nullable<Int32> OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if ((_OrderId != value))
                {
                    SendPropertyChanging("OrderId",_OrderId,value);
                    _OrderId = value;
                    SendPropertyChanged("OrderId");
                }
            }
        }
        System.Nullable<double> _Profit;
        /// <summary>
        /// 盈亏
        /// </summary>
        [Display(Name = "盈亏")]
        [Column("profit")]
        public virtual System.Nullable<double> Profit
        {
            get
            {
                return _Profit;
            }
            set
            {
                if ((_Profit != value))
                {
                    SendPropertyChanging("Profit",_Profit,value);
                    _Profit = value;
                    SendPropertyChanged("Profit");
                }
            }
        }
        FllowHistory_CloseTypeEnum? _CloseType;
        /// <summary>
        /// 平仓类型
        /// </summary>
        [Display(Name = "平仓类型")]
        [Column("closetype")]
        public virtual FllowHistory_CloseTypeEnum? CloseType
        {
            get
            {
                return _CloseType;
            }
            set
            {
                if ((_CloseType != value))
                {
                    SendPropertyChanging("CloseType",_CloseType,value);
                    _CloseType = value;
                    SendPropertyChanged("CloseType");
                }
            }
        }
        System.Nullable<Boolean> _IsOpenSuccess=true;
        /// <summary>
        /// 是否开仓成功
        /// </summary>
        [Display(Name = "是否开仓成功")]
        [Column("isopensuccess")]
        public virtual System.Nullable<Boolean> IsOpenSuccess
        {
            get
            {
                return _IsOpenSuccess;
            }
            set
            {
                if ((_IsOpenSuccess != value))
                {
                    SendPropertyChanging("IsOpenSuccess",_IsOpenSuccess,value);
                    _IsOpenSuccess = value;
                    SendPropertyChanged("IsOpenSuccess");
                }
            }
        }
        FllowHistory_OpenFailReasonEnum? _OpenFailReason;
        /// <summary>
        /// 开仓失败原因
        /// </summary>
        [Display(Name = "开仓失败原因")]
        [Column("openfailreason")]
        public virtual FllowHistory_OpenFailReasonEnum? OpenFailReason
        {
            get
            {
                return _OpenFailReason;
            }
            set
            {
                if ((_OpenFailReason != value))
                {
                    SendPropertyChanging("OpenFailReason",_OpenFailReason,value);
                    _OpenFailReason = value;
                    SendPropertyChanged("OpenFailReason");
                }
            }
        }
        System.Nullable<double> _OrderAmount;
        /// <summary>
        /// 下单金额
        /// </summary>
        [Display(Name = "下单金额")]
        [Column("orderamount")]
        public virtual System.Nullable<double> OrderAmount
        {
            get
            {
                return _OrderAmount;
            }
            set
            {
                if ((_OrderAmount != value))
                {
                    SendPropertyChanging("OrderAmount",_OrderAmount,value);
                    _OrderAmount = value;
                    SendPropertyChanged("OrderAmount");
                }
            }
        }
    }
    public enum FllowHistory_CloseTypeEnum:int
    {
        /// <summary>
        /// 跟单平仓
        /// </summary>
        FllowTradeUser = 1,
        /// <summary>
        /// 系统强平
        /// </summary>
        SystemClose = 2,
        /// <summary>
        /// 手动平仓
        /// </summary>
        Manual = 3
    }
    public enum FllowHistory_OpenFailReasonEnum:int
    {
        /// <summary>
        /// 账户资金不足
        /// </summary>
        NotEnoughMoney = 1,
        /// <summary>
        /// 跟单本金限制
        /// </summary>
        TotalAmountLimit = 2,
        /// <summary>
        /// 单日跟单本金限制
        /// </summary>
        DayAmountLimit = 3,
        /// <summary>
        /// 最大持仓比例限制
        /// </summary>
        PositionRateLimit = 4,
        /// <summary>
        /// 成交价格保护限制
        /// </summary>
        PriceProtect = 5,
        /// <summary>
        /// 跟单风控限制
        /// </summary>
        RiskControl = 6,
        /// <summary>
        /// 网络异常
        /// </summary>
        NetworkError =7,
    }
    /// <summary>
    /// 关注订单
    /// </summary>
    [TableConfig]
    [Table("interestorder")]
    public class InterestOrder :Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _OrderId;
        [Key]
        [Required]
        [Column("orderid")]
        public virtual System.Nullable<Int32> OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if ((_OrderId != value))
                {
                    SendPropertyChanging("OrderId",_OrderId,value);
                    _OrderId = value;
                    SendPropertyChanged("OrderId");
                }
            }
        }
        System.Nullable<Int32> _UserId;
        /// <summary>
        /// 关注的用户
        /// </summary>
        [Display(Name = "关注的用户")]
        [Column("userid")]
        public virtual System.Nullable<Int32> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId",_UserId,value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
    }
}

namespace FllowOrderSystem.DBModels.DB
{
    public class FllowOrders : Way.EntityDB.DBContext
    {
         public FllowOrders(string connection, Way.EntityDB.DatabaseType dbType): base(connection, dbType)
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
             var db =  sender as FllowOrderSystem.DBModels.DB.FllowOrders;
            if (db == null) return;
            if (e.DataItem is FllowUserSetting)
            {
                var deletingItem = (FllowUserSetting)e.DataItem;
                var items0 = (from m in db.FllowProduct where m.FllowUserSettingId == deletingItem.id
                select new FllowProduct
                {
                    id = m.id
                }
                );
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradeUser>().HasKey(m => m.TradeUserId);
            modelBuilder.Entity<FllowUserSetting>().HasKey(m => m.id);
            modelBuilder.Entity<FllowProduct>().HasKey(m => m.id);
            modelBuilder.Entity<FllowHistory>().HasKey(m => m.id);
            modelBuilder.Entity<InterestOrder>().HasKey(m => m.OrderId);
        }
        System.Linq.IQueryable<TradeUser> _TradeUser;
        public virtual System.Linq.IQueryable<TradeUser> TradeUser
        {
            get
            {
                if (_TradeUser == null)
                {
                    _TradeUser = this.Set<TradeUser>();
                }
                return _TradeUser;
            }
        }
        System.Linq.IQueryable<FllowUserSetting> _FllowUserSetting;
        public virtual System.Linq.IQueryable<FllowUserSetting> FllowUserSetting
        {
            get
            {
                if (_FllowUserSetting == null)
                {
                    _FllowUserSetting = this.Set<FllowUserSetting>();
                }
                return _FllowUserSetting;
            }
        }
        System.Linq.IQueryable<FllowProduct> _FllowProduct;
        public virtual System.Linq.IQueryable<FllowProduct> FllowProduct
        {
            get
            {
                if (_FllowProduct == null)
                {
                    _FllowProduct = this.Set<FllowProduct>();
                }
                return _FllowProduct;
            }
        }
        System.Linq.IQueryable<FllowHistory> _FllowHistory;
        public virtual System.Linq.IQueryable<FllowHistory> FllowHistory
        {
            get
            {
                if (_FllowHistory == null)
                {
                    _FllowHistory = this.Set<FllowHistory>();
                }
                return _FllowHistory;
            }
        }
        System.Linq.IQueryable<InterestOrder> _InterestOrder;
        public virtual System.Linq.IQueryable<InterestOrder> InterestOrder
        {
            get
            {
                if (_InterestOrder == null)
                {
                    _InterestOrder = this.Set<InterestOrder>();
                }
                return _InterestOrder;
            }
        }
        protected override string GetDesignString()
        {
            var result = new StringBuilder();
            result.Append("\r\n");
            result.Append("H4sIAAAAAAAAC+0bW1PTaPSvOH3GNemN1pl9cAHHzuJlRJ2dER/S5qNkTBNMUhmGYaauOiKK4Kq7eFtQ8bKOog6uIsX1zzQpPO1f2PN9SS+5lIa2CSnuU5Pv1nM/5zvnZDJ0iknzSA4dPDupPx5jcih0MDR0gecUFOoJnRTH9dmUgnL6k7GEY2H6DMPn4YWe6qmOKxNj");
            result.Append("qDYT6pMQoyBy9qGMwolCqG5tRhQUJCh1yyeHdTiGQwfhkWPhl473DJMN8AyzEsOi0zKShkMw3M8oTJqRUaofJmMwwA2KmfPwTE3BS5/I53OCDK9nK4f1RuoPw+ekYBjGUvKhvCKmhIyEcgASTI8wvIzwKYxwLM/zdSNs+hQgSU7g8NIeA2gCBQE3JZ/4mbwpUh7vECUW");
            result.Append("SQQAisz2c3JG4nKcwCiiVDl56hye6/+lTxRGuCwBWx8h+NTTjTXQrudBDLZjdg0pQG9CgCZMC3vKtF6APMOM4c2EUJufF9XZe5sr/5S/rhCKVZlwmOcBaqQonJBtkanR+vO4Rgw1eLFTfva2zM+eKoAxCzVK68vawh319oIBrF28dyCWBkwOWPBIyCqjZGhbrCpn1tCi");
            result.Append("XaFl0swAQB0OjHJFtlGuUUbI7ki5jvNs1Tg7GMFjaHy7aQGN1+kMRjpDIGCbmsdWhNFjGwkzPzGZ8/kxnYrsCUkcQ5LCIYzGZBV2TDSJy8JentDRJKBTU0QYWMQjxUQFf0Uk6qmI2KyqTUpsK8yCUhUJqyVXH66rKw+0d3PamyfYql9b0q7fGB4W9gkgAZtPXpWX10tr");
            result.Append("s/oqs3EbFBU50PbBrhjOgrI37bq/4h/rEvFPOAYyWqG49fSxTer1+Ka0NrN1f94iAKLC8OQ/D+XEvMHH1qSAFfMk2GpLECIdUgV/hSbuaczqzGr16mp5tagtLKnvrzhErm3cRZJehq2J9sPWBOV3fJfoQFSaoHfF8Ca6JTTtDWpoWmVg2KKHW89uaUsbZt0bUiYMG9ge");
            result.Append("RweEfK4fjXCCPnzgQHnxbXn9G1j2oVFRUvb9uA/EaVg4cGDr3jd9fFAUsjAcNoavzZaKd+DxCJcdheFIMzmJd0LEIxYKlVcKpeINM4X6ET7DWNMynS4yErgCyYpVmKJ2iFinYi9/lSUReGWJWsPzjYI6/25z5enWwlWzQAwI+PShfBqzIN2O8qQ5Z3PIohEmzyu1K9dO");
            result.Append("hSTiSvpjjiirH+5BEGZGOSWf4WSuEi0FDNmoK2Tj1qCEcLZU/Gw3iRXOnpC4DPI8wGyCXcwVdtbLZWljQbu8BNhZUBtDGY7hA4FY3BVi1lhSe1QAD6IzD67M6vJfDZjXz0x4fElugl9vVxrqZLCvk8ElHE15T7nGLs483cDFme5JKVn3Y35YdHqHQX53XqppOugSkDRd");
            result.Append("RAExSTnF5dryBEAbpXJE67c6Vy48abqQDghsMGB35aCT1ruYntdtlvf9d+MmTvaqv908CgrFjfFInXu9efmr9uh6aa1QWnsND2phw+/0cKIDnj1pvXvptFALs52kRWXprtKjOyMBOrx3QoHvsQjjo6REAu/4os7Vh9+/qPO3LekeTkIEUC+SYtrbZ/gPh4XDojTOSGwt");
            result.Append("LabOzeozaSjLGlNhb6KrRHeao+geNEd7tCgWINMUC7xpsmXhQAD+eG6SBLOBYiYIv31idRNjknQV69mSb1Xsrt22IRgg7GhX9b1krz1JpS6/1G5egpKG9u5u6Z8bELyqs6ul4kyNtWRWx1+dXdIH9dfygyv6LjNdTogyh//iJMj+rhOG7k4nEg+qOQgwzXoDQbOuzAl6");
            result.Append("W/ZypM0eo+A2+eh+AtuOO1UaB3SedYhTnrbbJG2VLRwngkPZejBXKhZKX6ZL6y/VO5ccmm6g7ZPNZ5TW+m6SCS/7bpLt990kTQlvqx543ciS7ECDAk1RFuZaql0TubTId74tIUbtEJuwO2xMGdxBdBFJTNbj3FyyvVKDj9+R+FQ+2LvOIhzuDgrW9MFaFdAW3qnzL3TT");
            result.Append("rV0v4NS2g+lOyfpdHytF8Ip3dHd2KIUjXjrpMNXgO6736td7Do75CCcD2SZac8w0FfHQMxNU2vTMNBVt1PFvyQX41HZqRqplbx1z5HJp3dJOFQCEXDrseCM2QY4CmnBwW/ecpceo8sHQcfxfu4ylqz44mnL+yHI7FHcfNVclc5qyZpjLD+E2MGdJLEniiOENPEwpNUPI");
            result.Append("VR2dpqy3HfULpNXulD8U1T8t+bI+XpSRDmPnKznGNw3kz3E9BxvtqrGqlXXKq8VycVHdWIeVuBd6QgYfRACrtT5DxVGdeVU96igj5BneRQt0M4K6KsPTJMVpj0GgFxQnL6fn1ZlFa/RxfAwJQ/lMBsnybgQgzfDudYc3be9+BYzV5Q+bH5+rtxbVh0sWpQesDzMcfxIx");
            result.Append("sjfVwc2PL7Tpz5t/X4E0MK73fMIic0xUBgQxnx09KgpooiZZRhb50RucM74/r05/guG61Pkg4K7UhMxUVTBvgoKCeUvEkEtbFru6pT4VXdkVNXZNz4OT0PtqS98eazPL+q59eBvuOwVro0CFFXbE6jHBHyfceln9h5OcfB4iP0USsSrEDW36ertcfKRu/KqurWHSIGVc");
            result.Append("lM4PSJIIKofZ3pa+NKuL+hiLRj2NRW2Sf3VVW32l+zqLrsNxEpIV4vBaDEbJfaBl1+kuJKU7EJLSEUeyQBRQvvsK9NL/EI7ulm9Qw7HvIXUBoKXk0wJ3gfilCj9Sch+fB68uIbae8+QgDBvZWpMXfKwBMi7uE/lr/VTT9ch6tKcc96GQVp+cduZ2/YrAcNopz+wra3yo");
            result.Append("19WnJ5xZU78iMKzZVl3a08RdUUJvy4t2529jtX1JYHi9KwxJBlv1arGOLf22dqPafuKQ6/CnG6dZgL5dr9H/VsWtEMOrIRIhLMY1xakIMw7xMePgXc9X/ABqHo8SeTWtNiTcvn5IkcDx2TfUxNz9HhNODUE7h9HCs+B0jY1ROh1GbJTaz6J0dH80HsvsT8TZkf1UNEnF");
            result.Append("0lQ8NsJQoan/AMthgTC7TwAA");
            return result.ToString();
        }
    }
}

/*<design>
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
<design>*/

