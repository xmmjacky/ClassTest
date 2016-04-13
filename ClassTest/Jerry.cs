using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Jerry
    {
        private static string str;
        static  Jerry( ) {
             str = "123";
        }
        public static void Show() {
            Console.WriteLine(str);
            Console.ReadKey();
        }

    }
}
