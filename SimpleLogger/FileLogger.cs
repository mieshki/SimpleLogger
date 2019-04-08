using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    class FileLogger
    {
        public static void Log(string msg)
        {
            string projectDirectory = Environment.CurrentDirectory + "\\logs.txt";

            using (StreamWriter sw = File.AppendText(projectDirectory))
            {
                sw.WriteLine("[" + DateTime.UtcNow + "] " + msg);
                Console.WriteLine("Log has been saved successfully to the file");
            }
        }
    }
}
