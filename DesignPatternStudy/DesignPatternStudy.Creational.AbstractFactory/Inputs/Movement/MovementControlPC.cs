namespace DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement
{
    public class MovementControlPC : MovementControl
    {
        public override void Move()
        {
            Console.WriteLine("Moving through PC input");
        }
    }
}
