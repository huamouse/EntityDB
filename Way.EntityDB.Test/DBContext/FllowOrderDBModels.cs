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
        System.Nullable<double> _TradeProfits;
        /// <summary>
        /// 累计盈利
        /// </summary>
        [Display(Name = "累计盈利")]
        [Column("tradeprofits")]
        public virtual System.Nullable<double> TradeProfits
        {
            get
            {
                return _TradeProfits;
            }
            set
            {
                if ((_TradeProfits != value))
                {
                    SendPropertyChanging("TradeProfits", _TradeProfits, value);
                    _TradeProfits = value;
                    SendPropertyChanged("TradeProfits");
                }
            }
        }
        System.Nullable<Int32> _DayTradeLots;
        /// <summary>
        /// 日均交易笔数
        /// </summary>
        [Display(Name = "日均交易笔数")]
        [Column("daytradelots")]
        public virtual System.Nullable<Int32> DayTradeLots
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
        System.Nullable<DateTime> _Date;
        /// <summary>
        /// 日期
        /// </summary>
        [Display(Name = "日期")]
        [Column("date")]
        public virtual System.Nullable<DateTime> Date
        {
            get
            {
                return _Date;
            }
            set
            {
                if ((_Date != value))
                {
                    SendPropertyChanging("Date", _Date, value);
                    _Date = value;
                    SendPropertyChanged("Date");
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
            result.Append("H4sIAAAAAAAAE81da1Pbxhr+Kxk+J41lbGN3mg8pJFPmkMtA2p6ZQ6cj7AU0MRKV5KRMJjPmpDlAEkLI5UACLSQlDc0J0DaEgA3hz1iy+dS/cPYiG2lXWOuLZH/C9uqyz+677/u8l11udVwTh9JA6/j8X7fIx8viGOj4vGPgh/QAUG8AteN0R79yk1zQq4Mx8sm6SkrB");
            result.Append("5m/EdAZ+icdun6406BPj4Lipo1sFog7w888ndUmRO2zXJhVZB7Juu/zWIOnLYMfn8KOUgn+F04P4evgRNqpiCnytAXWwA/7cI+rikKiB3h7rOqlPSV6Hn0O34ZduJZ0Zk7VB1O2qz+pN4af1auczutIrJ1UwBnsFrxkW0xpATxLly5l02vZLaugaxIkfMySNSOhq+Gsa");
            result.Append("yCP6KP4Vf8dQKp3r1a7+A3/R1Qx6hqKmgIq7FcKtPZKWVKUxSRZ1RS2/C46W1fcovCgpjqMxxG84+vWhubqP31OBNKBPoLHjBGP1w4alDOSCnBnrAcOSTH4+e7a4slHMHQ4OygOjiqqfOndK+OIL2OtB+ezZo2eHpKlPkUdIi2C1TM0W8k/gx6+kkVHSErZa/rd49Gre");
            result.Append("armogh8yQE5OkEs6ySWF3bz5YRJ+vCRK8oAOxWiMtEdIu3mYLR0uwY/9YkpKimnSGC3fbHW3G2IHah8EQtpjVvvBQ/L+PuVm5fXnYHsXaS8d5EnP+2D/9G9FFYwqGQ2gK+LW6zdembMraEB0ZbxP0TTy/MQxvl8fHj3/3YLYL2nXraGxRq24/t6YfI3vB2LKgi4ItYhR");
            result.Append("eUKP5aiTR45ilBwVN7OF/H2nHPUA9Ajrmrql6YaoJkdFlcYUDoVqgxXhgdVFwTL2s8ajrdLmq6PFu05wF2T04oHMEHreUCPLZUhyX/cpMCxm0jpWavjXGgFHeQDHXQEbfz4rruWcgHu1byRNGmpIM/gFNcYDNUFBJbNayH9kFWB5Vq+qUrIRvCklUx6wupdjFw82pBAc");
            result.Append("4Ar7i+adVQiOQjYOkpKYbgdccS5cAoXLXM5CU0GmzphaNdZ+P2HqesQJrQk2rG54CR54EdocF+/tmNlJ2hyLeqYZWCh7fFnB9qxsSjZmjE93jc2X5uousofghgRuSsQWkytI21H2RelwCv5wfnxcVW6AFLwgzLeohdpGUOAiNBHGEm1Dff3SfLpTXLrnHMhrio5EXxm2");
            result.Append("tFDrZF8QuKDR1oiAKj6ccuIikPohQ241rDAXLNrmlA7nO435dbi0jbU3xtIv5uM1J8B+oKti0kLTWoRcRjVCm5pCbs1cfAKVlfnsD0omkfvQal0lcNnPKG1jzAeTkN8a0/8xdu8UX/wEsRlZypJeVTQJXQ8f3Q7yyWVLo7TNIRrFogu5HDOHFZuj+jGLjXIjgcsSRWlL");
            result.Append("VLqzzCiabyW5HWaRy0GJ0naBrEHosDGw4BqUK/5bq8FxuSlRxk9Z2zbuzGXUtBPZV9Ar7E0q8tdWQ1M9MKFWD4zL6EVp62Aufii+oVbcZSl5nXxpNqhojZi4LF6UtgdEoxCJhHrFmH3mbhi6lUxDJo9bp9QImouZxWh7UVyaNqZ/r4aXMBm/UPPj45LUGG0nCrk5c3al");
            result.Append("Gj4U4mk9Oi6ZjYVd9ac5c/8kaHoj1q8ZujPMF7nqdF2MRDhPlMmWY+OyC7EIrTwXXhs/T5GpK757ykwdZJ7NmL3GZZKLV8dokkJcBrepuyT+2BaeXpiLWsdoskKAEYXCAENapNWwuJh0gtaQxsETY2aW+A1QFo+m5tzdhcDsXq3Wni9oFWeiVjZPyZybKx3+4Y4bPnhA");
            result.Append("V1vPaoRqOL9DbT3/7FbkYWkEJ8bIL4MoY2ZPzKWsxJo9yyfA21FCEAW1AE6xeaUFu/xMC9JGrvRxBRrv0uan4sGmc4ouptPKzStohAaArkvySH25w7D9mdJJKUNrYqtmDMsyfjypYfuk1pce7LR3L6CsZthDFnn6HWHMdnt0notqCbQUmotbxqPfzOUZ89k0nYQheacg");
            result.Append("cjB0uNYDKhf5EhwCBpWAql+TGvLjoJIBevkRdc8TF7sSHFJ2QU61Rde5mJNAMydjKWdsvkDqbmoVcvrBQfmUDPtZerleXMsVdmdJ+9/7DxAzNB4/uARFQxpPA2PubenOARTNwm62sPsWfmBifr5zSY8B4WJcAs24yFAY2dlmDkX50lYOB1/+kA4oEUNo/nfPeDRPuQyS");
            result.Append("CpIN5vRPrBAxN35FLxyULyrqTVFN2bJPc7OkZUhMXrea6sw7eQwYJ8ejFxQcrYXX1rBl80evfmY9LZR/Oj/WILflou8eELlCwgKTMK+Am5pn8LUPOL68YZjJZmCXy/JNtp4WPmGlaMy+L+TvHc8sbib4jdlV8iP5ijIg5DZXah9E4NxrYLioVJhxsjEbgVCPXsyZM1mk");
            result.Append("8HJvjCdUlrpXwwz5POp/23ETvsQk67ZNPyrk1kiFSOHwZ/PemtsMY6cAV1T4N8es4/pZKBSucRCqkBzUs7SoaQ7ujye04u3Y3Ho2RI8kBNpD9GFu/ig7ae5Mm5NbtIRckdMTl4CmiSMtKSLyGp8qTKqm8RHiMYdmxB1vvq0svs8X8ytEBaESwAkN+tH2Ph0bz+LTdXP6");
            result.Append("Y+VSuvMnmlL+sXNn/wiNfVyYtFV+p3SIeFfxzWPKXIK02EgurnG3swqNZKSBHXunPDAVDziXbC7sQKNR2toorWcpCi3KI5nGVglvJMhrGKrQR55FwQaLbqHnfS1LP+BVanW8V+tOZ+AYqiBlfzqOn6DH4zsdEQmHk//d6WqRmu/JZd87brnta9Aq7mfQik5gkHAVMdCF");
            result.Append("fLawN+1moPGwXFWVVCap1xm7chS+Nzl41WmXw/qCV+Ewg9eSgMYCQd66pNNjEXH1np5W5/QNTIwNKY1wK16F4IGFi0mFHZGSPnADqI1ps4anoFp0yktHlZ/GqaRowWOVk7UKv6ev9FcnJfzUSXTisRxI/8M4eOaih76SNDgDE3XqIQe9arIeijRBD9E0xyr/m190SS8H");
            result.Append("FKeOVF8efBqKoTF4kgu5nBNXe0DiikeHT6jUnF9EzAxXchhzVA39FRX1TkxjilEDTjdPpnGYXJHrTjrYQWauGsZ2wFYlEsdS8EwyCV1L3HE7+e5kqjmXID2i886BlAp4oK0SlONHS6eSjL33hfyT4p954xcqbNGdVjTgl29K5Iu8HEVzkc6vqDubX4pdWGM/B6+suLC4");
            result.Append("Y8gltfbIzdw37q1XHnVJlDN4n15ngxqvisrjH27a7Bn7WZToX/uztP3aeLhiLK1S62ocyBdFKd0PRM2fCHpp+zfk6n/46WhqvrA7W9pBA3tZ0S/ISmZk9JIig4nj8beCmsvvUAjz+SNjegf+bIvk9sGR0Y+nwhHjdt7UI044b7E2YLJR1cot9sho+a7ytkwm8EbuOoVu");
            result.Append("Q5E2uGB1kER3RO1I0G7Wh28qb0AbJiGr01UFCYy1a7N4MF/MLxv7/zZ20UaXy0C/qajXL6iqAgWzvHOT1PA93jQeTUMv/Whhu7SD3HU0OtIYUDLozfHGBLAWxxqJDCt8DM3YvV+JRruo82CC817Lror/wL3s4g5Hzx8dVhny8mqxd4YjYOYxDu7RJWe8LE57hC3f/+M1");
            result.Append("uVXoMf/k0jq1uH7fyM2Vpt4Wn66fQKD9qQWnkwwe6PlyDFEHgEAKCDz6zVVAkKBlkVg6ZoMpMnCB7C71EsUq9J9bFBOMeccshAGNGUtboK4lxXMSaiHOpEZJfufjX8X8nDG5bG68gqsRkjIroeCWB4RdCKpOiQ5geY1RLWkeaoyaHCnyiGFbQRIqbn26oVd6vy2QAHki");
            result.Append("5Gcwiqmm3pkube+5BaPgTGqZMdAPklBA6otGdcZP+xeNitlluc6STjrEAVmE+e4TE7UJMhrlgFVvySdz5EF+0Q1Xe0Di2xnNFCBg34Nie+JEMLTBAxFXfC3CFFhjx9RuUMyZJ8X88xNCpFCrIV2rjrXCkHgMAFfkLULzJjf3LBjPzAMOV51ghInzH7wz7r4uHDyHoCxp");
            result.Append("HZRPHb36Ce2YtrWh6ijc/Pf+A/OvctPefWNmFv5SOnxe2H1rbCyYmx8KeytQPEg1JbyLUlLKl2JalJOgLZYAH3NmlsDBu9L2b8bURmlrklHBsjYM1G+UTHIUBLEPxANgtVLawLiQw0b7T4acrwuGDQl+siGm6Obue/P9ujG9UHpJ+dMQehKocn08KOrn1pauxnlQlNbE");
            result.Append("bZCVc8CqkwdFmXgJLvZqCQnywFONBDW3UIiexJNWOhJ3u0oJaL2H/VzvdJaWyAM0pZbAb+25ne1B6kvsJ3zUrAFifnpC8cY1QIw5hgGPjNXRliiAePUFw6UAuhhHqDzPLaog8gDF5Qp10a5QC8+j8cDD5Qh10SzQfkxZCyP6Htiq+TiBEUCHagqwijPR6aeadldGRCAY");
            result.Append("Zobw2ooUalbNXY59l01WzYnGVXOXO4lppWpOVF8ZfKqZ2Uuz8Npcpk506GlwmfO5sh5w+JQyE1jFcNyqS/wqLIFvJNUGtp2B8+vw77cAXD9XLhlZnkaVInAVjp7zKhPxGBc+5c4W/LEHdwRxaocHGL4jkJndPS5HaQZTMOUBp1r4JTDjdKyZg7RMEV/PymdK5rAyLhy+");
            result.Append("ZPZ0YbTysFKfVUpEmWf5r9eFJpyin2AUYYsPqWvGyXsJ90MFnaCCPlGwgeP3gj2nJhH1dUky+/NxMhOdPJBbYmuWXViTauWw61mnQsJRcR+YIyl4xJP4Tu3Acu2yW9dv6+XVe76DOxKOoEogW2m8Os53okQiYe/4l5reHEZYf7e5znUIh0JO0ub3uXgeneY6qSEcavhf");
            result.Append("0tRZwO/Vfb5NGCGHd1rr3oO6iUATkgrhkGOnW0BHDnqlDTi7HmW7Hsjxzl7d59uMFHLYpOBK8Ly6z3X8UDjk8p9mUIm8S8EHKqkMJt3tOTN80JijcXDVpBs0sgelLbAFxyThV4tjYS557GuWGSXiZwge+jdqeEfMZ72yHovgFzmutmgme/2ArkryCHvDMdfkv8eB6cSu");
            result.Append("fYdgodYBoFs3RoShMEhFQmdSYChyJhKLJs/EY6nhM6FIIhQdCsWiw2Ko4/b/AUEaK61CbgAA");
            return result.ToString();
        }
    }
}

/*<design>
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
<design>*/

