using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuizGame
{
    public class CSVSource : QuestionSource
    {
        public List<QuestionIF> LoadQuestions()
        {
            List<QuestionIF> questions = new List<QuestionIF>();

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Select a Quiz CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    string type = parts[0].Trim().ToLower();
                    string prompt = parts[1].Trim();
                    string correct = parts[2].Trim();

                    if (type == "mc")
                    {
                        string[] options = parts[3].Split(';');
                        var builder = new MultipleChoiceBuilder().SetPrompt(prompt).SetAnswer(correct);
                        foreach (var opt in options)
                            ((MultipleChoiceBuilder)builder).AddOption(opt.Trim());
                        questions.Add(builder.Build());
                    }
                    else if (type == "oe")
                    {
                        var builder = new OpenEndedBuilder().SetPrompt(prompt).SetAnswer(correct);
                        questions.Add(builder.Build());
                    }
                }
            }

            return questions;
        }
    }
}