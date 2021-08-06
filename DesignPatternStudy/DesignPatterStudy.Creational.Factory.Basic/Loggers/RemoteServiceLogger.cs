using System;

namespace DesignPatternStudy.Creational.Factory.Basic.Loggers
{
    public class RemoteServiceLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"Remote Service Logger: {message}");
        }
    }
}
