using System.Collections.Generic;

// Builder for creating multiple choice questions
namespace QuizGame
{
    public class MultipleChoiceBuilder : Builder
    {
        private string prompt;
        private List<string> options = new List<string>();
        private string correctAnswer;

        public Builder SetPrompt(string prompt)
        {
            this.prompt = prompt;
            return this;
        }

        public Builder SetAnswer(string answer)
        {
            this.correctAnswer = answer;
            return this;
        }

        public MultipleChoiceBuilder AddOption(string option)
        {
            options.Add(option);
            return this;
        }

        public QuestionIF Build()
        {
            return new MultipleChoice(new Prompt(prompt), correctAnswer, options);
        }
    }
}