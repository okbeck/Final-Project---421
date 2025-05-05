// Base class for all types of questions
namespace QuizGame
{
    public abstract class AbstractQuestion : QuestionIF
    {
        protected Prompt prompt;
        protected Answer answer;

        public abstract bool Evaluate(string userInput);

        public string GetPrompt() => prompt.Text;
    }
}