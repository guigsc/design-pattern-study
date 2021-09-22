namespace DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement
{
    public class MovementControlConsole : MovementControl
    {
        public override void Move()
        {
            Console.WriteLine("Moving through console input");
        }
    }
}
