using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace Final_Project
{

    // Test
    public abstract class AbstractQuestion_Options : AbstractQuestion
    {
        protected Options options;

        public AbstractQuestion_Options(Prompt prompt, Answer answer, Options options)
            : base(prompt, answer)
        {
            this.options = options;
        }

        public override abstract bool Evaluate();
    }


}
