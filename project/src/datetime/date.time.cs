using System;

namespace MyDateTome
{
    public  class DateTimeUtils    {
        public static void convertTz()
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("UTC");
            var utcTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            System.Console.WriteLine(utcTime);

        }
        public static void showTimeZones()
        {
            var time = DateTimeOffset.Now;
            foreach(var tz in TimeZoneInfo.GetSystemTimeZones())
            {
                if(tz.GetUtcOffset(time) == time.Offset)
                {
                    System.Console.WriteLine(tz);
                }
            }
        }
    }
}