using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Loggers
{
    [LoggerMedium("FILE")]
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Logger: {message}");
        }
    }
}
