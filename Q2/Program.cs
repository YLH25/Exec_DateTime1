using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算圖書下個月歸還時間

            DateTime now = DateTime.Now;
            DateTime returnTime = now.AddMonths(1);
            Console.WriteLine($"你的圖書歸還時間{returnTime}");
        }
    }
}
