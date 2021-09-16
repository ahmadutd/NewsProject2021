using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNewsCms.Web.Helper
{
    public static class Helper
    {
        public static DateTime ToEuropianDateTime(this DateTime dateTime)
        {
            TimeZoneInfo europianZone = TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time");
            DateTime convertedDateTime = TimeZoneInfo.ConvertTime(dateTime, europianZone);
            return convertedDateTime;
        }
    }
}
