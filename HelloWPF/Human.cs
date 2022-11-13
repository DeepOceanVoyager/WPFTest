using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWPF
{
    [TypeConverter(typeof(NameToHumanTypeConverter))]
    public class Human
    {
        public string? Name { get; set; }
        //在.Net6中，声明的引用类型必须给初始值，如果不想给就需要加上问号，声明成可空类型
        public Human? Child { get; set; }
    }
}
