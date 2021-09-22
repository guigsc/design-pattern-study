using DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement;

namespace DesignPatternStudy.Creational.AbstractFactory.Inputs
{
    public class PCControlFactory : IControlFactory
    {
        public JumpControl CreateJumpControl()
        {
            return new JumpControlPC();
        }

        public MovementControl CreateMovementControl()
        {
            return new MovementControlPC();
        }

        public StartControl CreateStartControl()
        {
            return new StartControlPC();
        }
    }
}
