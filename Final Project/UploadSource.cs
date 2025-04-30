using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class UploadSource : QuestionSource
    {
        public List<QuestionIF> LoadQuestions()
        {
            // Placeholder: would load from a JSON file
            List<QuestionIF> list = new List<QuestionIF>();
            list.Add(new OpenEnded(new Prompt("What is 2 + 2?"), new Answer("4")));
            list.Add(new OpenEnded(new Prompt("What is the capital of France?"), new Answer("Paris")));
            return list;
        }
    }
}
