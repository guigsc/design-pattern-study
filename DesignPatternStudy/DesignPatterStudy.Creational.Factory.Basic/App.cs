using System;

namespace DesignPatterStudy.Creational.Factory.Basic
{
    public class App
    {
        public void Run()
        {
            Console.WriteLine("Which logger you would like to use: (InMemory, File, DB, RemoteService)");

            string loggerMedium = Console.ReadLine();

            try
            {
                string message = "Logging";
                switch (loggerMedium)
                {
                    case "InMemory":
                        Console.WriteLine($"In Memory Logger: {message}");
                        break;
                    case "File":
                        Console.WriteLine($"File Logger: {message}");
                        break;
                    case "DB":
                        Console.WriteLine($"DB Logger: {message}");
                        break;
                    case "RemoteService":
                        Console.WriteLine($"Remote Service Logger: {message}");
                        break;
                    default:
                        throw new NotSupportedException($"Could not find a logger to create for logger medium: '{loggerMedium}'");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
