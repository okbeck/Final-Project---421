namespace QuizGame
{
    public interface QuestionIF
    {
        bool Evaluate(string userInput);
        string GetPrompt();
    }
}