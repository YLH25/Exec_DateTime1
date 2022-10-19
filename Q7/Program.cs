using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //根據時間不同,傳回不同問安方式

            Console.Write("請輸入現在幾點:");
            string input = Console.ReadLine();
            int hour = Convert.ToInt32(input);
            DateTime now = DateTime.Now;
            DateTime time = new DateTime(now.Year, now.Month, now.Day, hour, now.Minute, now.Second);
            if (string.IsNullOrEmpty(input) || hour > 24 || hour < 0)
            {
                Console.WriteLine("請重新輸入");
                return;
            }
            if (hour <= 10 && hour >= 4)
            {
                Console.WriteLine("早安");
            }
            if (hour > 10 && hour < 18)
            {

                Console.WriteLine("午安");
            }
            if (hour >= 18 || hour < 4)
            {
                Console.WriteLine("晚安");
            }
        }
    }
}
