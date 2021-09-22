using System;
using System.Collections.Generic;

namespace DesignPatternStudy.Creational.Factory
{
    public class LoggerFactory : ILoggerFactory
    {
        private readonly Dictionary<string, Func<ILogger>> loggers;

        public LoggerFactory()
        {
            loggers = new();
        }

        public ILogger this[string loggerMedium] => CreateLogger(loggerMedium);

        public ILogger CreateLogger(string loggerMedium) => loggers[loggerMedium]();

        public void RegisterLogger(string loggerMedium, Func<ILogger> factoryMethod)
        {
            if (string.IsNullOrEmpty(loggerMedium)) return;
            if (factoryMethod is null) return;

            loggers[loggerMedium] = factoryMethod;
        }
    }
}
