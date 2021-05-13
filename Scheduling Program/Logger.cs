using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C969___Seth_Meyer___Scheduling_Software
{
    class Logger
    {
        private static DateTime? _time;
        public static void SetTime(DateTime? Time)
        {
            _time = Time;
        }
        public static DateTime? GetTime()
        {
            return _time;
        }

        // This created a text file for logging purposes.
        public static void WriteUserLoginLog(string userName)
        {

            FileStream outp = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sr = new StreamWriter(outp))
            {
                sr.WriteLine("User Name: " + userName + " Logged in at : " + DateTime.Now.ToString());
                sr.Close();
            }
        }
    }
}
