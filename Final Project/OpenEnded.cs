using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class OpenEnded : AbstractQuestion
    {
        private string userInput;

        public OpenEnded(Prompt prompt, Answer answer, string userInput)
            : base(prompt, answer)
        {
            this.userInput = userInput;
        }

        public override bool Evaluate()
        {
            return userInput.Trim().Equals(answer.Text.Trim());
        }
    }
}
