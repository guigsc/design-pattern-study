using DesignPatterStudy.Creational.Factory.Basic.Interfaces;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public abstract class Logger : ILogger
    {
        public abstract void Log(string message);
    }
}
