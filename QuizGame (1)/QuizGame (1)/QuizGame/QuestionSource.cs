using System.Collections.Generic;
using QuizGame;

namespace QuizGame
{
    public interface QuestionSource
    {
        List<QuestionIF> LoadQuestions();
    }
}