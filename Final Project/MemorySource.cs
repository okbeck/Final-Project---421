using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class MemorySource : QuestionSource
    {
        public List<QuestionIF> LoadQuestions()
        {
            // You can dynamically build questions here using a builder
            var builder = new OpenEndedBuilder();
            var questions = new List<QuestionIF>();

            builder.SetPrompt("What's the capital of France?")
                   .SetAnswer("Paris");

            questions.Add(builder.Build());
            return questions;
        }
    }
}
