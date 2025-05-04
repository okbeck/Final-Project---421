// override previous version
using System.Windows.Forms;
using QuizGame;

namespace QuizGame
{
    public class UploadQuizState : GameState
    {
        public override IGameState Render(int eventCode)
        {
            if (Application.OpenForms[0] is MainForm form)
            {
                form.ClearUI();

                Label label = new Label { Text = "Upload Quiz", Top = 20, Left = 220, AutoSize = true };
                Button uploadCSV = new Button { Text = "Upload CSV", Top = 60, Left = 200, Width = 150 };
                Button uploadJSON = new Button { Text = "Upload JSON", Top = 100, Left = 200, Width = 150 };
                Button backBtn = new Button { Text = "Back", Top = 140, Left = 200, Width = 150 };

                uploadCSV.Click += (s, e) =>
                {
                    var controller = (GameController)form.GetType()
                        .GetField("controller", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(form);
                    var quiz = controller.GetQuiz();
                    var csv = new CSVSource();
                    foreach (var q in csv.LoadQuestions())
                        quiz.AddQuestion(q);

                    MessageBox.Show("CSV Quiz loaded successfully.");
                    form.TransitionTo(new MainMenuState());
                };

                uploadJSON.Click += (s, e) =>
                {
                    var controller = (GameController)form.GetType()
                        .GetField("controller", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(form);
                    var quiz = controller.GetQuiz();
                    var json = new JSONSource();
                    foreach (var q in json.LoadQuestions())
                        quiz.AddQuestion(q);

                    MessageBox.Show("JSON Quiz loaded successfully.");
                    form.TransitionTo(new MainMenuState());
                };

                backBtn.Click += (s, e) => form.TransitionTo(new MainMenuState());

                form.AddControl(label);
                form.AddControl(uploadCSV);
                form.AddControl(uploadJSON);
                form.AddControl(backBtn);
            }

            return this;
        }

        public override IGameState HandleInput(string apply, string save, string revert) => this;

        protected override IGameState NextState(int eventCode) => this;
    }
}