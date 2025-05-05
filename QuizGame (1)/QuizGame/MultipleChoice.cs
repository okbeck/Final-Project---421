using System.Collections.Generic;

// Multiple choice question implementation
namespace QuizGame
{
    public class MultipleChoice : AbstractQuestion_Options
    {
        private string correctAnswer;

        public MultipleChoice(Prompt prompt, string correctAnswer, List<string> optionsList)
        {
            this.prompt = prompt;
            this.correctAnswer = correctAnswer;
            foreach (var option in optionsList)
            {
                options.AddEntry(option);
            }
        }

        public override bool Evaluate(string userInput)
        {
            return userInput.Trim().ToLower() == correctAnswer.Trim().ToLower();
        }

        public string GetCorrectAnswer() => correctAnswer;
    }
}