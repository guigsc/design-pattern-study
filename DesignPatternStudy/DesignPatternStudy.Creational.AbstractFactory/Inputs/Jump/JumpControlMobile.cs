namespace DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement
{
    public class JumpControlMobile : JumpControl
    {
        public override void Jump()
        {
            Console.WriteLine("Jumping through mobile input");
        }
    }
}
