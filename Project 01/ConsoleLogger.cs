using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    public class ConsoleLogger
    {
        public void LogLine (String message)
        {
            Console.WriteLine (message);
        }

        public void Log(String message)
        {
            Console.Write(message);
        }

    }
}
