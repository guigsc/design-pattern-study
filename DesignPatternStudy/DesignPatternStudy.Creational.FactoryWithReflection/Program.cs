using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternStudy.Creational.FactoryWithReflection
{
    class Program
    {
        private static ServiceProvider _serviceProvider = RegisterServices();

        static void Main()
        {
            _serviceProvider.GetRequiredService<IApp>().Run();

            DisposeServices();
        }

        private static ServiceProvider RegisterServices()
        {
            return _serviceProvider = new ServiceCollection()
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
