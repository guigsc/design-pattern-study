using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using DesignPatternStudy.Creational.FactoryWithReflection.Enums;
using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Loggers
{
    [LoggerMedium(LoggerEnum.File)]
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Logger: {message}");
        }
    }
}
