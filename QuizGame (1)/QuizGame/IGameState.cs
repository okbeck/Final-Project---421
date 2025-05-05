// Interface for game states (menu, quiz, results, etc.)
namespace QuizGame
{
    public interface IGameState
    {
        IGameState Render(int eventCode);
        IGameState HandleInput(string apply, string save, string revert);
    }
}