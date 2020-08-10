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
using System.Diagnostics.CodeAnalysis;

namespace FllowOrderSystem.DBModels
{
    [TableConfig]
    [Table("tradeuser")]
    public class TradeUser : Way.EntityDB.DataItem
    {
        System.Nullable<Int64> _TradeUserId;
        [Key]
        [DisallowNull]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
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
                    SendPropertyChanging("Style", _Style, value);
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
                    SendPropertyChanging("Description", _Description, value);
                    _Description = value;
                    SendPropertyChanged("Description");
                }
            }
        }
        System.Nullable<Boolean> _EnableSubscribe = false;
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
                    SendPropertyChanging("EnableSubscribe", _EnableSubscribe, value);
                    _EnableSubscribe = value;
                    SendPropertyChanged("EnableSubscribe");
                }
            }
        }
        System.Nullable<Boolean> _IsVisible = false;
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
                    SendPropertyChanging("IsVisible", _IsVisible, value);
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
                    SendPropertyChanging("SubscribePrice", _SubscribePrice, value);
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
                    SendPropertyChanging("SpecialPrice", _SpecialPrice, value);
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
                    SendPropertyChanging("SubscribeDays", _SubscribeDays, value);
                    _SubscribeDays = value;
                    SendPropertyChanged("SubscribeDays");
                }
            }
        }
        TradeUser_StatusEnum? _Status = (TradeUser_StatusEnum?)(1);
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        [Column("status")]
        public virtual TradeUser_StatusEnum? Status
        {
            get
            {
                return _Status;
            }
            set
            {
                if ((_Status != value))
                {
                    SendPropertyChanging("Status", _Status, value);
                    _Status = value;
                    SendPropertyChanged("Status");
                }
            }
        }
        System.Nullable<double> _TotalProfit;
        /// <summary>
        /// 累计收益
        /// </summary>
        [Display(Name = "累计收益")]
        [Column("totalprofit")]
        public virtual System.Nullable<double> TotalProfit
        {
            get
            {
                return _TotalProfit;
            }
            set
            {
                if ((_TotalProfit != value))
                {
                    SendPropertyChanging("TotalProfit", _TotalProfit, value);
                    _TotalProfit = value;
                    SendPropertyChanged("TotalProfit");
                }
            }
        }
        System.Nullable<double> _ProfitRate;
        /// <summary>
        /// 收益率
        /// </summary>
        [Display(Name = "收益率")]
        [Column("profitrate")]
        public virtual System.Nullable<double> ProfitRate
        {
            get
            {
                return _ProfitRate;
            }
            set
            {
                if ((_ProfitRate != value))
                {
                    SendPropertyChanging("ProfitRate", _ProfitRate, value);
                    _ProfitRate = value;
                    SendPropertyChanged("ProfitRate");
                }
            }
        }
        System.Nullable<double> _Retracement;
        /// <summary>
        /// 近3周最大回撤
        /// </summary>
        [Display(Name = "近3周最大回撤")]
        [Column("retracement")]
        public virtual System.Nullable<double> Retracement
        {
            get
            {
                return _Retracement;
            }
            set
            {
                if ((_Retracement != value))
                {
                    SendPropertyChanging("Retracement", _Retracement, value);
                    _Retracement = value;
                    SendPropertyChanged("Retracement");
                }
            }
        }
        System.Nullable<Int32> _TradeDays;
        /// <summary>
        /// 交易天数
        /// </summary>
        [Display(Name = "交易天数")]
        [Column("tradedays")]
        public virtual System.Nullable<Int32> TradeDays
        {
            get
            {
                return _TradeDays;
            }
            set
            {
                if ((_TradeDays != value))
                {
                    SendPropertyChanging("TradeDays", _TradeDays, value);
                    _TradeDays = value;
                    SendPropertyChanged("TradeDays");
                }
            }
        }
        System.Nullable<double> _PositionDisRate;
        /// <summary>
        /// 持仓分布的数值
        /// </summary>
        [Display(Name = "持仓分布的数值")]
        [Column("positiondisrate")]
        public virtual System.Nullable<double> PositionDisRate
        {
            get
            {
                return _PositionDisRate;
            }
            set
            {
                if ((_PositionDisRate != value))
                {
                    SendPropertyChanging("PositionDisRate", _PositionDisRate, value);
                    _PositionDisRate = value;
                    SendPropertyChanged("PositionDisRate");
                }
            }
        }
        System.Nullable<Int32> _Subscribers = 0;
        /// <summary>
        /// 累计订阅人数
        /// </summary>
        [Display(Name = "累计订阅人数")]
        [Column("subscribers")]
        public virtual System.Nullable<Int32> Subscribers
        {
            get
            {
                return _Subscribers;
            }
            set
            {
                if ((_Subscribers != value))
                {
                    SendPropertyChanging("Subscribers", _Subscribers, value);
                    _Subscribers = value;
                    SendPropertyChanged("Subscribers");
                }
            }
        }
        System.Nullable<double> _WinRate;
        /// <summary>
        /// 胜率
        /// </summary>
        [Display(Name = "胜率")]
        [Column("winrate")]
        public virtual System.Nullable<double> WinRate
        {
            get
            {
                return _WinRate;
            }
            set
            {
                if ((_WinRate != value))
                {
                    SendPropertyChanging("WinRate", _WinRate, value);
                    _WinRate = value;
                    SendPropertyChanged("WinRate");
                }
            }
        }
        System.Nullable<double> _TranFrequency;
        /// <summary>
        /// 交易频率
        /// </summary>
        [Display(Name = "交易频率")]
        [Column("tranfrequency")]
        public virtual System.Nullable<double> TranFrequency
        {
            get
            {
                return _TranFrequency;
            }
            set
            {
                if ((_TranFrequency != value))
                {
                    SendPropertyChanging("TranFrequency", _TranFrequency, value);
                    _TranFrequency = value;
                    SendPropertyChanged("TranFrequency");
                }
            }
        }
        String _HeadIconUrl;
        /// <summary>
        /// 头像url
        /// </summary>
        [MaxLength(100)]
        [Display(Name = "头像url")]
        [Column("headiconurl")]
        public virtual String HeadIconUrl
        {
            get
            {
                return _HeadIconUrl;
            }
            set
            {
                if ((_HeadIconUrl != value))
                {
                    SendPropertyChanging("HeadIconUrl", _HeadIconUrl, value);
                    _HeadIconUrl = value;
                    SendPropertyChanged("HeadIconUrl");
                }
            }
        }
        String _NickName;
        /// <summary>
        /// 昵称
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "昵称")]
        [Column("nickname")]
        public virtual String NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                if ((_NickName != value))
                {
                    SendPropertyChanging("NickName", _NickName, value);
                    _NickName = value;
                    SendPropertyChanged("NickName");
                }
            }
        }
        System.Nullable<Int32> _TradeCount;
        /// <summary>
        /// 累计交易订单数
        /// </summary>
        [Display(Name = "累计交易订单数")]
        [Column("tradecount")]
        public virtual System.Nullable<Int32> TradeCount
        {
            get
            {
                return _TradeCount;
            }
            set
            {
                if ((_TradeCount != value))
                {
                    SendPropertyChanging("TradeCount", _TradeCount, value);
                    _TradeCount = value;
                    SendPropertyChanged("TradeCount");
                }
            }
        }
        System.Nullable<Int32> _TradeProfitCount;
        /// <summary>
        /// 盈利订单数
        /// </summary>
        [Display(Name = "盈利订单数")]
        [Column("tradeprofitcount")]
        public virtual System.Nullable<Int32> TradeProfitCount
        {
            get
            {
                return _TradeProfitCount;
            }
            set
            {
                if ((_TradeProfitCount != value))
                {
                    SendPropertyChanging("TradeProfitCount", _TradeProfitCount, value);
                    _TradeProfitCount = value;
                    SendPropertyChanged("TradeProfitCount");
                }
            }
        }
        System.Nullable<Int32> _TradeLossCount;
        /// <summary>
        /// 亏损订单数
        /// </summary>
        [Display(Name = "亏损订单数")]
        [Column("tradelosscount")]
        public virtual System.Nullable<Int32> TradeLossCount
        {
            get
            {
                return _TradeLossCount;
            }
            set
            {
                if ((_TradeLossCount != value))
                {
                    SendPropertyChanging("TradeLossCount", _TradeLossCount, value);
                    _TradeLossCount = value;
                    SendPropertyChanged("TradeLossCount");
                }
            }
        }
        System.Nullable<double> _TradeLots;
        /// <summary>
        /// 交易手数
        /// </summary>
        [Display(Name = "交易手数")]
        [Column("tradelots")]
        public virtual System.Nullable<double> TradeLots
        {
            get
            {
                return _TradeLots;
            }
            set
            {
                if ((_TradeLots != value))
                {
                    SendPropertyChanging("TradeLots", _TradeLots, value);
                    _TradeLots = value;
                    SendPropertyChanged("TradeLots");
                }
            }
        }
        System.Nullable<double> _DayTradeLots;
        /// <summary>
        /// 日均交易笔数
        /// </summary>
        [Display(Name = "日均交易笔数")]
        [Column("daytradelots")]
        public virtual System.Nullable<double> DayTradeLots
        {
            get
            {
                return _DayTradeLots;
            }
            set
            {
                if ((_DayTradeLots != value))
                {
                    SendPropertyChanging("DayTradeLots", _DayTradeLots, value);
                    _DayTradeLots = value;
                    SendPropertyChanged("DayTradeLots");
                }
            }
        }
        System.Nullable<double> _MaxProfit;
        /// <summary>
        /// 最大盈利
        /// </summary>
        [Display(Name = "最大盈利")]
        [Column("maxprofit")]
        public virtual System.Nullable<double> MaxProfit
        {
            get
            {
                return _MaxProfit;
            }
            set
            {
                if ((_MaxProfit != value))
                {
                    SendPropertyChanging("MaxProfit", _MaxProfit, value);
                    _MaxProfit = value;
                    SendPropertyChanged("MaxProfit");
                }
            }
        }
        System.Nullable<double> _MaxLoss;
        /// <summary>
        /// 最大亏损
        /// </summary>
        [Display(Name = "最大亏损")]
        [Column("maxloss")]
        public virtual System.Nullable<double> MaxLoss
        {
            get
            {
                return _MaxLoss;
            }
            set
            {
                if ((_MaxLoss != value))
                {
                    SendPropertyChanging("MaxLoss", _MaxLoss, value);
                    _MaxLoss = value;
                    SendPropertyChanged("MaxLoss");
                }
            }
        }
        System.Nullable<Int32> _PositionCount = 0;
        /// <summary>
        /// 当前持仓数量
        /// </summary>
        [Display(Name = "当前持仓数量")]
        [Column("positioncount")]
        public virtual System.Nullable<Int32> PositionCount
        {
            get
            {
                return _PositionCount;
            }
            set
            {
                if ((_PositionCount != value))
                {
                    SendPropertyChanging("PositionCount", _PositionCount, value);
                    _PositionCount = value;
                    SendPropertyChanged("PositionCount");
                }
            }
        }
        String _PositionDisStr;
        /// <summary>
        /// 持仓分布描述
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "持仓分布描述")]
        [Column("positiondisstr")]
        public virtual String PositionDisStr
        {
            get
            {
                return _PositionDisStr;
            }
            set
            {
                if ((_PositionDisStr != value))
                {
                    SendPropertyChanging("PositionDisStr", _PositionDisStr, value);
                    _PositionDisStr = value;
                    SendPropertyChanged("PositionDisStr");
                }
            }
        }
    }
    public enum TradeUser_StyleEnum : int
    {
        /// <summary>
        /// 短线
        /// </summary>
        Short = 1 << 0,
        /// <summary>
        /// 长线
        /// </summary>
        Long = 1 << 1,
        /// <summary>
        /// 重仓
        /// </summary>
        High = 1 << 2,
        /// <summary>
        /// 高频
        /// </summary>
        HighFrequency = 1 << 3,
        /// <summary>
        /// 主流
        /// </summary>
        MainStream = 1 << 4,
        /// <summary>
        /// 激进
        /// </summary>
        Radical = 1 << 5,
        /// <summary>
        /// 中线
        /// </summary>
        CenterLine = 1 << 6,
        /// <summary>
        /// 低频
        /// </summary>
        LowFrequency = 1 << 7,
        /// <summary>
        /// 轻仓
        /// </summary>
        LightWarehouse = 1 << 8,
        /// <summary>
        /// 止损
        /// </summary>
        StopLoss = 1 << 9,
        /// <summary>
        /// 高风险
        /// </summary>
        HighRisk = 1 << 10,
        /// <summary>
        /// 稳健
        /// </summary>
        Steady = 1 << 11
    }
    public enum TradeUser_StatusEnum : int
    {
        None = 0,
        /// <summary>
        /// 等待审核
        /// </summary>
        Reviewing = 1,
        /// <summary>
        /// 审核通过
        /// </summary>
        Approved = 2
    }
    /// <summary>
    /// 跟单设置
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = (FllowOrderSetting_TypeEnum)0)]
    [Table("fllowordersetting")]
    public class FllowOrderSetting : Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
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
                    SendPropertyChanging("id", _id, value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        [DisallowNull]
        [Column("userid")]
        public virtual System.Nullable<Int64> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId", _UserId, value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        [DisallowNull]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Boolean> _IsEnable = true;
        /// <summary>
        /// 是否有效
        /// </summary>
        [Display(Name = "是否有效")]
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
                    SendPropertyChanging("IsEnable", _IsEnable, value);
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
                    SendPropertyChanging("StartTime", _StartTime, value);
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
                    SendPropertyChanging("EndTime", _EndTime, value);
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
                    SendPropertyChanging("Lots", _Lots, value);
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
                    SendPropertyChanging("Multiple", _Multiple, value);
                    _Multiple = value;
                    SendPropertyChanged("Multiple");
                }
            }
        }
        FllowOrderSetting_DirectionEnum? _Direction = (FllowOrderSetting_DirectionEnum?)(1);
        /// <summary>
        /// 跟单方向
        /// </summary>
        [Display(Name = "跟单方向")]
        [Column("direction")]
        public virtual FllowOrderSetting_DirectionEnum? Direction
        {
            get
            {
                return _Direction;
            }
            set
            {
                if ((_Direction != value))
                {
                    SendPropertyChanging("Direction", _Direction, value);
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
                    SendPropertyChanging("DayTotalAmount", _DayTotalAmount, value);
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
                    SendPropertyChanging("TotalAmount", _TotalAmount, value);
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
                    SendPropertyChanging("PositionRate", _PositionRate, value);
                    _PositionRate = value;
                    SendPropertyChanged("PositionRate");
                }
            }
        }
        System.Nullable<Boolean> _IsFllowAll = true;
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
                    SendPropertyChanging("IsFllowAll", _IsFllowAll, value);
                    _IsFllowAll = value;
                    SendPropertyChanged("IsFllowAll");
                }
            }
        }
        FllowOrderSetting_TypeEnum? _Type;
        [Column("type")]
        public virtual FllowOrderSetting_TypeEnum? Type
        {
            get
            {
                return _Type;
            }
            set
            {
                if ((_Type != value))
                {
                    SendPropertyChanging("Type", _Type, value);
                    _Type = value;
                    SendPropertyChanged("Type");
                }
            }
        }
        [ForeignKey("TradeUserId")]
        public virtual TradeUser TradeUser { get; set; }
        [ForeignKey("UserId")]
        public virtual UserInfo NickNameInfo { get; set; }
    }
    public enum FllowOrderSetting_DirectionEnum : int
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
    /// 跟单设置
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = FllowOrderSetting_TypeEnum.UserFllowSetting)]
    public class UserFllowSetting : FllowOrderSetting
    {
        System.Nullable<double> _OrderPriceRate = 0.002;
        /// <summary>
        /// 成交价格保护比例
        /// </summary>
        [Display(Name = "成交价格保护比例")]
        [Column("orderpricerate")]
        public virtual System.Nullable<double> OrderPriceRate
        {
            get
            {
                return _OrderPriceRate;
            }
            set
            {
                if ((_OrderPriceRate != value))
                {
                    SendPropertyChanging("OrderPriceRate", _OrderPriceRate, value);
                    _OrderPriceRate = value;
                    SendPropertyChanged("OrderPriceRate");
                }
            }
        }
        System.Nullable<Boolean> _IsOnlyMessage = false;
        /// <summary>
        /// 是否只是发送消息
        /// </summary>
        [Display(Name = "是否只是发送消息")]
        [Column("isonlymessage")]
        public virtual System.Nullable<Boolean> IsOnlyMessage
        {
            get
            {
                return _IsOnlyMessage;
            }
            set
            {
                if ((_IsOnlyMessage != value))
                {
                    SendPropertyChanging("IsOnlyMessage", _IsOnlyMessage, value);
                    _IsOnlyMessage = value;
                    SendPropertyChanged("IsOnlyMessage");
                }
            }
        }
        String _Language;
        /// <summary>
        /// 订阅时的语言
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "订阅时的语言")]
        [Column("language")]
        public virtual String Language
        {
            get
            {
                return _Language;
            }
            set
            {
                if ((_Language != value))
                {
                    SendPropertyChanging("Language", _Language, value);
                    _Language = value;
                    SendPropertyChanged("Language");
                }
            }
        }
    }
    public enum FllowOrderSetting_TypeEnum : int
    {
        /// <summary>
        /// 系统跟单
        /// </summary>
        SystemFllowSetting = 1,
        /// <summary>
        /// 用户跟单
        /// </summary>
        UserFllowSetting = 2
    }
    /// <summary>
    /// 跟单设置
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = FllowOrderSetting_TypeEnum.SystemFllowSetting)]
    public class SystemFllowSetting : FllowOrderSetting
    {
        System.Nullable<Int32> _Delay;
        /// <summary>
        /// 延迟几秒
        /// </summary>
        [Display(Name = "延迟几秒")]
        [Column("delay")]
        public virtual System.Nullable<Int32> Delay
        {
            get
            {
                return _Delay;
            }
            set
            {
                if ((_Delay != value))
                {
                    SendPropertyChanging("Delay", _Delay, value);
                    _Delay = value;
                    SendPropertyChanged("Delay");
                }
            }
        }
    }
    /// <summary>
    /// 设置跟随什么产品
    /// </summary>
    [TableConfig]
    [Table("fllowproduct")]
    public class FllowProduct : Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
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
                    SendPropertyChanging("id", _id, value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int32> _FllowSettingId;
        [DisallowNull]
        [Column("fllowsettingid")]
        public virtual System.Nullable<Int32> FllowSettingId
        {
            get
            {
                return _FllowSettingId;
            }
            set
            {
                if ((_FllowSettingId != value))
                {
                    SendPropertyChanging("FllowSettingId", _FllowSettingId, value);
                    _FllowSettingId = value;
                    SendPropertyChanged("FllowSettingId");
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
                    SendPropertyChanging("Symbol", _Symbol, value);
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
                    SendPropertyChanging("Leverage", _Leverage, value);
                    _Leverage = value;
                    SendPropertyChanged("Leverage");
                }
            }
        }
    }
    /// <summary>
    /// 跟单记录
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = (FllowHistory_TypeEnum)0)]
    [Table("fllowhistory")]
    public class FllowHistory : Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
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
                    SendPropertyChanging("id", _id, value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 交易员
        /// </summary>
        [DisallowNull]
        [Display(Name = "交易员")]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 跟单人
        /// </summary>
        [DisallowNull]
        [Display(Name = "跟单人")]
        [Column("userid")]
        public virtual System.Nullable<Int64> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId", _UserId, value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
        System.Nullable<Int64> _OriginalOrderId;
        /// <summary>
        /// 交易员的订单号
        /// </summary>
        [Display(Name = "交易员的订单号")]
        [Column("originalorderid")]
        public virtual System.Nullable<Int64> OriginalOrderId
        {
            get
            {
                return _OriginalOrderId;
            }
            set
            {
                if ((_OriginalOrderId != value))
                {
                    SendPropertyChanging("OriginalOrderId", _OriginalOrderId, value);
                    _OriginalOrderId = value;
                    SendPropertyChanged("OriginalOrderId");
                }
            }
        }
        FllowHistory_TypeEnum? _Type;
        [Column("type")]
        public virtual FllowHistory_TypeEnum? Type
        {
            get
            {
                return _Type;
            }
            set
            {
                if ((_Type != value))
                {
                    SendPropertyChanging("Type", _Type, value);
                    _Type = value;
                    SendPropertyChanged("Type");
                }
            }
        }
        String _TradeUserName;
        /// <summary>
        /// 程序自用
        /// </summary>
        [MaxLength(1)]
        [Display(Name = "程序自用")]
        [Column("tradeusername")]
        public virtual String TradeUserName
        {
            get
            {
                return _TradeUserName;
            }
            set
            {
                if ((_TradeUserName != value))
                {
                    SendPropertyChanging("TradeUserName", _TradeUserName, value);
                    _TradeUserName = value;
                    SendPropertyChanged("TradeUserName");
                }
            }
        }
        System.Nullable<DateTime> _Time;
        [Column("time")]
        public virtual System.Nullable<DateTime> Time
        {
            get
            {
                return _Time;
            }
            set
            {
                if ((_Time != value))
                {
                    SendPropertyChanging("Time", _Time, value);
                    _Time = value;
                    SendPropertyChanged("Time");
                }
            }
        }
    }
    /// <summary>
    /// 跟单记录
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = FllowHistory_TypeEnum.SuccessOrder)]
    public class SuccessOrder : FllowHistory
    {
        System.Nullable<Int64> _OrderId;
        /// <summary>
        /// 跟单的订单号
        /// </summary>
        [Display(Name = "跟单的订单号")]
        [Column("orderid")]
        public virtual System.Nullable<Int64> OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if ((_OrderId != value))
                {
                    SendPropertyChanging("OrderId", _OrderId, value);
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
                    SendPropertyChanging("Profit", _Profit, value);
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
                    SendPropertyChanging("CloseType", _CloseType, value);
                    _CloseType = value;
                    SendPropertyChanged("CloseType");
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
                    SendPropertyChanging("OrderAmount", _OrderAmount, value);
                    _OrderAmount = value;
                    SendPropertyChanged("OrderAmount");
                }
            }
        }
        System.Nullable<double> _ProfitRate;
        /// <summary>
        /// 收益率
        /// </summary>
        [Display(Name = "收益率")]
        [Column("profitrate")]
        public virtual System.Nullable<double> ProfitRate
        {
            get
            {
                return _ProfitRate;
            }
            set
            {
                if ((_ProfitRate != value))
                {
                    SendPropertyChanging("ProfitRate", _ProfitRate, value);
                    _ProfitRate = value;
                    SendPropertyChanged("ProfitRate");
                }
            }
        }
        System.Nullable<double> _OpenPrice;
        /// <summary>
        /// 开仓价
        /// </summary>
        [Display(Name = "开仓价")]
        [Column("openprice")]
        public virtual System.Nullable<double> OpenPrice
        {
            get
            {
                return _OpenPrice;
            }
            set
            {
                if ((_OpenPrice != value))
                {
                    SendPropertyChanging("OpenPrice", _OpenPrice, value);
                    _OpenPrice = value;
                    SendPropertyChanged("OpenPrice");
                }
            }
        }
        System.Nullable<double> _ClosePrice;
        /// <summary>
        /// 平仓价
        /// </summary>
        [Display(Name = "平仓价")]
        [Column("closeprice")]
        public virtual System.Nullable<double> ClosePrice
        {
            get
            {
                return _ClosePrice;
            }
            set
            {
                if ((_ClosePrice != value))
                {
                    SendPropertyChanging("ClosePrice", _ClosePrice, value);
                    _ClosePrice = value;
                    SendPropertyChanged("ClosePrice");
                }
            }
        }
        System.Nullable<Boolean> _IsFllowDisable = false;
        /// <summary>
        /// 是否已经停止自动跟单
        /// </summary>
        [Display(Name = "是否已经停止自动跟单")]
        [Column("isfllowdisable")]
        public virtual System.Nullable<Boolean> IsFllowDisable
        {
            get
            {
                return _IsFllowDisable;
            }
            set
            {
                if ((_IsFllowDisable != value))
                {
                    SendPropertyChanging("IsFllowDisable", _IsFllowDisable, value);
                    _IsFllowDisable = value;
                    SendPropertyChanged("IsFllowDisable");
                }
            }
        }
    }
    public enum FllowHistory_CloseTypeEnum : int
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
    /// <summary>
    /// 跟单记录
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = FllowHistory_TypeEnum.FailOrder)]
    public class FailOrder : FllowHistory
    {
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
                    SendPropertyChanging("OpenFailReason", _OpenFailReason, value);
                    _OpenFailReason = value;
                    SendPropertyChanged("OpenFailReason");
                }
            }
        }
    }
    public enum FllowHistory_OpenFailReasonEnum : int
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
        NetworkError = 7,
        /// <summary>
        /// 订单撮合时间超时
        /// </summary>
        Timeout = 8
    }
    public enum FllowHistory_TypeEnum : int
    {
        FailOrder = 1,
        SuccessOrder = 2
    }
    /// <summary>
    /// 消费记录
    /// </summary>
    [TableConfig]
    [Table("consumerecord")]
    public class ConsumeRecord : Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
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
                    SendPropertyChanging("id", _id, value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 收款人
        /// </summary>
        [DisallowNull]
        [Display(Name = "收款人")]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 付款人
        /// </summary>
        [DisallowNull]
        [Display(Name = "付款人")]
        [Column("userid")]
        public virtual System.Nullable<Int64> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId", _UserId, value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
        System.Nullable<DateTime> _PayTime;
        /// <summary>
        /// 时间
        /// </summary>
        [Display(Name = "时间")]
        [Column("paytime")]
        public virtual System.Nullable<DateTime> PayTime
        {
            get
            {
                return _PayTime;
            }
            set
            {
                if ((_PayTime != value))
                {
                    SendPropertyChanging("PayTime", _PayTime, value);
                    _PayTime = value;
                    SendPropertyChanged("PayTime");
                }
            }
        }
        System.Nullable<Boolean> _IsConfirm = false;
        /// <summary>
        /// 资金是否已经打给交易员
        /// </summary>
        [Display(Name = "资金是否已经打给交易员")]
        [Column("isconfirm")]
        public virtual System.Nullable<Boolean> IsConfirm
        {
            get
            {
                return _IsConfirm;
            }
            set
            {
                if ((_IsConfirm != value))
                {
                    SendPropertyChanging("IsConfirm", _IsConfirm, value);
                    _IsConfirm = value;
                    SendPropertyChanged("IsConfirm");
                }
            }
        }
        System.Nullable<double> _Amount;
        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        [Column("amount")]
        public virtual System.Nullable<double> Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                if ((_Amount != value))
                {
                    SendPropertyChanging("Amount", _Amount, value);
                    _Amount = value;
                    SendPropertyChanged("Amount");
                }
            }
        }
        System.Nullable<DateTime> _ToBalanceTime;
        /// <summary>
        /// 转入余额时间
        /// 预计转入余额的时间，没转入之前，这个字段也是有值的
        /// </summary>
        [Display(Name = "转入余额时间  预计转入余额的时间，没转入之前，这个字段也是有值的")]
        [Column("tobalancetime")]
        public virtual System.Nullable<DateTime> ToBalanceTime
        {
            get
            {
                return _ToBalanceTime;
            }
            set
            {
                if ((_ToBalanceTime != value))
                {
                    SendPropertyChanging("ToBalanceTime", _ToBalanceTime, value);
                    _ToBalanceTime = value;
                    SendPropertyChanged("ToBalanceTime");
                }
            }
        }
        String _TransferVoucher;
        /// <summary>
        /// 转账凭证
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "转账凭证")]
        [Column("transfervoucher")]
        public virtual String TransferVoucher
        {
            get
            {
                return _TransferVoucher;
            }
            set
            {
                if ((_TransferVoucher != value))
                {
                    SendPropertyChanging("TransferVoucher", _TransferVoucher, value);
                    _TransferVoucher = value;
                    SendPropertyChanged("TransferVoucher");
                }
            }
        }
    }
    /// <summary>
    /// 关注列表
    /// </summary>
    [TableConfig]
    [Table("concern")]
    public class Concern : Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
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
                    SendPropertyChanging("id", _id, value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 交易员
        /// </summary>
        [DisallowNull]
        [Display(Name = "交易员")]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 用户
        /// </summary>
        [DisallowNull]
        [Display(Name = "用户")]
        [Column("userid")]
        public virtual System.Nullable<Int64> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId", _UserId, value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
    }
    /// <summary>
    /// 用户的交易对胜率
    /// </summary>
    [TableConfig]
    [Table("symbolwinrate")]
    public class SymbolWinRate : Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
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
                    SendPropertyChanging("id", _id, value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 用户id
        /// </summary>
        [DisallowNull]
        [Display(Name = "用户id")]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        String _Symbol;
        /// <summary>
        /// 交易对
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "交易对")]
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
                    SendPropertyChanging("Symbol", _Symbol, value);
                    _Symbol = value;
                    SendPropertyChanged("Symbol");
                }
            }
        }
        System.Nullable<double> _WinRate;
        /// <summary>
        /// 胜率
        /// </summary>
        [Display(Name = "胜率")]
        [Column("winrate")]
        public virtual System.Nullable<double> WinRate
        {
            get
            {
                return _WinRate;
            }
            set
            {
                if ((_WinRate != value))
                {
                    SendPropertyChanging("WinRate", _WinRate, value);
                    _WinRate = value;
                    SendPropertyChanged("WinRate");
                }
            }
        }
        System.Nullable<double> _ProfitRate;
        /// <summary>
        /// 累计收益率
        /// </summary>
        [Display(Name = "累计收益率")]
        [Column("profitrate")]
        public virtual System.Nullable<double> ProfitRate
        {
            get
            {
                return _ProfitRate;
            }
            set
            {
                if ((_ProfitRate != value))
                {
                    SendPropertyChanging("ProfitRate", _ProfitRate, value);
                    _ProfitRate = value;
                    SendPropertyChanged("ProfitRate");
                }
            }
        }
    }
    /// <summary>
    /// 用户收益表
    /// </summary>
    [TableConfig]
    [Table("userprofit")]
    public class UserProfit : Way.EntityDB.DataItem
    {
        System.Nullable<Int32> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
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
                    SendPropertyChanging("id", _id, value);
                    _id = value;
                    SendPropertyChanged("id");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 用户id
        /// </summary>
        [DisallowNull]
        [Display(Name = "用户id")]
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        UserProfit_TypeEnum? _Type;
        /// <summary>
        /// 日期类型
        /// </summary>
        [Display(Name = "日期类型")]
        [Column("type")]
        public virtual UserProfit_TypeEnum? Type
        {
            get
            {
                return _Type;
            }
            set
            {
                if ((_Type != value))
                {
                    SendPropertyChanging("Type", _Type, value);
                    _Type = value;
                    SendPropertyChanged("Type");
                }
            }
        }
        System.Nullable<double> _Loss;
        /// <summary>
        /// 亏损
        /// </summary>
        [Display(Name = "亏损")]
        [Column("loss")]
        public virtual System.Nullable<double> Loss
        {
            get
            {
                return _Loss;
            }
            set
            {
                if ((_Loss != value))
                {
                    SendPropertyChanging("Loss", _Loss, value);
                    _Loss = value;
                    SendPropertyChanged("Loss");
                }
            }
        }
        System.Nullable<double> _Profit;
        /// <summary>
        /// 收益
        /// </summary>
        [Display(Name = "收益")]
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
                    SendPropertyChanging("Profit", _Profit, value);
                    _Profit = value;
                    SendPropertyChanged("Profit");
                }
            }
        }
        System.Nullable<double> _TotalProfit;
        /// <summary>
        /// 总盈亏
        /// </summary>
        [Display(Name = "总盈亏")]
        [Column("totalprofit")]
        public virtual System.Nullable<double> TotalProfit
        {
            get
            {
                return _TotalProfit;
            }
            set
            {
                if ((_TotalProfit != value))
                {
                    SendPropertyChanging("TotalProfit", _TotalProfit, value);
                    _TotalProfit = value;
                    SendPropertyChanged("TotalProfit");
                }
            }
        }
        String _DateText;
        /// <summary>
        /// 日期
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "日期")]
        [Column("datetext")]
        public virtual String DateText
        {
            get
            {
                return _DateText;
            }
            set
            {
                if ((_DateText != value))
                {
                    SendPropertyChanging("DateText", _DateText, value);
                    _DateText = value;
                    SendPropertyChanged("DateText");
                }
            }
        }
        System.Nullable<Int32> _Index;
        /// <summary>
        /// 排序索引
        /// </summary>
        [Display(Name = "排序索引")]
        [Column("index")]
        public virtual System.Nullable<Int32> Index
        {
            get
            {
                return _Index;
            }
            set
            {
                if ((_Index != value))
                {
                    SendPropertyChanging("Index", _Index, value);
                    _Index = value;
                    SendPropertyChanged("Index");
                }
            }
        }
        System.Nullable<Int32> _Year;
        [Column("year")]
        public virtual System.Nullable<Int32> Year
        {
            get
            {
                return _Year;
            }
            set
            {
                if ((_Year != value))
                {
                    SendPropertyChanging("Year", _Year, value);
                    _Year = value;
                    SendPropertyChanged("Year");
                }
            }
        }
    }
    public enum UserProfit_TypeEnum : int
    {
        /// <summary>
        /// 日
        /// </summary>
        Day = 1,
        /// <summary>
        /// 周
        /// </summary>
        Week = 2,
        /// <summary>
        /// 月
        /// </summary>
        Month = 3
    }
    /// <summary>
    /// 用户信息
    /// </summary>
    [TableConfig]
    [Table("userinfo")]
    public class UserInfo : Way.EntityDB.DataItem
    {
        System.Nullable<Int64> _UserId;
        [Key]
        [DisallowNull]
        [Column("userid")]
        public virtual System.Nullable<Int64> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if ((_UserId != value))
                {
                    SendPropertyChanging("UserId", _UserId, value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
        String _NickName;
        /// <summary>
        /// 昵称
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "昵称")]
        [Column("nickname")]
        public virtual String NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                if ((_NickName != value))
                {
                    SendPropertyChanging("NickName", _NickName, value);
                    _NickName = value;
                    SendPropertyChanged("NickName");
                }
            }
        }
        String _HeadIconUrl;
        /// <summary>
        /// 头像
        /// </summary>
        [MaxLength(100)]
        [Display(Name = "头像")]
        [Column("headiconurl")]
        public virtual String HeadIconUrl
        {
            get
            {
                return _HeadIconUrl;
            }
            set
            {
                if ((_HeadIconUrl != value))
                {
                    SendPropertyChanging("HeadIconUrl", _HeadIconUrl, value);
                    _HeadIconUrl = value;
                    SendPropertyChanged("HeadIconUrl");
                }
            }
        }
    }
    /// <summary>
    /// 记录一些交易员的订单
    /// </summary>
    [TableConfig]
    [Table("traderorder")]
    public class TraderOrder : Way.EntityDB.DataItem
    {
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
                    SendPropertyChanging("Symbol", _Symbol, value);
                    _Symbol = value;
                    SendPropertyChanged("Symbol");
                }
            }
        }
        System.Nullable<double> _OrderPrice;
        [Column("orderprice")]
        public virtual System.Nullable<double> OrderPrice
        {
            get
            {
                return _OrderPrice;
            }
            set
            {
                if ((_OrderPrice != value))
                {
                    SendPropertyChanging("OrderPrice", _OrderPrice, value);
                    _OrderPrice = value;
                    SendPropertyChanged("OrderPrice");
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
                    SendPropertyChanging("Leverage", _Leverage, value);
                    _Leverage = value;
                    SendPropertyChanged("Leverage");
                }
            }
        }
        System.Nullable<Int32> _Bstype;
        [Column("bstype")]
        public virtual System.Nullable<Int32> Bstype
        {
            get
            {
                return _Bstype;
            }
            set
            {
                if ((_Bstype != value))
                {
                    SendPropertyChanging("Bstype", _Bstype, value);
                    _Bstype = value;
                    SendPropertyChanged("Bstype");
                }
            }
        }
        System.Nullable<Int32> _Lots;
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
                    SendPropertyChanging("Lots", _Lots, value);
                    _Lots = value;
                    SendPropertyChanged("Lots");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        [Column("tradeuserid")]
        public virtual System.Nullable<Int64> TradeUserId
        {
            get
            {
                return _TradeUserId;
            }
            set
            {
                if ((_TradeUserId != value))
                {
                    SendPropertyChanging("TradeUserId", _TradeUserId, value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int64> _OrderId;
        [Key]
        [DisallowNull]
        [Column("orderid")]
        public virtual System.Nullable<Int64> OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if ((_OrderId != value))
                {
                    SendPropertyChanging("OrderId", _OrderId, value);
                    _OrderId = value;
                    SendPropertyChanged("OrderId");
                }
            }
        }
        System.Nullable<double> _Profit;
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
                    SendPropertyChanging("Profit", _Profit, value);
                    _Profit = value;
                    SendPropertyChanged("Profit");
                }
            }
        }
        System.Nullable<double> _ProfitRate;
        [Column("profitrate")]
        public virtual System.Nullable<double> ProfitRate
        {
            get
            {
                return _ProfitRate;
            }
            set
            {
                if ((_ProfitRate != value))
                {
                    SendPropertyChanging("ProfitRate", _ProfitRate, value);
                    _ProfitRate = value;
                    SendPropertyChanged("ProfitRate");
                }
            }
        }
        System.Nullable<double> _ClosePrice;
        [Column("closeprice")]
        public virtual System.Nullable<double> ClosePrice
        {
            get
            {
                return _ClosePrice;
            }
            set
            {
                if ((_ClosePrice != value))
                {
                    SendPropertyChanging("ClosePrice", _ClosePrice, value);
                    _ClosePrice = value;
                    SendPropertyChanged("ClosePrice");
                }
            }
        }
        System.Nullable<DateTime> _OpenTime;
        /// <summary>
        /// 开仓时间
        /// </summary>
        [Display(Name = "开仓时间")]
        [Column("opentime")]
        public virtual System.Nullable<DateTime> OpenTime
        {
            get
            {
                return _OpenTime;
            }
            set
            {
                if ((_OpenTime != value))
                {
                    SendPropertyChanging("OpenTime", _OpenTime, value);
                    _OpenTime = value;
                    SendPropertyChanged("OpenTime");
                }
            }
        }
        System.Nullable<DateTime> _CloseTime;
        /// <summary>
        /// 平仓时间
        /// </summary>
        [Display(Name = "平仓时间")]
        [Column("closetime")]
        public virtual System.Nullable<DateTime> CloseTime
        {
            get
            {
                return _CloseTime;
            }
            set
            {
                if ((_CloseTime != value))
                {
                    SendPropertyChanging("CloseTime", _CloseTime, value);
                    _CloseTime = value;
                    SendPropertyChanged("CloseTime");
                }
            }
        }
    }
}

