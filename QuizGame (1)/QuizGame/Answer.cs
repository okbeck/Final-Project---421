// Represents an answer to a quiz question
namespace QuizGame
{
    public class Answer
    {
        public string Text { get; set; }

        public Answer(string text)
        {
            Text = text;
        }
    }
}