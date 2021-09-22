using DesignPatternStudy.Creational.Factory.Loggers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatternStudy.Creational.Factory
{
    class Program
    {
        private static ServiceProvider _serviceProvider = RegisterServices();

        static void Main(string[] args)
        {
            _serviceProvider.GetRequiredService<IApp>().Run();
            DisposeServices();
        }   

        private static ServiceProvider RegisterServices()
        {
            return new ServiceCollection()
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
                .AddSingleton<IApp, App>()
                .BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
                return;

            if (_serviceProvider is IDisposable)
                ((IDisposable)_serviceProvider).Dispose();
        }
    }
}
