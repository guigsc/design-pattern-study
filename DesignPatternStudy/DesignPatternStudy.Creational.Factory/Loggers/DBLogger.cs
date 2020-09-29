using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.Factory.Loggers
{
    public class DBLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("DB Logger");
        }
    }
}
