using DesignPatternStudy.Creational.AbstractFactory;
using DesignPatternStudy.Creational.AbstractFactory.Inputs;
using Microsoft.Extensions.DependencyInjection;

ServiceProvider serviceProvider = RegisterServices();

serviceProvider.GetRequiredService<IApp>().Run();

DisposeServices();

ServiceProvider RegisterServices()
{
    return new ServiceCollection()
        .AddSingleton<IApp, App>()
        .AddSingleton<IInputFactory, InputFactory>()
        .BuildServiceProvider();
}

void DisposeServices()
{
    if (serviceProvider == null)
    {
        return;
    }

    if (serviceProvider is IDisposable)
    {
        ((IDisposable)serviceProvider).Dispose();
    }
}