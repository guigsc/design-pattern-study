using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatternStudy.Creational.FactoryWithReflection
{
    class Program
    {
        private static ServiceProvider _serviceProvider;

        static void Main()
        {
            RegisterServices();

            _serviceProvider.GetRequiredService<IApp>().Run();

            DisposeServices();
        }

        private static void RegisterServices()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<ILoggerFactory, LoggerFactory>()
                .AddSingleton<IApp, App>()
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
