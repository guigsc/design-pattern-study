using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Loggers
{
    [LoggerMedium("DB")]
    public class DBLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"DB Logger: {message}");
        }
    }
}
