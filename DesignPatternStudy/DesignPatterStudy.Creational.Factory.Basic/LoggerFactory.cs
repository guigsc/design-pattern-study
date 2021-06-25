using DesignPatternStudy.Creational.Factory.Basic.Loggers;
using DesignPatterStudy.Creational.Factory.Basic.Interfaces;
using System;

namespace DesignPatterStudy.Creational.Factory.Basic
{
    public class LoggerFactory
    {
        private const string LoggerMediumNotFoundMessage = "Could not find a logger to create for logger medium: ";

        public ILogger CreateLogger(string loggerMedium)
        {
            switch(loggerMedium)
            {
                case "InMemory":
                    return new InMemoryLogger();
                case "File":
                    return new FileLogger();
                case "DB":
                    return new DBLogger();
                case "RemoteService":
                    return new RemoteServiceLogger();
                default:
                    throw new NotSupportedException($"{LoggerMediumNotFoundMessage}'{loggerMedium}'");
            }
        }
    }
}
