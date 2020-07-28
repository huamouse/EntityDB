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
        System.Nullable<Int64> _TradeUserId;
        [Key]
        [Required]
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
        TradeUser_StatusEnum? _Status=(TradeUser_StatusEnum?)(1);
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
                    SendPropertyChanging("Status",_Status,value);
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
                    SendPropertyChanging("TotalProfit",_TotalProfit,value);
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
                    SendPropertyChanging("ProfitRate",_ProfitRate,value);
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
                    SendPropertyChanging("Retracement",_Retracement,value);
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
                    SendPropertyChanging("TradeDays",_TradeDays,value);
                    _TradeDays = value;
                    SendPropertyChanged("TradeDays");
                }
            }
        }
        System.Nullable<double> _PositionCycle;
        /// <summary>
        /// 持仓周期
        /// </summary>
        [Display(Name = "持仓周期")]
        [Column("positioncycle")]
        public virtual System.Nullable<double> PositionCycle
        {
            get
            {
                return _PositionCycle;
            }
            set
            {
                if ((_PositionCycle != value))
                {
                    SendPropertyChanging("PositionCycle",_PositionCycle,value);
                    _PositionCycle = value;
                    SendPropertyChanged("PositionCycle");
                }
            }
        }
        System.Nullable<Int32> _Subscribers=0;
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
                    SendPropertyChanging("Subscribers",_Subscribers,value);
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
                    SendPropertyChanging("WinRate",_WinRate,value);
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
                    SendPropertyChanging("TranFrequency",_TranFrequency,value);
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
                    SendPropertyChanging("HeadIconUrl",_HeadIconUrl,value);
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
                    SendPropertyChanging("NickName",_NickName,value);
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
                    SendPropertyChanging("TradeCount",_TradeCount,value);
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
                    SendPropertyChanging("TradeProfitCount",_TradeProfitCount,value);
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
                    SendPropertyChanging("TradeLossCount",_TradeLossCount,value);
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
                    SendPropertyChanging("TradeLots",_TradeLots,value);
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
                    SendPropertyChanging("TradeProfits",_TradeProfits,value);
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
                    SendPropertyChanging("DayTradeLots",_DayTradeLots,value);
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
                    SendPropertyChanging("MaxProfit",_MaxProfit,value);
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
                    SendPropertyChanging("MaxLoss",_MaxLoss,value);
                    _MaxLoss = value;
                    SendPropertyChanged("MaxLoss");
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
        High = 3,
        /// <summary>
        /// 高频
        /// </summary>
        HighFrequency = 4,
        /// <summary>
        /// 主流
        /// </summary>
        MainStream = 5,
        /// <summary>
        /// 激进
        /// </summary>
        Radical = 6,
        /// <summary>
        /// 中线
        /// </summary>
        CenterLine = 7,
        /// <summary>
        /// 低频
        /// </summary>
        LowFrequency=8,
        /// <summary>
        /// 轻仓
        /// </summary>
        LightWarehouse=9,
        /// <summary>
        /// 止损
        /// </summary>
        StopLoss = 10,
        /// <summary>
        /// 高风险
        /// </summary>
        HighRisk = 11,
        /// <summary>
        /// 稳健
        /// </summary>
        Steady = 12
    }
    public enum TradeUser_StatusEnum:int
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
        System.Nullable<Int64> _UserId;
        [Required]
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
                    SendPropertyChanging("UserId",_UserId,value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
        System.Nullable<Int64> _TradeUserId;
        [Required]
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
                    SendPropertyChanging("NickName",_NickName,value);
                    _NickName = value;
                    SendPropertyChanged("NickName");
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
        [Required]
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
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 交易员
        /// </summary>
        [Required]
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
                    SendPropertyChanging("TradeUserId",_TradeUserId,value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 跟单人
        /// </summary>
        [Required]
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
                    SendPropertyChanging("UserId",_UserId,value);
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
                    SendPropertyChanging("OriginalOrderId",_OriginalOrderId,value);
                    _OriginalOrderId = value;
                    SendPropertyChanged("OriginalOrderId");
                }
            }
        }
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
        System.Nullable<Int64> _OrderId;
        [Key]
        [Required]
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
                    SendPropertyChanging("OrderId",_OrderId,value);
                    _OrderId = value;
                    SendPropertyChanged("OrderId");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 关注的用户
        /// </summary>
        [Required]
        [Display(Name = "关注的用户")]
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
                    SendPropertyChanging("UserId",_UserId,value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
    }
    /// <summary>
    /// 消费记录
    /// </summary>
    [TableConfig]
    [Table("consumerecord")]
    public class ConsumeRecord :Way.EntityDB.DataItem
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
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 收款人
        /// </summary>
        [Required]
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
                    SendPropertyChanging("TradeUserId",_TradeUserId,value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 付款人
        /// </summary>
        [Required]
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
                    SendPropertyChanging("UserId",_UserId,value);
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
                    SendPropertyChanging("PayTime",_PayTime,value);
                    _PayTime = value;
                    SendPropertyChanged("PayTime");
                }
            }
        }
        System.Nullable<Boolean> _IsConfirm=false;
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
                    SendPropertyChanging("IsConfirm",_IsConfirm,value);
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
                    SendPropertyChanging("Amount",_Amount,value);
                    _Amount = value;
                    SendPropertyChanged("Amount");
                }
            }
        }
        System.Nullable<DateTime> _ToBalanceTime;
        /// <summary>
        /// 转入余额时间
        /// </summary>
        [Display(Name = "转入余额时间")]
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
                    SendPropertyChanging("ToBalanceTime",_ToBalanceTime,value);
                    _ToBalanceTime = value;
                    SendPropertyChanged("ToBalanceTime");
                }
            }
        }
    }
    /// <summary>
    /// 关注列表
    /// </summary>
    [TableConfig]
    [Table("concern")]
    public class Concern :Way.EntityDB.DataItem
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
        System.Nullable<Int64> _TradeUserId;
        /// <summary>
        /// 交易员
        /// </summary>
        [Required]
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
                    SendPropertyChanging("TradeUserId",_TradeUserId,value);
                    _TradeUserId = value;
                    SendPropertyChanged("TradeUserId");
                }
            }
        }
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 用户
        /// </summary>
        [Required]
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
                    SendPropertyChanging("UserId",_UserId,value);
                    _UserId = value;
                    SendPropertyChanged("UserId");
                }
            }
        }
    }
    /// <summary>
    /// 交易对胜率
    /// </summary>
    [TableConfig]
    [Table("symbolwinrate")]
    public class SymbolWinRate :Way.EntityDB.DataItem
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
        System.Nullable<Int64> _TradeUserId;
        [Required]
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
                    SendPropertyChanging("TradeUserId",_TradeUserId,value);
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
                    SendPropertyChanging("Symbol",_Symbol,value);
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
                    SendPropertyChanging("WinRate",_WinRate,value);
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
                    SendPropertyChanging("ProfitRate",_ProfitRate,value);
                    _ProfitRate = value;
                    SendPropertyChanged("ProfitRate");
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
            modelBuilder.Entity<ConsumeRecord>().HasKey(m => m.id);
            modelBuilder.Entity<Concern>().HasKey(m => m.id);
            modelBuilder.Entity<SymbolWinRate>().HasKey(m => m.id);
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
        protected override string GetDesignString()
        {
            var result = new StringBuilder();
            result.Append("\r\n");
            result.Append("H4sIAAAAAAAAE81ca1MTyRr+K1Y+65FcAav8wAEsUwfRAt3dqo21NZk0MGUygzMTOSnLqnhci4tyW+CAggsqrrhHcT0iYgLyZ9Iz4dP5C6d7enKZnpBpMrl9YtLdM91P99vPe+vmvucmF40DxXPp5/vkcZBLAM8lz/Dd+DCQ7wHZc94zJE2QBmEVJMiT2UqIoeofuHgS");
            result.Append("/fA+OF8sV1PjoFTj6ZUBpwLj8z28Kkiip6wtL4kqENWy5vcjZCgRzyX0KMTQX+/5iNEePaJKmYuBWwqQIx5U3MepXJRTQLjPbCcMSPwd9NzxAP3oleLJhKhE8KirfiscM74WVnqSqhQWeRkk0KhQmxEurgD8JU4cTMbjZSWx6E2E0/hMVBgVcGtUGgfiqDpmlBq/DSjF");
            result.Append("wYWVG/8wfqhyEn9DkmNANobVYdT2CQovCwlB5FRJLvSFZsscexA14rlxPIdGDyev57StQ6OfIqRhNYXnjhGMOY4yLAUg/WIy0QdGBJEUX7yob37QM8eRiDg8JsnqucvnEKCIePHiycoxKR+QxFFU7DOLJ2dz2SX0eFUYHUPFfrP4P2snrxbN4isyuJsEIp9C9QFSnzvI");
            result.Append("al8eosdrnCAOq0h0EqgySCq143T+eB09DnExgefiqCZUeM0cXC9CCuQBNGxU2WlWHs2RPgekiWKXl7tIZf4oS8Y5gAak/sjJYExKKuByt9nlh1fa7CZGrUrjA5KiYOAdJSyv506evTPhDAnKHVxtToy+8xk+fGO8CrgYxuj1nUVGCqtVEhI/i5CEKCHRd9O57BOrkPQB");
            result.Append("/AmzTc2ico+T+TFOpjH5OjrOBivAAquTggUP03DhY3731cnaYyu4fhF3PJyM4u9F3eyFqFB5U8fACJeMqwZjGaVnBBxkAdxVETD8tKJvZ6yAw8oPgiJEXW37RkENsUDtpqCSVc1lv9rZrbCqN2SBd4M3JiULE1bzduxkwYbJwgIud7imPdpC4Chk44AXuHg74OpiwuWl");
            result.Append("cGkbaaQKyNLByS24/e6UpevjUkodFFTN8LpZ4AVoXavP7Gvph7Su5dRkPbBQynZQMtSXqWb0D9Pw+2O4+1LbOsC6D9wTwIRg6FpT05C6k/Tz/PEkKugZH5eleyCGlTHbpvaebQa9TNZKwKaJ9hBfv9SW9/X1GetE3pRULPrSiMlCrZN9r5cJGq2NCCh9btKKi0AaQuZv");
            result.Append("q2H5mGDROid/vOiHiztoa8Ptt3D9d+23bSvAIaDKHG+iaS1CJqUaoFVNLrOtrS0hstJW/qJkEvsGreYqL5P+DNI6Rnv6EBm1xsptUhIpKQJu1pviXdkLdVkyJgUapBUNoRHTRshkbAtXVDRyI5bOrUHkZdKuQVr95B9t2NjlR0FsB2ph8kqCtDIgGw/5ZTZYaOOJRTet");
            result.Append("1eCYfJOgzTnZ3oOP5pNy3IrsKvIDw7wk3jIr6up2ec/qdjFpuiCtErS1L/pbascNCvwd8qPeoIJnxMSk5oK0EiCMQiQS8QqcXamsDXqlpCs9x8wpZ1xIJos2RCsJfX0KTr2rhpeYL41Czb6oTOZmiNYTucy8NrtZDR+O57QeHdM+DPkq8qc2/eQ0aKob7VcP7vQxbcaQ");
            result.Append("v+JmJMJ5qky2HBtbKC5Ak+fqG/hikiyd/n7ZtnTI3KzH6rmXSSa1F6KNFOInVFq6a9w/28K98zF5CSHaWCHACKHYgGEWaTWsam7CbVzX91OvJI4Io0YuhJREcJKkPBcTM3Mp1rzObSMFhEMdwMiqOCSCfI1MBNEkmP+6icg9v/tdP9q1rsuVeFyawJmdYaCqgjhaW7LI");
            result.Append("V/5J4bQckbmmVVNEhS1ZWlJf+ZLWlg/ylw+vSWksX3VJZAuf2Fi9PQbPROpei1CEFZJuaEbonY7SOaBh4nCvRYbQLpfVm4IrSx6xCFALn6h5KZh42msRpH4x1hZDZwrZeGndCdczcPc5JrTJLWTVRSLiORGNM/9yR9/O5A5mSf3/Dp9i2wD+9vQaEg1hPA7g/J/5R0fa");
            result.Append("xnTuIJ07+BM9wDSVNGm4NeEwIWx5ElrnkqmA6dl6TkWhaSungy29QocUiKrT/v0NLixSRqMgA95lKvfUrL/24TXuMCJekeQJTo6VJR3mZ0lNlOPvmFU1phscJozJvfXa8qVotlbfmNOWzp68emG3tXHaoSfh0gNkMuCc1CaTvvfaEqVFdJOLNoBthI7JKvDZotiG1U1i");
            result.Append("2drH5dx3gxXh7Odcdqa0tEY1wQ9nt0gh+ak//9V8rWIIvBmxU6eJYXKRfTY/a+0jXPgDQT15Pq9NpzHjZd7CJSo7GVYMI7gHj7/tjBO2qHHIlmdrbfTRAVS11bR7Yfdx41uicNeYwcLXwkpvPKmoQAax8sEbvglGabxasvZvn6/i9PxSaGXMaO2dWUz06j1amj5opKPp");
            result.Append("b6SjSQeliItJdlwum859m6q044zZuCFLsSSv1uhwWo4n1tnj9JdLb20ep89XbfXdeXDOhpW/+vZj0zL00lLJw1QiKrkhTFYqccDCphgs/s8AuAdkbrSxtq3DsKuxep0ZsJLw2bnJ3I2/VGrdUHoKNJKe6LhyIQ72FzxaqUBJVwUFLUSqRkoKNZCSAnWgJNpGMI90LK5V");
            result.Append("yB40Kc4UqL5L2IjKdhjHWORcJmPF1R6Q2PjqlNM3i2vIVCeJOjhPnYu8LuPRcfHruKsz4KxkyrqHyWS1+mlHhqxcNYztgI0pXui3ncZZR6bQPOVhNSXV4wCHKYLopzMK8BvyLpf0T1n4O+U29sYlBZARutavtjALkRDSOQ62YNYuElYp5qJ/zurZTXiYQS3xxYIUUpMJ");
            result.Append("Y2Clixfa9BM4s1P81DVOTBo3JfzuppMpqumnjSviqcLDNHbhpxbgDJU+CyvXx4E4nOR54CqJVrOb6oCaKXTpp9UxwQu3P+X33sC5Tbi+Re13hPkKJ8SHAKc0JmyX3/tDm/qa//LryeRi7mA2v4/FZVBS+0UpOTp2TRJBqiRVZiBl4z0OmzxbgFP7qLgsejSAoKslAbME");
            result.Append("1qwv9XEp6yvmrR97JKf4Snk0pvCWeRcICQxSEOQaQO74hTazTd46h1/D5+QRz6iAV0sXhMzoz+s5be5tsQd8LQcZnaoslV0Y0o8W9ewGPPwXPMCHqgeBOiHJd/plWULbDa+6m73CFOH12+yWgyfF0FUF/dCcSJ4Dsmqh2Drb9w5BB9OmpQIO7uIczr01JbIRbKTrYMs7");
            result.Append("Pf6sfd4hhgnFzfgmHVBUQ/pq8x38QTdmTq2matC9U+Gns1FkmpAJpy/vIGZtiQluwXU2r6IZ0UeLvDRnp4QauVNsh4D2p/J73yo52WhalWQCDAEerUaNO6XrfOO87FAdNgTtumnL+9r77zZvtJledqj2/VA6imK7npddq4SrPSCx3eKx3cxb3T9Z3aNcNC7VnMMSDoiY");
            result.Append("HOqA7dyXYdiazsXX/+rZeW16Sc8+OyX0g1gNE5+caIaHQQd6HSaAyesO0H5VJSuxOQaiAxwmNzFgi18evYeP3+SOniFQlaT1pvR3Ls6JPGgLma0WWWiaEWzROY23gq3dNUW5dzZSudtu7Bj2HZxazb/csSl3HshibWo92MgTpJ3u1XqQJpY2CJ5bYNWo1oM0w7TQbHfA");
            result.Append("08RDA1XZBAt5U3jE6KgpDNLdUE+azs+YW+fjt0p3NUleufzG5pm5JNRIF6HLPZeEulvFGF3VdxgTY3TaHIHCcrbogIADKCZXoJN2BVp4jdgBD5Mj0Ek7AuX/UqKF/33BAVs1G79pFG9hoDqe00I/TbIyaLg0ogIZY6LD04n/r5yRsPpbWFRDAaMjS2uToe3th1VZEEft");
            result.Append("L5Romv0dC6ZTh3Ybw8K1w0A1Xwx4oz4QC3RciIFo4EIgFOQvdIViIxc6At0dwWhHKDjCdXge/B+6zlvpU08AAA==");
            return result.ToString();
        }
    }
}

/*<design>
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
<design>*/

