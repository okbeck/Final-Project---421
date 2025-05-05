// override
using QuizGame;

// Controls main game logic and transitions between states
namespace QuizGame
{
    public class GameController
    {
        private IGameState currentState;
        private Quiz quiz;
        private QuestionSource source;
        private MainForm form;
        private QuizResult result;

        public GameController(MainForm form)
        {
            this.form = form;
            source = new MemorySource();
            quiz = new Quiz();
            result = new QuizResult();
            currentState = new MainMenuState();
        }

        public void StartGame()
        {
            currentState.Render(0); // this will use OpenForms to find MainForm
        }

        public void ChangeState(IGameState newState)
        {
            currentState = newState;
            currentState.Render(0);
        }

        public Quiz GetQuiz() => quiz;
        public QuizResult GetResult() => result;
        public void ResetQuiz()
        {
            quiz = new Quiz();
            result = new QuizResult();
        }
    }
}
