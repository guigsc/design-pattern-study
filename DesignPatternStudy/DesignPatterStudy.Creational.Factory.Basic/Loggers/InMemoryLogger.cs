using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class InMemoryLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"In Memory Logger: {message}");
        }
    }
}
