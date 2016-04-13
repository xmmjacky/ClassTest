using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            long k = 0, g = 0, d = 0;
            float pai = 0.0F, x = 0.0F, y = 0.0F;
            var ro = new Random(10);
            long tick = DateTime.Now.Ticks;
            var seed = Guid.NewGuid().GetHashCode();
            var random = new System.Random((int)(tick& 0xffffffffL)|(int)(tick>>32)|seed);

            for (k = 1; k <= 1000000; k++)
            {
                d = d + 1;
                x = Convert.ToInt32(random.Next()) / 32767;
                y = Convert.ToInt32(random.Next()) / 32767;
                if (Math.Sqrt(x * x + y * y) > 1 && (Math.Sqrt((x - 1) * (x - 1) + y * y) > 1))
                    g = g + 1;
                Console.WriteLine("x的值：{0}", x);
                Console.WriteLine("y的值：{0}", y);
                Console.WriteLine("g的值：{0}", g);
            }
            pai = 4.0F * (float)g / d;
            Console.WriteLine("pai的值为：{0}", pai);
            Console.ReadKey();
        }
    }
}
