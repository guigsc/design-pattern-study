using DesignPatternStudy.Creational.FactoryWithReflection;
using DesignPatternStudy.Creational.FactoryWithReflection.Interfaces;
using Microsoft.Extensions.DependencyInjection;

ServiceProvider serviceProvider = RegisterServices();

serviceProvider.GetRequiredService<IApp>().Run();

DisposeServices();

ServiceProvider RegisterServices()
{
    return new ServiceCollection()
        .AddSingleton<ILoggerFactory, LoggerFactory>()
        .AddSingleton<IApp, App>()
        .BuildServiceProvider();
}

void DisposeServices()
{
    if (serviceProvider == null)
        return;

    if (serviceProvider is IDisposable)
        ((IDisposable)serviceProvider).Dispose();
}
