
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

        System.Nullable<Boolean> _IsDiscriminator=false;
        /// <summary>
        /// 是否是Discriminator字段
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.Column("isdiscriminator")]
        [Way.EntityDB.WayDBColumnAttribute(Name="isdiscriminator",Comment="",Caption="是否是Discriminator字段",Storage = "_IsDiscriminator",DbType="bit")]
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
        [System.ComponentModel.DataAnnotations.Schema.Column("classname")]
        [Way.EntityDB.WayDBColumnAttribute(Name="classname",Comment="",Caption="派生类的类名",Storage = "_ClassName",DbType="varchar(120)")]
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
H4sIAAAAAAAAC81ce3PbVBb/Khnvvylrva0M/NEkZTEUpkNgd2c2O4wSK6nBkYMlQzPQmXS2pQW2TYB0+2BpabctXVgSHqWkDrRfJrKdb7H36HEfkizfOLJlmIFY0jnnd889j/s4935QmDUcY8GwzcLUB4VqpTAlThZONepvm4tOebYwJUwWXjNW0MuCadhrb9cXCpOF
ysIba6um9+Vi3ZpzGugtcJmYqzcbi+YL84XK1B9PoM9fri88V1mYLwBNrXbKcE6jLz+Yb8xbExPoI/RmCv1/dmoe/TNTr5g2/HHCcqrO2uw0/P0XY+05+vesaVeXLfjrVfR5zf8+ELRozxcmQ952dWW1Zvr80b/o6VkEonqyvvhOYUqR/UbNrRqL0LITL6N3f2pC4wva
i/KMPK0Wjynq9PQxebokHjuuS8IxXSoWp+WiphzX1MLZyQKS36yZdmHqb77WJKyn9tUf2pe33dYX3e2n3e07iHWoYdAn0lnZfrFeq5hIa06jaU4WVo2GaXnKLp6d9LnJmFsl7J0UNktGzWb4SCEfFfPp/LzX2bvtYzsUL4xJw7ymm8uDsdAxi7LlmI0lUP8g6hGKmJF7
u9W5s9698/BQiPSzf58svGEsRHpw0Vh1qnULsT2486TzJSgqEBN4RFxIYFJ0zxEu2BQIo5Dc7s9KoVn5/dfZeti+9Cvh9qaNmteXkZqIqf3VPw5ubFLIpk/V3+dhpzGK2rrR3dlpf3Lf/eyTQrqFRPmU4rD8fsSAvB7qz0inGbnfX2tv/0JzmanXmitWfzZgVQmAonry
QHGqShDiRhXlF5gWL0cpDrL98I771TW6yX504uDGmGun9U333JZ76euDG/dobrNmzXTMmbq1VOXoVoGxW09bZQsDopVIPe7HkzFhd2tnf3fdXf+t8+iu+9tVwrU8+9eyVTHP9GcoMiCRubr3znc2P3KvfORu/NTd/sH9nWKLXr9kWJWa+VLVduqNNQ72DF5Ef3DjvLv7
oH3pW/fLpwzj8oqxzBMMRMbrUKvdC/c7N8+jtEr11MmT5ZXVeoMjTIms81257278x89XiCkyUtT+zt4X7VvnC/GQzdtpYkK45+9yifHGiHDfhxBgd/smEzMi33E6laxgBos1w7ZXG/VVs+FwdLRMMqw/NuE2EZnk07k1+2Q9zbPCZBVqj0la/htEgXzZfx38OINSCOrm
NeQ+GpWe8Pdq/HtJVSIECkVQSiEoYQqVotDjFCr4BqKQ9BKVUDAFBOEoiQ4DNkSiYIoSTSElCPFliCU8EtJpigRNqaLkkxRlOh8QGiWh8Zrm0ciCTgd8QpOgYVUS/LYodETHJExbVI+iJPpCmKCNCZQ4gQTmjCg0goruRYAYk6H7jRexvgA7JtFoCs2jEIp+O1QRU9Aq
hvgaJZH1oFdIU0RaxWAYcZqiry7cFpHWMERFQgIddsbrdb/9AqYRe6k4IIE+8NqPKehOgWCZIMX3LVFUMRHdMRD9YkQaKB+IBEJE9w0EvZ6SZCJJYvw+wTRVybcaTcXmLNHoIG5FaYQiNBTQSdgMJBodhKyo5ciyrzpJESFMhRnYC1HoNzt4IHELAhOj39fNmsHoDh54
IzdPEyIJSHoaJSiQpZRIYKLbokVFKlFCgcyi1DRCNUaIXVulI5vSHyruX7WUQhgVKBJ5egoZWBNDp+AGasU0OiFKhzWq0SYlRejkWPMwGWPyUX1qsb7HfqypaYSlGCGRqKUQxhuI+0Eo0o4WNTaIkfjBWyj/L7JjUIZpiVa/FX4d8iIC5TSBcoLA2PicEQsmyCNWyVhs
KUkszZWIVlNE64mS8YyOkSnrfE3V0ppKWz/LgoxcGamaxCe1lCa12EtqOIBl7VPmE6mniISkERMZHfyyYQYyflwsGrHWTCSPjIDoYCInx65Ifya2kgkEWBw1RCYShRSJpUSJ4coCI1HilyimSITBRILIZPNRJW6ZdGTQj+6iEPSTXTT8BBJ66GwkdbPLJOgJnsd4f5ft
402nXrYWG+YKWm0LV/FmDOu1JpqsBj/DJeRCFX0yWThhNVdmzaWqBY9gtdhcMpo1589GrRk8oaN32T71Cvzps6o30BofAOux6uKBwxiDXzGUwRJhL5jvGY3F00ZjYKgBe4wVpzSwpBy1KXNoM2FhFH0fXb/yHh1WrUfBG1WpmLyolV/3p2Al0ywlcW228+Oee+tTAjsA
komC596tzZmN98zGxAsTwuS8hX5XHRP9ENGPV9fQzxck9Nepuu0sN0z4KcfbKXA2lEymmRWx7rNbsOb0/bXO/x7s7/5EGhrsJ2XZQzXTWvY2nsRiceAOI7N1Zh0OLb91tm63L222/3Vxf++xe+8J1WfBjtdQ2iIcoS1kdMssAvqrTST8BD+H4tJFTqgavbjA+rS/ecc4
dvgob+8u0csbOQZ3pX9wh9UUyi2/+bz7MeWNr9e9AUsGJuD+tu5ufLbfarmfXQ/ijrt9F+1ldb7baf/yaXfnKnn3/PPwOrKN6u5e8t+JEx9O0NzQpx20ao3W7j3qBLIPgQxCmp+7Onsb6GufmRxlxq3Qngkd1prGIfukYGVWuQjWU2jw/z76iErt5EnemCV6kS1Hn1I5
fIrduE3Ysh3NWEnlsVZ2bzi6NRnMy7IIABvfdnf2kNcVkSPuP9tubz0BFxy4BcSGmYSM3Z8eoVKzqXzVToy4lKsRaxxGzCTc9tcXD+5ep7Zvq85AmWGgqKBx2DG7W9je2Nxv3euuX6CtYK65sFJ1Rud+GofxwmZQFHb72uODa4+iuN+oDpQ6UPmQ6fik2UAnOwNMnvO3
zyMa9zfN81c32QJhiyf+ve5uXnE3Lh88uBRV+knDdlDYGAuVK/QOTo5Ro9Q/asB2EUEY/kVmd/jBSAJHiSdwqOMxXCvxRAsm1TFZLZdMV+IJE+MxxyzxRAc9V/fS+7uXXBy5e/Gvnugc3iaPycqszuFtMpPguhe/de/eOrj6jACOIj089oXqYe1Y53A52JGnMvPGzv7e
/f3dVue/LYI9RDQkzAInZux7cnLdrF/MmdlqaNa2gjMz7KZRjvmHKOIxwYtX/qD8g+AF5qiQbv/JxwQxJXAo4UQ6Qjgh1WxsKfLVZ27rAWlCICt/teP1QJlJhgd717vb91AZK2XZNP+xC+O4Bgt22qMlvtQohDwY+hAkLemQQnp2cnh9x918gP67v7t3sEXV+AeMcg7j
Ak6WCpMsww8wXPJg+MOnNLw4YSr5bmXCvnS/AZTCpEa8FjDypTkaa8/BEpR5jIeXpcEl3a/k2/0CR/czaY/euM5jL5tG3NsItDGxWIHDBFQhXxPgqA1Rx2R7hsbas/OhOGicJvxpoIkRMGELH8Kj0ix+MvxEm4aY1PcykQufEsSIqSe5qlimC5Lz9DOOqiGoOx2T5CXz
eBozMncv/Nw9t9W985CGTNfb5Qyb+BozEI8UAMaRh89HE+F46p+gCDGq92DSf/N8VPthXWLO2sduqDHpLlpLGYdujY3+8cKFlvOYnaNEBQqsxySS8NR/wJkIAhcfl8F4qSe5Ahbp0xgE8BmC9EzeEEmUYPLdGoG4ljdEEguYfLe/+wjtKLob1w8ubhC0SzVjeWTer/B4
P5P1AJ7IohXHAS5etdTy3aCBEtZ+wQpO+YxJsOIp/ykxGewVc80mWINfeRSvpmEXmYM8h+n/gFNEpeT8GEcuEmB4Th3eH7wnsTJ6Qeh9YgASe5bt5jBrAfxziO3msVUBrIKUiTuDbblV4b6FQXAQu2NLwNtXPndbVJD3CEapIHKWgK3nDm602P5ne+dqtLzlxapVtU8f
vaYoEazGU3oOBd1ZGjFHSZvAlmNXajW/ar/76477lLroYvWoVfuRzZZEkL3NHEqyM1uOTLYmntI0AQqZs+whjvIhAQqSh9x2nqIgAYqMs1oUxDAU1hh4Kn4EyAi4GPuIq1C0PtLWzNKQkWADISlL8+AofxHAcLOaRiVbB08RiwAKOvIc6dDyKaPQM5gAHVo+6Xoots2q
sCEyKORCQg6VQf1sgORlu27BavgAaBzzzEAaoa5wEbNb3s7CTSkNkYj6frUyUGIb0F5Iroe61QDDabO6fNoZHQhygAxKUzOMV+AD/U/Oqlnt1CU2nMbQO1pJww6aaTBI0GILQd1ff+rsbXTvfte+vbnfah1snUMFSGQIBnWhnsYqo8v+xJsjBXS/f+F+fLnzyeP2+jmC
cM4xnKadzUTer/vv7N2InJKDozJ+eTp6h880hMfnqOE9HN4dYDROnIMtv0MY2l9fjBTzD8OA0+a71HFuZoHS/eiCu00dsx3WVJBnXVJg6+iQ3uC+yOj5DdOqDGmmlQaSOnktx8uf/CsUY/cn2m9a1XcHKj3rm7sE3gUe6goyJQ68e+5m5zxV5Fe2Z2pN2zEbZmXoGTcN
NVG3zl5H6ikauVPnXot2J++64SFMK3g2O9G0NNNcCA7a9zwZ3B4TyAyvjMk0ltAgUlpOBmrWkCZ2aUDIqUW4WIqykh9vtde/gas3I4XDS/UGGjFZ75hrb41ca+S0IlxKFQe06O1pjhIRdjIR7qsKLdhGQGpoqWCwow+HCwFp6PAAQoQrrbL0L55Dx9RqOC4KyrpruE4U
w01XAZDjXqeMEgblYPrwJ6lpSIj3ULeVzww8WEmbo6bBIC4DFXxZGiXPIWK43WjYRsmzqCpS+zbDmFekgSAmSW3cDGlAmIaDMkhlBK7Bcx5XpLZ0huQaPOdqxciOTnhAYBallkZ1pWoZTr0RvVe+bDOvh5559BQzp7qWvdf70VN0PREaUwQji83LBP8M3PWX3eI22lzh
RSvDvXL0VYNV/7bYs/8HW/demoxkAAA=
<design>*/
