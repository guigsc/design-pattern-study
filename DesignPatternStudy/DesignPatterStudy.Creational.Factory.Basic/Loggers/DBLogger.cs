using DesignPatterStudy.Creational.Factory.Basic.Interfaces;
using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class DBLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"DB Logger: {message}");
        }
    }
}
