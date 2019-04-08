using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    class EventLogLogger
    {
        public static void Log(string msg)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "ESENT";
                eventLog.WriteEntry(msg);
                Console.WriteLine("Log has been saved successfully to the event log");
            }
        }
    }
}
