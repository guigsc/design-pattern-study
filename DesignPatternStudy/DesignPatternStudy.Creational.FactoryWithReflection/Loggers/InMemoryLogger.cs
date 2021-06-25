using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using DesignPatternStudy.Creational.FactoryWithReflection.Enums;
using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Loggers
{
    [LoggerMedium(LoggerEnum.InMemory)]
    public class InMemoryLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In Memory Logger: {message}");
        }
    }
}
