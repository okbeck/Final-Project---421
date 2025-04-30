using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public abstract class AbstractQuestion_Options : AbstractQuestion
    {
        protected List<string> options;
        public AbstractQuestion_Options() => options = new List<string>();
        public void AddOption(string option) => options.Add(option);
        public void RemoveOption(int index) => options.RemoveAt(index);
        public string GetOption(int index) => options[index];
        public List<string> GetOptions() => new List<string>(options);
    }

}
