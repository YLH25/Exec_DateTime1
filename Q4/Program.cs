using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //取得本月最後一天
            DateTime today = DateTime.Now;
            DateTime dayOfNextMonth = today.AddMonths(1);
            DateTime fistdayOfNextMonth = new DateTime(today.Year, today.Month + 1, 1);
            DateTime lastdayOfThisMonth = fistdayOfNextMonth.AddDays(-1);
            Console.WriteLine(lastdayOfThisMonth.ToString("yyyy,MM,dd"));
        }
    }
}
