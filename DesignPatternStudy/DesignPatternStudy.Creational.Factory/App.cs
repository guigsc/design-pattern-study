using System;

namespace DesignPatternStudy.Creational.Factory
{
    public class App : IApp
    {
        private readonly ILoggerFactory loggerFactory;

        public App(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        public void Run()
        {
            Console.WriteLine("Which logger you would like to use: (MEMORY, FILE, DB, REMOTE_SERVICE");
            string loggerMedium = Console.ReadLine();
            loggerFactory[loggerMedium].Log("message");
        }
    }
}
