using DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement;

namespace DesignPatternStudy.Creational.AbstractFactory.Inputs
{
    public class ConsoleControlFactory : IControlFactory
    {
        public JumpControl CreateJumpControl()
        {
            return new JumpControlConsole();
        }

        public MovementControl CreateMovementControl()
        {
            return new MovementControlConsole();
        }

        public StartControl CreateStartControl()
        {
            return new StartControlConsole();
        }
    }
}
