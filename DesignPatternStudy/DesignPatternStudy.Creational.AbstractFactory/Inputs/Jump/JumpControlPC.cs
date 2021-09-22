namespace DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement
{
    public class JumpControlPC : JumpControl
    {
        public override void Jump()
        {
            Console.WriteLine("Jumping through PC input");
        }
    }
}
