using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Options
    {
        private List<string> entries = new List<string>();

        public void AddEntry(string option)
        {
            entries.Add(option);
        }

        public string GetOption(int choice)
        {
            if (choice >= 0 && choice < entries.Count)
                return entries[choice];
            return null;
        }

        public List<string> GetAllEntries()
        {
            return entries;
        }
    }

}
