using DesignPatterStudy.Creational.Factory.Basic.Interfaces;
using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class RemoteServiceLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Remote Service Logger: {message}");
        }
    }
}
