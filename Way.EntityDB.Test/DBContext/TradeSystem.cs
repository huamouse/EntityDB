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

namespace Way.EntityDB.Test
{
    [TableConfig]
    [Table("order")]
    [Way.EntityDB.DataItemJsonConverter]
    public class Order : Way.EntityDB.DataItem
    {
        System.Nullable<Int64> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
        [Column("id")]
        public virtual System.Nullable<Int64> id
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
        Order_DelegateTypeEnum? _DelegateType;
        /// <summary>
        /// 委托类型
        /// </summary>
        [Display(Name = "委托类型")]
        [Column("delegatetype")]
        public virtual Order_DelegateTypeEnum? DelegateType
        {
            get
            {
                return _DelegateType;
            }
            set
            {
                if ((_DelegateType != value))
                {
                    SendPropertyChanging("DelegateType", _DelegateType, value);
                    _DelegateType = value;
                    SendPropertyChanged("DelegateType");
                }
            }
        }
        Order_StatusEnum? _Status = (Order_StatusEnum?)(1);
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        [Column("status")]
        public virtual Order_StatusEnum? Status
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
        System.Nullable<Int64> _DelegateOrderId;
        /// <summary>
        /// 原委托单号
        /// </summary>
        [Display(Name = "原委托单号")]
        [Column("delegateorderid")]
        public virtual System.Nullable<Int64> DelegateOrderId
        {
            get
            {
                return _DelegateOrderId;
            }
            set
            {
                if ((_DelegateOrderId != value))
                {
                    SendPropertyChanging("DelegateOrderId", _DelegateOrderId, value);
                    _DelegateOrderId = value;
                    SendPropertyChanged("DelegateOrderId");
                }
            }
        }
        Int32 _Lots = 0;
        /// <summary>
        /// 订单手数
        /// </summary>
        [DisallowNull]
        [Display(Name = "订单手数")]
        [Column("lots")]
        public virtual Int32 Lots
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
        Int32 _ClosedLots = 0;
        /// <summary>
        /// 已平仓手数
        /// </summary>
        [DisallowNull]
        [Display(Name = "已平仓手数")]
        [Column("closedlots")]
        public virtual Int32 ClosedLots
        {
            get
            {
                return _ClosedLots;
            }
            set
            {
                if ((_ClosedLots != value))
                {
                    SendPropertyChanging("ClosedLots", _ClosedLots, value);
                    _ClosedLots = value;
                    SendPropertyChanged("ClosedLots");
                }
            }
        }
        System.Nullable<DateTime> _DelegateTime;
        /// <summary>
        /// 委托时间
        /// </summary>
        [Display(Name = "委托时间")]
        [Column("delegatetime")]
        public virtual System.Nullable<DateTime> DelegateTime
        {
            get
            {
                return _DelegateTime;
            }
            set
            {
                if ((_DelegateTime != value))
                {
                    SendPropertyChanging("DelegateTime", _DelegateTime, value);
                    _DelegateTime = value;
                    SendPropertyChanged("DelegateTime");
                }
            }
        }
        System.Nullable<Decimal> _DelegatePrice;
        /// <summary>
        /// 委托价格
        /// </summary>
        [Display(Name = "委托价格")]
        [Column("delegateprice")]
        public virtual System.Nullable<Decimal> DelegatePrice
        {
            get
            {
                return _DelegatePrice;
            }
            set
            {
                if ((_DelegatePrice != value))
                {
                    SendPropertyChanging("DelegatePrice", _DelegatePrice, value);
                    _DelegatePrice = value;
                    SendPropertyChanged("DelegatePrice");
                }
            }
        }
        System.Nullable<Decimal> _OpenPrice;
        /// <summary>
        /// 开仓价
        /// </summary>
        [Display(Name = "开仓价")]
        [Column("openprice")]
        public virtual System.Nullable<Decimal> OpenPrice
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
        System.Nullable<Decimal> _ClosePrice;
        /// <summary>
        /// 最后一次平仓价
        /// </summary>
        [Display(Name = "最后一次平仓价")]
        [Column("closeprice")]
        public virtual System.Nullable<Decimal> ClosePrice
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
        System.Nullable<Int64> _UserId;
        /// <summary>
        /// 用户id
        /// </summary>
        [Display(Name = "用户id")]
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
        System.Nullable<DateTime> _CancelTime;
        /// <summary>
        /// 撤销时间
        /// </summary>
        [Display(Name = "撤销时间")]
        [Column("canceltime")]
        public virtual System.Nullable<DateTime> CancelTime
        {
            get
            {
                return _CancelTime;
            }
            set
            {
                if ((_CancelTime != value))
                {
                    SendPropertyChanging("CancelTime", _CancelTime, value);
                    _CancelTime = value;
                    SendPropertyChanged("CancelTime");
                }
            }
        }
        Decimal _Margin = 0m;
        /// <summary>
        /// 保证金
        /// </summary>
        [DisallowNull]
        [Display(Name = "保证金")]
        [Column("margin")]
        public virtual Decimal Margin
        {
            get
            {
                return _Margin;
            }
            set
            {
                if ((_Margin != value))
                {
                    SendPropertyChanging("Margin", _Margin, value);
                    _Margin = value;
                    SendPropertyChanged("Margin");
                }
            }
        }
        String _Symbol;
        /// <summary>
        /// 币种
        /// </summary>
        [MaxLength(50)]
        [Display(Name = "币种")]
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
        Int32 _Leverage;
        /// <summary>
        /// 杠杆
        /// </summary>
        [DisallowNull]
        [Display(Name = "杠杆")]
        [Column("leverage")]
        public virtual Int32 Leverage
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
        System.Nullable<Decimal> _StopProfit;
        /// <summary>
        /// 止盈价格
        /// </summary>
        [Display(Name = "止盈价格")]
        [Column("stopprofit")]
        public virtual System.Nullable<Decimal> StopProfit
        {
            get
            {
                return _StopProfit;
            }
            set
            {
                if ((_StopProfit != value))
                {
                    SendPropertyChanging("StopProfit", _StopProfit, value);
                    _StopProfit = value;
                    SendPropertyChanged("StopProfit");
                }
            }
        }
        System.Nullable<Decimal> _StopLoss;
        /// <summary>
        /// 止损价格
        /// </summary>
        [Display(Name = "止损价格")]
        [Column("stoploss")]
        public virtual System.Nullable<Decimal> StopLoss
        {
            get
            {
                return _StopLoss;
            }
            set
            {
                if ((_StopLoss != value))
                {
                    SendPropertyChanging("StopLoss", _StopLoss, value);
                    _StopLoss = value;
                    SendPropertyChanged("StopLoss");
                }
            }
        }
        System.Nullable<DateTime> _CloseTime;
        /// <summary>
        /// 最后一次平仓时间
        /// </summary>
        [Display(Name = "最后一次平仓时间")]
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
        System.Nullable<Decimal> _StopProfitAmount;
        /// <summary>
        /// 止盈金额
        /// </summary>
        [Display(Name = "止盈金额")]
        [Column("stopprofitamount")]
        public virtual System.Nullable<Decimal> StopProfitAmount
        {
            get
            {
                return _StopProfitAmount;
            }
            set
            {
                if ((_StopProfitAmount != value))
                {
                    SendPropertyChanging("StopProfitAmount", _StopProfitAmount, value);
                    _StopProfitAmount = value;
                    SendPropertyChanged("StopProfitAmount");
                }
            }
        }
        System.Nullable<Decimal> _StopLossAmount;
        /// <summary>
        /// 止损金额
        /// </summary>
        [Display(Name = "止损金额")]
        [Column("stoplossamount")]
        public virtual System.Nullable<Decimal> StopLossAmount
        {
            get
            {
                return _StopLossAmount;
            }
            set
            {
                if ((_StopLossAmount != value))
                {
                    SendPropertyChanging("StopLossAmount", _StopLossAmount, value);
                    _StopLossAmount = value;
                    SendPropertyChanged("StopLossAmount");
                }
            }
        }
        System.Nullable<Decimal> _Profit = 0m;
        /// <summary>
        /// 总盈亏
        /// </summary>
        [Display(Name = "总盈亏")]
        [Column("profit")]
        public virtual System.Nullable<Decimal> Profit
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
        Order_BsTypeEnum _BsType;
        /// <summary>
        /// 方向
        /// </summary>
        [DisallowNull]
        [Display(Name = "方向")]
        [Column("bstype")]
        public virtual Order_BsTypeEnum BsType
        {
            get
            {
                return _BsType;
            }
            set
            {
                if ((_BsType != value))
                {
                    SendPropertyChanging("BsType", _BsType, value);
                    _BsType = value;
                    SendPropertyChanged("BsType");
                }
            }
        }
        System.Nullable<Decimal> _MarketPrice;
        /// <summary>
        /// 当前的市价
        /// </summary>
        [Display(Name = "当前的市价")]
        [Column("marketprice")]
        public virtual System.Nullable<Decimal> MarketPrice
        {
            get
            {
                return _MarketPrice;
            }
            set
            {
                if ((_MarketPrice != value))
                {
                    SendPropertyChanging("MarketPrice", _MarketPrice, value);
                    _MarketPrice = value;
                    SendPropertyChanged("MarketPrice");
                }
            }
        }
        System.Nullable<Decimal> _PriceOnSetPL;
        /// <summary>
        /// 设置止盈止损时的市价
        /// </summary>
        [Display(Name = "设置止盈止损时的市价")]
        [Column("priceonsetpl")]
        public virtual System.Nullable<Decimal> PriceOnSetPL
        {
            get
            {
                return _PriceOnSetPL;
            }
            set
            {
                if ((_PriceOnSetPL != value))
                {
                    SendPropertyChanging("PriceOnSetPL", _PriceOnSetPL, value);
                    _PriceOnSetPL = value;
                    SendPropertyChanged("PriceOnSetPL");
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
        Int32 _OriginalLots = 0;
        /// <summary>
        /// 最初委托手数
        /// </summary>
        [DisallowNull]
        [Display(Name = "最初委托手数")]
        [Column("originallots")]
        public virtual Int32 OriginalLots
        {
            get
            {
                return _OriginalLots;
            }
            set
            {
                if ((_OriginalLots != value))
                {
                    SendPropertyChanging("OriginalLots", _OriginalLots, value);
                    _OriginalLots = value;
                    SendPropertyChanged("OriginalLots");
                }
            }
        }
        System.Nullable<Decimal> _OriginalMarketPrice;
        /// <summary>
        /// 最初下单时的市场价
        /// </summary>
        [Display(Name = "最初下单时的市场价")]
        [Column("originalmarketprice")]
        public virtual System.Nullable<Decimal> OriginalMarketPrice
        {
            get
            {
                return _OriginalMarketPrice;
            }
            set
            {
                if ((_OriginalMarketPrice != value))
                {
                    SendPropertyChanging("OriginalMarketPrice", _OriginalMarketPrice, value);
                    _OriginalMarketPrice = value;
                    SendPropertyChanged("OriginalMarketPrice");
                }
            }
        }
        Order_OpenFailReasionEnum? _OpenFailReasion;
        /// <summary>
        /// 开仓失败原因
        /// </summary>
        [Display(Name = "开仓失败原因")]
        [Column("openfailreasion")]
        public virtual Order_OpenFailReasionEnum? OpenFailReasion
        {
            get
            {
                return _OpenFailReasion;
            }
            set
            {
                if ((_OpenFailReasion != value))
                {
                    SendPropertyChanging("OpenFailReasion", _OpenFailReasion, value);
                    _OpenFailReasion = value;
                    SendPropertyChanged("OpenFailReasion");
                }
            }
        }
        Int64 _MoneyAcountId;
        /// <summary>
        /// 资金账号id
        /// </summary>
        [DisallowNull]
        [Display(Name = "资金账号id")]
        [Column("moneyacountid")]
        public virtual Int64 MoneyAcountId
        {
            get
            {
                return _MoneyAcountId;
            }
            set
            {
                if ((_MoneyAcountId != value))
                {
                    SendPropertyChanging("MoneyAcountId", _MoneyAcountId, value);
                    _MoneyAcountId = value;
                    SendPropertyChanged("MoneyAcountId");
                }
            }
        }
        Decimal _Fee = 0m;
        /// <summary>
        /// 交易手续费
        /// </summary>
        [DisallowNull]
        [Display(Name = "交易手续费")]
        [Column("fee")]
        public virtual Decimal Fee
        {
            get
            {
                return _Fee;
            }
            set
            {
                if ((_Fee != value))
                {
                    SendPropertyChanging("Fee", _Fee, value);
                    _Fee = value;
                    SendPropertyChanged("Fee");
                }
            }
        }
    }
    public enum Order_DelegateTypeEnum : int
    {
        /// <summary>
        /// 数量委托
        /// </summary>
        Quantity = 1,
        /// <summary>
        /// 价格委托
        /// </summary>
        Price = 2
    }
    public enum Order_StatusEnum : int
    {
        /// <summary>
        /// 委托中
        /// </summary>
        Delegate = 1,
        /// <summary>
        /// 准备成交
        /// </summary>
        ReadyToOpen = 2,
        /// <summary>
        /// 已开仓
        /// </summary>
        Open = 101,
        /// <summary>
        /// 平仓中
        /// </summary>
        Closing = 201,
        /// <summary>
        /// 部分平仓
        /// </summary>
        PartialClosed = 301,
        /// <summary>
        /// 全部平仓
        /// </summary>
        AllClosed = 401,
        /// <summary>
        /// 已撤销
        /// </summary>
        Canceled = 501,
        /// <summary>
        /// 已合并
        /// </summary>
        Merge = 502,
        /// <summary>
        /// 开仓失败
        /// </summary>
        OpenFailed = 601
    }
    public enum Order_BsTypeEnum : int
    {
        /// <summary>
        /// 做多
        /// </summary>
        Buy = 1,
        /// <summary>
        /// 做空
        /// </summary>
        Sell = 2
    }
    public enum Order_OpenFailReasionEnum : int
    {
        /// <summary>
        /// 超出价格保护范围
        /// </summary>
        PriceProtect = 1
    }
    [TableConfig]
    [Table("closeorderhistory")]
    [Way.EntityDB.DataItemJsonConverter]
    public class CloseOrderHistory : Way.EntityDB.DataItem
    {
        System.Nullable<Int64> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
        [Column("id")]
        public virtual System.Nullable<Int64> id
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
        System.Nullable<Int64> _OrderId;
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
        System.Nullable<Decimal> _ClosePrice;
        /// <summary>
        /// 平仓价
        /// </summary>
        [Display(Name = "平仓价")]
        [Column("closeprice")]
        public virtual System.Nullable<Decimal> ClosePrice
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
        System.Nullable<Int32> _Lots;
        /// <summary>
        /// 平仓手数
        /// </summary>
        [Display(Name = "平仓手数")]
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
        System.Nullable<Decimal> _Profit = 0m;
        /// <summary>
        /// 盈亏
        /// </summary>
        [Display(Name = "盈亏")]
        [Column("profit")]
        public virtual System.Nullable<Decimal> Profit
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
    /// <summary>
    /// 用户资金表
    /// </summary>
    [TableConfig]
    [Table("moneyaccount")]
    [Way.EntityDB.DataItemJsonConverter]
    public class MoneyAccount : Way.EntityDB.DataItem
    {
        Int64 _UserId;
        [DisallowNull]
        [Column("userid")]
        public virtual Int64 UserId
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
        Decimal _Balance = 0m;
        /// <summary>
        /// 可用余额
        /// </summary>
        [DisallowNull]
        [Display(Name = "可用余额")]
        [Column("balance")]
        public virtual Decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if ((_Balance != value))
                {
                    SendPropertyChanging("Balance", _Balance, value);
                    _Balance = value;
                    SendPropertyChanged("Balance");
                }
            }
        }
        Decimal _OrderMargin = 0m;
        /// <summary>
        /// 持仓保证金
        /// </summary>
        [DisallowNull]
        [Display(Name = "持仓保证金")]
        [Column("ordermargin")]
        public virtual Decimal OrderMargin
        {
            get
            {
                return _OrderMargin;
            }
            set
            {
                if ((_OrderMargin != value))
                {
                    SendPropertyChanging("OrderMargin", _OrderMargin, value);
                    _OrderMargin = value;
                    SendPropertyChanged("OrderMargin");
                }
            }
        }
        String _Coin = "USDT";
        /// <summary>
        /// 币种
        /// </summary>
        [MaxLength(10)]
        [Display(Name = "币种")]
        [Column("coin")]
        public virtual String Coin
        {
            get
            {
                return _Coin;
            }
            set
            {
                if ((_Coin != value))
                {
                    SendPropertyChanging("Coin", _Coin, value);
                    _Coin = value;
                    SendPropertyChanged("Coin");
                }
            }
        }
        System.Nullable<Int64> _Id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
        [Column("id")]
        public virtual System.Nullable<Int64> Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if ((_Id != value))
                {
                    SendPropertyChanging("Id", _Id, value);
                    _Id = value;
                    SendPropertyChanged("Id");
                }
            }
        }
        Decimal _WithdrawFrozen = 0m;
        /// <summary>
        /// 提现冻结金额
        /// </summary>
        [DisallowNull]
        [Display(Name = "提现冻结金额")]
        [Column("withdrawfrozen")]
        public virtual Decimal WithdrawFrozen
        {
            get
            {
                return _WithdrawFrozen;
            }
            set
            {
                if ((_WithdrawFrozen != value))
                {
                    SendPropertyChanging("WithdrawFrozen", _WithdrawFrozen, value);
                    _WithdrawFrozen = value;
                    SendPropertyChanged("WithdrawFrozen");
                }
            }
        }
        MoneyAccount_PositionTypeEnum _PositionType = (MoneyAccount_PositionTypeEnum)(1);
        /// <summary>
        /// 持仓模式
        /// </summary>
        [DisallowNull]
        [Display(Name = "持仓模式")]
        [Column("positiontype")]
        public virtual MoneyAccount_PositionTypeEnum PositionType
        {
            get
            {
                return _PositionType;
            }
            set
            {
                if ((_PositionType != value))
                {
                    SendPropertyChanging("PositionType", _PositionType, value);
                    _PositionType = value;
                    SendPropertyChanged("PositionType");
                }
            }
        }
    }
    public enum MoneyAccount_PositionTypeEnum : int
    {
        /// <summary>
        /// 逐仓模式
        /// </summary>
        SingleMode = 1,
        /// <summary>
        /// 全仓模式
        /// </summary>
        FullMode = 2
    }
    [TableConfig]
    [Table("symbolinfo")]
    [Way.EntityDB.DataItemJsonConverter]
    public class SymbolInfo : Way.EntityDB.DataItem
    {
        System.Nullable<Int64> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
        [Column("id")]
        public virtual System.Nullable<Int64> id
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
        String _Name;
        [MaxLength(50)]
        [Column("name")]
        public virtual String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if ((_Name != value))
                {
                    SendPropertyChanging("Name", _Name, value);
                    _Name = value;
                    SendPropertyChanged("Name");
                }
            }
        }
        System.Nullable<Int32> _Sort = 0;
        [Column("sort")]
        public virtual System.Nullable<Int32> Sort
        {
            get
            {
                return _Sort;
            }
            set
            {
                if ((_Sort != value))
                {
                    SendPropertyChanging("Sort", _Sort, value);
                    _Sort = value;
                    SendPropertyChanged("Sort");
                }
            }
        }
        Boolean _Enable = true;
        [DisallowNull]
        [Column("enable")]
        public virtual Boolean Enable
        {
            get
            {
                return _Enable;
            }
            set
            {
                if ((_Enable != value))
                {
                    SendPropertyChanging("Enable", _Enable, value);
                    _Enable = value;
                    SendPropertyChanged("Enable");
                }
            }
        }
    }
    /// <summary>
    /// 资金明细
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = (MoneyHistory_TypeEnum)0)]
    [Table("moneyhistory")]
    [Way.EntityDB.DataItemJsonConverter]
    public class MoneyHistory : Way.EntityDB.DataItem
    {
        System.Nullable<Int64> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
        [Column("id")]
        public virtual System.Nullable<Int64> id
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
        Int64 _UserId;
        [DisallowNull]
        [Column("userid")]
        public virtual Int64 UserId
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
        System.Nullable<Decimal> _Amount;
        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        [Column("amount")]
        public virtual System.Nullable<Decimal> Amount
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
        System.Nullable<Decimal> _Balance;
        /// <summary>
        /// 当时余额
        /// </summary>
        [Display(Name = "当时余额")]
        [Column("balance")]
        public virtual System.Nullable<Decimal> Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if ((_Balance != value))
                {
                    SendPropertyChanging("Balance", _Balance, value);
                    _Balance = value;
                    SendPropertyChanged("Balance");
                }
            }
        }
        MoneyHistory_TypeEnum _Type;
        /// <summary>
        /// 明细类型
        /// </summary>
        [DisallowNull]
        [Display(Name = "明细类型")]
        [Column("type")]
        public virtual MoneyHistory_TypeEnum Type
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
        DateTime _CreateTime;
        [DisallowNull]
        [Column("createtime")]
        public virtual DateTime CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                if ((_CreateTime != value))
                {
                    SendPropertyChanging("CreateTime", _CreateTime, value);
                    _CreateTime = value;
                    SendPropertyChanged("CreateTime");
                }
            }
        }
        Int64 _MoneyAccountId;
        /// <summary>
        /// 资金账户Id
        /// </summary>
        [DisallowNull]
        [Display(Name = "资金账户Id")]
        [Column("moneyaccountid")]
        public virtual Int64 MoneyAccountId
        {
            get
            {
                return _MoneyAccountId;
            }
            set
            {
                if ((_MoneyAccountId != value))
                {
                    SendPropertyChanging("MoneyAccountId", _MoneyAccountId, value);
                    _MoneyAccountId = value;
                    SendPropertyChanged("MoneyAccountId");
                }
            }
        }
    }
    /// <summary>
    /// 与订单相关的记录
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = MoneyHistory_TypeEnum.OrderHistory)]
    public class OrderHistory : MoneyHistory
    {
        System.Nullable<Int64> _OrderId;
        /// <summary>
        /// 关联的订单id
        /// </summary>
        [Display(Name = "关联的订单id")]
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
    }
    /// <summary>
    /// 扣除订单保证金
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = MoneyHistory_TypeEnum.AddOrderMarginHistory)]
    public class AddOrderMarginHistory : OrderHistory
    {
    }
    /// <summary>
    /// 归还订单保证金
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = MoneyHistory_TypeEnum.CancelOrderMarginHistory)]
    public class CancelOrderMarginHistory : OrderHistory
    {
    }
    /// <summary>
    /// 扣除手续费
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = MoneyHistory_TypeEnum.AddTradeFeeHistory)]
    public class AddTradeFeeHistory : OrderHistory
    {
    }
    /// <summary>
    /// 归还手续费
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = MoneyHistory_TypeEnum.CancelTradeFeeHistory)]
    public class CancelTradeFeeHistory : OrderHistory
    {
    }
    /// <summary>
    /// 订单盈亏
    /// </summary>
    [TableConfig(AutoSetPropertyNameOnInsert = "Type", AutoSetPropertyValueOnInsert = MoneyHistory_TypeEnum.OrderProfitHistory)]
    public class OrderProfitHistory : OrderHistory
    {
    }
    public enum MoneyHistory_TypeEnum : int
    {
        /// <summary>
        /// 与订单相关的记录
        /// </summary>
        OrderHistory = 1,
        /// <summary>
        /// 扣除订单保证金
        /// </summary>
        AddOrderMarginHistory = 101 + OrderHistory,
        /// <summary>
        /// 归还订单保证金
        /// </summary>
        CancelOrderMarginHistory = 201 + OrderHistory,
        /// <summary>
        /// 扣除手续费
        /// </summary>
        AddTradeFeeHistory = 301 + OrderHistory,
        /// <summary>
        /// 归还手续费
        /// </summary>
        CancelTradeFeeHistory = 401 + OrderHistory,
        /// <summary>
        /// 订单盈亏
        /// </summary>
        OrderProfitHistory = 501 + OrderHistory
    }
    /// <summary>
    /// 设置止盈止损的历史
    /// </summary>
    [TableConfig]
    [Table("setstopplhistory")]
    [Way.EntityDB.DataItemJsonConverter]
    public class SetStopPLHistory : Way.EntityDB.DataItem
    {
        System.Nullable<Int64> _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisallowNull]
        [Column("id")]
        public virtual System.Nullable<Int64> id
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
        System.Nullable<Decimal> _StopProfit;
        /// <summary>
        /// 止盈价格
        /// </summary>
        [Display(Name = "止盈价格")]
        [Column("stopprofit")]
        public virtual System.Nullable<Decimal> StopProfit
        {
            get
            {
                return _StopProfit;
            }
            set
            {
                if ((_StopProfit != value))
                {
                    SendPropertyChanging("StopProfit", _StopProfit, value);
                    _StopProfit = value;
                    SendPropertyChanged("StopProfit");
                }
            }
        }
        System.Nullable<Decimal> _StopLoss;
        /// <summary>
        /// 止损价格
        /// </summary>
        [Display(Name = "止损价格")]
        [Column("stoploss")]
        public virtual System.Nullable<Decimal> StopLoss
        {
            get
            {
                return _StopLoss;
            }
            set
            {
                if ((_StopLoss != value))
                {
                    SendPropertyChanging("StopLoss", _StopLoss, value);
                    _StopLoss = value;
                    SendPropertyChanged("StopLoss");
                }
            }
        }
        System.Nullable<Decimal> _StopProfitAmount;
        /// <summary>
        /// 止盈金额
        /// </summary>
        [Display(Name = "止盈金额")]
        [Column("stopprofitamount")]
        public virtual System.Nullable<Decimal> StopProfitAmount
        {
            get
            {
                return _StopProfitAmount;
            }
            set
            {
                if ((_StopProfitAmount != value))
                {
                    SendPropertyChanging("StopProfitAmount", _StopProfitAmount, value);
                    _StopProfitAmount = value;
                    SendPropertyChanged("StopProfitAmount");
                }
            }
        }
        System.Nullable<Decimal> _StopLossAmount;
        /// <summary>
        /// 止损金额
        /// </summary>
        [Display(Name = "止损金额")]
        [Column("stoplossamount")]
        public virtual System.Nullable<Decimal> StopLossAmount
        {
            get
            {
                return _StopLossAmount;
            }
            set
            {
                if ((_StopLossAmount != value))
                {
                    SendPropertyChanging("StopLossAmount", _StopLossAmount, value);
                    _StopLossAmount = value;
                    SendPropertyChanged("StopLossAmount");
                }
            }
        }
        System.Nullable<Decimal> _PriceOnSetPL;
        /// <summary>
        /// 设置止盈止损时的市价
        /// </summary>
        [Display(Name = "设置止盈止损时的市价")]
        [Column("priceonsetpl")]
        public virtual System.Nullable<Decimal> PriceOnSetPL
        {
            get
            {
                return _PriceOnSetPL;
            }
            set
            {
                if ((_PriceOnSetPL != value))
                {
                    SendPropertyChanging("PriceOnSetPL", _PriceOnSetPL, value);
                    _PriceOnSetPL = value;
                    SendPropertyChanged("PriceOnSetPL");
                }
            }
        }
        DateTime _CreateTime;
        [DisallowNull]
        [Column("createtime")]
        public virtual DateTime CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                if ((_CreateTime != value))
                {
                    SendPropertyChanging("CreateTime", _CreateTime, value);
                    _CreateTime = value;
                    SendPropertyChanged("CreateTime");
                }
            }
        }
        Int64 _OrderId;
        [DisallowNull]
        [Column("orderid")]
        public virtual Int64 OrderId
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
    }
}

