using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EJClient.Forms.DBTableEditor;

namespace EJClient.Designer
{
	internal class ClassName
	{
		public string Name;
		public string BaseName;
	}
	internal class ClassNameTypeConvert : System.ComponentModel.TypeConverter
	{
		internal static List<ClassName> EnumNames;
		public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}

		public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
		{
			

			StandardValuesCollection svc = new StandardValuesCollection((from m in EnumNames orderby m.Name select m.Name).ToArray());
			return svc;
		}

		public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
		{
			return false;
		}

	}
}
