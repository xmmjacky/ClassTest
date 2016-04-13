using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModle
{
   
    public abstract class Live
    {
        public abstract void Action();
    }
    public class Music : Live
    {
        public override void Action()
        {
            Console.WriteLine("哈嘿哈嘿");
        }
    }
    public class Bread:Live
    {
        public override void Action()
        {
            Console.WriteLine("努力！");
        }
    }

    public abstract class LiveFactory
    {
        public abstract Live Create();
    }
    public class MusicFactory:LiveFactory
    {
        public override Live Create()
        {
            return new Music();
        }
    }

    public class BreadFactory:LiveFactory
    {
        public override Live Create()
        {
            return new Bread();
        }
    }
}
