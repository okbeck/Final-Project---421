using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

// Loads quiz data from a JSON file
namespace QuizGame
{
    public class JSONSource : QuestionSource
    {
        private class JsonQuestion
        {
            public string type { get; set; }
            public string prompt { get; set; }
            public string correct { get; set; }
            public List<string> options { get; set; }
        }

        public List<QuestionIF> LoadQuestions()
        {
            List<QuestionIF> questions = new List<QuestionIF>();

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                Title = "Select a Quiz JSON File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                var parsed = JsonSerializer.Deserialize<List<JsonQuestion>>(json);

                foreach (var item in parsed)
                {
                    if (item.type == "mc")
                    {
                        var builder = new MultipleChoiceBuilder().SetPrompt(item.prompt).SetAnswer(item.correct);
                        foreach (var opt in item.options)
                            ((MultipleChoiceBuilder)builder).AddOption(opt);
                        questions.Add(builder.Build());
                    }
                    else if (item.type == "oe")
                    {
                        var builder = new OpenEndedBuilder().SetPrompt(item.prompt).SetAnswer(item.correct);
                        questions.Add(builder.Build());
                    }
                }
            }

            return questions;
        }
    }
}