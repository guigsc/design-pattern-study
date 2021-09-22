namespace DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement
{
    public class JumpControlConsole : JumpControl
    {
        public override void Jump()
        {
            Console.WriteLine("Jumping through console input");
        }
    }
}
