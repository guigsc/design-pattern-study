using DesignPatternStudy.Creational.AbstractFactory.Inputs.Movement;

namespace DesignPatternStudy.Creational.AbstractFactory.Inputs
{
    public interface IControlFactory
    {
        MovementControl CreateMovementControl();
        JumpControl CreateJumpControl();
        StartControl CreateStartControl();
    }
}