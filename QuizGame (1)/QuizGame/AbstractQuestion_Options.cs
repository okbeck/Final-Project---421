using System.Collections.Generic;

// Abstract class for questions that include selectable options
namespace QuizGame
{
    public abstract class AbstractQuestion_Options : AbstractQuestion
    {
        protected Options options;

        public AbstractQuestion_Options()
        {
            options = new Options();
        }

        public void AddOption(string option)
        {
            options.AddEntry(option);
        }

        public List<string> GetOptions()
        {
            return options.GetAllOptions();
        }
    }
}