using DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement;

namespace DesignPatternStudy.Creational.AbstractFactory.Inputs
{
    public class MobileControlFactory : IControlFactory
    {
        public JumpControl CreateJumpControl()
        {
            return new JumpControlMobile();
        }

        public MovementControl CreateMovementControl()
        {
            return new MovementControlMobile();
        }

        public StartControl CreateStartControl()
        {
            return new StartControlMobile();
        }
    }
}