namespace FllowOrderSystem.DBModels.DB
{
    public class FllowOrders : Way.EntityDB.DBContext
    {
        public FllowOrders(string connection, Way.EntityDB.DatabaseType dbType, bool upgradeDatabase = true) : base(connection, dbType, upgradeDatabase)
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
            var db = sender as FllowOrderSystem.DBModels.DB.FllowOrders;
            if (db == null) return;
            if (e.DataItem is FllowOrderSetting)
            {
                var deletingItem = (FllowOrderSetting)e.DataItem;
                var items0 = (from m in db.FllowProduct
                              where m.FllowSettingId == deletingItem.id
                              select new FllowProduct
                              {
                                  id = m.id
                              }
                );
                while (true)
                {
                    var data2del = items0.Take(100).ToList();
                    if (data2del.Count() == 0)
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
            modelBuilder.Entity<FllowOrderSetting>().HasKey(m => m.id);
            modelBuilder.Entity<FllowOrderSetting>().HasDiscriminator<FllowOrderSetting_TypeEnum?>("Type")
            .HasValue<FllowOrderSetting>((FllowOrderSetting_TypeEnum)0)
            .HasValue<UserFllowSetting>(FllowOrderSetting_TypeEnum.UserFllowSetting)
            .HasValue<SystemFllowSetting>(FllowOrderSetting_TypeEnum.SystemFllowSetting)
            ;
            modelBuilder.Entity<FllowProduct>().HasKey(m => m.id);
            modelBuilder.Entity<FllowHistory>().HasKey(m => m.id);
            modelBuilder.Entity<FllowHistory>().HasDiscriminator<FllowHistory_TypeEnum?>("Type")
            .HasValue<FllowHistory>((FllowHistory_TypeEnum)0)
            .HasValue<SuccessOrder>(FllowHistory_TypeEnum.SuccessOrder)
            .HasValue<FailOrder>(FllowHistory_TypeEnum.FailOrder)
            ;
            modelBuilder.Entity<ConsumeRecord>().HasKey(m => m.id);
            modelBuilder.Entity<Concern>().HasKey(m => m.id);
            modelBuilder.Entity<SymbolWinRate>().HasKey(m => m.id);
            modelBuilder.Entity<UserProfit>().HasKey(m => m.id);
            modelBuilder.Entity<UserInfo>().HasKey(m => m.UserId);
            modelBuilder.Entity<TraderOrder>().HasKey(m => m.OrderId);
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
        System.Linq.IQueryable<FllowOrderSetting> _FllowOrderSetting;
        public virtual System.Linq.IQueryable<FllowOrderSetting> FllowOrderSetting
        {
            get
            {
                if (_FllowOrderSetting == null)
                {
                    _FllowOrderSetting = this.Set<FllowOrderSetting>();
                }
                return _FllowOrderSetting;
            }
        }
        System.Linq.IQueryable<UserFllowSetting> _UserFllowSetting;
        public virtual System.Linq.IQueryable<UserFllowSetting> UserFllowSetting
        {
            get
            {
                if (_UserFllowSetting == null)
                {
                    _UserFllowSetting = this.Set<UserFllowSetting>();
                }
                return _UserFllowSetting;
            }
        }
        System.Linq.IQueryable<SystemFllowSetting> _SystemFllowSetting;
        public virtual System.Linq.IQueryable<SystemFllowSetting> SystemFllowSetting
        {
            get
            {
                if (_SystemFllowSetting == null)
                {
                    _SystemFllowSetting = this.Set<SystemFllowSetting>();
                }
                return _SystemFllowSetting;
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
        System.Linq.IQueryable<SuccessOrder> _SuccessOrder;
        public virtual System.Linq.IQueryable<SuccessOrder> SuccessOrder
        {
            get
            {
                if (_SuccessOrder == null)
                {
                    _SuccessOrder = this.Set<SuccessOrder>();
                }
                return _SuccessOrder;
            }
        }
        System.Linq.IQueryable<FailOrder> _FailOrder;
        public virtual System.Linq.IQueryable<FailOrder> FailOrder
        {
            get
            {
                if (_FailOrder == null)
                {
                    _FailOrder = this.Set<FailOrder>();
                }
                return _FailOrder;
            }
        }
        System.Linq.IQueryable<ConsumeRecord> _ConsumeRecord;
        public virtual System.Linq.IQueryable<ConsumeRecord> ConsumeRecord
        {
            get
            {
                if (_ConsumeRecord == null)
                {
                    _ConsumeRecord = this.Set<ConsumeRecord>();
                }
                return _ConsumeRecord;
            }
        }
        System.Linq.IQueryable<Concern> _Concern;
        public virtual System.Linq.IQueryable<Concern> Concern
        {
            get
            {
                if (_Concern == null)
                {
                    _Concern = this.Set<Concern>();
                }
                return _Concern;
            }
        }
        System.Linq.IQueryable<SymbolWinRate> _SymbolWinRate;
        public virtual System.Linq.IQueryable<SymbolWinRate> SymbolWinRate
        {
            get
            {
                if (_SymbolWinRate == null)
                {
                    _SymbolWinRate = this.Set<SymbolWinRate>();
                }
                return _SymbolWinRate;
            }
        }
        System.Linq.IQueryable<UserProfit> _UserProfit;
        public virtual System.Linq.IQueryable<UserProfit> UserProfit
        {
            get
            {
                if (_UserProfit == null)
                {
                    _UserProfit = this.Set<UserProfit>();
                }
                return _UserProfit;
            }
        }
        System.Linq.IQueryable<UserInfo> _UserInfo;
        public virtual System.Linq.IQueryable<UserInfo> UserInfo
        {
            get
            {
                if (_UserInfo == null)
                {
                    _UserInfo = this.Set<UserInfo>();
                }
                return _UserInfo;
            }
        }
        System.Linq.IQueryable<TraderOrder> _TraderOrder;
        public virtual System.Linq.IQueryable<TraderOrder> TraderOrder
        {
            get
            {
                if (_TraderOrder == null)
                {
                    _TraderOrder = this.Set<TraderOrder>();
                }
                return _TraderOrder;
            }
        }
        protected override string GetDesignString()
        {
            var result = new StringBuilder();
            result.Append("\r\n");
            result.Append("H4sIAAAAAAAAE+VdbVPbRh7/KhleJ41lbGN3mhcpJFPmyMOEtL2bo5MR9gKaGIlKciiTyYy5NAWSACEPBwn08lDS0FwgbUMI2BC+jCWbV/0Kt6uVjbQrpLVlyZ7cK2TtSvr/dv/7f97lesdlfjALlI7P/3kdX57nR0HH5x3932f7gXwNyB3HOy5J47hDrwpG8ZXZS8jA");
            result.Append("5m/4bA7+SCZuHK81qBNj4LCpo1sGvAqM959Oq4Ikdlj6piVRBaJq6X59ANMy0PE5vBQy8C93fMDoDy9ho8xnwNcKkAc64O0eXuUHeQX09pj9hD4pfRVeR27AH91SNjcqKgOIbNd39WaMt/Uqp3Oq1CumZTAKqYJ9hvisAtCbePF8Lpu13MkMXoY4jdcMCsMC6g3vZoE4");
            result.Append("rI4Yd43fBpQacb3Kxb8ZP1Q5h94hyRkgG2RFjNYeQUnLwqgg8qokV78FR8ukPQ47pfkxNIbGFw5+mdOf7RrfqUHqVyfQ2DGCMemwYKkCOSPmRnvAkCDi2ydPlp+ulwv7AwNi/4gkq8dOHeO++AJSPSCePHnwaB839UniMG7hzJap2VLxAbz8ShgewS1Rs+W/SwcvFsyW");
            result.Append("szL4PgfE9ATu0om7lLaL+vtJeHmOF8R+FbLRKG6P4XZ9P1/ZX4aXl/iMkOazuDFefdgktxtiB3IfBILbE2b73hz+fp80Xvv8Kdjehdsre0VMeR+kT/2Wl8GIlFMA6pE0P7/+Qp99igZElcb6JEXB708d4vtl7uDxbybES4Jy1Rwac9TKa++0yZfG84DPmNA5rh42qk7o");
            result.Append("IR91svBRguCj8ka+VLxj56MegF5h9mmYm67xcnqEl0lM0UikPlgxFlhdBCxtN6/de1vZeHGwdMsO7oyIPtyfG0TvG/SzXAYF53WfAUN8LqsaQs24WyfgOAvgpCNg7Y9H5dWCHXCv8o2gCIO+JENQUBMsUFMEVDyrpeIHWgBWZ/WiLKT94M1IueqANbwcu1iwIYFgA1fa");
            result.Append("XdJvPoPgCGRjIC3w2XbAlWTCxRG49JU8VBV46rSpZ9rqb0dMXQ8/oTRBhzUML8UCL0aq4/LtLT0/SapjXs01Awuhj89Lhj6rqpL1Ge3jLW3juf5sG+lDcE0A4wLWxbgHbjvIP6nsT8Ebp8fGZOkayMAOUbZFzdU3ghyTQROjNNEmlNfP9Ydb5eXb9oG8LKmI9aUhUwq1");
            result.Append("jvc5jgkaqY0wqPLclB0XhnQJWsithhVlgkXqnMr+Qqe2sAaXtrb6Slv+j35/1Q7wElBlPm2iaS1CJqUaI1VNqbCqLz2Awkp/9DvBk8h9aLWs4pj0Z5zUMfrdSWjfatM/ads3y09+hNi0PKFJL0qKgPrDV7cDfzLp0jipc7BEMc2FQoGaw5rOkYOYRb+2EcekieKkJqrc");
            result.Append("XKEEzbeC2A6zyOSgxEm9gNcgdNgoWHANijX/rdXgmNyUOOWnrG5qN+dzctaO7CvoFfamJfFrs6GpHhhXrwfGpPTipHbQl96XXxEr7ryQvop/NBtUvE5MTBovTuoDLFEwR0K5os0+clYM3VLOl8pjlil1gmayzBKkvigvT2vTv7nhxZZMUKjZ8TFxaoLUE6XCvD771A0f");
            result.Append("CvG0Hh0TzyaijvJTn7lzFDTVj/ZrhuyMskWuOh0XI2bOI3my5diY9EIiRgrPxZfaz1N46spvHlJTBy3PZsyef55ksqsTpJGCXQanqTvH/9AWnl6UybROkMYKBoYFCgUMSZFWw2KypFOkhNT2Hmgzs9hvgLx4MDXv7C6Epvfq1fZsQaskFbWyeEr6/Hxl/3dn3PDF/arc");
            result.Append("equGc8P5HWrr+Xu3JA4Jw0ZiDN8ZQBkza2IuYybWrFk+Dj6OEoIoqAWMFJtXWrAryLQgqeQqH55C5V3Z+Fje27BP0dlsVhq/gEaoH6iqIA43ljuMWt8pHJUyNCfWNWNY5fHDSY1aJ7Wx9GCnlbyQsppRD15koTtGqe32IJ7J1OJILtSX3mr3ftVXZvRH02QSBuedwsjB");
            result.Append("kOFaD6hMxhdnYzAoBGT1suDLj4NCBqjVVzQ8T0zWFWfjsjNipi1IZ7KcONJy0pYL2sYTJO6mnkGbfmBAPCZCOivP18qrhdL2LG7/a/cusgy1+3fPQdYQxrJAm39dubkHWbO0nS9tv4YXVMwvcFvSY0CYLC6OtLjwUGj52WYORbVrK4eDLX9IBpSwItT/vaPdWyBcBkEG");
            result.Append("aZ85/SMrRPT1X9AHB8SzkjzOyxlL9ml+FrcM8umrZlODeSePAWO08cgFBUdr8aU5bPniwYufaU8L5Z9Oj/q0bZnMdw+ITCFhjkqY18BNLVD42gccW94wSmUzDJfL9E3ePix9NISiNvuuVLx9OLNGM8avzT7DN/FPlAHBjzma9mEEzr0GhsmUilJOtmGNQKgHT+b1mTwS");
            result.Append("eIVX2gMiS92rGBbyaUR/29kmbIlJ2m2bvlcqrOIKkdL+z/rtVacZNpwCo6IiuDmmHdfPIpFonYPgYuQgyrK8othsf2NCa96Oxa2nQ/SIQ6A+RBfzCwf5SX1rWp98S3LIBTE7cQ4oCj/ckiIir/FxsaTqGh8umbBJRoPw5uvK8rtiufgUiyBUAjihQD/aStOh8iw/XNOn");
            result.Append("P9S6ksQfqUrZx87Z+kdorONCpa2KW5V9ZHeVX90n1CXI8n5ycf7dThczkuIGeuzt/EBVPBi5ZH1xCyqNytv1ylqeMKF5cTjnb5WwRoK8hsHFfGRZFHSw6Dp639ei8L2xSk3Ce5XubA6OoQwy1rcb8RP0euNJW0TC5uR/d9wtUnMFd7tie+RGoEGrZJBBKzKBgcNVWEGX");
            result.Append("ivnSzrSTgjaG5aIsZXJptcHYla3wvcnBq04rHzYWvIpGKbwmB/gLBHnLkk6PRcREPTmt9unrnxgdlPzYVqwCwQMLkyUVtUVK+sA1IPuTZr6nwC065SWjqm9jFFIk49HCyVyFV8iewcqkVJAyiUw8VgPpv2t7jxzk0FeCAmdgokE5ZDOvmiyHYk2QQ6SZY5b/LSw5pJdD");
            result.Append("ilPH3JcHm4SizBhjkkuFgh1Xe0BiikdHj6jUXFhClplRyaHNEzX0F2REHZ81TIw6cDp5Mv5hMkWuO8lgB545N4ztgM0lEkeb4Ll0GrqWBuFW47uTquZchuYRmXcOpVTAA61LUI4dLZlK0nbelYoPyn8Utf8QYYvurKSAoHxTzF/44yiai2R+TdxZ/FLDhdV2C7BnzYU1");
            result.Append("CEMuqblHbuaOdnut9qpzvJgz9ul1+pR4LiKPfbhJtaft5lGif/WPyuZLbe6ptvyMWFdjQDzLC9lLgFeCiaBXNn9Frv77Hw+mFkrbs5UtNLDnJfWMKOWGR85JIpg4HH8zqLnyBoUwH9/TprfgbUsktw+OjHo4FbYYt/2hHn7C/oi5AZOOqtYesUZGq09Vt2VSgTf81DH0");
            result.Append("GIq0wQWrgjR6Im5Fgnazzr2qfQFtmIRWnSpLiGHMXZvlvYVycUXb/Ze2jTa6nAfquCRfPSPLEmTM6s5NXMN3f0O7Nw299IPFzcoWctfR6AijQMqhLyf9MWA9jjViGZr5KDNj+04tGu0gzsMJznstOxf/gXnZJW2OXjAyrDbk1dViJYYhYOYxDs7RJXu8LEl6hC3f/+M1");
            result.Append("uS7mMfvkkjK1vHZHK8xXpl6XH64dYUAHUwtOJhk80LPlGOI2AKEUEHjQzVRAkCJ5EWs6aoMpUnCh7C71YkUX85+ZFVOUejesEAq0YbG0Bep6UjxHoeaSVGoU53c+/FkuzmuTK/r6C7gaoVFmJhSc8oCQhLDqlMgAltcY1ZPmIcaoyZEijxi2GSQh4tbHfX3S+2uhBMhT");
            result.Append("kSCDUVQ19dZ0ZXPHKRgFZ1LJjYJLIA0ZpLFoVGfyeHDRqISVlxss6SRDHNCK0N98pKI2YUajbLAaLfmkjjwoLjnhag9IbDujqQIEw/cgrD1+IhyzwQMRU3wtRhVYG46pVaHoMw/KxcdHhEihVEOyVh5thSLxGACmyFuMtJuc3LNwPDMPOEx1gjEqzr/3Rrv1srT3GIIy");
            result.Append("uXVAPHbw4ke0Y9rShqqjjOa/du/qf1abdu5oM7PwTmX/cWn7tba+qG+8L+08heyBqynhU4SQkr7ks7yYBm2xBNgsZ2oJ7L2pbP6qTa1X3k5SIlhUhoD8jZRLj4Aw9oF4AHQrpQ3NFrLp6OCNIfvnwrGGuCCtIaro5tY7/d2aNr1YeU740xB6GshiY3ZQPMitLV3+7aA4");
            result.Append("KYnbICtng9WgHRSn4iVGsVdLjCAPPG5GUHMLhchJPGqlI3a3ipSQ1ns0yPVOZmkxP0BVajL82x2nsz1wfYn1hI+6JUAiSE8o6V8CJKhjGIyRMQltiQBIui8YJgHQRTlC1XluUQWRBygmV6iLdIVaeB6NBx4mR6iLtAKtx5S1MKLvgc3NxwnNALSJphCrOFOdQYppZ2GE");
            result.Append("GYKyzBBeS5FC3aK5y7bvssmiOeVfNHc5GzGtFM0p95XBJpqpvTSLL/UV4kSHHp/LnM2V9YDDJpSpwKoBx6m6JKjCEvhFXG1g2Rm4sAb/fgvA1VPVkpGVaVQpAlfhyCmvMhGPcWET7nTBH31wRxindniAYTsCmdrd43CUZjgFUx5w3MIvoSmnQ8kcpmaKBXpWPlUyZwjj");
            result.Append("0v5zak+XgVYckhrTSqk49a7g5TrXhFP0U5QgbPEhdc04eS/lfKigHVTYJwr6OH4v3HNqUvFAlyS1P99IZqKTBwrLdM2yg9UkmznsRtYpl7JV3IfmSHIe8SS2UzsMvnbYrRu09vKinu3gjpQtqBLKVhovwtlOlEilrIR/qajNsQgbJ5vpXIdoJGI32oI+F8+DaKaTGqIR");
            result.Append("3/+SpsECfi/y2TZhRGzeab17Dxo2BJqQVIhGbDvdQjpy0CttwEh6nCY9lOOdvchn24wUsemk8ErwvMhnOn4oGnH4TzOoRN6h4AOVVIaT7vacGTZo1NE4RtWkEzS8B6UtsLWRJen2j9BGeHG4LkvyQjZjdKe1A54KMO7WLIJxiz2IUKcNCjLE3QzIAtV29xM+bjdkdnA7");
            result.Append("ALMN2aHVZxEHPf2w5Us+fTU3hgc/Axl2DMiqYISKrltIuX64VfSwxswwS27cuOG8aELmLLdTKlrKWYe6hMySaHM/afN/6vmi0zZOs4S5TUSIm5tUjyQNmSncjgloQ3Hjrn0+aQYKjym4iFu9vn+uINKbFFsQ7UcIC+qf4B0xyyH+HzCPDIZXfWXjIiKgbAf8yJUxnO1Q");
            result.Append("UaecgpBcCTjdwUXcCiTbhv3o6n3nZO9l8IMfxmONnobEe59WrvuTX0lupYdts5KoA9Hn7muF+fLmC22X3G4oZsAPgUZoPZgpOCvvE2M8t2KqtmE8WyD6H4D3swfDN2t5/ROO/xPWgj9NMAZzHdJTZTGUz0SjDn/jE2Q+6xXVRMz4kK23yXZ0/35VFsRh+oFD3mN/xobp");
            result.Append("SNK+Q7BQaz9QzQdj3GAUZGKRExkwGDsRS8TTJ5KJzNCJSCwViQ9GEvEhPtJx439MZhaucoEAAA==");
            return result.ToString();
        }
    }
}

/*<design>
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
<design>*/

