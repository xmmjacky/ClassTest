using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class ClassDemo
    {
        public void Test1()
        {
            Console.WriteLine("第一");
            test2 test = new test2();
            test.A = "1";
            test.B = "2";
        }
        public class test2
        {
            public string A { get; set; }
            public string B { get; set; }
        }


    }
    class ClaseeDemo2
    {
        ClassDemo testa = new ClassDemo();
        void test3()
        {
            var t2 = new ClassDemo.test2();
        }
    }


    public class Base
    {
        public virtual string AA() {
            return "1";
        }
    }

    public class Test1 : Base
    {
        public void DD()
        {
            Console.Write(AA());
        }
        public override string AA()
        {
            return base.AA();
        }
    }

    abstract class VirBase{
       public abstract int Inset();
    } 
}
