using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Decorators
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class LoggerMediumAttribute : Attribute
    {
        public string LoggerMedium { get; set; }
        public LoggerMediumAttribute(string loggerMedium)
        {
            this.LoggerMedium = loggerMedium;
        }
    }
}
