using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
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
            var promptObj = new Prompt(prompt);
            var answerObj = new Answer(correctAnswer);
            return new OpenEnded(promptObj, answerObj, correctAnswer); // assume input = correct answer
        }
    }

}
