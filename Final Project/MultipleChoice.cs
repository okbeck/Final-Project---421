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

        public MultipleChoice(Prompt prompt, Answer answer, Options options)
            : base(prompt, answer, new Options())
        {
//            foreach (var entry in entries)
//            {
//                this.options.AddEntry(entry);
//            }
        }

        public List<string> GetOptions()
        {
            return options.GetAllOptions(); // assumes Options has GetAllOptions()
        }

        private string userChoice;

        public void SetUserChoice(string selected)
        {
            userChoice = selected;
        }

        public override bool Evaluate()
        {
            return userChoice == answer.Text;
        }

        public string GetCorrectAnswer() => answer.Text;
    }


}
