using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductModle
{
    class Program
    {
        static void Main(string[] args)
        {
            LiveFactory liveFactory = new MusicFactory();
            Live musicLive = liveFactory.Create();
            musicLive.Action();
            Console.ReadKey();

            string strfactoryName = "BreadFactory";
            LiveFactory factory;
            factory = (LiveFactory)Assembly.Load("ProductModle").CreateInstance("ProductModle." + strfactoryName);
            Live live = factory.Create();
            live.Action();
            Console.ReadLine();
        }
    }
}
