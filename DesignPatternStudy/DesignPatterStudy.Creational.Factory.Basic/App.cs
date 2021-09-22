using System;

namespace DesignPatterStudy.Creational.Factory.Basic
{
    public class App
    {
        public void Run()
        {
            Console.WriteLine("Which logger you would like to use: (InMemory, File, DB, RemoteService)");

            string loggerMedium = Console.ReadLine() ?? string.Empty;

            try
            {
                var logger = new LoggerFactory().CreateLogger(loggerMedium);
                logger.Log("Logging");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
