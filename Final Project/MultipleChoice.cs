using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace Final_Project
{
    public class MultipleChoice : AbstractQuestion_Options
    {
        private int selectedIndex;

        public MultipleChoice(Prompt prompt, Answer answer, List<string> entries, int selectedIndex)
            : base(prompt, answer, new Options())
        {
            foreach (var entry in entries)
            {
                this.options.AddEntry(entry);
            }
            this.selectedIndex = selectedIndex;
        }

        public override bool Evaluate()
        {
            string selected = options.GetOption(selectedIndex);
            return selected != null && selected.Equals(answer.Text);
        }

        public string GetCorrectAnswer() => answer.Text;
    }


}
