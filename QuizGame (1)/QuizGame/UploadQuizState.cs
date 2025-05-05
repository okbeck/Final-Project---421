using System.Windows.Forms;
using QuizGame;

// Game state for uploading/importing quizzes
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
                    var questions = csv.LoadQuestions();

                    if (questions.Count > 0)
                    {
                        foreach (var q in questions)
                            quiz.AddQuestion(q);

                        MessageBox.Show("CSV Quiz loaded successfully.");
                        form.TransitionTo(new MainMenuState());
                    }
                    else
                    {
                        MessageBox.Show("Failed to load CSV quiz. Please check the file format.");
                    }
                };

                uploadJSON.Click += (s, e) =>
                {
                    var controller = (GameController)form.GetType()
                        .GetField("controller", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(form);
                    var quiz = controller.GetQuiz();
                    var json = new JSONSource();
                    var questions = json.LoadQuestions();

                    if (questions.Count > 0)
                    {
                        foreach (var q in questions)
                            quiz.AddQuestion(q);

                        MessageBox.Show("JSON Quiz loaded successfully.");
                        form.TransitionTo(new MainMenuState());
                    }
                    else
                    {
                        MessageBox.Show("Failed to load JSON quiz. Please check the file format.");
                    }
                };

                backBtn.Click += (s, e) =>
                {
                    form.TransitionTo(new MainMenuState());
                };

                form.AddControl(label);
                form.AddControl(uploadCSV);
                form.AddControl(uploadJSON);
                form.AddControl(backBtn);
            }

            return this;
        }

        protected override IGameState NextState(int code)
        {
            return this;
        }

        public override IGameState HandleInput(string userInput, string userName, string action)
        {
            return this;
        }
    }
}
