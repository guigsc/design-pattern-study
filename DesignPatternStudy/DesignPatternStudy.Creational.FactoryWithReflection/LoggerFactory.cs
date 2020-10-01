using DesignPatternStudy.Creational.FactoryWithReflection.Decorators;
using System;
using System.Linq;

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

            var types = typeof(ILogger).Assembly.GetTypes()
                .Where(type => !type.IsAbstract && typeof(ILogger).IsAssignableFrom(type))
                .ToList();

            ILogger logger = null;
            foreach(var type in types)
            {
                object[] customAttributes = type.GetCustomAttributes(typeof(LoggerMediumAttribute), false);
                LoggerMediumAttribute attribute = (LoggerMediumAttribute)customAttributes.FirstOrDefault();

                if (attribute != null && attribute.LoggerMedium == loggerMedium.ToUpperInvariant())
                {
                    logger = Activator.CreateInstance(type) as ILogger;
                    break;
                }
            }

            if (logger == null)
            {
                string message = $"Could not find a logger to create for logger medium: '{loggerMedium}'";
                throw new NotSupportedException(message);
            }

            return logger;
        }
    }
}
