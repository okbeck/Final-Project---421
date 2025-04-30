using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
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

        public MultipleChoiceBuilder SetCorrectOption(string option)
        {
            this.correctAnswer = option;
            return this;
        }

        public QuestionIF Build()
        {
            return new MultipleChoice(new Prompt(prompt), new Answer(correctAnswer), options);
        }
    }

}
