using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class LegacyExtensions
    {
        public static string ToLegacyFormat(this DateTime dateTime)
        {
            return dateTime.Year > 1930 ? dateTime.ToString("1yyMMdd") : dateTime.ToString("0yyMMdd");
        }
    }
}
