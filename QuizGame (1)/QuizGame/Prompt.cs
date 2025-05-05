// Represents a question prompt (the question text itself)
namespace QuizGame
{
    public class Prompt
    {
        public string Text { get; set; }

        public Prompt(string text)
        {
            Text = text;
        }
    }
}