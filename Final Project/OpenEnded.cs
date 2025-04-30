using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class OpenEnded : AbstractQuestion
    {
        public OpenEnded(Prompt prompt, Answer answer)
        {
            this.prompt = prompt;
            this.answer = answer;
        }
        public override bool Evaluate()
        {
            // For demo purposes, just return true
            return true;
        }
    }
}
