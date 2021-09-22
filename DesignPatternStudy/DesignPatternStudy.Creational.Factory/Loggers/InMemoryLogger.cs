using System;

namespace DesignPatternStudy.Creational.Factory.Loggers
{
    public class InMemoryLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("In Memory Logger");
        }
    }
}
