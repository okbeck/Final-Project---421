namespace QuizGame
{
    public class PauseState : GameState
    {
        public override IGameState Render(int eventCode)
        {
            System.Console.WriteLine("Game Paused.");
            return this;
        }

        public override IGameState HandleInput(string apply, string save, string revert)
        {
            return NextState(ApplyEvent);
        }

        protected override IGameState NextState(int eventCode)
        {
            return new InGameState();
        }
    }
}