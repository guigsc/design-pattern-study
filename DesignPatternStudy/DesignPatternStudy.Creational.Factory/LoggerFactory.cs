using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.Factory
{
    public interface ILoggerFactory
    {
        ILogger this[string loggerMedium] => CreateLogger(loggerMedium);
        ILogger CreateLogger(string loggerMedium);
        void RegisterLogger(string loggerMedium, Func<ILogger> factoryMethod);
    }

    class LoggerFactory : ILoggerFactory
    {
        private readonly Dictionary<string, Func<ILogger>> loggers;

        public LoggerFactory()
        {
            loggers = new Dictionary<string, Func<ILogger>>();
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
