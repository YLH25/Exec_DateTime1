using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //取得本月第一天
            DateTime today = DateTime.Now;
            DateTime day1 = new DateTime(today.Year, today.Month, 1);
            Console.WriteLine(day1.ToString("yyyy,MM,dd"));
        }
    }
}
