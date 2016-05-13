using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OperFile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 读写文本文件操作
            //var str1 = FileHelp.ReadTxt("data2");
            //var data = DateTime.Now.ToString();
            //FileHelp.Writetxt(false, data, 1);
            //Console.WriteLine("文件已写入...");
            //var str = FileHelp.ReadTxt("data1");
            //Console.WriteLine("文件读书的内容：" + str);
            //Console.ReadKey();
            #endregion

            #region 读写锁的操作
            ReaderWriterLockSlim
            #endregion
        }
    }
}
