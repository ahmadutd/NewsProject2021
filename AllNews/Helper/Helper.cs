using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNews.Helper
{
    public static class Helper
    {
        public static DateTime ToEuropianDateTime(this DateTime dateTime)
        {
            TimeZoneInfo europianZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            DateTime convertedDateTime = TimeZoneInfo.ConvertTime(dateTime, europianZone);
            return convertedDateTime;
        }
    }
}
