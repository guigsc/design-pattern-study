using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Loggers
{
    [LoggerMedium("REMOTE_SERVICE")]
    public class RemoteServiceLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Remote Service Logger: {message}");
        }
    }
}
