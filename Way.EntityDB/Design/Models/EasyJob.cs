
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace EJ{


    /// <summary>
	/// 项目
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("project")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="Name",Storage = "_Name",DbType="varchar(50)")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("databases")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("projectid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="projectid",Comment="",Caption="项目ID",Storage = "_ProjectID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="Name",Storage = "_Name",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("dbtype")]
        [Way.EntityDB.WayDBColumnAttribute(Name="dbtype",Comment="",Caption="数据库类型",Storage = "_dbType",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("constr")]
        [Way.EntityDB.WayDBColumnAttribute(Name="constr",Comment="",Caption="连接字符串",Storage = "_conStr",DbType="varchar(200)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("dllpath")]
        [Way.EntityDB.WayDBColumnAttribute(Name="dllpath",Comment="",Caption="dll生成文件夹",Storage = "_dllPath",DbType="varchar(100)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("ilock")]
        [Way.EntityDB.WayDBColumnAttribute(Name="ilock",Comment="",Caption="iLock",Storage = "_iLock",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("namespace")]
        [Way.EntityDB.WayDBColumnAttribute(Name="namespace",Comment="",Caption="NameSpace",Storage = "_NameSpace",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("guid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="guid",Comment="",Caption="唯一标示ID",Storage = "_Guid",DbType="varchar(50)")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("user")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("role")]
        [Way.EntityDB.WayDBColumnAttribute(Name="role",Comment="",Caption="角色",Storage = "_Role",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="Name",Storage = "_Name",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("password")]
        [Way.EntityDB.WayDBColumnAttribute(Name="password",Comment="",Caption="Password",Storage = "_Password",DbType="varchar(50)")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("dbpower")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="用户",Storage = "_UserID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("power")]
        [Way.EntityDB.WayDBColumnAttribute(Name="power",Comment="",Caption="权限",Storage = "_Power",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("databaseid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="databaseid",Comment="",Caption="数据库ID",Storage = "_DatabaseID",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("bug")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("title")]
        [Way.EntityDB.WayDBColumnAttribute(Name="title",Comment="",Caption="标题",Storage = "_Title",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("submituserid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="submituserid",Comment="",Caption="提交者ID",Storage = "_SubmitUserID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("submittime")]
        [Way.EntityDB.WayDBColumnAttribute(Name="submittime",Comment="",Caption="提交时间",Storage = "_SubmitTime",DbType="datetime")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("handlerid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="handlerid",Comment="",Caption="处理者ID",Storage = "_HandlerID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("lastdate")]
        [Way.EntityDB.WayDBColumnAttribute(Name="lastdate",Comment="",Caption="最后反馈时间",Storage = "_LastDate",DbType="datetime")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("finishtime")]
        [Way.EntityDB.WayDBColumnAttribute(Name="finishtime",Comment="",Caption="处理完毕时间",Storage = "_FinishTime",DbType="datetime")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("status")]
        [Way.EntityDB.WayDBColumnAttribute(Name="status",Comment="",Caption="当前状态",Storage = "_Status",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("dbtable")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("caption")]
        [Way.EntityDB.WayDBColumnAttribute(Name="caption",Comment="",Caption="caption",Storage = "_caption",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="Name",Storage = "_Name",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("databaseid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="databaseid",Comment="",Caption="DatabaseID",Storage = "_DatabaseID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("ilock")]
        [Way.EntityDB.WayDBColumnAttribute(Name="ilock",Comment="",Caption="iLock",Storage = "_iLock",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("dbcolumn")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("caption")]
        [Way.EntityDB.WayDBColumnAttribute(Name="caption",Comment="",Caption="caption",Storage = "_caption",DbType="varchar(200)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="Name",Storage = "_Name",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("isautoincrement")]
        [Way.EntityDB.WayDBColumnAttribute(Name="isautoincrement",Comment="",Caption="自增长",Storage = "_IsAutoIncrement",DbType="bit")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("cannull")]
        [Way.EntityDB.WayDBColumnAttribute(Name="cannull",Comment="",Caption="可以为空",Storage = "_CanNull",DbType="bit")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("dbtype")]
        [Way.EntityDB.WayDBColumnAttribute(Name="dbtype",Comment="",Caption="数据库字段类型",Storage = "_dbType",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("type")]
        [Way.EntityDB.WayDBColumnAttribute(Name="type",Comment="",Caption="c#类型",Storage = "_Type",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("enumdefine")]
        [Way.EntityDB.WayDBColumnAttribute(Name="enumdefine",Comment="",Caption="Enum定义",Storage = "_EnumDefine",DbType="varchar(300)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("length")]
        [Way.EntityDB.WayDBColumnAttribute(Name="length",Comment="",Caption="长度",Storage = "_length",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("defaultvalue")]
        [Way.EntityDB.WayDBColumnAttribute(Name="defaultvalue",Comment="",Caption="默认值",Storage = "_defaultValue",DbType="varchar(200)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("tableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="tableid",Comment="",Caption="TableID",Storage = "_TableID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("ispkid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="ispkid",Comment="",Caption="是否是主键",Storage = "_IsPKID",DbType="bit")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("orderid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="orderid",Comment="",Caption="orderid",Storage = "_orderid",DbType="int")]
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
}}
namespace EJ{


    /// <summary>
	/// 数据表权限
	/// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("tablepower")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="UserID",Storage = "_UserID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("tableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="tableid",Comment="",Caption="TableID",Storage = "_TableID",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("projectpower")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("projectid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="projectid",Comment="",Caption="ProjectID",Storage = "_ProjectID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="UserID",Storage = "_UserID",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("dbmodule")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("name")]
        [Way.EntityDB.WayDBColumnAttribute(Name="name",Comment="",Caption="Name",Storage = "_Name",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("databaseid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="databaseid",Comment="",Caption="DatabaseID",Storage = "_DatabaseID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("isfolder")]
        [Way.EntityDB.WayDBColumnAttribute(Name="isfolder",Comment="",Caption="IsFolder",Storage = "_IsFolder",DbType="bit")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("parentid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="parentid",Comment="",Caption="parentID",Storage = "_parentID",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("dbdeleteconfig")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("tableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="tableid",Comment="",Caption="TableID",Storage = "_TableID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("relatableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="relatableid",Comment="",Caption="关联表ID",Storage = "_RelaTableID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("relatable_desc")]
        [Way.EntityDB.WayDBColumnAttribute(Name="relatable_desc",Comment="",Caption="RelaTable_Desc",Storage = "_RelaTable_Desc",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("relacolumid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="relacolumid",Comment="",Caption="关联字段的ID",Storage = "_RelaColumID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("relacolumn_desc")]
        [Way.EntityDB.WayDBColumnAttribute(Name="relacolumn_desc",Comment="",Caption="RelaColumn_Desc",Storage = "_RelaColumn_Desc",DbType="varchar(50)")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("tableinmodule")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("tableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="tableid",Comment="",Caption="TableID",Storage = "_TableID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("moduleid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="moduleid",Comment="",Caption="ModuleID",Storage = "_ModuleID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("x")]
        [Way.EntityDB.WayDBColumnAttribute(Name="x",Comment="",Caption="x",Storage = "_x",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("y")]
        [Way.EntityDB.WayDBColumnAttribute(Name="y",Comment="",Caption="y",Storage = "_y",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("flag")]
        [Way.EntityDB.WayDBColumnAttribute(Name="flag",Comment="",Caption="临时变量",Storage = "_flag",DbType="varchar(50)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("flag2")]
        [Way.EntityDB.WayDBColumnAttribute(Name="flag2",Comment="",Caption="flag2",Storage = "_flag2",DbType="varchar(50)")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("idxindex")]
    [Way.EntityDB.Attributes.Table("id")]
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
[System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("id")]
        [Way.EntityDB.WayDBColumnAttribute(Name="id",Comment="",Caption="id",Storage = "_id",DbType="int" ,IsPrimaryKey=true,IsDbGenerated=true)]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("tableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="tableid",Comment="",Caption="TableID",Storage = "_TableID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("keys")]
        [Way.EntityDB.WayDBColumnAttribute(Name="keys",Comment="",Caption="Keys",Storage = "_Keys",DbType="varchar(100)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("isunique")]
        [Way.EntityDB.WayDBColumnAttribute(Name="isunique",Comment="",Caption="是否唯一索引",Storage = "_IsUnique",DbType="bit")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("isclustered")]
        [Way.EntityDB.WayDBColumnAttribute(Name="isclustered",Comment="",Caption="是否聚焦",Storage = "_IsClustered",DbType="bit")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("bughandlehistory")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _BugID;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("bugid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="bugid",Comment="",Caption="",Storage = "_BugID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="发标者ID",Storage = "_UserID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("content")]
        [Way.EntityDB.WayDBColumnAttribute(Name="content",Comment="",Caption="内容",Storage = "_content",DbType="image")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("sendtime")]
        [Way.EntityDB.WayDBColumnAttribute(Name="sendtime",Comment="",Caption="发表时间",Storage = "_SendTime",DbType="datetime")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("bugimages")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _BugID;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("bugid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="bugid",Comment="",Caption="",Storage = "_BugID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("content")]
        [Way.EntityDB.WayDBColumnAttribute(Name="content",Comment="",Caption="",Storage = "_content",DbType="image")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("orderid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="orderid",Comment="",Caption="排序",Storage = "_orderID",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("dllimport")]
    [Way.EntityDB.Attributes.Table("id")]
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

        String _path;
        /// <summary>
        /// dll文件路径
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("path")]
        [Way.EntityDB.WayDBColumnAttribute(Name="path",Comment="",Caption="dll文件路径",Storage = "_path",DbType="varchar(200)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("projectid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="projectid",Comment="",Caption="",Storage = "_ProjectID",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("interfacemodule")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _ProjectID;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("projectid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="projectid",Comment="",Caption="",Storage = "_ProjectID",DbType="int")]
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

        System.Nullable<Int32> _ParentID=0;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("parentid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="parentid",Comment="",Caption="",Storage = "_ParentID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("isfolder")]
        [Way.EntityDB.WayDBColumnAttribute(Name="isfolder",Comment="",Caption="",Storage = "_IsFolder",DbType="bit")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("lockuserid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="lockuserid",Comment="",Caption="已经被某人锁定",Storage = "_LockUserId",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("interfaceinmodule")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _ModuleID;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("moduleid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="moduleid",Comment="",Caption="",Storage = "_ModuleID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("x")]
        [Way.EntityDB.WayDBColumnAttribute(Name="x",Comment="",Caption="",Storage = "_x",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("y")]
        [Way.EntityDB.WayDBColumnAttribute(Name="y",Comment="",Caption="",Storage = "_y",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("type")]
        [Way.EntityDB.WayDBColumnAttribute(Name="type",Comment="",Caption="",Storage = "_Type",DbType="varchar(100)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("jsondata")]
        [Way.EntityDB.WayDBColumnAttribute(Name="jsondata",Comment="",Caption="",Storage = "_JsonData",DbType="text")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("width")]
        [Way.EntityDB.WayDBColumnAttribute(Name="width",Comment="",Caption="",Storage = "_width",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("height")]
        [Way.EntityDB.WayDBColumnAttribute(Name="height",Comment="",Caption="",Storage = "_height",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("interfacemodulepower")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _UserID;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="",Storage = "_UserID",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("moduleid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="moduleid",Comment="",Caption="",Storage = "_ModuleID",DbType="int")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("classproperty")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _tableid;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("tableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="tableid",Comment="",Caption="",Storage = "_tableid",DbType="int")]
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

        System.Nullable<Int32> _foreignkey_tableid;
        /// <summary>
        /// 属性的类型
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("foreignkey_tableid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="foreignkey_tableid",Comment="",Caption="属性的类型",Storage = "_foreignkey_tableid",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("foreignkey_columnid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="foreignkey_columnid",Comment="",Caption="",Storage = "_foreignkey_columnid",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("iscollection")]
        [Way.EntityDB.WayDBColumnAttribute(Name="iscollection",Comment="",Caption="",Storage = "_iscollection",DbType="bit")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("designhistory")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _DatabaseId;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("databaseid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="databaseid",Comment="",Caption="",Storage = "_DatabaseId",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("actionid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="actionid",Comment="",Caption="",Storage = "_ActionId",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("type")]
        [Way.EntityDB.WayDBColumnAttribute(Name="type",Comment="",Caption="",Storage = "_Type",DbType="varchar(100)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("content")]
        [Way.EntityDB.WayDBColumnAttribute(Name="content",Comment="",Caption="",Storage = "_Content",DbType="text")]
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
    [System.ComponentModel.DataAnnotations.Schema.Table("syslog")]
    [Way.EntityDB.Attributes.Table("id")]
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

        System.Nullable<Int32> _DatabaseId;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("databaseid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="databaseid",Comment="",Caption="",Storage = "_DatabaseId",DbType="int")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("userid")]
        [Way.EntityDB.WayDBColumnAttribute(Name="userid",Comment="",Caption="",Storage = "_UserId",DbType="int")]
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

        String _Type;
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("type")]
        [Way.EntityDB.WayDBColumnAttribute(Name="type",Comment="",Caption="",Storage = "_Type",DbType="varchar(100)")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("content")]
        [Way.EntityDB.WayDBColumnAttribute(Name="content",Comment="",Caption="",Storage = "_Content",DbType="text")]
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
result.Append("H4sIAAAAAAAAC+1d7XPTRhr/VxjfV7ixbNmymfYDSY6rr5TLENrpTNPpCFtJfFXkVJIbMpSZcAck0IJDSY6XXnlreDl6dVpKIdgU/hlLtv+LW60ce3clW7LslTdTf4Fo9eLnp3329zy7+zyPzkROiqdkSYsc/uSM/edxcVGKHI7MfCHndSlyMHKisGyfzejSov1X65J8");
result.Append("Dpz+SJSL4IBLpM4ebJ/RV5akzrnIpCqJugSffiSr5wtKBLk2W1B0SdGRy8/M2pLMRg6DP/M58H/84GwkKy5Z94Kj2Ujz/qv6d+XZCGi2HgPbptXCP6SsDhunRF08JWpSZgqcioGG/LFC9nPwd/QsOJgsyMVFRQOHn+z9ABclfsFqRZ/eOs5oR4p6IaNkVWkRSA1O6WpR");
result.Append("sp4pKseLstxpyJ06Cd6Cfa91IWj6i1JcnJLm8ordDNty0pxYlHWIvdMK8UPhLeQZbfp9eNB6dEHNSSoUG8BpI+AIBLboKIZ2ixPFnChrXjC+FNXsgqgOB8reD3awcGc/tS6Y+niyoMzl52H32C0QKKozuVb3ohoYA7dbyjqjA12z34yXyqZpqixPdIe59bN5pWxUruN9");
result.Append("sqepWkC9jTGqt7xvvXUf29Z9LqO71RxMgYeGx6m8MQQQz/pA9MASR7Akumlx/ZeqcedrHNaeiMPuIGCLZiT1S0k98O4BwHKzim2cwBHQ/lnlgxVw/G7cHTrXH3YewZ4ksDfe3jGvPjR+ulH/36Pa7jMcO+CEGV2l2KmypMzrC/A4Fo0Oo58TCFaBwJqT5frmXXN9w/z3");
result.Append("Wq36wth+RXS1LE+Lljhh4OWGgzeJ4E2RtGnzLMac7aYQ2CbaHxQBgZJ2oZuZJTHrwjmdZiaJJ4WiImEZmzu13VXz3lp9u0Iah78Wu5q5fmEhapfos1NCd2CSUZoODEn99V+r9erd+uYTc/0l/vo/1CQ1mPsSY9XtTvh1X2Kk2914/G3jEmEcThSsNztsJjFerxqla7VK");
result.Append("xbh2c88yGuUHoHvqP+6Yv33d2NnqnHznHXi+bb8b5TeN8n1jd90+GTvw1QH0eda19fL9+sZF+36X+76y7gPO26xie2z1aglcbj+Odzyu75fuNr46bz3Guo+V8O0vxkgHeFrUtGVwKeEAo61MYoqHzn8cTf4j3b/2EDC//1fz1gYxjZuYLiwHZkGeURZM+mZBh7HoYiZG");
result.Append("Nn9L+ucWR8e79Hent4dL6aWnjZ0q4FBgF2eV2tuyufnKYtRhQEQpR+im26Rnheoyi/0WPufEaHIO2S/NzVuNnR3z8kPj2mW8YyaK8wHJJsUo2Qi+yYacGoBJQfPBTRzFybw+kM81qK0UfPNNnPSBzdJGrbLdWL1ADsaZ4qnFvD5SGhV8c0ycc4Vl3njRvPHcDdfJ/EAO");
result.Append("Gxjekr73CArQkFWxOOl9Gtvngevr0mPviUpOZre7kNWuOOmFmv9ZNTauGqUrzUfrbp12TNR0QD4sdxm6wOVY8bH7zCh/Y+5sueE7mlfy2sIwlRJZWugPB7pwxZP9ZPx+3bh0pX75hbl6jhhWwKgVteFrnj2Q69VbxAQU+iy2woCTbRZrT02RF24t3Q72ToTQDX+cpuFP");
result.Append("uTpkjftPyGlG68Yglj/O6jQj5dfyx8lpRvtvFAbaOBrjn/Jv/JOsL2Sk/Ft80nslJg/sTCpS/k096xsFHlD40GmSp0mTjk2Bn26Y5d9IjrS5LyBJphklybRfkuSjbJBkgA3LtG/e5JmPdkn75k2enE401p4aD+40t97igBw4AmM7lR+AcdK+ydPpq5Z2atWHtd1K/b8V");
result.Append("HFtb2nAwcf1hQuZJfNe4HpuLqMRFUNZFZJ7EOzysP7khYhsPMl/iSf/K+jmjfLv26hKOCBUjDEqMD4cSkUAA3rF4uPXWqDzCYe5JwGrXISEAPOl6Nas3G+VtY/U1MbqwX9xH5iyNYCW9jvZDsFGHNIbvNHsZZ8QFSTiWNG/uGBuPwL+13Wpzkwjc3Xsok+aMQ5yOBOl0");
result.Append("tC9D4aCNI5gQeOGJhT4jSNCcETgCt9srJ27bdvDuAXZqE6yG28LX4Gt6kCCdMmQ/gY2tWhxLz2lAgmefN73ghD8gk1QHJEmSdnSQ6ya6HdM9yHhMsDoeOd/jkfRQ8Uh3ZgLgcUS9R6XAPMVwrI1JgeqYjLsaSfPJfeP7G+Tq2QeFXDHoFkOSY3U8+s6jSjIfWohj6TkS");
result.Append("k/H9siTvBQpZL0uSRj+jHS3I4EJyWoG0jmBi4YUIWShLkmZsSVSBlGQnYa3sdVH4ew1Uc04deVz1yuPGuU1j/V7z1jZJmlOSLOmSDTwgdSZZpU7fqXxJYR94455JHB04jpCRC78CBQBTSxLSCUkW2YaF0ie51tSW/rMpSct2QdY5NyKj5z9pUYi69ltrff72ebfegwOS");
result.Append("2d5D9h8E0sNqS6906T7yJJv9lwjdeFDN/nYkztpvQkGca4IQ0VN9Gw+B2XUp34lUQnwfGA//GUoC6T3Y3UviwVrZA4SYDYHU6NM4ktOMQkANA+lireAQVhiFgNI/6WLVdp+D6FWjdLO5VsLRzMni/CgJP+F701kgHS1L9JgTTYxhOMmw7ZdANfnXUfzATr8Gm6/15w+M");
result.Append("11vEVHvq44ySk04HNF6shlzBl+DLeKWi+8B4+U+BS5FO5vvSioZjabcwU/3BCx9aosWxhGRvUNtK7qrh2odK/ouBAgz2FpPIkHfP4CQvYGi9FsdKkg2sce52/TwRCpLRJuWipkuqlAsDVbRPVKGvJglUs4kdGbITxflWRsTVi0bpWaP8s/E7oXTgEjuB6L28phfUlaCl");
result.Append("zYRgZLrXJy780+lGiMtngbI4AW4oVNg9gwQXrSfhcY6wPqN0zby35pLSNbR9q+CCY8WmSL0yLl4wykS1npaGDiL0ojgvDSg2ylOOuDzwvq2YDbfsQEnJhZOG5QUgfEqimmzsSHQHQ7J567yx+8hcf2p898ZBRhlLCYIWqoMLQNRYyLenxkFHPkwW8u92cdAmhj1q+3Cb");
result.Append("HGXCzKvfGhVi3glvHfFLDb0sgEA1O9BRrwH4p8aFh2AtO9eKme9sRR07lllcKqh60GGapjlMfef4c47KUACpXYuu8XLHeHMeR700vFp0LnG+3QD0HsywMhSV8J0e48IzPz/scUE1HcxRy8Kqz1j6wa5RBUYHiDsDTnW9et28QyhMBjxdnROz0iCr7hwsQ0VtsPhOi+Vg");
result.Append("CamwVc1/kisHCxzRCJ/pVa3PS0DUsEHPr/MChxdn0fe02Etq1ImGdShoxLsMXWq0rKojpdZ4+axeLTUe/Gje3ahVKs3Nc0b5Nj5crYEIJ165kep06JuUAtXYeVhIx0mJg21FctA3o0aKvtNgOWgLaWy09dAf/wmsHNS1oe6eBZcLo8L0sLfEgsuFkV2UUgKiy1Kzfwkx");
result.Append("YsMcvr9pBcUaPANIqUunB32DaAkcWOKnLd9yPjeQzzx476JlbWBtkrZsC1J+fkEfqXCh15cRqGZlOIqMEQ6wnZ4BHGdgeh1VZ4hrB8jX4GAFF1rGAYL0+dGBZMhrurhsvU1DPHzL5SVe6BPHFNXtbbhq3llok0VNW1ILS5KqB9xkAUsFFBUbiuuvNmIUM0IAhQw6gqrq");
result.Append("4MK5aXbYqtNrI29BVOb7Up2/yzl4eQ9tOS4te11S0Bckdaw3/euNIi27vjZs6quEs6LgJTFaYTeKOVtzBRW4NMrn0spnLAxJxK+ORfkugmbhax+xpIh/HYvivoMGBJTBOtdgVYwCL3l4SW6vFWQh3+QQFbZaczBbhGwNkyJjVCkSLVPoIEf0ZDdaHJcqDCuucVyqkO28");
result.Append("yD9aqULc3rNMob12fMde5v6ZnSDSjZ3KsVO5D5zK/cORvXb/xxw55khaE29se/mXO+bqYysaBBayrFUfNv/5Q233KbQ+nebdirF2EfeWxrP2P+isff8QbILuPB77OLVzJo+d7jaXH3+ievyJ6vEnqsefqHZd3hh/ohozP+NPVI8/UU3/E9X7xb0Bm+pUgwCwGJApSQMb");
result.Append("XwNlWsaiNEMfobg+gwCwAJI2DsorbX18YjWKBT/a/Tdi8bA5ZHoUsYZeEqK7trCocFvCyYEzxXyEGnqJF3Z2JFhMpsoO2BiaWdGOFYJ+cRVWm6VGC/6/mwpnYqHTgv+UqRieIR5CwL+XcCgp4Ams4WQke8mHUUJiJKTl/xOjMTy9NRzS8vxE6HBJCxy2GCBi0Zb9N0pe");
result.Append("1qizAIBjwCmA3/4MomuTPPwh7OoWoTmvn9HVvDLvvKHDav7vwTB1Fe1TC5Z1dkbSWzcKR/lJfiIZPZRITkwc4idSsUNH0nHuUBp812aCjwqJI0Iycvb/492GI16QAAA=");
return result.ToString();}
}}
/*<design>
H4sIAAAAAAAAC81ce3MbRRL/Ki7dvw5o35IL/ohjOAyBSuFwdVXnK0q21o5AXhntCuKCVDl1eQFHbMC5PDgSkktCDg6bdxwZyJfxSvK3uOnd1UzP7mo1lldaQRVYu9vdv+npxzx65v3cTMkpLZRsMzf1fq5Szk3Jk7lT9dpb5qIzO5ObkiZzr5VWyMucWbLX3qot5CZz
5YXTa6um9+VizZpz6uQtcJmYqzXqi+bz87ny1LOOaTvPvkBoXq4tPFNemM8BYbV6quScIZ+/P1+ftyYmyJfkzRT5/8zUPPknkPHMoj2fm+x+YldWVqum/xn5lzw9R3hVTtYW385NabIPcG61tAgoX3iZvPtzAxqSM15UT6jTev6Ypk9PH1OnC/Kx40VFOlZU8vlpNW9o
xw09d24y92qt3Kiadm7qb74GFNrm1rXvW59su83PO9t/dLbvEtZdbYFuiOhZ+8VatWwSDTj1hjmZWy3VTctTXP7cpM9NpdzKXU0nsFkqVW2Oj9Llo1M+7Z/22nt3fGyH4kUxGZTXdGN5MBZFymLWcsz6Eqh/EPVIecrIvdNs313v3H10KETFc3+fzJ0uLYR6cLG06lRq
FmF7cPdJ+wtQVCAmsO6okMCkcM8xLtQUGKMuud2flYZZ+f3X3nrUuvKYcXvDJs3ry0iPxdT68h8HNzcRsulTtfdE2BmcorZudnZ2Wh89cD/9KJdsIWE+hSgsvx8pIK+H+jMqYkbud9db279gLidq1caK1Z8NWFUMoLCePFCCqpKkqFGF+QWmJcpRiYJsPbrrfnkdN9mP
TgLcOHNtN7/unN9yr3x1cPM+5jZjVk3HPFGzlioC3Spxdutpa9aigLAS0eN+PDkTdrd29nfX3fXf2j/fc3+7xrjOzvx11iqbZ/szlDmQxFzd+xfam5fcq5fcjR8729+7vyO25PVLJatcNV+q2E6tvibAnsNL6A9uXnB3H7aufON+8QfHeHaltCwSDGTO60ir3YsP2rcu
kOyIeurkydmV1VpdIEzJvPNdfeBu/MfPV4QpMVLS/vbe563bF3LRkC3aaXJMuBfvcoXzxpBw34cIYHf7FhczQt8JOpWqUQaL1ZJtr9Zrq2bdEeholWXYGdOuLFvCJqKyfDq3Zp+sJXlWN1l1tcclLf8NoSC+7L8OfpwlKYR08xpxHwOlJ/q9Hv1e0bUQgYYICgkEBUqh
I4pilEKHjiUUSoGOUgxEAUE4TFLUVI9EK6DUwSiUGCG6RyAzGUVMEaMpXVZ8kryK8wGj0WIabxgejSoVccBnNDEa1hXJb4uGIzol4dqiexQF2RfCBW1KoEUJFDBnQmEwVLgXAWJERtFvvEz1BdgpiYEpDI9Cyvvt0GVKgVUM8TVMohaDXmFNkbGKIWhGaXxr0WhbZKxh
iIqMBDrsrNfrfvslSiP3UnFAAn3gtZ9S4E6BYBkjxfctWdYpEe4YiH4RIgOUD0QSI8J9A77RU5LKJCmc32u9vcxgpqlgdBC3wjRSHhoK6BRqBgpGByErbDmq6qtO0WQIU90M7IUo8psfPLC4BR2Ho8TrZrXE+Sc88AZuni2wMTH2fIDLEYLOOUJJZoGsmEQJ6uIpFRbQ
sA6MsEgtTCix2ZeeRKhHCGlI0LF2tP5QqV3ohQTCsECZySsmkIEVcnQaC9z5JDopTEc1amBTVEJ04c5n+jQ4Vwnr04j0PfV/Q08iLEQImUQjgTDaQNoPUh47aNjYILbSB2+SccMiP3blmBaw+q3u111eTKCaJFCNERgZ13NiwQRFxGopiy3EicVcmWg9QXQxVjKdCXIy
1aJYU42kpmLr51mwES8f0xQxqYUkqfleUrsDX94+VTGRxQSRkGwiIsODZj7MwEghKpaMdKsmkcdGTjiYqPGxK9Sfsa3kAgEVh4bWTKKUILEQK7G7IsFJVMQlygkSYRASIzLefHSln0wv+/qvWd7l1zjIEzoJ8f6etY83nNqstVg3V8hSWXcJ7kTJeq1BZprBz+5abq5C
PpnMvWA1VmbMpYoFj2DF1lwqNarOX0rVRvAEh9BZ+9Qr8KfPqlYnC3QArMeSiQeOYgx+RVAG63u9YL5bqi+eKdUHhhqwp1hpXoHuzFCbqoA2Y1Y1yffhxSfv0WHVehS8YZXK8StS2XV/AlY2R9JiF1bbP+y5tz9msAMgqSh47p3qnFl/16xPPD8hTc5b5HfFMckPmfx4
dY38fF4hf52q2c5y3YSfarSdkmBD2UyYW87qPL0NC0bfXW//7+H+7o+socHGTpo9VDWtZW/zR87nB+4wNtXmFtHI2ll7607rymbrX5f393517z9BfRbsOg2lLdIR2sKGmNwKnr9UxMJP8HMoLp0XhGrglQHep/2dN86xu4+y9u4CXpvIMLhr/YM7LIUgt/z6s86HyBtf
r3mjhhRMwP1t3d34dL/ZdD+9EcQdd/se2Yhqf7vT+uXjzs419u655+B1aA/U3b3iv5MnPpjA3MinbbLkTBbePeoYsg+ADEKan7vaexvka5+ZGmYmrNCeCR0WisYh+yRg5ZaoGNZTZAT+HvkIpXb2JGvMCl4hy9CndAGf4nddY/ZbRzNW0kWsld/YDe8rBpOjNALAxjed
nT3idXniiPtPt1tbT8AFB24Bs2EuIVP3xyNUNKXJVu3MiAuZGrEhYMRcwm19dfng3g2091pxBsoMA0UFQ8CO+a2+1sbmfvN+Z/0itoK5xsJKxRmd+xkCxgs7OWHYreu/Hlz/OYz7dGWg1EFqf0zHJ00HOlvW5/Kcv/cd0ri/4529ulW854HU/e91d/Oqu/HJwcMrYaWf
LNkOCRtjoXINb79kGDUK/aMG7PUwhN2/2OyOPhhJ4CiIBA59PIZrBZFowaU6LqtlkukKImFiPOaYBZHoUMzUvYr93UvNj9y9xFdPigLepo7JymxRwNtULsF1Ln/j3rt9cO0pAxxGenjsC5XD2nFRwOVgOx1l5o2d/b0H+7vN9n+bDHsX0ZAwS4KYqe+p8UWvfiVmaquh
adsKzcywpYUc809hxGOCl678Qe0GwwvMSRXc/pMPGWIkcCjhRDlCOGGlaHwd8bWnbvMha0IgK3u10/VAlUuGB3s3Otv3SQ0qsmzMf+zCOK0Dgu3ucH0uGoWwB0MfgiQlHVbxw08Ob+y4mw/Jf/d39w62UIF+wCjjMC7RZKlxybL7AYXLHgx/+JSElyZMOBOT4fgJ9qX7
DaA0LjXStYCRL81hrD0HS1BrMR5elgSXdb+WbfdLAt3PpT28cZ3FXjZG3NsIjDGxWEnABHQpWxMQqA3Rx2R7BmPt2flQoTNOE/4k0MwIuLBFT9ChNEufDD/RJiFmRbZc5KJH/Chi9CRTFau4KjhLPxOoGoLizzFJXqqIp3Ejc/fiT53zW527jzBkXGiXMWzma9xAPFT5
F0XefT6aCCdS/wTl32G9B5P+WxfC2u9WLmasfeqGBpfuwqWUUejW2OifLlwYGY/ZBUpUoMp5TCKJSP0HHExgcOlZF4oXPckUsIyPRDDAZxnSs1lDZFGCy3drDOJa1hBZLODy3f7uz2RH0d24cXB5g6FdqpaWR+b9moj3c1kP4Mk8Wnkc4NJVSyPbDRooYe0XrOCozZgE
K5HynwKXwV4x12yGNfiVRfFqEnaZO01zmP4POIVUyg5xCeQiCYbn6OT94D1JldELQu8TA5DY02y3gFlL4J9DbLeIrUpgFaxM3Blsy60ClyUMgoPZHV8C3rr6mdtEQd4jGKWC2FkCvp47uI5i+5+tnWvh8pYXK1bFPnP0mqJYsIZI6TkUdKdpxAIlbRJfjl2uVv2q/c7j
HfcPdEvF6lGr9kObLbEge5s5lGSnthwZb00ipWkSFDKn2UMC5UMSFCQPue0iRUESFBmntShIYWi8MYhU/EiQEWgx9hFXobA+ktbMkpCxYAMhKU3zECh/kcBw05pGxVuHSBGLBAo68hzp0PKRURRTmAAdWj7reii2TauwITQoFELCDpVB/WyA5GW7ZsFq+ABoHPPsQBpB
96/I6S1vp+GmSEMsor5XKQ+U2Aa0F5broW41wHDGrCyfcUYHgh0gg9LUFOMV+ED/k7N6Wjt1sQ3HGHpHK2XYQTMJBgtafCGo+/jH9t5G5963rTub+83mwdZ5UoDEhmBQF+pprDy67M+8OVRA9/vn7oeftD/6tbV+niGcc0pOw05nIu/X/bf3boZOycFRGb88nbyjZxq6
x+fQ8B4O7w4wGmfOwZffEQytry6HivmHYcBJ8110nJtboHQvXXS30THbYU0FRdYlJb6OjugNLnsMn98wrfKQZlpJINHJazVa/uTffxi5/NB+w6q8M1DpWd/cJYku8KD7w7Qo8M75W+0LqMhv1j5RbdiOWTfLQ8+4SaiZuov8XaKeook7te83sTt5dwUPYVohstlJpqWp
5kJw0L7nyeAKl0Bm996WVGMJBpHQcjZQs4Y0sUsCwk4twu1OyEp+uN1a/xruzQwVDi/V6mTEZL1trr05cq2x04pwM1QU0KK3pzlKRNTJZLg0qmvBNgFSJUsFgx19OFwISEJHBxAy3CuVpn+JHDpGq+G0KCjtrhE6UQzXTQVAjnudMkoYyMGKw5+kJiFh3oOuGj8x8GAl
aY6aBIO5DFTwpWmUIoeI4XajYRulyKKqjPZthjGvSALBTBJt3AxpQJiEAxmkNgLXMIRskgXKIblGAgwN7jfD985V/CtHz/0fWqF9951iAAA=
<design>*/
