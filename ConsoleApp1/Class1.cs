using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public record Product
    {
        readonly string Name;

        readonly string Description;

    }



    public class AppSetting
    {
        public string ReferenceKey { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
