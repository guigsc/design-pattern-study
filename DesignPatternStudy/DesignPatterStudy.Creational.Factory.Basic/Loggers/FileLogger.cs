using DesignPatterStudy.Creational.Factory.Basic.Interfaces;
using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Logger: {message}");
        }
    }
}
