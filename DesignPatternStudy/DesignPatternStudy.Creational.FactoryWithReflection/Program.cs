using DesignPatternStudy.Creational.FactoryWithReflection.Loggers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection
{
    class Program
    {
        private static ServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            Console.WriteLine("Which logger you would like to use: (MEMORY, FILE, DB, REMOTE_SERVICE");
            string loggerMedium = Console.ReadLine();

            var factory = _serviceProvider.GetRequiredService<ILoggerFactory>();

            try
            {
                var logger = factory.CreateLogger(loggerMedium);
                logger.Log("Logging");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            DisposeServices();
        }

        private static void RegisterServices()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<ILoggerFactory, LoggerFactory>()
                .BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }

            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
