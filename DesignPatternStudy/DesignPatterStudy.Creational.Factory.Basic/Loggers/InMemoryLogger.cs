using DesignPatterStudy.Creational.Factory.Basic.Interfaces;
using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class InMemoryLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In Memory Logger: {message}");
        }
    }
}
