namespace QuizGame
{
    public class CreateQuizState : GameState
    {
        public override IGameState Render(int eventCode)
        {
            System.Console.WriteLine("Create a new quiz (Placeholder)");
            return this;
        }

        public override IGameState HandleInput(string apply, string save, string revert)
        {
            return NextState(SaveEvent);
        }

        protected override IGameState NextState(int eventCode)
        {
            return new MainMenuState();
        }
    }
}