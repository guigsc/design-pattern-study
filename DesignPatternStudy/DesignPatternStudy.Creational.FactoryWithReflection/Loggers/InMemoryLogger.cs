using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Loggers
{
    [LoggerMedium("MEMORY")]
    public class InMemoryLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In Memory Logger: {message}");
        }
    }
}
