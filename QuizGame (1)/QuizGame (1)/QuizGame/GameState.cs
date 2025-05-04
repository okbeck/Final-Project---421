namespace QuizGame
{
    public abstract class GameState : IGameState
    {
        public const int GameEvent = 1;
        public const int ApplyEvent = 2;
        public const int SaveEvent = 3;
        public const int RevertEvent = 4;

        public abstract IGameState Render(int eventCode);
        public abstract IGameState HandleInput(string apply, string save, string revert);

        protected abstract IGameState NextState(int eventCode);
    }
}