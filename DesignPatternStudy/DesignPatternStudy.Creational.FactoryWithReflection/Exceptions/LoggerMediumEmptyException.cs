using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Exceptions
{
    public class LoggerMediumEmptyException : NotSupportedException
    {
        public LoggerMediumEmptyException() : base("Logger medium can not be null of empty")
        {
            
        }
    }
}
