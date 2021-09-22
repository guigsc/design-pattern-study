namespace DesignPatternStudy.Creational.AbstractFactory.Inputs
{
    public class InputFactory : IInputFactory
    {
        public IControlFactory CreateControlFactory(InputType inputType) => inputType switch
        {
            InputType.Console => new ConsoleControlFactory(),
            InputType.Mobile => new MobileControlFactory(),
            InputType.PC => new PCControlFactory(),
            _ => new PCControlFactory()
        };
    }
}
