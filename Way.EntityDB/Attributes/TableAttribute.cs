using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Way.EntityDB.Attributes
{
    public class Table:Attribute
    {
        internal static Dictionary<Type, WayDBColumnAttribute[]> DataTypeColumns = new Dictionary<Type, WayDBColumnAttribute[]>();
        public string KeyName
        {
            get;
            set;
        }
        public string AutoSetPropertyNameOnInsert
        {
            get;
            set;
        }
        public object AutoSetPropertyValueOnInsert
        {
            get;
            set;
        }
        public Table( string keyname)
        {

            this.KeyName = keyname;
        }
    }
}
