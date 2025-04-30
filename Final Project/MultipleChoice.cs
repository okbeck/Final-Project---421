using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class MultipleChoice : AbstractQuestion_Options
    {
        private string correctAnswer;
        public MultipleChoice(Prompt prompt, string correctAnswer, List<string> options)
        {
            this.prompt = prompt;
            this.correctAnswer = correctAnswer;
            this.options = options;
        }

        public MultipleChoice(Prompt prompt, Answer answer, List<string> options)
        {
            this.prompt = prompt;
            this.answer = answer;
            this.options = options;
        }

        public override bool Evaluate()
        {
            // Dummy logic for now
            return true;
        }
        public string GetCorrectAnswer() => correctAnswer;
    }

}
