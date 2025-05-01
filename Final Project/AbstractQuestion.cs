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

        public AbstractQuestion(Prompt prompt, Answer answer)
        {
            this.prompt = prompt;
            this.answer = answer;
        }

        public abstract bool Evaluate();
    }

}
