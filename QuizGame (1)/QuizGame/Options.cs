using System.Collections.Generic;

// Represents a set of options for multiple choice questions
namespace QuizGame
{
    public class Options
    {
        private List<string> entries = new List<string>();

        public void AddEntry(string option)
        {
            entries.Add(option);
        }

        public void RemoveEntry(int index)
        {
            if (index >= 0 && index < entries.Count)
                entries.RemoveAt(index);
        }

        public string GetOption(int choice)
        {
            if (choice >= 0 && choice < entries.Count)
                return entries[choice];
            return null;
        }

        public List<string> GetAllOptions() => entries;
    }
}