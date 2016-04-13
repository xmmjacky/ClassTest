using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        //static Program() { }
        static readonly int A = B * 10;
        static readonly int B = 10;
        public Program()
        {
             //A = A + B;
             //B = B + A;
        }
       public static void Main(string[] args)
        {
            Console.WriteLine("A is {0},B is {1}", A, B);
            Console.ReadKey();
            int bits = Convert.ToInt32("11", 16);
            Console.WriteLine("Old Bits is {0}",bits);
            for (int i=0;i< 5;i++)
            {
                bits <<= 2;
                Console.WriteLine("第{0}次 Bits is {1}",i,bits);
            }
            
            Console.ReadKey();

            //Program p = new Program();
            //p.GreetPeople("1123");
            //new Program().GreetPeople("Jacky");
            //new Program().Test();

            #region 对象转Json字符串
            #endregion
        }
        //public void GreetPeople(string name)
        //{
        //    EnglishGreeting(name);
        //}
        //public void EnglishGreeting(string name)
        //{
        //    Console.WriteLine("Morning,"+ name);
        //    Console.ReadKey();
        //}
        //public void ChineseGreeting(string name)
        //{
        //    Console.WriteLine("早上好，" + name);
        //    Console.ReadKey();
        //}
        //public void Test()
        //{
        //    Jerry.Show();
        //}
    }
}
