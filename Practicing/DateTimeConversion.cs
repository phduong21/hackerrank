using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    public class DateTimeConversion
    {
        public static string timeConversion(string s)
        {
            return Convert.ToDateTime(s).ToString("HH:mm:ss");
        }

    }
}
