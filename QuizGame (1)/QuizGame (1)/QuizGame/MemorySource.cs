using System.Collections.Generic;

namespace QuizGame
{
    public class MemorySource : QuestionSource
    {
        public List<QuestionIF> LoadQuestions()
        {
            var questions = new List<QuestionIF>();

            var builder1 = new MultipleChoiceBuilder();
            builder1.SetPrompt("What is the capital of France?")
                    .SetAnswer("Paris");
            ((MultipleChoiceBuilder)builder1).AddOption("Paris");
            ((MultipleChoiceBuilder)builder1).AddOption("London");
            ((MultipleChoiceBuilder)builder1).AddOption("Berlin");
            questions.Add(builder1.Build());

            var builder2 = new OpenEndedBuilder();
            builder2.SetPrompt("Name a programming language that starts with 'P'")
                    .SetAnswer("Python");
            questions.Add(builder2.Build());

            return questions;
        }
    }
}