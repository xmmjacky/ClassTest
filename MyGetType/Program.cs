using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGetType
{
   public class Program
    {
        public class NestedClass
        {
            public class DoubleNestedClass
            {
                //...
            }
        }
        static void Main(string[] args)
        {
            //Type guyType = typeof(Guy);
            //Console.WriteLine("{0}extend{1}", guyType.FullName, guyType.BaseType);
            #region 相等性比较
           
            Guy joe1 = new Guy("Joe", 37, 100);
            Guy joe2 = joe1;
            Console.WriteLine(object.ReferenceEquals(joe1, joe2));
            Console.WriteLine(joe1.Equals(joe2));
            Console.WriteLine(object.ReferenceEquals(null, null));
            Console.ReadKey();
            #endregion
        }
    }

    internal class Guy
    {
        //private string name;
        //private int age;
        //private int num;
         public Guy(string name,int age,int num)
        {
            this.Name = name;
            this.Age = age;
            this.Num = num;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public int Num { get; set; }
    }
}
