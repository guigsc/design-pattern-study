using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Creational.FactoryWithReflection
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string loggerMedium);
    }
}
