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
        private Quiz quiz;
        private QuestionSource source = new UploadSource();

        public void StartGame()
        {
            quiz = new Quiz();
            foreach (var q in source.LoadQuestions())
            {
                quiz.AddQuestion(q);
            }
            currentState = new MainMenuState(this);
            currentState.Enter();
        }

        public void SubmitAnswer()
        {
            Console.WriteLine("Answer submitted.");
            quiz.Evaluate();
            quiz.NextQuestion();
        }

        public void ChangeState(GameState newState)
        {
            currentState = newState;
            currentState.Enter();
        }

        public QuestionIF GetCurrentQuestion()
        {
            return quiz.GetCurrentQuestion();
        }

        public bool HasNextQuestion()
        {
            return quiz.HasNextQuestion();
        }
    }
}
