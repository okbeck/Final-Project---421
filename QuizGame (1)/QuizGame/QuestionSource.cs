using System.Collections.Generic;
using QuizGame;

// Abstract base for loading questions from different sources
namespace QuizGame
{
    public interface QuestionSource
    {
        List<QuestionIF> LoadQuestions();
    }
}