using System.Windows.Forms;

// Game state that displays quiz statistics or scores
namespace QuizGame
{
    public class StatsState : GameState
    {
        public override IGameState Render(int eventCode)
        {
            if (Application.OpenForms[0] is MainForm form)
            {
                form.ClearUI();

                var controller = (GameController)form.GetType()
                    .GetField("controller", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .GetValue(form);

                var result = controller.GetResult();

                Label statsLabel = new Label
                {
                    Text = $"Score: {result.CorrectAnswers}/{result.TotalQuestions} ({result.ScorePercentage:F1}%)\n" +
                           $"Time: {result.Duration.TotalSeconds:F2} seconds",
                    Top = 20,
                    Left = 20,
                    Width = 500,
                    Height = 100
                };

                Button backBtn = new Button
                {
                    Text = "Back to Menu",
                    Top = 130,
                    Left = 20
                };

                backBtn.Click += (s, e) =>
                {
                    controller.ResetQuiz();
                    form.TransitionTo(new MainMenuState());
                };

                form.AddControl(statsLabel);
                form.AddControl(backBtn);
            }

            return this;
        }

        public override IGameState HandleInput(string apply, string save, string revert) => this;

        protected override IGameState NextState(int eventCode) => this;
    }
}