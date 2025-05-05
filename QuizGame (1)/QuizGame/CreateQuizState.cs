using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Game state for creating a new quiz manually
namespace QuizGame
{
    public class CreateQuizState : GameState
    {
        private List<string> mcOptions = new List<string>();

        public override IGameState Render(int eventCode)
        {
            if (Application.OpenForms[0] is MainForm form)
            {
                form.ClearUI();

                var controller = (GameController)form.GetType()
                    .GetField("controller", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .GetValue(form);
                controller.ResetQuiz(); // clear previous quiz if any


                Label header = new Label { Text = "Create Your Quiz", Top = 20, Left = 200, Width = 200 };

                Label promptLabel = new Label { Text = "Question Prompt:", Top = 60, Left = 20 };
                TextBox promptBox = new TextBox { Top = 80, Left = 20, Width = 500 };

                Label typeLabel = new Label { Text = "Question Type:", Top = 120, Left = 20 };
                ComboBox typeDropdown = new ComboBox { Top = 140, Left = 20, Width = 200 };
                typeDropdown.Items.AddRange(new string[] { "Open-Ended", "Multiple Choice" });
                typeDropdown.SelectedIndex = 0;

                Label answerLabel = new Label { Text = "Correct Answer:", Top = 180, Left = 20 };
                TextBox answerBox = new TextBox { Top = 200, Left = 20, Width = 300 };

                Label optionsLabel = new Label { Text = "Options (MC only):", Top = 240, Left = 20 };
                TextBox optionsBox = new TextBox { Top = 260, Left = 20, Width = 300 };
                optionsBox.PlaceholderText = "Separate options with semicolons";

                Button addButton = new Button { Text = "Add Question", Top = 300, Left = 20 };
                Button finishButton = new Button { Text = "Finish Quiz", Top = 340, Left = 20 };
                Button backButton = new Button { Text = "Back to Menu", Top = 380, Left = 20 };

                form.AddControl(header);
                form.AddControl(promptLabel);
                form.AddControl(promptBox);
                form.AddControl(typeLabel);
                form.AddControl(typeDropdown);
                form.AddControl(answerLabel);
                form.AddControl(answerBox);
                form.AddControl(optionsLabel);
                form.AddControl(optionsBox);
                form.AddControl(addButton);
                form.AddControl(finishButton);
                form.AddControl(backButton);

                addButton.Click += (s, e) =>
                {
                    string prompt = promptBox.Text.Trim();
                    string answer = answerBox.Text.Trim();
                    string type = typeDropdown.SelectedItem.ToString();

                    if (string.IsNullOrWhiteSpace(prompt) || string.IsNullOrWhiteSpace(answer))
                    {
                        MessageBox.Show("Prompt and Answer cannot be empty.");
                        return;
                    }

                    var controller = (GameController)form.GetType()
                        .GetField("controller", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(form);
                    var quiz = controller.GetQuiz();

                    if (type == "Multiple Choice")
                    {
                        var builder = new MultipleChoiceBuilder().SetPrompt(prompt).SetAnswer(answer) as MultipleChoiceBuilder;
                        string[] options = optionsBox.Text.Split(';');
                        if (options.Length < 2)
                        {
                            MessageBox.Show("Please provide at least two options.");
                            return;
                        }

                        foreach (string opt in options)
                            builder.AddOption(opt.Trim());

                        quiz.AddQuestion(builder.Build());
                    }
                    else
                    {
                        var builder = new OpenEndedBuilder().SetPrompt(prompt).SetAnswer(answer);
                        quiz.AddQuestion(builder.Build());
                    }

                    MessageBox.Show("Question added!");
                    promptBox.Text = "";
                    answerBox.Text = "";
                    optionsBox.Text = "";
                };

                finishButton.Click += (s, e) =>
                {
                    MessageBox.Show("Quiz created and stored in memory.");
                    form.TransitionTo(new MainMenuState());
                };

                backButton.Click += (s, e) =>
                {
                    form.TransitionTo(new MainMenuState());
                };
            }

            return this;
        }

        protected override IGameState NextState(int code) => this;
        public override IGameState HandleInput(string userInput, string userName, string action) => this;
    }
}
