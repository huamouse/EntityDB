
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
namespace EJ{


    /// <summary>
	/// 项目
	/// </summary>
    [Table("project")]
    [TableConfig]
    public class Project :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Project()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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
        /// Name
        /// </summary>
[Display(Name = "Name")]
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
}}
namespace EJ{

/// <summary>
/// 
/// </summary>
public enum Databases_dbTypeEnum:int
{
    

/// <summary>
/// </summary>
SqlServer = 1,

/// <summary>
/// </summary>
Sqlite = 2,

/// <summary>
/// </summary>
MySql=3,

/// <summary>
/// </summary>
PostgreSql=4
}


    /// <summary>
	/// 数据库
	/// </summary>
    [Table("databases")]
    [TableConfig]
    public class Databases :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Databases()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<Int32> _ProjectID;
        /// <summary>
        /// 项目ID
        /// </summary>
[Display(Name = "项目ID")]
        [Column("projectid")]
        public virtual System.Nullable<Int32> ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                if ((this._ProjectID != value))
                {
                    this.SendPropertyChanging("ProjectID",this._ProjectID,value);
                    this._ProjectID = value;
                    this.SendPropertyChanged("ProjectID");

                }
            }
        }

        String _Name;
        /// <summary>
        /// Name
        /// </summary>
[Display(Name = "Name")]
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

        System.Nullable<Databases_dbTypeEnum> _dbType=(System.Nullable<Databases_dbTypeEnum>)(1);
        /// <summary>
        /// 数据库类型
        /// </summary>
[Display(Name = "数据库类型")]
        [Column("dbtype")]
        public virtual System.Nullable<Databases_dbTypeEnum> dbType
        {
            get
            {
                return this._dbType;
            }
            set
            {
                if ((this._dbType != value))
                {
                    this.SendPropertyChanging("dbType",this._dbType,value);
                    this._dbType = value;
                    this.SendPropertyChanged("dbType");

                }
            }
        }

        String _conStr;
        /// <summary>
        /// 连接字符串
        /// </summary>
[Display(Name = "连接字符串")]
        [Column("constr")]
        public virtual String conStr
        {
            get
            {
                return this._conStr;
            }
            set
            {
                if ((this._conStr != value))
                {
                    this.SendPropertyChanging("conStr",this._conStr,value);
                    this._conStr = value;
                    this.SendPropertyChanged("conStr");

                }
            }
        }

        String _dllPath;
        /// <summary>
        /// dll生成文件夹
        /// </summary>
[Display(Name = "dll生成文件夹")]
        [Column("dllpath")]
        public virtual String dllPath
        {
            get
            {
                return this._dllPath;
            }
            set
            {
                if ((this._dllPath != value))
                {
                    this.SendPropertyChanging("dllPath",this._dllPath,value);
                    this._dllPath = value;
                    this.SendPropertyChanged("dllPath");

                }
            }
        }

        System.Nullable<Int32> _iLock=0;
        /// <summary>
        /// iLock
        /// </summary>
[Display(Name = "iLock")]
        [Column("ilock")]
        public virtual System.Nullable<Int32> iLock
        {
            get
            {
                return this._iLock;
            }
            set
            {
                if ((this._iLock != value))
                {
                    this.SendPropertyChanging("iLock",this._iLock,value);
                    this._iLock = value;
                    this.SendPropertyChanged("iLock");

                }
            }
        }

        String _NameSpace;
        /// <summary>
        /// NameSpace
        /// </summary>
[Display(Name = "NameSpace")]
        [Column("namespace")]
        public virtual String NameSpace
        {
            get
            {
                return this._NameSpace;
            }
            set
            {
                if ((this._NameSpace != value))
                {
                    this.SendPropertyChanging("NameSpace",this._NameSpace,value);
                    this._NameSpace = value;
                    this.SendPropertyChanged("NameSpace");

                }
            }
        }

        String _Guid;
        /// <summary>
        /// 唯一标示ID
        /// </summary>
[Display(Name = "唯一标示ID")]
        [Column("guid")]
        public virtual String Guid
        {
            get
            {
                return this._Guid;
            }
            set
            {
                if ((this._Guid != value))
                {
                    this.SendPropertyChanging("Guid",this._Guid,value);
                    this._Guid = value;
                    this.SendPropertyChanged("Guid");

                }
            }
        }
}}
namespace EJ{

/// <summary>
/// 
/// </summary>
public enum User_RoleEnum:int
{
    

/// <summary>
/// </summary>
开发人员 = 1,

/// <summary>
/// </summary>
客户端测试人员 = 1<<1,

/// <summary>
/// </summary>
数据库设计师 = 1<<2 | 开发人员,

/// <summary>
/// </summary>
管理员 = 数据库设计师 | 1<<3,

/// <summary>
/// </summary>
项目经理 = 1<<4 | 开发人员,
}


    /// <summary>
	/// 系统用户
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
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<User_RoleEnum> _Role;
        /// <summary>
        /// 角色
        /// </summary>
[Display(Name = "角色")]
        [Column("role")]
        public virtual System.Nullable<User_RoleEnum> Role
        {
            get
            {
                return this._Role;
            }
            set
            {
                if ((this._Role != value))
                {
                    this.SendPropertyChanging("Role",this._Role,value);
                    this._Role = value;
                    this.SendPropertyChanged("Role");

                }
            }
        }

        String _Name;
        /// <summary>
        /// Name
        /// </summary>
[Display(Name = "Name")]
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

        String _Password;
        /// <summary>
        /// Password
        /// </summary>
[Display(Name = "Password")]
        [Column("password")]
        public virtual String Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if ((this._Password != value))
                {
                    this.SendPropertyChanging("Password",this._Password,value);
                    this._Password = value;
                    this.SendPropertyChanged("Password");

                }
            }
        }
}}
namespace EJ{

/// <summary>
/// 
/// </summary>
public enum DBPower_PowerEnum:int
{
    

/// <summary>
/// </summary>
只读 = 0,

/// <summary>
/// </summary>
修改 = 1
}


    /// <summary>
	/// 数据库权限
	/// </summary>
    [Table("dbpower")]
    [TableConfig]
    public class DBPower :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  DBPower()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<Int32> _UserID;
        /// <summary>
        /// 用户
        /// </summary>
[Display(Name = "用户")]
        [Column("userid")]
        public virtual System.Nullable<Int32> UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if ((this._UserID != value))
                {
                    this.SendPropertyChanging("UserID",this._UserID,value);
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");

                }
            }
        }

        System.Nullable<DBPower_PowerEnum> _Power;
        /// <summary>
        /// 权限
        /// </summary>
[Display(Name = "权限")]
        [Column("power")]
        public virtual System.Nullable<DBPower_PowerEnum> Power
        {
            get
            {
                return this._Power;
            }
            set
            {
                if ((this._Power != value))
                {
                    this.SendPropertyChanging("Power",this._Power,value);
                    this._Power = value;
                    this.SendPropertyChanged("Power");

                }
            }
        }

        System.Nullable<Int32> _DatabaseID;
        /// <summary>
        /// 数据库ID
        /// </summary>
[Display(Name = "数据库ID")]
        [Column("databaseid")]
        public virtual System.Nullable<Int32> DatabaseID
        {
            get
            {
                return this._DatabaseID;
            }
            set
            {
                if ((this._DatabaseID != value))
                {
                    this.SendPropertyChanging("DatabaseID",this._DatabaseID,value);
                    this._DatabaseID = value;
                    this.SendPropertyChanged("DatabaseID");

                }
            }
        }
}}
namespace EJ{

/// <summary>
/// 
/// </summary>
public enum Bug_StatusEnum:int
{
    

/// <summary>
/// </summary>
提交给开发人员 = 0,

/// <summary>
/// </summary>
反馈给提交者 = 1,

/// <summary>
/// </summary>
处理完毕 = 2
}


    /// <summary>
	/// 错误报告
	/// </summary>
    [Table("bug")]
    [TableConfig]
    public class Bug :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  Bug()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        String _Title;
        /// <summary>
        /// 标题
        /// </summary>
[Display(Name = "标题")]
        [Column("title")]
        public virtual String Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                if ((this._Title != value))
                {
                    this.SendPropertyChanging("Title",this._Title,value);
                    this._Title = value;
                    this.SendPropertyChanged("Title");

                }
            }
        }

        System.Nullable<Int32> _SubmitUserID;
        /// <summary>
        /// 提交者ID
        /// </summary>
[Display(Name = "提交者ID")]
        [Column("submituserid")]
        public virtual System.Nullable<Int32> SubmitUserID
        {
            get
            {
                return this._SubmitUserID;
            }
            set
            {
                if ((this._SubmitUserID != value))
                {
                    this.SendPropertyChanging("SubmitUserID",this._SubmitUserID,value);
                    this._SubmitUserID = value;
                    this.SendPropertyChanged("SubmitUserID");

                }
            }
        }

        System.Nullable<DateTime> _SubmitTime;
        /// <summary>
        /// 提交时间
        /// </summary>
