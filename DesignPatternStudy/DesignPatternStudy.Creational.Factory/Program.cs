using DesignPatternStudy.Creational.Factory;
using DesignPatternStudy.Creational.Factory.Loggers;
using Microsoft.Extensions.DependencyInjection;

ServiceProvider serviceProvider = RegisterServices();

serviceProvider.GetRequiredService<IApp>().Run();

DisposeServices();

ServiceProvider RegisterServices()
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

void DisposeServices()
{
    if (serviceProvider == null)
        return;

    if (serviceProvider is IDisposable)
        ((IDisposable)serviceProvider).Dispose();
}
