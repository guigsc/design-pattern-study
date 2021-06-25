using DesignPatternStudy.Creational.FactoryWithReflection.Enums;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection.Decorators
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class LoggerMediumAttribute : Attribute
    {
        public string LoggerMedium { get; set; }
        public LoggerMediumAttribute(LoggerEnum loggerMedium)
        {
            this.LoggerMedium = loggerMedium.ToString();
        }
    }
}
