using DesignPatternStudy.Creational.AbstractFactory.Inputs;

namespace DesignPatternStudy.Creational.AbstractFactory
{
    public class App : IApp
    {
        private readonly IInputFactory inputFactory;
        public App(IInputFactory inputFactory)
        {
            this.inputFactory = inputFactory;
        }

        public void Run()
        {
            Console.WriteLine("Choose your input: Console, PC or Mobile");
            
            string input = Console.ReadLine() ?? string.Empty;
            while (string.IsNullOrEmpty(input))
                input = Console.ReadLine() ?? string.Empty;

            bool canParseInput = Enum.TryParse<InputType>(input, out var inputType);
            if (canParseInput)
            {
                var controlFactory = inputFactory.CreateControlFactory(inputType);

                var movementControl = controlFactory.CreateMovementControl();
                var jumpControl = controlFactory.CreateJumpControl();
                var startControl = controlFactory.CreateStartControl();

                movementControl.Move();
                jumpControl.Jump();
                startControl.Start();
            }
        }
    }
}