[Display(Name = "提交时间")]
        [Column("submittime")]
        public virtual System.Nullable<DateTime> SubmitTime
        {
            get
            {
                return this._SubmitTime;
            }
            set
            {
                if ((this._SubmitTime != value))
                {
                    this.SendPropertyChanging("SubmitTime",this._SubmitTime,value);
                    this._SubmitTime = value;
                    this.SendPropertyChanged("SubmitTime");

                }
            }
        }

        System.Nullable<Int32> _HandlerID;
        /// <summary>
        /// 处理者ID
        /// </summary>
[Display(Name = "处理者ID")]
        [Column("handlerid")]
        public virtual System.Nullable<Int32> HandlerID
        {
            get
            {
                return this._HandlerID;
            }
            set
            {
                if ((this._HandlerID != value))
                {
                    this.SendPropertyChanging("HandlerID",this._HandlerID,value);
                    this._HandlerID = value;
                    this.SendPropertyChanged("HandlerID");

                }
            }
        }

        System.Nullable<DateTime> _LastDate;
        /// <summary>
        /// 最后反馈时间
        /// </summary>
[Display(Name = "最后反馈时间")]
        [Column("lastdate")]
        public virtual System.Nullable<DateTime> LastDate
        {
            get
            {
                return this._LastDate;
            }
            set
            {
                if ((this._LastDate != value))
                {
                    this.SendPropertyChanging("LastDate",this._LastDate,value);
                    this._LastDate = value;
                    this.SendPropertyChanged("LastDate");

                }
            }
        }

        System.Nullable<DateTime> _FinishTime;
        /// <summary>
        /// 处理完毕时间
        /// </summary>
[Display(Name = "处理完毕时间")]
        [Column("finishtime")]
        public virtual System.Nullable<DateTime> FinishTime
        {
            get
            {
                return this._FinishTime;
            }
            set
            {
                if ((this._FinishTime != value))
                {
                    this.SendPropertyChanging("FinishTime",this._FinishTime,value);
                    this._FinishTime = value;
                    this.SendPropertyChanged("FinishTime");

                }
            }
        }

        System.Nullable<Bug_StatusEnum> _Status;
        /// <summary>
        /// 当前状态
        /// </summary>
[Display(Name = "当前状态")]
        [Column("status")]
        public virtual System.Nullable<Bug_StatusEnum> Status
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
}}
namespace EJ{


    /// <summary>
	/// 数据表
	/// </summary>
    [Table("dbtable")]
    [TableConfig]
    public class DBTable :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  DBTable()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        String _caption;
        /// <summary>
        /// caption
        /// </summary>
[Display(Name = "caption")]
        [Column("caption")]
        public virtual String caption
        {
            get
            {
                return this._caption;
            }
            set
            {
                if ((this._caption != value))
                {
                    this.SendPropertyChanging("caption",this._caption,value);
                    this._caption = value;
                    this.SendPropertyChanged("caption");

                }
            }
        }

        String _Name;
        /// <summary>
        /// Name
        /// </summary>
[Display(Name = "Name")]
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

        System.Nullable<Int32> _DatabaseID;
        /// <summary>
        /// DatabaseID
        /// </summary>
[Display(Name = "DatabaseID")]
        [Column("databaseid")]
        public virtual System.Nullable<Int32> DatabaseID
        {
            get
            {
                return this._DatabaseID;
            }
            set
            {
                if ((this._DatabaseID != value))
                {
                    this.SendPropertyChanging("DatabaseID",this._DatabaseID,value);
                    this._DatabaseID = value;
                    this.SendPropertyChanged("DatabaseID");

                }
            }
        }

