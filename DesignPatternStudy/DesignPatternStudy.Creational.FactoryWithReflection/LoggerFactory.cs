using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using DesignPatternStudy.Creational.FactoryWithReflection.Extensions;
using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using System;
using System.Linq;

namespace DesignPatternStudy.Creational.FactoryWithReflection
{
    public class LoggerFactory : ILoggerFactory
    {
        private const string LoggerMediumEmptyMessage = "Logger medium can not be null of empty";
        private const string LoggerMediumNotFoundMessage = "Could not find a logger to create for logger medium: ";
        private const string LoggerMediumAttributeName = "LoggerMedium";

        public ILogger CreateLogger(string loggerMedium) 
        {
            if (string.IsNullOrEmpty(loggerMedium))
                throw new NotSupportedException(LoggerMediumEmptyMessage);

            var type = typeof(ILogger).GetImplementations().FirstOrDefault(t => t.HasCustomAttribute<LoggerMediumAttribute>(LoggerMediumAttributeName, loggerMedium));
            if (type == null)
                throw new NotSupportedException($"{LoggerMediumNotFoundMessage}'{loggerMedium}'");

            return Activator.CreateInstance(type) as ILogger;
        }
    }
}
