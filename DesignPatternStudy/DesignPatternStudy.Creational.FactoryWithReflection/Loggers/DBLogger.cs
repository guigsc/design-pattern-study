using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using DesignPatternStudy.Creational.FactoryWithReflection.Enums;
using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Loggers
{
    [LoggerMedium(LoggerEnum.DB)]
    public class DBLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"DB Logger: {message}");
        }
    }
}
