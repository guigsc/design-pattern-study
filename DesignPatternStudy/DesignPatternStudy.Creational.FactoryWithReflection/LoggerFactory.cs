using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using DesignPatternStudy.Creational.FactoryWithReflection.Exceptions;
using DesignPatternStudy.Creational.FactoryWithReflection.Extensions;
using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using System;
using System.Linq;

namespace DesignPatternStudy.Creational.FactoryWithReflection
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(string loggerMedium) 
        {
            if (string.IsNullOrEmpty(loggerMedium))
                throw new LoggerMediumEmptyException();

            var type = typeof(ILogger).GetImplementations<ILogger>().FirstOrDefault(t => t.HasCustomAttribute<LoggerMediumAttribute>(loggerMedium));
            if (type == null)
                throw new LoggerMediumNotFoundException(loggerMedium);

            return Activator.CreateInstance(type) as ILogger;
        }
    }
}
