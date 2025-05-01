using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    using System.Collections.Generic;

    public class MultipleChoiceBuilder : Builder
    {
        private string prompt;
        private List<string> options = new List<string>();
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

        public MultipleChoiceBuilder AddOption(string option)
        {
            options.Add(option);
            return this;
        }

        public MultipleChoiceBuilder SetCorrectOption(string correctOption)
        {
            this.correctAnswer = correctOption;
            return this;
        }

        public QuestionIF Build()
        {
            var promptObj = new Prompt(prompt);
            var answerObj = new Answer(correctAnswer);
            return new MultipleChoice(promptObj, answerObj, options, options.IndexOf(correctAnswer));
        }
    }


}
