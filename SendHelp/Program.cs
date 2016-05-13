using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SendHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendHelp.SendEmail("test", "wenben", "zhanglonghao@aidaijia.com", "", "", System.Net.Mail.MailPriority.Low);
            //SendHelp.SendMail("test", "测试测试测试！", "wangxixing@aidaijia.com", "");
            MyMain();

        }

        public static void MyMain()
        {
            var result = false;
            Process.Execute(() => result = Save(new AccountModel()));
        }
        public static Boolean Save(AccountModel model)
        {
            var ret = false;
            ret = true;
            return ret;
        }
    }


    class AccountModel
    {
        public string Age { get; set; }
        public string name { get; set; }
    }

    public sealed class DataAccess<T> where T : IBase
    {
        private static readonly string datacenterPath = "111";
        private static readonly string namesspace = "2222";
        private static object lockHelper = new object();
        private static T obj = default(T);
        public static T CreateInstance(object type)
        {
            string className = namesspace + "." + typeof(T).Name.Substring(1);
            if (obj == null)
            {
                lock (lockHelper)
                {
                    obj = (T)Assembly.Load(datacenterPath).CreateInstance(className);
                }
            }
            return obj;
        }
    }
}
