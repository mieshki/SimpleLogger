using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    class Program
    {
        static void Main()
        {
            PrintMenu();
        }

        static void PrintMenu()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1. FileLogger, path = " + Environment.CurrentDirectory + "\\logs.txt");
            Console.WriteLine("2. RegistryLogger, path = HKEY_CURRENT_USER\\SOFTWARE\\SimpleLogger\\");
            Console.WriteLine("3. EventLogLogger, path = Dzienniki systemu Windows\\Aplikacja\\");
            Console.WriteLine("9. Close application");
            Console.WriteLine("------------------------------------------------------------");
            string input = Console.ReadLine();
            SelectLogDestination(input);
        }
        

        static void SelectLogDestination(string target)
        {
            string Choosed(string logDestination)
            {
                return $"Choosed {logDestination}, type log message: ";
            }

            switch (target)
            {
                case "1":
                    Console.Write(Choosed("File logger"));
                    FileLogger.Log(Console.ReadLine());
                    break;
                case "2":
                    Console.Write(Choosed("Registry logger"));
                    RegistryLogger.Log(Console.ReadLine());
                    break;
                case "3":
                    Console.Write(Choosed("EventLog logger"));
                    EventLogLogger.Log(Console.ReadLine());
                    break;
                case "9":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Wrong input, please try again.");
                    break;
            }

            PrintMenu();
        }
    }
}
