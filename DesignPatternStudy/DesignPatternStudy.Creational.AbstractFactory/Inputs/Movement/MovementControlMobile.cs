namespace DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement
{
    public class MovementControlMobile : MovementControl
    {
        public override void Move()
        {
            Console.WriteLine("Moving through mobile input");
        }
    }
}
