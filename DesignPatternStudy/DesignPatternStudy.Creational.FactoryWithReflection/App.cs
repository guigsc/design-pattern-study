using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection
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
            Console.WriteLine("Which logger you would like to use: (InMemory, File, DB, RemoteService)");

            string loggerMedium = Console.ReadLine() ?? string.Empty;

            try
            {
                var logger = loggerFactory.CreateLogger(loggerMedium);
                logger?.Log("Logging");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
