using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //根據日期，傳回今天是本月的上、中、下旬

            Console.WriteLine("請輸入今天幾號");
            DateTime today = DateTime.Now;
            DateTime dayOfNextMonth = today.AddMonths(1);
            DateTime fistdayOfNextMonth = new DateTime(today.Year, today.Month + 1, 1);
            DateTime lastdayOfThisMonth = fistdayOfNextMonth.AddDays(-1);
            Console.WriteLine(lastdayOfThisMonth.Day);

            string input = Console.ReadLine();
            int day = Convert.ToInt32(input);
            if (day <= 10)
            {
                Console.WriteLine("上旬");
            }
            else if (day < 10 && day < 20)
            {
                Console.WriteLine("中旬");
            }
            else if (day >= 20 && day <= lastdayOfThisMonth.Day)
            {
                Console.WriteLine("下旬");
            }
            else
            {
                Console.WriteLine("請重新輸入");
            }
        }
    }
}
