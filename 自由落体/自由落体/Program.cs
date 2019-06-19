using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自由落体
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 100, n = 10, sums = 0,sum1 = 0,sum2 = 0;
            for (int i = 1; i < n + 1; i++)
            {
                sum1 += h;
                sum2 += h / 2;
                h = h / 2;
                sums = sum1 + sum2;
                Console.WriteLine("第" + i + "次反弹的高度" + h); 
            }
            Console.WriteLine("共走了" + sums + "米");
            Console.ReadKey();
        }
    }
}
