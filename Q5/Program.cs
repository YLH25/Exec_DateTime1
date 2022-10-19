using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //列出指定年份的每個星期天
            Console.Write("請輸入指定年份");
            string input = Console.ReadLine();
            int year = Convert.ToInt32(input);
            DateTime firstdayOfYear = new DateTime(year, 01, 01);

            for (int i = 0; i < 365; i++)
            {
                DateTime day = firstdayOfYear.AddDays(i);
                if (day.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(day.ToString("yyyy,MM,dd"));
                }
            }
        }
    }
}
