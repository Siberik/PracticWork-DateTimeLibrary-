using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLibrary
{
    public class DateTimeClass
    {
        public static string PrevDate(DateTime time)
        {
            //указывается год, месяц, день, час, минуту и секунду
            return time.AddDays(-1).ToString("yyyy-MM-dd");
        }
        public static string NextDate(DateTime time)
        {
            //указывается год, месяц, день, час, минуту и секунду
            return time.AddDays(1).ToString("yyyy-MM-dd");
        }
        public static string DaysUntilEndMonth(DateTime time)
        {
            //указывается год, месяц, день, час, минуту и секунду
            return  DateTime.DaysInMonth(time.Year,time.Month).ToString();
        }
    }
}
