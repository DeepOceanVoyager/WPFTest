using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWPF
{
    public class NameToHumanTypeConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value)
        {
            Human child = new Human();
            if (value != null)
            {
                string? name = value.ToString();
                child.Name = name;
            }
            return child;
        }
    }
}
