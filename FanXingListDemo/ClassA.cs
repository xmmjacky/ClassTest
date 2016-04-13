using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanXingListDemo
{
   public abstract class ClassA<T>
    {
        public abstract void Show();
    }

    public class AFactory:ClassA<string>
    {
        public override void Show()
        {
            Console.WriteLine("泛型初步尝试!");
        }
    }

    //public abstract class ClassB<T>
    //{
    //    public  abstract ClassA<T>  ReShow();
    //}

    //public class BFactory:ClassB<int>
    //{
    //    public override  ClassA<int> ReShow()
    //    {
    //        int A = 10;
    //        Console.WriteLine("A is {0}", A);
    //        return new BFactory().GetType();
    //    }
    //}
}
