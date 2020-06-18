using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAssistant.bases.utils
{
    public class TimeUtils
    {
        //时间戳转时间
        public static DateTime Stamp2DateTime(int timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime targetDt = dtStart.Add(toNow);
            return dtStart.Add(toNow); 
        }

        //时间转时间戳
        public static int DataTime2Stamp(DateTime dateTime)
        {
            DateTime dateStart = new DateTime(1970, 1, 1, 8, 0, 0);
            int timeStamp = Convert.ToInt32((dateTime - dateStart).TotalSeconds);
            return timeStamp;  
        }

        public static string DataTime2String(DateTime dateTime)
        {
            return dateTime.ToString("MM月dd日hh时");
        }

        public static string Stamp2String(int stamp)
        {
            return DataTime2String(Stamp2DateTime(stamp));
        }

    }
}