        System.Nullable<Int32> _iLock=0;
        /// <summary>
        /// iLock
        /// </summary>
[Display(Name = "iLock")]
        [Column("ilock")]
        public virtual System.Nullable<Int32> iLock
        {
            get
            {
                return this._iLock;
            }
            set
            {
                if ((this._iLock != value))
                {
                    this.SendPropertyChanging("iLock",this._iLock,value);
                    this._iLock = value;
                    this.SendPropertyChanged("iLock");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 字段
	/// </summary>
    [Table("dbcolumn")]
    [TableConfig]
    public class DBColumn :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  DBColumn()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        String _caption;
        /// <summary>
        /// caption
        /// </summary>
[Display(Name = "caption")]
        [Column("caption")]
        public virtual String caption
        {
            get
            {
                return this._caption;
            }
            set
            {
                if ((this._caption != value))
                {
                    this.SendPropertyChanging("caption",this._caption,value);
                    this._caption = value;
                    this.SendPropertyChanged("caption");

                }
            }
        }

        String _Name;
        /// <summary>
        /// Name
        /// </summary>
[Display(Name = "Name")]
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

        System.Nullable<Boolean> _IsAutoIncrement=false;
        /// <summary>
        /// 自增长
        /// </summary>
[Display(Name = "自增长")]
        [Column("isautoincrement")]
        public virtual System.Nullable<Boolean> IsAutoIncrement
        {
            get
            {
                return this._IsAutoIncrement;
            }
            set
            {
                if ((this._IsAutoIncrement != value))
                {
                    this.SendPropertyChanging("IsAutoIncrement",this._IsAutoIncrement,value);
                    this._IsAutoIncrement = value;
                    this.SendPropertyChanged("IsAutoIncrement");

                }
            }
        }

        System.Nullable<Boolean> _CanNull=true;
        /// <summary>
        /// 可以为空
        /// </summary>
[Display(Name = "可以为空")]
        [Column("cannull")]
        public virtual System.Nullable<Boolean> CanNull
        {
            get
            {
                return this._CanNull;
            }
            set
            {
                if ((this._CanNull != value))
                {
                    this.SendPropertyChanging("CanNull",this._CanNull,value);
                    this._CanNull = value;
                    this.SendPropertyChanged("CanNull");

                }
            }
        }

        String _dbType;
        /// <summary>
        /// 数据库字段类型
        /// </summary>
[Display(Name = "数据库字段类型")]
        [Column("dbtype")]
        public virtual String dbType
        {
            get
            {
                return this._dbType;
            }
            set
            {
                if ((this._dbType != value))
                {
                    this.SendPropertyChanging("dbType",this._dbType,value);
                    this._dbType = value;
                    this.SendPropertyChanged("dbType");

                }
            }
        }

        String _Type;
        /// <summary>
        /// c#类型
        /// </summary>
[Display(Name = "c#类型")]
        [Column("type")]
        public virtual String Type
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

        String _EnumDefine;
        /// <summary>
        /// Enum定义
        /// </summary>
[Display(Name = "Enum定义")]
        [Column("enumdefine")]
        public virtual String EnumDefine
        {
            get
            {
                return this._EnumDefine;
            }
            set
            {
                if ((this._EnumDefine != value))
                {
                    this.SendPropertyChanging("EnumDefine",this._EnumDefine,value);
                    this._EnumDefine = value;
                    this.SendPropertyChanged("EnumDefine");

                }
            }
        }

        String _length;
        /// <summary>
        /// 长度
        /// </summary>
[Display(Name = "长度")]
        [Column("length")]
        public virtual String length
        {
            get
            {
                return this._length;
            }
            set
            {
                if ((this._length != value))
                {
                    this.SendPropertyChanging("length",this._length,value);
                    this._length = value;
                    this.SendPropertyChanged("length");

                }
            }
        }

        String _defaultValue;
        /// <summary>
        /// 默认值
        /// </summary>
[Display(Name = "默认值")]
        [Column("defaultvalue")]
        public virtual String defaultValue
        {
            get
            {
                return this._defaultValue;
            }
            set
            {
                if ((this._defaultValue != value))
                {
                    this.SendPropertyChanging("defaultValue",this._defaultValue,value);
                    this._defaultValue = value;
                    this.SendPropertyChanged("defaultValue");

                }
            }
        }

        System.Nullable<Int32> _TableID;
        /// <summary>
        /// TableID
        /// </summary>
[Display(Name = "TableID")]
        [Column("tableid")]
        public virtual System.Nullable<Int32> TableID
        {
            get
            {
                return this._TableID;
            }
            set
            {
                if ((this._TableID != value))
                {
                    this.SendPropertyChanging("TableID",this._TableID,value);
                    this._TableID = value;
                    this.SendPropertyChanged("TableID");

                }
            }
        }

        System.Nullable<Boolean> _IsPKID=false;
        /// <summary>
        /// 是否是主键
        /// </summary>
[Display(Name = "是否是主键")]
        [Column("ispkid")]
        public virtual System.Nullable<Boolean> IsPKID
        {
            get
            {
                return this._IsPKID;
            }
            set
            {
                if ((this._IsPKID != value))
                {
                    this.SendPropertyChanging("IsPKID",this._IsPKID,value);
                    this._IsPKID = value;
                    this.SendPropertyChanged("IsPKID");

                }
            }
        }

        System.Nullable<Int32> _orderid=0;
        /// <summary>
        /// orderid
        /// </summary>
[Display(Name = "orderid")]
        [Column("orderid")]
        public virtual System.Nullable<Int32> orderid
        {
            get
            {
                return this._orderid;
            }
            set
            {
                if ((this._orderid != value))
                {
                    this.SendPropertyChanging("orderid",this._orderid,value);
                    this._orderid = value;
                    this.SendPropertyChanged("orderid");

                }
            }
        }

        System.Nullable<Boolean> _IsDiscriminator=false;
        /// <summary>
        /// 是否是Discriminator字段
        /// </summary>
[Display(Name = "是否是Discriminator字段")]
        [Column("isdiscriminator")]
        public virtual System.Nullable<Boolean> IsDiscriminator
        {
            get
            {
                return this._IsDiscriminator;
            }
            set
            {
                if ((this._IsDiscriminator != value))
                {
                    this.SendPropertyChanging("IsDiscriminator",this._IsDiscriminator,value);
                    this._IsDiscriminator = value;
                    this.SendPropertyChanged("IsDiscriminator");

                }
            }
        }

        String _ClassName;
        /// <summary>
        /// 派生类的类名
        /// </summary>
[Display(Name = "派生类的类名")]
        [Column("classname")]
        public virtual String ClassName
        {
            get
            {
                return this._ClassName;
            }
            set
            {
                if ((this._ClassName != value))
                {
                    this.SendPropertyChanging("ClassName",this._ClassName,value);
                    this._ClassName = value;
                    this.SendPropertyChanged("ClassName");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 数据表权限
	/// </summary>
    [Table("tablepower")]
    [TableConfig]
    public class TablePower :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  TablePower()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<Int32> _UserID;
        /// <summary>
        /// UserID
        /// </summary>
[Display(Name = "UserID")]
        [Column("userid")]
        public virtual System.Nullable<Int32> UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if ((this._UserID != value))
                {
                    this.SendPropertyChanging("UserID",this._UserID,value);
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");

                }
            }
        }

        System.Nullable<Int32> _TableID;
        /// <summary>
        /// TableID
        /// </summary>
[Display(Name = "TableID")]
        [Column("tableid")]
        public virtual System.Nullable<Int32> TableID
        {
            get
            {
                return this._TableID;
            }
            set
            {
                if ((this._TableID != value))
                {
                    this.SendPropertyChanging("TableID",this._TableID,value);
                    this._TableID = value;
                    this.SendPropertyChanged("TableID");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 项目权限
	/// </summary>
    [Table("projectpower")]
    [TableConfig]
    public class ProjectPower :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  ProjectPower()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<Int32> _ProjectID;
        /// <summary>
        /// ProjectID
        /// </summary>
[Display(Name = "ProjectID")]
        [Column("projectid")]
        public virtual System.Nullable<Int32> ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                if ((this._ProjectID != value))
                {
                    this.SendPropertyChanging("ProjectID",this._ProjectID,value);
                    this._ProjectID = value;
                    this.SendPropertyChanged("ProjectID");

                }
            }
        }

        System.Nullable<Int32> _UserID;
        /// <summary>
        /// UserID
        /// </summary>
[Display(Name = "UserID")]
        [Column("userid")]
        public virtual System.Nullable<Int32> UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if ((this._UserID != value))
                {
                    this.SendPropertyChanging("UserID",this._UserID,value);
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 数据模块
	/// </summary>
    [Table("dbmodule")]
    [TableConfig]
    public class DBModule :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  DBModule()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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
        /// Name
        /// </summary>
[Display(Name = "Name")]
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

        System.Nullable<Int32> _DatabaseID;
        /// <summary>
        /// DatabaseID
        /// </summary>
[Display(Name = "DatabaseID")]
        [Column("databaseid")]
        public virtual System.Nullable<Int32> DatabaseID
        {
            get
            {
                return this._DatabaseID;
            }
            set
            {
                if ((this._DatabaseID != value))
                {
                    this.SendPropertyChanging("DatabaseID",this._DatabaseID,value);
                    this._DatabaseID = value;
                    this.SendPropertyChanged("DatabaseID");

                }
            }
        }

        System.Nullable<Boolean> _IsFolder=false;
        /// <summary>
        /// IsFolder
        /// </summary>
[Display(Name = "IsFolder")]
        [Column("isfolder")]
        public virtual System.Nullable<Boolean> IsFolder
        {
            get
            {
                return this._IsFolder;
            }
            set
            {
                if ((this._IsFolder != value))
                {
                    this.SendPropertyChanging("IsFolder",this._IsFolder,value);
                    this._IsFolder = value;
                    this.SendPropertyChanged("IsFolder");

                }
            }
        }

        System.Nullable<Int32> _parentID;
        /// <summary>
        /// parentID
        /// </summary>
[Display(Name = "parentID")]
        [Column("parentid")]
        public virtual System.Nullable<Int32> parentID
        {
            get
            {
                return this._parentID;
            }
            set
            {
                if ((this._parentID != value))
                {
                    this.SendPropertyChanging("parentID",this._parentID,value);
                    this._parentID = value;
                    this.SendPropertyChanged("parentID");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 级联删除
	/// </summary>
    [Table("dbdeleteconfig")]
    [TableConfig]
    public class DBDeleteConfig :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  DBDeleteConfig()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<Int32> _TableID;
        /// <summary>
        /// TableID
        /// </summary>
[Display(Name = "TableID")]
        [Column("tableid")]
        public virtual System.Nullable<Int32> TableID
        {
            get
            {
                return this._TableID;
            }
            set
            {
                if ((this._TableID != value))
                {
                    this.SendPropertyChanging("TableID",this._TableID,value);
                    this._TableID = value;
                    this.SendPropertyChanged("TableID");

                }
            }
        }

        System.Nullable<Int32> _RelaTableID;
        /// <summary>
        /// 关联表ID
        /// </summary>
[Display(Name = "关联表ID")]
        [Column("relatableid")]
        public virtual System.Nullable<Int32> RelaTableID
        {
            get
            {
                return this._RelaTableID;
            }
            set
            {
                if ((this._RelaTableID != value))
                {
                    this.SendPropertyChanging("RelaTableID",this._RelaTableID,value);
                    this._RelaTableID = value;
                    this.SendPropertyChanged("RelaTableID");

                }
            }
        }

        String _RelaTable_Desc;
        /// <summary>
        /// RelaTable_Desc
        /// </summary>
[Display(Name = "RelaTable_Desc")]
        [Column("relatable_desc")]
        public virtual String RelaTable_Desc
        {
            get
            {
                return this._RelaTable_Desc;
            }
            set
            {
                if ((this._RelaTable_Desc != value))
                {
                    this.SendPropertyChanging("RelaTable_Desc",this._RelaTable_Desc,value);
                    this._RelaTable_Desc = value;
                    this.SendPropertyChanged("RelaTable_Desc");

                }
            }
        }

        System.Nullable<Int32> _RelaColumID;
        /// <summary>
        /// 关联字段的ID
        /// </summary>
[Display(Name = "关联字段的ID")]
        [Column("relacolumid")]
        public virtual System.Nullable<Int32> RelaColumID
        {
            get
            {
                return this._RelaColumID;
            }
            set
            {
                if ((this._RelaColumID != value))
                {
                    this.SendPropertyChanging("RelaColumID",this._RelaColumID,value);
                    this._RelaColumID = value;
                    this.SendPropertyChanged("RelaColumID");

                }
            }
        }

        String _RelaColumn_Desc;
        /// <summary>
        /// RelaColumn_Desc
        /// </summary>
[Display(Name = "RelaColumn_Desc")]
        [Column("relacolumn_desc")]
        public virtual String RelaColumn_Desc
        {
            get
            {
                return this._RelaColumn_Desc;
            }
            set
            {
                if ((this._RelaColumn_Desc != value))
                {
                    this.SendPropertyChanging("RelaColumn_Desc",this._RelaColumn_Desc,value);
                    this._RelaColumn_Desc = value;
                    this.SendPropertyChanged("RelaColumn_Desc");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// TableInModule
	/// </summary>
    [Table("tableinmodule")]
    [TableConfig]
    public class TableInModule :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  TableInModule()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<Int32> _TableID;
        /// <summary>
        /// TableID
        /// </summary>
[Display(Name = "TableID")]
        [Column("tableid")]
        public virtual System.Nullable<Int32> TableID
        {
            get
            {
                return this._TableID;
            }
            set
            {
                if ((this._TableID != value))
                {
                    this.SendPropertyChanging("TableID",this._TableID,value);
                    this._TableID = value;
                    this.SendPropertyChanged("TableID");

                }
            }
        }

        System.Nullable<Int32> _ModuleID;
        /// <summary>
        /// ModuleID
        /// </summary>
[Display(Name = "ModuleID")]
        [Column("moduleid")]
        public virtual System.Nullable<Int32> ModuleID
        {
            get
            {
                return this._ModuleID;
            }
            set
            {
                if ((this._ModuleID != value))
                {
                    this.SendPropertyChanging("ModuleID",this._ModuleID,value);
                    this._ModuleID = value;
                    this.SendPropertyChanged("ModuleID");

                }
            }
        }

        System.Nullable<Int32> _x;
        /// <summary>
        /// x
        /// </summary>
[Display(Name = "x")]
        [Column("x")]
        public virtual System.Nullable<Int32> x
        {
            get
            {
                return this._x;
            }
            set
            {
                if ((this._x != value))
                {
                    this.SendPropertyChanging("x",this._x,value);
                    this._x = value;
                    this.SendPropertyChanged("x");

                }
            }
        }

        System.Nullable<Int32> _y;
        /// <summary>
        /// y
        /// </summary>
[Display(Name = "y")]
        [Column("y")]
        public virtual System.Nullable<Int32> y
        {
            get
            {
                return this._y;
            }
            set
            {
                if ((this._y != value))
                {
                    this.SendPropertyChanging("y",this._y,value);
                    this._y = value;
                    this.SendPropertyChanged("y");

                }
            }
        }

        String _flag;
        /// <summary>
        /// 临时变量
        /// </summary>
[Display(Name = "临时变量")]
        [Column("flag")]
        public virtual String flag
        {
            get
            {
                return this._flag;
            }
            set
            {
                if ((this._flag != value))
                {
                    this.SendPropertyChanging("flag",this._flag,value);
                    this._flag = value;
                    this.SendPropertyChanged("flag");

                }
            }
        }

        String _flag2;
        /// <summary>
        /// flag2
        /// </summary>
[Display(Name = "flag2")]
        [Column("flag2")]
        public virtual String flag2
        {
            get
            {
                return this._flag2;
            }
            set
            {
                if ((this._flag2 != value))
                {
                    this.SendPropertyChanging("flag2",this._flag2,value);
                    this._flag2 = value;
                    this.SendPropertyChanged("flag2");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 唯一值索引
	/// </summary>
    [Table("idxindex")]
    [TableConfig]
    public class IDXIndex :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  IDXIndex()
        {
        }


        System.Nullable<Int32> _id;
        /// <summary>
        /// id
        /// </summary>
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Display(Name = "id")]
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

        System.Nullable<Int32> _TableID;
        /// <summary>
        /// TableID
        /// </summary>
[Display(Name = "TableID")]
        [Column("tableid")]
        public virtual System.Nullable<Int32> TableID
        {
            get
            {
                return this._TableID;
            }
            set
            {
                if ((this._TableID != value))
                {
                    this.SendPropertyChanging("TableID",this._TableID,value);
                    this._TableID = value;
                    this.SendPropertyChanged("TableID");

                }
            }
        }

        String _Keys;
        /// <summary>
        /// Keys
        /// </summary>
[Display(Name = "Keys")]
        [Column("keys")]
        public virtual String Keys
        {
            get
            {
                return this._Keys;
            }
            set
            {
                if ((this._Keys != value))
                {
                    this.SendPropertyChanging("Keys",this._Keys,value);
                    this._Keys = value;
                    this.SendPropertyChanged("Keys");

                }
            }
        }

        System.Nullable<Boolean> _IsUnique=true;
        /// <summary>
        /// 是否唯一索引
        /// </summary>
[Display(Name = "是否唯一索引")]
        [Column("isunique")]
        public virtual System.Nullable<Boolean> IsUnique
        {
            get
            {
                return this._IsUnique;
            }
            set
            {
                if ((this._IsUnique != value))
                {
                    this.SendPropertyChanging("IsUnique",this._IsUnique,value);
                    this._IsUnique = value;
                    this.SendPropertyChanged("IsUnique");

                }
            }
        }

        System.Nullable<Boolean> _IsClustered=false;
        /// <summary>
        /// 是否聚焦
        /// </summary>
[Display(Name = "是否聚焦")]
        [Column("isclustered")]
        public virtual System.Nullable<Boolean> IsClustered
        {
            get
            {
                return this._IsClustered;
            }
            set
            {
                if ((this._IsClustered != value))
                {
                    this.SendPropertyChanging("IsClustered",this._IsClustered,value);
                    this._IsClustered = value;
                    this.SendPropertyChanged("IsClustered");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// Bug处理历史记录
	/// </summary>
    [Table("bughandlehistory")]
    [TableConfig]
    public class BugHandleHistory :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  BugHandleHistory()
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

        System.Nullable<Int32> _BugID;
        /// <summary>
        /// 
        /// </summary>
        [Column("bugid")]
        public virtual System.Nullable<Int32> BugID
        {
            get
            {
                return this._BugID;
            }
            set
            {
                if ((this._BugID != value))
                {
                    this.SendPropertyChanging("BugID",this._BugID,value);
                    this._BugID = value;
                    this.SendPropertyChanged("BugID");

                }
            }
        }

        System.Nullable<Int32> _UserID;
        /// <summary>
        /// 发标者ID
        /// </summary>
[Display(Name = "发标者ID")]
        [Column("userid")]
        public virtual System.Nullable<Int32> UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if ((this._UserID != value))
                {
                    this.SendPropertyChanging("UserID",this._UserID,value);
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");

                }
            }
        }

        Byte[] _content;
        /// <summary>
        /// 内容
        /// </summary>
[Display(Name = "内容")]
        [Column("content")]
        public virtual Byte[] content
        {
            get
            {
                return this._content;
            }
            set
            {
                if ((this._content != value))
                {
                    this.SendPropertyChanging("content",this._content,value);
                    this._content = value;
                    this.SendPropertyChanged("content");

                }
            }
        }

        System.Nullable<DateTime> _SendTime;
        /// <summary>
        /// 发表时间
        /// </summary>
[Display(Name = "发表时间")]
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
}}
namespace EJ{


    /// <summary>
	/// Bug附带截图
	/// </summary>
    [Table("bugimages")]
    [TableConfig]
    public class BugImages :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  BugImages()
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

        System.Nullable<Int32> _BugID;
        /// <summary>
        /// 
        /// </summary>
        [Column("bugid")]
        public virtual System.Nullable<Int32> BugID
        {
            get
            {
                return this._BugID;
            }
            set
            {
                if ((this._BugID != value))
                {
                    this.SendPropertyChanging("BugID",this._BugID,value);
                    this._BugID = value;
                    this.SendPropertyChanged("BugID");

                }
            }
        }

        Byte[] _content;
        /// <summary>
        /// 
        /// </summary>
        [Column("content")]
        public virtual Byte[] content
        {
            get
            {
                return this._content;
            }
            set
            {
                if ((this._content != value))
                {
                    this.SendPropertyChanging("content",this._content,value);
                    this._content = value;
                    this.SendPropertyChanged("content");

                }
            }
        }

        System.Nullable<Int32> _orderID;
        /// <summary>
        /// 排序
        /// </summary>
[Display(Name = "排序")]
        [Column("orderid")]
        public virtual System.Nullable<Int32> orderID
        {
            get
            {
                return this._orderID;
            }
            set
            {
                if ((this._orderID != value))
                {
                    this.SendPropertyChanging("orderID",this._orderID,value);
                    this._orderID = value;
                    this.SendPropertyChanged("orderID");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 引入的dll
	/// </summary>
    [Table("dllimport")]
    [TableConfig]
    public class DLLImport :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  DLLImport()
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

        String _path;
        /// <summary>
        /// dll文件路径
        /// </summary>
[Display(Name = "dll文件路径")]
        [Column("path")]
        public virtual String path
        {
            get
            {
                return this._path;
            }
            set
            {
                if ((this._path != value))
                {
                    this.SendPropertyChanging("path",this._path,value);
                    this._path = value;
                    this.SendPropertyChanged("path");

                }
            }
        }

        System.Nullable<Int32> _ProjectID;
        /// <summary>
        /// 
        /// </summary>
        [Column("projectid")]
        public virtual System.Nullable<Int32> ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                if ((this._ProjectID != value))
                {
                    this.SendPropertyChanging("ProjectID",this._ProjectID,value);
                    this._ProjectID = value;
                    this.SendPropertyChanged("ProjectID");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 接口设计的目录结构
	/// </summary>
    [Table("interfacemodule")]
    [TableConfig]
    public class InterfaceModule :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  InterfaceModule()
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

        System.Nullable<Int32> _ProjectID;
        /// <summary>
        /// 
        /// </summary>
        [Column("projectid")]
        public virtual System.Nullable<Int32> ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                if ((this._ProjectID != value))
                {
                    this.SendPropertyChanging("ProjectID",this._ProjectID,value);
                    this._ProjectID = value;
                    this.SendPropertyChanged("ProjectID");

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

        System.Nullable<Int32> _ParentID=0;
        /// <summary>
        /// 
        /// </summary>
        [Column("parentid")]
        public virtual System.Nullable<Int32> ParentID
        {
            get
            {
                return this._ParentID;
            }
            set
            {
                if ((this._ParentID != value))
                {
                    this.SendPropertyChanging("ParentID",this._ParentID,value);
                    this._ParentID = value;
                    this.SendPropertyChanged("ParentID");

                }
            }
        }

        System.Nullable<Boolean> _IsFolder=false;
        /// <summary>
        /// 
        /// </summary>
        [Column("isfolder")]
        public virtual System.Nullable<Boolean> IsFolder
        {
            get
            {
                return this._IsFolder;
            }
            set
            {
                if ((this._IsFolder != value))
                {
                    this.SendPropertyChanging("IsFolder",this._IsFolder,value);
                    this._IsFolder = value;
                    this.SendPropertyChanged("IsFolder");

                }
            }
        }

        System.Nullable<Int32> _LockUserId;
        /// <summary>
        /// 已经被某人锁定
        /// </summary>
[Display(Name = "已经被某人锁定")]
        [Column("lockuserid")]
        public virtual System.Nullable<Int32> LockUserId
        {
            get
            {
                return this._LockUserId;
            }
            set
            {
                if ((this._LockUserId != value))
                {
                    this.SendPropertyChanging("LockUserId",this._LockUserId,value);
                    this._LockUserId = value;
                    this.SendPropertyChanged("LockUserId");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 
	/// </summary>
    [Table("interfaceinmodule")]
    [TableConfig]
    public class InterfaceInModule :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  InterfaceInModule()
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

        System.Nullable<Int32> _ModuleID;
        /// <summary>
        /// 
        /// </summary>
        [Column("moduleid")]
        public virtual System.Nullable<Int32> ModuleID
        {
            get
            {
                return this._ModuleID;
            }
            set
            {
                if ((this._ModuleID != value))
                {
                    this.SendPropertyChanging("ModuleID",this._ModuleID,value);
                    this._ModuleID = value;
                    this.SendPropertyChanged("ModuleID");

                }
            }
        }

        System.Nullable<Int32> _x;
        /// <summary>
        /// 
        /// </summary>
        [Column("x")]
        public virtual System.Nullable<Int32> x
        {
            get
            {
                return this._x;
            }
            set
            {
                if ((this._x != value))
                {
                    this.SendPropertyChanging("x",this._x,value);
                    this._x = value;
                    this.SendPropertyChanged("x");

                }
            }
        }

        System.Nullable<Int32> _y;
        /// <summary>
        /// 
        /// </summary>
        [Column("y")]
        public virtual System.Nullable<Int32> y
        {
            get
            {
                return this._y;
            }
            set
            {
                if ((this._y != value))
                {
                    this.SendPropertyChanging("y",this._y,value);
                    this._y = value;
                    this.SendPropertyChanged("y");

                }
            }
        }

        String _Type;
        /// <summary>
        /// 
        /// </summary>
        [Column("type")]
        public virtual String Type
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

        String _JsonData;
        /// <summary>
        /// 
        /// </summary>
        [Column("jsondata")]
        public virtual String JsonData
        {
            get
            {
                return this._JsonData;
            }
            set
            {
                if ((this._JsonData != value))
                {
                    this.SendPropertyChanging("JsonData",this._JsonData,value);
                    this._JsonData = value;
                    this.SendPropertyChanged("JsonData");

                }
            }
        }

        System.Nullable<Int32> _width;
        /// <summary>
        /// 
        /// </summary>
        [Column("width")]
        public virtual System.Nullable<Int32> width
        {
            get
            {
                return this._width;
            }
            set
            {
                if ((this._width != value))
                {
                    this.SendPropertyChanging("width",this._width,value);
                    this._width = value;
                    this.SendPropertyChanged("width");

                }
            }
        }

        System.Nullable<Int32> _height;
        /// <summary>
        /// 
        /// </summary>
        [Column("height")]
        public virtual System.Nullable<Int32> height
        {
            get
            {
                return this._height;
            }
            set
            {
                if ((this._height != value))
                {
                    this.SendPropertyChanging("height",this._height,value);
                    this._height = value;
                    this.SendPropertyChanged("height");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// InterfaceModule权限设定表
	/// </summary>
    [Table("interfacemodulepower")]
    [TableConfig]
    public class InterfaceModulePower :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  InterfaceModulePower()
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

        System.Nullable<Int32> _UserID;
        /// <summary>
        /// 
        /// </summary>
        [Column("userid")]
        public virtual System.Nullable<Int32> UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if ((this._UserID != value))
                {
                    this.SendPropertyChanging("UserID",this._UserID,value);
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");

                }
            }
        }

        System.Nullable<Int32> _ModuleID;
        /// <summary>
        /// 
        /// </summary>
        [Column("moduleid")]
        public virtual System.Nullable<Int32> ModuleID
        {
            get
            {
                return this._ModuleID;
            }
            set
            {
                if ((this._ModuleID != value))
                {
                    this.SendPropertyChanging("ModuleID",this._ModuleID,value);
                    this._ModuleID = value;
                    this.SendPropertyChanged("ModuleID");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 
	/// </summary>
    [Table("classproperty")]
    [TableConfig]
    public class classproperty :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  classproperty()
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

        System.Nullable<Int32> _tableid;
        /// <summary>
        /// 
        /// </summary>
        [Column("tableid")]
        public virtual System.Nullable<Int32> tableid
        {
            get
            {
                return this._tableid;
            }
            set
            {
                if ((this._tableid != value))
                {
                    this.SendPropertyChanging("tableid",this._tableid,value);
                    this._tableid = value;
                    this.SendPropertyChanged("tableid");

                }
            }
        }

        String _name;
        /// <summary>
        /// 
        /// </summary>
        [Column("name")]
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

        System.Nullable<Int32> _foreignkey_tableid;
        /// <summary>
        /// 属性的类型
        /// </summary>
[Display(Name = "属性的类型")]
        [Column("foreignkey_tableid")]
        public virtual System.Nullable<Int32> foreignkey_tableid
        {
            get
            {
                return this._foreignkey_tableid;
            }
            set
            {
                if ((this._foreignkey_tableid != value))
                {
                    this.SendPropertyChanging("foreignkey_tableid",this._foreignkey_tableid,value);
                    this._foreignkey_tableid = value;
                    this.SendPropertyChanged("foreignkey_tableid");

                }
            }
        }

        System.Nullable<Int32> _foreignkey_columnid;
        /// <summary>
        /// 
        /// </summary>
        [Column("foreignkey_columnid")]
        public virtual System.Nullable<Int32> foreignkey_columnid
        {
            get
            {
                return this._foreignkey_columnid;
            }
            set
            {
                if ((this._foreignkey_columnid != value))
                {
                    this.SendPropertyChanging("foreignkey_columnid",this._foreignkey_columnid,value);
                    this._foreignkey_columnid = value;
                    this.SendPropertyChanged("foreignkey_columnid");

                }
            }
        }

        System.Nullable<Boolean> _iscollection=false;
        /// <summary>
        /// 
        /// </summary>
        [Column("iscollection")]
        public virtual System.Nullable<Boolean> iscollection
        {
            get
            {
                return this._iscollection;
            }
            set
            {
                if ((this._iscollection != value))
                {
                    this.SendPropertyChanging("iscollection",this._iscollection,value);
                    this._iscollection = value;
                    this.SendPropertyChanged("iscollection");

                }
            }
        }
}}
namespace EJ{


    /// <summary>
	/// 
	/// </summary>
    [Table("designhistory")]
    [TableConfig]
    public class DesignHistory :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  DesignHistory()
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

        System.Nullable<Int32> _DatabaseId;
        /// <summary>
        /// 
        /// </summary>
        [Column("databaseid")]
        public virtual System.Nullable<Int32> DatabaseId
        {
            get
            {
                return this._DatabaseId;
            }
            set
            {
                if ((this._DatabaseId != value))
                {
                    this.SendPropertyChanging("DatabaseId",this._DatabaseId,value);
                    this._DatabaseId = value;
                    this.SendPropertyChanged("DatabaseId");

                }
            }
        }

        System.Nullable<Int32> _ActionId;
        /// <summary>
        /// 
        /// </summary>
        [Column("actionid")]
        public virtual System.Nullable<Int32> ActionId
        {
            get
            {
                return this._ActionId;
            }
            set
            {
                if ((this._ActionId != value))
                {
                    this.SendPropertyChanging("ActionId",this._ActionId,value);
                    this._ActionId = value;
                    this.SendPropertyChanged("ActionId");

                }
            }
        }

        String _Type;
        /// <summary>
        /// 
        /// </summary>
        [Column("type")]
        public virtual String Type
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
}}
namespace EJ{


    /// <summary>
	/// 
	/// </summary>
    [Table("syslog")]
    [TableConfig]
    public class SysLog :Way.EntityDB.DataItem
    {

        /// <summary>
	    /// 
	    /// </summary>
        public  SysLog()
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

        System.Nullable<Int32> _DatabaseId;
        /// <summary>
        /// 
        /// </summary>
        [Column("databaseid")]
        public virtual System.Nullable<Int32> DatabaseId
        {
            get
            {
                return this._DatabaseId;
            }
            set
            {
                if ((this._DatabaseId != value))
                {
                    this.SendPropertyChanging("DatabaseId",this._DatabaseId,value);
                    this._DatabaseId = value;
                    this.SendPropertyChanged("DatabaseId");

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

        String _Type;
        /// <summary>
        /// 
        /// </summary>
        [Column("type")]
        public virtual String Type
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
}}

namespace EJ.DB{
    /// <summary>
	/// 
	/// </summary>
    public class easyjob : Way.EntityDB.DBContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="dbType"></param>
        public easyjob(string connection, Way.EntityDB.DatabaseType dbType): base(connection, dbType)
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
            var db =  sender as EJ.DB.easyjob;
            if (db == null)
                return;


                    if (e.DataItem is EJ.Project)
                    {
                        var deletingItem = (EJ.Project)e.DataItem;
                        
                    var items0 = (from m in db.Databases
                    where m.ProjectID == deletingItem.id
                    select new EJ.Databases
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

                    var items1 = (from m in db.DLLImport
                    where m.ProjectID == deletingItem.id
                    select new EJ.DLLImport
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
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items2 = (from m in db.InterfaceModule
                    where m.ProjectID == deletingItem.id
                    select new EJ.InterfaceModule
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items2.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items3 = (from m in db.ProjectPower
                    where m.ProjectID == deletingItem.id
                    select new EJ.ProjectPower
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items3.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    }

                    if (e.DataItem is EJ.Databases)
                    {
                        var deletingItem = (EJ.Databases)e.DataItem;
                        
                    var items0 = (from m in db.DBPower
                    where m.DatabaseID == deletingItem.id
                    select new EJ.DBPower
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

                    var items1 = (from m in db.DBTable
                    where m.DatabaseID == deletingItem.id
                    select new EJ.DBTable
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
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items2 = (from m in db.DBModule
                    where m.DatabaseID == deletingItem.id
                    select new EJ.DBModule
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items2.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    }

                    if (e.DataItem is EJ.User)
                    {
                        var deletingItem = (EJ.User)e.DataItem;
                        
                    var items0 = (from m in db.InterfaceModulePower
                    where m.UserID == deletingItem.id
                    select new EJ.InterfaceModulePower
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

                    var items1 = (from m in db.DBPower
                    where m.UserID == deletingItem.id
                    select new EJ.DBPower
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
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items2 = (from m in db.TablePower
                    where m.UserID == deletingItem.id
                    select new EJ.TablePower
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items2.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items3 = (from m in db.ProjectPower
                    where m.UserID == deletingItem.id
                    select new EJ.ProjectPower
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items3.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    }

                    if (e.DataItem is EJ.Bug)
                    {
                        var deletingItem = (EJ.Bug)e.DataItem;
                        
                    var items0 = (from m in db.BugHandleHistory
                    where m.BugID == deletingItem.id
                    select new EJ.BugHandleHistory
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

                    var items1 = (from m in db.BugImages
                    where m.BugID == deletingItem.id
                    select new EJ.BugImages
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
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    }

                    if (e.DataItem is EJ.DBTable)
                    {
                        var deletingItem = (EJ.DBTable)e.DataItem;
                        
                    var items0 = (from m in db.IDXIndex
                    where m.TableID == deletingItem.id
                    select new EJ.IDXIndex
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

                    var items1 = (from m in db.DBDeleteConfig
                    where m.TableID == deletingItem.id
                    select new EJ.DBDeleteConfig
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
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items2 = (from m in db.DBDeleteConfig
                    where m.RelaTableID == deletingItem.id
                    select new EJ.DBDeleteConfig
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items2.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items3 = (from m in db.DBColumn
                    where m.TableID == deletingItem.id
                    select new EJ.DBColumn
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items3.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items4 = (from m in db.TableInModule
                    where m.TableID == deletingItem.id
                    select new EJ.TableInModule
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items4.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items5 = (from m in db.TablePower
                    where m.TableID == deletingItem.id
                    select new EJ.TablePower
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items5.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    var items6 = (from m in db.classproperty
                    where m.tableid == deletingItem.id
                    select new EJ.classproperty
                    {
                        id = m.id
                    });
                    while(true)
                    {
                        var data2del = items6.Take(100).ToList();
                        if(data2del.Count() ==0)
                            break;
                        foreach (var t in data2del)
                    {
                        t.ChangedProperties.Clear();
                        db.Delete(t);
                        }
                    }

                    }

                    if (e.DataItem is EJ.DBColumn)
                    {
                        var deletingItem = (EJ.DBColumn)e.DataItem;
                        
                    var items0 = (from m in db.DBDeleteConfig
                    where m.RelaColumID == deletingItem.id
                    select new EJ.DBDeleteConfig
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

                    if (e.DataItem is EJ.InterfaceModule)
                    {
                        var deletingItem = (EJ.InterfaceModule)e.DataItem;
                        
                    var items0 = (from m in db.InterfaceInModule
                    where m.ModuleID == deletingItem.id
                    select new EJ.InterfaceInModule
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

                    var items1 = (from m in db.InterfaceModulePower
                    where m.ModuleID == deletingItem.id
                    select new EJ.InterfaceModulePower
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
   modelBuilder.Entity<EJ.Project>().HasKey(m => m.id);
modelBuilder.Entity<EJ.Databases>().HasKey(m => m.id);
modelBuilder.Entity<EJ.User>().HasKey(m => m.id);
modelBuilder.Entity<EJ.DBPower>().HasKey(m => m.id);
modelBuilder.Entity<EJ.Bug>().HasKey(m => m.id);
modelBuilder.Entity<EJ.DBTable>().HasKey(m => m.id);
modelBuilder.Entity<EJ.DBColumn>().HasKey(m => m.id);
modelBuilder.Entity<EJ.TablePower>().HasKey(m => m.id);
modelBuilder.Entity<EJ.ProjectPower>().HasKey(m => m.id);
modelBuilder.Entity<EJ.DBModule>().HasKey(m => m.id);
modelBuilder.Entity<EJ.DBDeleteConfig>().HasKey(m => m.id);
modelBuilder.Entity<EJ.TableInModule>().HasKey(m => m.id);
modelBuilder.Entity<EJ.IDXIndex>().HasKey(m => m.id);
modelBuilder.Entity<EJ.BugHandleHistory>().HasKey(m => m.id);
modelBuilder.Entity<EJ.BugImages>().HasKey(m => m.id);
modelBuilder.Entity<EJ.DLLImport>().HasKey(m => m.id);
modelBuilder.Entity<EJ.InterfaceModule>().HasKey(m => m.id);
modelBuilder.Entity<EJ.InterfaceInModule>().HasKey(m => m.id);
modelBuilder.Entity<EJ.InterfaceModulePower>().HasKey(m => m.id);
modelBuilder.Entity<EJ.classproperty>().HasKey(m => m.id);
modelBuilder.Entity<EJ.DesignHistory>().HasKey(m => m.id);
modelBuilder.Entity<EJ.SysLog>().HasKey(m => m.id);
}

        System.Linq.IQueryable<EJ.Project> _Project;
        /// <summary>
        /// 项目
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.Project> Project
        {
             get
            {
                if (_Project == null)
                {
                    _Project = this.Set<EJ.Project>();
                }
                return _Project;
            }
        }

        System.Linq.IQueryable<EJ.Databases> _Databases;
        /// <summary>
        /// 数据库
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.Databases> Databases
        {
             get
            {
                if (_Databases == null)
                {
                    _Databases = this.Set<EJ.Databases>();
                }
                return _Databases;
            }
        }

        System.Linq.IQueryable<EJ.User> _User;
        /// <summary>
        /// 系统用户
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.User> User
        {
             get
            {
                if (_User == null)
                {
                    _User = this.Set<EJ.User>();
                }
                return _User;
            }
        }

        System.Linq.IQueryable<EJ.DBPower> _DBPower;
        /// <summary>
        /// 数据库权限
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.DBPower> DBPower
        {
             get
            {
                if (_DBPower == null)
                {
                    _DBPower = this.Set<EJ.DBPower>();
                }
                return _DBPower;
            }
        }

        System.Linq.IQueryable<EJ.Bug> _Bug;
        /// <summary>
        /// 错误报告
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.Bug> Bug
        {
             get
            {
                if (_Bug == null)
                {
                    _Bug = this.Set<EJ.Bug>();
                }
                return _Bug;
            }
        }

        System.Linq.IQueryable<EJ.DBTable> _DBTable;
        /// <summary>
        /// 数据表
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.DBTable> DBTable
        {
             get
            {
                if (_DBTable == null)
                {
                    _DBTable = this.Set<EJ.DBTable>();
                }
                return _DBTable;
            }
        }

        System.Linq.IQueryable<EJ.DBColumn> _DBColumn;
        /// <summary>
        /// 字段
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.DBColumn> DBColumn
        {
             get
            {
                if (_DBColumn == null)
                {
                    _DBColumn = this.Set<EJ.DBColumn>();
                }
                return _DBColumn;
            }
        }

        System.Linq.IQueryable<EJ.TablePower> _TablePower;
        /// <summary>
        /// 数据表权限
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.TablePower> TablePower
        {
             get
            {
                if (_TablePower == null)
                {
                    _TablePower = this.Set<EJ.TablePower>();
                }
                return _TablePower;
            }
        }

        System.Linq.IQueryable<EJ.ProjectPower> _ProjectPower;
        /// <summary>
        /// 项目权限
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.ProjectPower> ProjectPower
        {
             get
            {
                if (_ProjectPower == null)
                {
                    _ProjectPower = this.Set<EJ.ProjectPower>();
                }
                return _ProjectPower;
            }
        }

        System.Linq.IQueryable<EJ.DBModule> _DBModule;
        /// <summary>
        /// 数据模块
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.DBModule> DBModule
        {
             get
            {
                if (_DBModule == null)
                {
                    _DBModule = this.Set<EJ.DBModule>();
                }
                return _DBModule;
            }
        }

        System.Linq.IQueryable<EJ.DBDeleteConfig> _DBDeleteConfig;
        /// <summary>
        /// 级联删除
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.DBDeleteConfig> DBDeleteConfig
        {
             get
            {
                if (_DBDeleteConfig == null)
                {
                    _DBDeleteConfig = this.Set<EJ.DBDeleteConfig>();
                }
                return _DBDeleteConfig;
            }
        }

        System.Linq.IQueryable<EJ.TableInModule> _TableInModule;
        /// <summary>
        /// TableInModule
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.TableInModule> TableInModule
        {
             get
            {
                if (_TableInModule == null)
                {
                    _TableInModule = this.Set<EJ.TableInModule>();
                }
                return _TableInModule;
            }
        }

        System.Linq.IQueryable<EJ.IDXIndex> _IDXIndex;
        /// <summary>
        /// 唯一值索引
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.IDXIndex> IDXIndex
        {
             get
            {
                if (_IDXIndex == null)
                {
                    _IDXIndex = this.Set<EJ.IDXIndex>();
                }
                return _IDXIndex;
            }
        }

        System.Linq.IQueryable<EJ.BugHandleHistory> _BugHandleHistory;
        /// <summary>
        /// Bug处理历史记录
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.BugHandleHistory> BugHandleHistory
        {
             get
            {
                if (_BugHandleHistory == null)
                {
                    _BugHandleHistory = this.Set<EJ.BugHandleHistory>();
                }
                return _BugHandleHistory;
            }
        }

        System.Linq.IQueryable<EJ.BugImages> _BugImages;
        /// <summary>
        /// Bug附带截图
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.BugImages> BugImages
        {
             get
            {
                if (_BugImages == null)
                {
                    _BugImages = this.Set<EJ.BugImages>();
                }
                return _BugImages;
            }
        }

        System.Linq.IQueryable<EJ.DLLImport> _DLLImport;
        /// <summary>
        /// 引入的dll
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.DLLImport> DLLImport
        {
             get
            {
                if (_DLLImport == null)
                {
                    _DLLImport = this.Set<EJ.DLLImport>();
                }
                return _DLLImport;
            }
        }

        System.Linq.IQueryable<EJ.InterfaceModule> _InterfaceModule;
        /// <summary>
        /// 接口设计的目录结构
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.InterfaceModule> InterfaceModule
        {
             get
            {
                if (_InterfaceModule == null)
                {
                    _InterfaceModule = this.Set<EJ.InterfaceModule>();
                }
                return _InterfaceModule;
            }
        }

        System.Linq.IQueryable<EJ.InterfaceInModule> _InterfaceInModule;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.InterfaceInModule> InterfaceInModule
        {
             get
            {
                if (_InterfaceInModule == null)
                {
                    _InterfaceInModule = this.Set<EJ.InterfaceInModule>();
                }
                return _InterfaceInModule;
            }
        }

        System.Linq.IQueryable<EJ.InterfaceModulePower> _InterfaceModulePower;
        /// <summary>
        /// InterfaceModule权限设定表
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.InterfaceModulePower> InterfaceModulePower
        {
             get
            {
                if (_InterfaceModulePower == null)
                {
                    _InterfaceModulePower = this.Set<EJ.InterfaceModulePower>();
                }
                return _InterfaceModulePower;
            }
        }

        System.Linq.IQueryable<EJ.classproperty> _classproperty;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.classproperty> classproperty
        {
             get
            {
                if (_classproperty == null)
                {
                    _classproperty = this.Set<EJ.classproperty>();
                }
                return _classproperty;
            }
        }

        System.Linq.IQueryable<EJ.DesignHistory> _DesignHistory;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.DesignHistory> DesignHistory
        {
             get
            {
                if (_DesignHistory == null)
                {
                    _DesignHistory = this.Set<EJ.DesignHistory>();
                }
                return _DesignHistory;
            }
        }

        System.Linq.IQueryable<EJ.SysLog> _SysLog;
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Linq.IQueryable<EJ.SysLog> SysLog
        {
             get
            {
                if (_SysLog == null)
                {
                    _SysLog = this.Set<EJ.SysLog>();
                }
                return _SysLog;
            }
        }

protected override string GetDesignString(){System.Text.StringBuilder result = new System.Text.StringBuilder(); 
result.Append("\r\n");
result.Append("H4sIAAAAAAAAC+1d63fTRhb/Vzjer7DHsmXL5rQfSLJsvaUsh9A9Pafp6RG2kniryKkkN+RQzgm7QAJdcCjJ8uiWV8Nj6dbpg0KwKfwzlmz/Fzsa+TEzki1Z9siTU3+BaPTw/Wnu/O6dmXuvzkZOiadlSYsc/vis/edxcUmKHI7Mfi7ndSlyMHKysGKfzejSkv1X65J8");
result.Append("Dpz+mygXwQGXSJ072Dmjry5L3XORaVUSdQk+/UhWzxeUCHJttqDokqIjl5+dsyWZixwGf+Zz4P/4wblIVly27gVHc5Hmg1f1b8pzEdBsPQa2nVALf5eyOmycEXXxtKhJmRlwKgYa8scK2c/A39Fz4GC6IBeXFA0cftz+AS5K/ILVij69dZzRjhT1QkbJqtISkBqc0tWi");
result.Append("ZD1TVI4XZbnbkDt9CrwF+17rQtD0J6W4NCPN5xW7GbblpHmxKOsQe7cV4ofCW8gz2on34UHr0QU1J6lQbACng4AjENiioxg6LU4U86KsecH4QlSzi6I6GijtH+xi4c59Yl0w89F0QZnPL8DusVsgUFRncq3uRTUwBm63lHVWB7pmvxkvlU3TVFme6A5z+0fzatmo3MD7");
result.Append("pK2pWkC9jTGqt7xvvXUf29Z9LqO71RxMgUeGx6m8MQQQz/pA9MASR7Akemlx/aeqcfcrHFZbxFF3ELBFs5L6haQeePcAYLk5xTZO4Aho/5zywSo4fjfuDp0bDDuPYE8S2Btv75rXHhk/3Kz/73Ft72ccO+CEWV2l2KmypCzoi/A4Fo2Oop8TCFaBwJqT5frWPXNj0/z3");
result.Append("eq36wth5RXS1LJ8QLXHCwMuNBm8SwZsiadPmWYw5O00hsE10MCgCAiXtQjezy2LWhXO6zUwSTwpFRcIytnZre2vm/fX6ToU0Dn8u9jRzg8JC1C4xYKeE7sAkozQdGJL6679U69V79a2n5sZL/PV/qElqMPclxqrbnfDrvsRIt7vx5OvGZcI4nCxYb3bUTGK8XjNK12uV");
result.Append("inH9VtsyGuWHoHvq3++av37V2N3unnznHXi+Y78b5TeN8gNjb8M+GTvw5QH0eda19fKD+uYl+36X+7607gPO25xie2z1aglcbj+Odzxu4JfuNr66bz3Guo+V8O0vxkgH+ISoaSvgUsIBRluZxBQPnf84mvxHun+dIWB++8/m7U1iGjd1orASmAV5Rlkw6ZsFHcaih5kY");
result.Append("2/wt6Z9bHB3v0t/d3h4tpZeeNXargEOBXZxTam/L5tYri1FHARGlHKGXbpOeFarLLPZb+JwTo8k5ZL80t243dnfNK4+M61fwjpkqLgQkmxSjZCP4JhtyagAmBc2Ht3AUp/L6UD7XsLZS8M03cdIHNkubtcpOY+0iORhni6eX8vpYaVTwzTFxzhWWefNF8+ZzN1yn8kM5");
result.Append("bGB4S3r7ERSgIaticdL7NHYuANfXpcfeE5WczG53IatdcdILNf+zZmxeM0pXm4833DrtmKjpgHxY7jJ0gcux4mP3mVH+l7m77YbvaF7Ja4ujVEpkaWEwHOjCFU/2k/HbDePy1fqVF+baeWJYAaNW1EavefZArldvExNQ6LPYCgNOdlisMzVFXri1dDvcOxFCN/xxmoY/");
result.Append("5eqQNR48JacZrRuDWP44q9OMlF/LHyenGZ2/URho43iMf8q/8U+yvpCR8m/xSe+VmDywM6lI+Tf1rG8UeEDhQ6dJniZNOjYFfrhpln8lOdLmvoAkmWaUJNN+SZKPskGSATYs0755k2c+2iXtmzd5cjrRWH9mPLzb3H6LA3LgCIztdH4Ixkn7Jk+nr1rarVUf1fYq9f9W");
result.Append("cGwdacPBxA2GCZkn8T3jemwuohIXQVkXkXkS7/Cw/uCGiG08yHyJJ/0r6+eM8p3aq8s4IlSMMCgxPhpKRAIBeMfi4fZbo/IYh9mWgNWuQ0IAeNL1alZvNco7xtprYnRhv7iPzFkawUp6HZ2HYKMOaQzfafYyzogLknAsad7aNTYfg39re9XmFhG4234ok+aMQ5yOBOl0");
result.Append("dC5D4aCNY5gQeOGJhT4jSNCcETgCtzsrJ27bdvDuIXZqE6yG28LX4Gt6kCCdMmQ/gY2tWhxL32lAgmefN73ghD8gk1QHJEmSdnSQ6ya6HdM9zHhMsDoeOd/jkfRQ8Uh3ZgLgcUT9R6XAPMVwrI1JgeqYjLsaSfPpA+Pbm+Tq2QeFXDHoFkOSY3U8+s6jSjIfWohj6TsS");
result.Append("k/H9siTvBQpZL0uSRj+jHS3I4EJyWoG0jmFi4YUIWShLkmZsWVSBlGQnYa3sdVH4ew1Uc04deVz1ypPG+S1j437z9g5JmjOSLOmSDTwgdSZZpU7fqXxJYR94455JHF04jpCRi78ABQBTSxLSSUkW2YaF0ie51tSR/tMZScv2QNY9Nyaj5z9pUYi69ltrff7OBbfegwOS");
result.Append("2d5D9h8E0sPqSK/06D7yJJv9lwjdeFDN/nYkztpvQkGca4IQ0VMDGw+B2XUp34lUQnwfGA//GUoC6T3Y3UviwVrZA4SYDYHU6DM4kjOMQkANA+lireIQVhmFgNI/6WLV9p6D6FWjdKu5XsLRzMviwjgJP+F701kgHS1L9JgTTYxhOMmw7ZdANfnXUfzATr8Gm6/15w+N");
result.Append("19vEVHvmo4ySk84ENF6shlzBl+DLeKWi+8B4+U+BS5FO5vvSqoZj6bQwU/3BCx9aosWxhGRvUNtK7qrh2odK/vOhAgzai0lkyLtncJIXMLRei2MlyQbWOH+nfoEIBclo03JR0yVVyoWBKjogqtBXkwSq2cSODNmp4kIrI+LaJaP0c6P8o/EboXTgEjuB6L28phfU1aCl");
result.Append("zYRgZNruExf+6XYjxOWzQFmcADcSKuydQYKL1pfwOEdYn1G6bt5fd0npGtm+VXDBsWJTpF4Zly4aZaJaT0tDhxF6SVyQhhQb5SlHXB5431bMhlt2oKTkwknD8gIQPiVRTTZ2JLqDIdm8fcHYe2xuPDO+eeMgo4ylBEEL1cEFIGos5NtT46AjHyYL+Xe7OGgTwx61A7hN");
result.Append("jjJh5rWvjQox74S3jvmlhl4WQKCaHeio1wD8U+PiI7CWnWvFzHe3oo4dyywtF1Q96DBN0xymvnP8OUdlKIDUrkXXeLlrvLmAo14eXS06lzjfXgD6D2ZYGYpK+E6fceGZnx/2uKCaDuaoZWHVZyx9Z9eoAqMDxJ0Bp7pevWHeJRQmA56uzotZaZhVdw6WoaI2WHynxXKw");
result.Append("hFTYquY/yZWDBY5ohM/0q9bnJSBq2KDn132Bo4uzGHha7CU16kTDOhQ04l1GLjVaVtWRUmu8/LleLTUefm/e26xVKs2t80b5Dj5crYEIJ165sep06JuUAtXYeVhIx0mJw21FctA3o0aKvtNgOWgLaWy09dEf/wmsHNS1ke6eBZcLo8L0qLfEgsuFkV2UUgKiy1Kzfwkx");
result.Append("YsMcvr9oBcUaPENIqUtnhn2DaAkcWOKnI99KPjeUzzx876JlbWBtko5si1J+YVEfq3Ch15cRqGZlOIqMEQ6wnZ4BHGdgeh1VZ4hrh8jX4GAFF1rGAYL0+dGBZMhrurhs/U1DPHzL5SVe6BPHFNXtbbhq3l1ok0VNW1YLy5KqB9xkAUsFFBUbiuuvNmIUM0IAhQw6gqrq");
result.Append("4MK5aXbYqtNvI29RVBYGUp2/yjl4eR9tOS6teF1S0BcldaI3g+uNIq24vjZs6quEs6LgJTFaYTeKOVvzBRW4NMpn0uqnLAxJxK+ORfkegmbhax+zpIh/HYvivoMGBJTBOtdwVYwCL3l4SW6vFWQh3+QQFbZaczBbhGwNkyJjVCkSLVPoIEf0ZC9anJQqDCuucVKqkO28");
result.Append("yN9bqULc3rNMof12fCde5v6ZnSDSTZzKiVO5D5zK/cOR/Xb/Jxw54UhaE29se/mnu+baEysaBBayrFUfNf/xXW3vGbQ+3ea9irF+CfeWJrP23+msff8QbILuPB77OLVzJo+d7jWXn3yievKJ6sknqiefqHZd3ph8ohozP5NPVE8+UU3/E9X7xb0Bm+pUgwCwGJAZSQMb");
result.Append("X0NlWsaiNEMfobg+gwCwAJIODsorbQN8YjWKBT/a/Tdm8bA5ZHocsYZeEqK7trCocEfC6aEzxXyEGnqJF3Z2JFhMpsoO2BiaXdWOFYJ+cRVWm6VGC/6/mwpnYqHTgv+UqRieIR5CwL+XcCgp4Ams4WQke8mHUUJiLKTl/xOjMTy9NRzS8vxEaNikRTvyAvn4mUvoBXK2");
result.Append("R2SVM8e3/e2OGbB4p+aX8ooIXCS3L69lNOyScazveSVg2InBrLq7cdZ1w5Fv+fxNfeseWEFvraNvXsU1YtoKhKST78fFBu17fox9Dw5bz45YvW//jeqAZY0tyOAY+BpATf4Iou6TPPwh7OqWXjivn9XVvLLgvKGrHP7vwTD1FO0TC5Z1dlbSWzcKR/lpfioZPZRITk0d");
result.Append("4qdSsUNH0nHuUBp872qKjwqJI0Iycu7/fkvOYHaUAAA=");
return result.ToString();}
}}
/*<design>
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
KIxwAAA=
<design>*/