namespace Way.EntityDB.Test
{
    public class TradeSystemDB : Way.EntityDB.DBContext
    {
        public TradeSystemDB(string connection, Way.EntityDB.DatabaseType dbType, bool upgradeDatabase = true) : base(connection, dbType, upgradeDatabase)
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
            var db = sender as TradeSystemDB;
            if (db == null) return;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(m => m.id);
            modelBuilder.Entity<CloseOrderHistory>().HasKey(m => m.id);
            modelBuilder.Entity<MoneyAccount>().HasKey(m => m.Id);
            modelBuilder.Entity<SymbolInfo>().HasKey(m => m.id);
            modelBuilder.Entity<MoneyHistory>().HasKey(m => m.id);
            modelBuilder.Entity<MoneyHistory>().HasDiscriminator<MoneyHistory_TypeEnum>("Type")
            .HasValue<MoneyHistory>((MoneyHistory_TypeEnum)0)
            .HasValue<OrderHistory>(MoneyHistory_TypeEnum.OrderHistory)
            .HasValue<AddOrderMarginHistory>(MoneyHistory_TypeEnum.AddOrderMarginHistory)
            .HasValue<CancelOrderMarginHistory>(MoneyHistory_TypeEnum.CancelOrderMarginHistory)
            .HasValue<AddTradeFeeHistory>(MoneyHistory_TypeEnum.AddTradeFeeHistory)
            .HasValue<CancelTradeFeeHistory>(MoneyHistory_TypeEnum.CancelTradeFeeHistory)
            .HasValue<OrderProfitHistory>(MoneyHistory_TypeEnum.OrderProfitHistory)
            ;
            modelBuilder.Entity<SetStopPLHistory>().HasKey(m => m.id);
        }
        System.Linq.IQueryable<Order> _Order;
        public virtual System.Linq.IQueryable<Order> Order
        {
            get
            {
                if (_Order == null)
                {
                    _Order = this.Set<Order>();
                }
                return _Order;
            }
        }
        System.Linq.IQueryable<CloseOrderHistory> _CloseOrderHistory;
        public virtual System.Linq.IQueryable<CloseOrderHistory> CloseOrderHistory
        {
            get
            {
                if (_CloseOrderHistory == null)
                {
                    _CloseOrderHistory = this.Set<CloseOrderHistory>();
                }
                return _CloseOrderHistory;
            }
        }
        System.Linq.IQueryable<MoneyAccount> _MoneyAccount;
        public virtual System.Linq.IQueryable<MoneyAccount> MoneyAccount
        {
            get
            {
                if (_MoneyAccount == null)
                {
                    _MoneyAccount = this.Set<MoneyAccount>();
                }
                return _MoneyAccount;
            }
        }
        System.Linq.IQueryable<SymbolInfo> _SymbolInfo;
        public virtual System.Linq.IQueryable<SymbolInfo> SymbolInfo
        {
            get
            {
                if (_SymbolInfo == null)
                {
                    _SymbolInfo = this.Set<SymbolInfo>();
                }
                return _SymbolInfo;
            }
        }
        System.Linq.IQueryable<MoneyHistory> _MoneyHistory;
        public virtual System.Linq.IQueryable<MoneyHistory> MoneyHistory
        {
            get
            {
                if (_MoneyHistory == null)
                {
                    _MoneyHistory = this.Set<MoneyHistory>();
                }
                return _MoneyHistory;
            }
        }
        System.Linq.IQueryable<OrderHistory> _OrderHistory;
        public virtual System.Linq.IQueryable<OrderHistory> OrderHistory
        {
            get
            {
                if (_OrderHistory == null)
                {
                    _OrderHistory = this.Set<OrderHistory>();
                }
                return _OrderHistory;
            }
        }
        System.Linq.IQueryable<AddOrderMarginHistory> _AddOrderMarginHistory;
        public virtual System.Linq.IQueryable<AddOrderMarginHistory> AddOrderMarginHistory
        {
            get
            {
                if (_AddOrderMarginHistory == null)
                {
                    _AddOrderMarginHistory = this.Set<AddOrderMarginHistory>();
                }
                return _AddOrderMarginHistory;
            }
        }
        System.Linq.IQueryable<CancelOrderMarginHistory> _CancelOrderMarginHistory;
        public virtual System.Linq.IQueryable<CancelOrderMarginHistory> CancelOrderMarginHistory
        {
            get
            {
                if (_CancelOrderMarginHistory == null)
                {
                    _CancelOrderMarginHistory = this.Set<CancelOrderMarginHistory>();
                }
                return _CancelOrderMarginHistory;
            }
        }
        System.Linq.IQueryable<AddTradeFeeHistory> _AddTradeFeeHistory;
        public virtual System.Linq.IQueryable<AddTradeFeeHistory> AddTradeFeeHistory
        {
            get
            {
                if (_AddTradeFeeHistory == null)
                {
                    _AddTradeFeeHistory = this.Set<AddTradeFeeHistory>();
                }
                return _AddTradeFeeHistory;
            }
        }
        System.Linq.IQueryable<CancelTradeFeeHistory> _CancelTradeFeeHistory;
        public virtual System.Linq.IQueryable<CancelTradeFeeHistory> CancelTradeFeeHistory
        {
            get
            {
                if (_CancelTradeFeeHistory == null)
                {
                    _CancelTradeFeeHistory = this.Set<CancelTradeFeeHistory>();
                }
                return _CancelTradeFeeHistory;
            }
        }
        System.Linq.IQueryable<OrderProfitHistory> _OrderProfitHistory;
        public virtual System.Linq.IQueryable<OrderProfitHistory> OrderProfitHistory
        {
            get
            {
                if (_OrderProfitHistory == null)
                {
                    _OrderProfitHistory = this.Set<OrderProfitHistory>();
                }
                return _OrderProfitHistory;
            }
        }
        System.Linq.IQueryable<SetStopPLHistory> _SetStopPLHistory;
        public virtual System.Linq.IQueryable<SetStopPLHistory> SetStopPLHistory
        {
            get
            {
                if (_SetStopPLHistory == null)
                {
                    _SetStopPLHistory = this.Set<SetStopPLHistory>();
                }
                return _SetStopPLHistory;
            }
        }
        protected override string GetDesignString()
        {
            var result = new StringBuilder();
            result.Append("\r\n");
            result.Append("H4sIAAAAAAAACt1cbXPTRh7/Khm9PTj0YMs2M/ciJGXOc6HQJu3dTJ1hZGsTNJUlKsnt5BhmkrZ5oJQkV6Cl0LTA5a65mYNSyJGQkOuXsWTnW3R3JduyJDvWRptEeWVL+6Ddn3b//9//YXWDmZDKKjCZ8x/dcP++K1UBc54Z/0QdB8anwGDOMO/rn7kVihaouv+8WooM");
            result.Append("iz+U1Bq84HLczTPtEmvmOuiUMSMGkCyAHzBcsRRdY3x1K7pmAc3yVb9RcgdTYs7Dv4oMf3nuTImpSNdRY3ip1VQV3kA9wKsSc9mQgVFi4K1RyZLKkgmKo7AgB28oY3rlY/ifvQkvRnS1VtVMePlRu2exf9eoErwumsM1Sy9qFQNU4WhhkWXUAOpS0t6FTeCNKUk10R25");
            result.Append("PAGnjxuXlWkFVYZ3vXte9+9oteoomFI03z0VaNPWtc61DKakmmphVDp3MTJ4dhiTonnlL/jKG46OkMATY3HpqGJWDKWqaJKlG75BjqiSaXqTRD3DF9IGhO8CpMTYP99zbj1o/Lpr/3gbz6UNzihQwTR6tXhykTC1H9jGyRupD6YBMCox584591/sL664oymVtPdqkmYp");
            result.Append("1szQn4YgEiXt3Ln67pbz+G27whVDqQBYyuPO2/CWGHwdD97WNDr45onxFQL4Nr567czOdSM7bklWzaSPqQtWffsZxKv1NjuA2osL9vqis7Ra31mHN94HkjwzoV++DjQEq1dn66X9dra+exdeeSUc22r/5hUscHsfUXVT0aZRQ1g8hMv3v9iwlxbcWuiFSYalSCqqCWRY");
            result.Append("UWj3M7+BqrbqDaudOpl2na2Xzjfr+/dm0bMkrQIng8qzvnJ7dcl+8xpeXQLGNJpmlm1NAs/AXv+1ufkvbx4XJcXtQWS5QRZQiXGrDb6CCsQrKBPcocs/uS/SvnPfXtmK3qRYSBblQ6wpMnGW0H7jMsRwZQNwNZ8/hUA5t25DidKN1ZhuDb7pIgR+YvCUGDbmauJEYnzE");
            result.Append("4HKCWwXvtSiI3J2XZqByxEDlIjWj893r/e82e2hGBd0g3nEy7MJqdXEMe45cyeUjoXI1dDRUWF0fBitQUaqSGh8qOMt8MnCRS/RCEC6skCBc3VghxZR+nHhibppjAzg5P8zaq8v17Vnnv088thHEDAusUwAaTwwaFySc9zacpS3Psmnj9IGZZnpALNRzQXPHZZFRQt2l");
            result.Append("lSkX6QIxUEG7pf7bWvOXuf3Ff3SjdEky4Do4DDlIfLMRkASOGKYQOd+ea/x8J2DezVTLunqIVfSpZFSuSUZ8iLJsMsuIGJ4gGXfWHjtrCwEaDqDvSZoGJ4JhxsaGfIcFibjz7Gnj0VIUaRq39OtXDH1KsdKt1IiNulwujJVz56deWI3ppplupLLESOUP5EyRyg7RpnTr");
            result.Append("Op54J+ZzkTsR6rr9p2u9duJwVa95Qie1q4zYiZDPR+7HXoih/Xga8CKmnfmgxefM7iJZv7PSDdbxCXk+MTLFE9vFhaDp4nz7xl4NEM4LZqz4AxlXwM7yuYf2+kPoH75Q80Ud4N3Gf3bg33GgqtTCDcSKshAK5+zdtW/daTz80t7+PGQsQ/L+MbDSby0Ty7FC0MppPv9/");
            result.Append("Y++5K/9dmQa1ZQ/0MG6X4UKwroylGj6490nxy0R6sqIYBnJmpZxgEJtBhUIEKVta8xzKEW73ywbyrkhqmh3vpBRWYKPcfktr9e3bKI7T2o72Dzthh6kH22mRa+QQBjWpP+SJ4oePHod3J4qBwqCvidsQozagdm2+nrcXd1wDDrqWnK/Wm19/YT/abEXyIROyQMVCipeK");
            result.Append("huVIvdICbtmlM/73JSS+zc1/w2Bs0M16SdfAzHAFUd8Y3tbEkkuSknykWGE3dpcXcWfdeYAijY3dZ83NN91gXQQg7Y7EmEhNouqjfxvRtSllupWpVDQ/0JRP8AhaDYvmiFozLWAA2d8dTnBC/eGmHaf+ZChd6mqrCL8c8icE1nPEgwI1vCnCCuxNfyKY7KVu+dPKcrAy");
            result.Append("ykBD6TAAJ3EdmIfGU81D4/smi2GfCZ70nxUTvugZwpy0XCGtOWk8nZy0PHtw/t8Jjl3xlJzp+ZBST3cI9ACciCOg+ZAN3DO9JRa/JuI6lBYRua8zaPGm2yfM0/KjBElear11fKImRsKEpS3KJ/sq1qvtepTphECVTgiRmRme+fBkI9JywESKkFjkM331aMwUkCNnFwIt");
            result.Append("PRoMStsrv8BXUd/7PhS8uCCpKAvkWKySGHtcoKVJQyHqr+cQ44hOBcGb9BjzQZIDjFS7CmxhgHSQET0GQAkmg3CRySBQDoyPTsQEiNgxhTNteouk4tHbOoMyDYGKrSPgDK2uLbay2lh+YS/sNnbvRsVT/6pY12RD+uyiof8dpH2jkfIzAaeShCWTs/HEfhtkabqpoGpH");
            result.Append("FDbcn13tDASGCRVtWgWXdNl/0GZ+w1/lIuzJq8ATnj0REo2PHUTyvNUf0yl1piX5JnvRHM9JddWtRpnqZahSvf7My00ILGpTOiGzK2TT6jLK0HEZFcS+gLh/Tm7+ZYYS1S3k+q9D3TiM+UozupihRGkL+b6IvKO5O5lcTZSVxEDhYoIiHFbM05W4WaoSN3TsD5vVzoPl");
            result.Append("xm4g3xirnEO57AV0kjSd8jdLh8aywol0NQxK7rN05K/ABmlqFKM/vszIXkQ+NkCDSx70RvwAhXwxe8gXnYQv5iTiRGzvsCFPDBZsUZ9pOCI7p7697J6sbjzatudfwaSc5vMX9t59dKDe57rtWD3OrX/uf7/utul4kErasCz7PEe+Ziw39Ichf1+e9bT3TfO3B+F+3PNa");
            result.Append("kV3xPbpyh9TJRsCDmTAkGcBUhE5zoe9I/M29M2OhHjI9emghiGMLHnBuVKHTNhtqS5YQkyWxEVsKq8/K7E8xPc0eJ4oU5aqgHEbK0nJ38b1yhaDj31OIkaZwipUlebJQ6MsE86+ac/ewZEHbJJhbddLzAA7AafDDBN5U27v/SNKG/Cw54eyh6PShrgcGa1J2BolUTRPx");
            result.Append("wCRzlNK6vGCvvOxe4TC1HB84GjuctYI/ppJKa0Wk5HTPnrqjlyIlCwZ/aOY0nbwUKWkv7rQeIhQpxUq503mGUKRkAeLPzZz+o0oiJSaOv0KTdjNFpHMMThjkg5sn2SI5AJfcCcxxC1K7hFLc4KXHABlEdjuDaVFexB7RG0DffZ2Bg6/+sahZYgY/qKu2R4PD9cctA8a0");
            result.Append("ww06XHjwNl1z6jm0STQtVApB8xoWyrzIFqbYs3khx53NZKWps/lsJXsW5GRWzFfKXDlXZm7+DvWRS/PzVgAA");
            return result.ToString();
        }
    }
}

/*<design>
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
<design>*/

