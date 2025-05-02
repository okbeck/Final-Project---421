using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class JSONSource : QuestionSource
    {
        public List<QuestionIF> LoadQuestions()
        {
            // Simulate loading from JSON
            Console.WriteLine("Loading questions from JSON...");
            return new MemorySource().LoadQuestions(); // for demonstration
        }
    }

}
