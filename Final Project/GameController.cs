using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class GameController
    {
        private GameState currentState;
        //private QuizRound currentRound;
        private QuestionSource source;
        private Builder builder;
        private Quiz quiz;

        public GameController(QuestionSource source, Builder builder)
        {
            this.source = source;
            this.builder = builder;
            this.currentState = new MainMenuState();

            // dynamic linkage
            var loader = new AbstractLoadableQuiz(source);
            loader.PopulateQuiz();
            quiz = (Quiz)loader.GetQuiz();
        }

        public void StartGame()
        {
            Console.WriteLine("Starting Game...");
            currentState = currentState.Render(GameState.GameEvent);
        }

        public void SubmitAnswer()
        {
            Console.WriteLine("Submitting answer...");
           // currentState = currentState.HandleInput(new Button("Apply"), new Button("Save"), new Button("Revert"));
        }
        public QuestionIF GetCurrentQuestion()
        {
            return quiz.GetCurrentQuestion();
        }

        public void ChangeState(GameState newState)
        {
            currentState = newState;
        }
    }

}
