using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class DBLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"DB Logger: {message}");
        }
    }
}
