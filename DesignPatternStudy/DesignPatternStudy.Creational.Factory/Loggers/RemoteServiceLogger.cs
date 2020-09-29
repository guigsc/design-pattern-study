using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.Factory.Loggers
{
    public class RemoteServiceLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Remote Service Logger");
        }
    }
}
