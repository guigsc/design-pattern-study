using DesignPatternStudy.Creational.Factory.Loggers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatternStudy.Creational.Factory
{
    class Program
    {
        // Factory is a creation design pattern which is used to create different implementation objects of the same type
        //
        // Example:
        // If you have to design Logger API (class) which can log to different mediums like:
        // - In memory data structure (MEMORY)
        // - File on disk (FILE)
        // - Database (DB)
        // - Remote storage (REMOTE_SERVICE) 
        //
        // based on this article:
        // https://medium.com/@kousiknath/design-patterns-different-approaches-to-use-factory-pattern-to-choose-objects-dynamically-at-run-71449bceecef
        //
        // and this one:
        // https://medium.com/swlh/factory-pattern-without-switch-this-is-how-it-should-be-done-cd895e356f44

        private static ServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            Console.WriteLine("Which logger you would like to use: (MEMORY, FILE, DB, REMOTE_SERVICE");
            string loggerMedium = Console.ReadLine();

            var loggerFactory = _serviceProvider.GetRequiredService<ILoggerFactory>();
            loggerFactory[loggerMedium].Log("message");

            DisposeServices();
        }   

        private static void RegisterServices()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<ILoggerFactory>(_ =>
                {
                    // Logic here to register loggers, so that it is possible to extend the factory without modifying it
                    // OCP (open/closed principle)
                    LoggerFactory factory = new LoggerFactory();

                    factory.RegisterLogger("MEMORY", () => new InMemoryLogger());
                    factory.RegisterLogger("FILE", () => new FileLogger());
                    factory.RegisterLogger("DB", () => new DBLogger());
                    factory.RegisterLogger("REMOTE_SERVICE", () => new RemoteServiceLogger());

                    return factory;
                })
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
