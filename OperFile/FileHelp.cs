using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OperFile
{
    public class FileHelp
    {
        private static object _lock;
        static FileHelp()
        {
            _lock = new object();
        }

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="sWord">要写入的文本内容</param>
        public static void Writetxt(bool isappend, string sWord, int type)
        {
            lock (_lock)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "data" + type + ".txt";
                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    fs.Close();
                }
                StreamWriter sw = new StreamWriter(path, isappend, System.Text.Encoding.Default);
                sw.Write(sWord);
                sw.Close();
            }
        }
        /// <summary>
        /// 文件读取
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static byte[] FileContent(string fileName)
        {
            fileName = AppDomain.CurrentDomain.BaseDirectory + fileName;
            lock (_lock)
            {
                var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                try
                {
                    var buffur = new byte[fs.Length];
                    fs.Read(buffur, 0, (int)fs.Length);

                    return buffur;
                }
                catch (Exception ex)
                {

                    return null;
                }
                finally
                {
                    //关闭资源   
                    fs.Close();
                }

            }

        }

        /// <summary>
        /// 文件读取返回字符串读取所有内容
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string ReadTxt(string fileName)
        {
            fileName = AppDomain.CurrentDomain.BaseDirectory + fileName + ".txt";
            lock (_lock)
            {
                string str = string.Empty;
                if (File.Exists(fileName))
                {
                    str = File.ReadAllText(fileName);
                }
                return str;
            }
        }
    }
}
