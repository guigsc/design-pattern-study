namespace DesignPatternStudy.Creational.FactoryWithReflection.Interfaces
{
    public interface ILoggerFactory
    {
        ILogger? CreateLogger(string loggerMedium);
    }
}
