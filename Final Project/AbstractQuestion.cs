using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public abstract class AbstractQuestion : QuestionIF
    {
        protected Prompt prompt;
        protected Answer answer;
        public abstract bool Evaluate();
        public string GetPrompt() => prompt.Text;
        public string GetAnswer() => answer.Text;
    }
}
