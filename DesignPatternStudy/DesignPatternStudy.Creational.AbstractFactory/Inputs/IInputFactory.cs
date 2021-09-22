namespace DesignPatternStudy.Creational.AbstractFactory.Inputs
{
    public interface IInputFactory
    {
        IControlFactory CreateControlFactory(InputType inputType);
    }
}