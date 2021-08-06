using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class FileLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"File Logger: {message}");
        }
    }
}
