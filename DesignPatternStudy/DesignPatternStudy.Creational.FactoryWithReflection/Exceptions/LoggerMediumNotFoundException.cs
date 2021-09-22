using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Exceptions
{
    public class LoggerMediumNotFoundException : NotSupportedException
    {
        public LoggerMediumNotFoundException(string loggerMedium) : base($"Could not find a logger to create for logger medium: '{loggerMedium}'")
        {
            
        }
    }
}
