    using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Singleton
    {
        private static Singleton instance;




        public void mymethod()
        {
            Console.WriteLine("name is humna");

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();

                }
                return instance;
            }
        }


    }
    public class Logger
    {
        private static Logger instance;
        private List<string> logMessages = new List<string>();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void LogMessage(string message)
        {
            logMessages.Add(message);
        }

        public void PrintLogs()
        {
            foreach (string message in logMessages)
            {
                Console.WriteLine(message);
            }
        }
    }
    class loadbalancer
    {
        private static loadbalancer instance;


        private loadbalancer() { }

        public static loadbalancer Instance()
        {
            if (instance == null)
            {
                instance = new loadbalancer();

            }

            return instance;
        }


    }

    //public class logger
    //{
    //    private static logger instance;
    //    private string log;
    //    private logger()
    //    {
    //        log = string.Empty;
    //    }


    //    public static logger Instance()
    //    {
    //        if (instance == null)
    //        {
    //            instance = new logger();
    //        }
    //        return instance;
    //    }

    //    public void Logmessage(string message)
    //    {
    //        log += $"{DateTime.Now}: {message}\n";
    //    }

    //    public void printmessage()
    //    {
    //        Console.WriteLine("Application started");
    //        Console.WriteLine(log);
    //    }

    //}



}





