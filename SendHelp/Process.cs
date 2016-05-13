using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendHelp
{
    public class Process
    {
        public static bool Execute(Action action)
        {
            try
            {
                action.Invoke();
                return true;
            }
            catch(Exception ex)
            {
                //写日志
                return false;
            }
            finally
            {

            }
        }
    }
}
