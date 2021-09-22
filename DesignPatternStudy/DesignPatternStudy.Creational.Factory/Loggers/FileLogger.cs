using System;

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
