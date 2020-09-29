using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.Factory.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("File Logger");
        }
    }
}
