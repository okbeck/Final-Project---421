// override
using System;
using System.Windows.Forms;
using QuizGame;

namespace QuizGame
{
    public class InGameState : GameState
    {
        private int currentIndex = 0;
        private bool started = false;

        public override IGameState Render(int eventCode)
        {
            if (Application.OpenForms[0] is MainForm form)
            {
                form.ClearUI();

                GameController controller = (GameController)form.GetType()
                    .GetField("controller", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .GetValue(form);

                var quiz = controller.GetQuiz();
                var questions = quiz.GetQuestions();
                var result = controller.GetResult();

                if (!started)
                {
                    result.TotalQuestions = questions.Count;
                    result.StartTime = DateTime.Now;
                    started = true;
                }

                if (currentIndex >= questions.Count)
                {
                    result.EndTime = DateTime.Now;
                    MessageBox.Show("Quiz completed!");
                    return new StatsState().Render(0);
                }

                var question = questions[currentIndex];
                Label promptLabel = new Label { Text = question.GetPrompt(), Top = 20, Left = 20, Width = 500 };

                TextBox inputBox = new TextBox { Top = 60, Left = 20, Width = 300 };
                Button submitButton = new Button { Text = "Submit", Top = 100, Left = 20 };

                submitButton.Click += (s, e) =>
                {
                    string userAnswer = inputBox.Text;
                    bool isCorrect = question.Evaluate(userAnswer);
                    if (isCorrect) result.CorrectAnswers++;
                    MessageBox.Show(isCorrect ? "Correct!" : "Incorrect.");
                    currentIndex++;
                    form.TransitionTo(new InGameState { currentIndex = this.currentIndex, started = this.started });
                };

                form.AddControl(promptLabel);
                form.AddControl(inputBox);
                form.AddControl(submitButton);
            }

            return this;
        }

        public override IGameState HandleInput(string apply, string save, string revert) => this;

        protected override IGameState NextState(int eventCode) => this;
    }
}