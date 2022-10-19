using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算三天後DVD歸還時間
            DateTime now = DateTime.Now;
            DateTime returnTime = now.AddDays(3);
            Console.WriteLine($"你的DVD歸還時間{returnTime}");
        }
    }
}
