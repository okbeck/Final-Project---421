namespace QuizGame
{
    public interface IGameState
    {
        IGameState Render(int eventCode);
        IGameState HandleInput(string apply, string save, string revert);
    }
}