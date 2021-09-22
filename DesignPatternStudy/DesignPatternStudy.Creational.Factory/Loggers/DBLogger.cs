using System;

namespace DesignPatternStudy.Creational.Factory.Loggers
{
    public class DBLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("DB Logger");
        }
    }
}
