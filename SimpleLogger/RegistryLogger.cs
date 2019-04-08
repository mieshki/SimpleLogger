using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    class RegistryLogger
    {
        public static void Log(string msg)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SimpleLogger"))
            {
                key.SetValue("[" + DateTime.UtcNow + "]", msg);
                key.Close();
                Console.WriteLine("Log has been saved successfully to the registry");
            }
        }
    }
}
