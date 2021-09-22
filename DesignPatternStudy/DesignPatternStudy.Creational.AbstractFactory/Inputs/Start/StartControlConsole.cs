namespace DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement
{
    public class StartControlConsole : StartControl
    {
        public override void Start()
        {
            Console.WriteLine("Starting through console input");
        }
    }
}
