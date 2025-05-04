namespace QuizGame
{
    public class OpenEnded : AbstractQuestion
    {
        public OpenEnded(Prompt prompt, Answer answer)
        {
            this.prompt = prompt;
            this.answer = answer;
        }

        public override bool Evaluate(string userInput)
        {
            return userInput.Trim().ToLower() == answer.Text.Trim().ToLower();
        }
    }
}