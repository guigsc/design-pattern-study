using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatternStudy.Creational.FactoryWithReflection.Extensions;

namespace DesignPatternStudy.Creational.FactoryWithReflection
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(string loggerMedium) 
        {
            if (string.IsNullOrEmpty(loggerMedium))
            {
                string message = "Logger medium can not be null of empty";
                throw new NotSupportedException(message);
            }

            var types = typeof(ILogger).GetImplementations();

            ILogger logger = FindLoggerInstance(types, loggerMedium);
            
            if (logger == null)
            {
                string message = $"Could not find a logger to create for logger medium: '{loggerMedium}'";
                throw new NotSupportedException(message);
            }

            return logger;
        }

        private ILogger FindLoggerInstance(List<Type> types, string loggerMedium)
        {
            foreach (var type in types)
            {
                object[] customAttributes = type.GetCustomAttributes(typeof(LoggerMediumAttribute), false);
                LoggerMediumAttribute attribute = (LoggerMediumAttribute)customAttributes.FirstOrDefault();

                if (attribute != null && attribute.LoggerMedium == loggerMedium.ToUpperInvariant())
                {
                    return Activator.CreateInstance(type) as ILogger;
                }
            }

            return null;
        }
    }
}
