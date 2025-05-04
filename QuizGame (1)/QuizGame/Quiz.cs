using System.Collections.Generic;
using QuizGame;

namespace QuizGame
{
    public class Quiz : QuizIF
    {
        private List<QuestionIF> questions = new List<QuestionIF>();
        private ReadWriteLock lockObj = new ReadWriteLock();

        public void AddQuestion(QuestionIF q)
        {
            lockObj.WriteLock();
            questions.Add(q);
            lockObj.Done();
        }

        public void Evaluate()
        {
            lockObj.ReadLock();
            foreach (var question in questions)
            {
                System.Console.WriteLine(question.GetPrompt());
                string input = System.Console.ReadLine();
                bool result = question.Evaluate(input);
                System.Console.WriteLine(result ? "Correct!" : "Incorrect.");
            }
            lockObj.Done();
        }

        public List<QuestionIF> GetQuestions()
        {
            return questions;
        }
    }
}