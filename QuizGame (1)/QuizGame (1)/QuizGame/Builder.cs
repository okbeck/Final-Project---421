namespace QuizGame
{
    public interface Builder
    {
        Builder SetPrompt(string prompt);
        Builder SetAnswer(string answer);
        QuestionIF Build();
    }
}