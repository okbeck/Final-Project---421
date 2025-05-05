// Builder for creating open-ended questions
namespace QuizGame
{
    public class OpenEndedBuilder : Builder
    {
        private string prompt;
        private string correctAnswer;

        public Builder SetPrompt(string prompt)
        {
            this.prompt = prompt;
            return this;
        }

        public Builder SetAnswer(string answer)
        {
            this.correctAnswer = answer;
            return this;
        }

        public QuestionIF Build()
        {
            return new OpenEnded(new Prompt(prompt), new Answer(correctAnswer));
        }
    }
}