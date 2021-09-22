using System;

namespace DesignPatternStudy.Creational.Factory
{
    public interface ILoggerFactory
    {
        ILogger this[string loggerMedium] => CreateLogger(loggerMedium);
        ILogger CreateLogger(string loggerMedium);
        void RegisterLogger(string loggerMedium, Func<ILogger> factoryMethod);
    }
}
