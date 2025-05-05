using System;
using System.Windows.Forms;
using QuizGame;

// Game state while the user is actively taking the quiz
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
                Control answerControl = null;
                Button submitButton = new Button { Text = "Submit", Top = 180, Left = 20 };

                if (question is MultipleChoice mcq)
                {
                    GroupBox groupBox = new GroupBox { Top = 60, Left = 20, Width = 400, Height = 100 };
                    int top = 20;
                    foreach (string option in mcq.GetOptions())
                    {
                        RadioButton rb = new RadioButton { Text = option, Top = top, Left = 10, Width = 300 };
                        groupBox.Controls.Add(rb);
                        top += 25;
                    }
                    answerControl = groupBox;

                    submitButton.Click += (s, e) =>
                    {
                        string selected = null;
                        foreach (RadioButton rb in groupBox.Controls)
                            if (rb.Checked) selected = rb.Text;

                        bool isCorrect = question.Evaluate(selected);
                        if (isCorrect) result.CorrectAnswers++;
                        MessageBox.Show(isCorrect ? "Correct!" : "Incorrect.");
                        currentIndex++;
                        form.TransitionTo(new InGameState().Render(0));
                    };
                }
                else
                {
                    TextBox inputBox = new TextBox { Top = 60, Left = 20, Width = 300 };
                    answerControl = inputBox;

                    submitButton.Click += (s, e) =>
                    {
                        string userAnswer = inputBox.Text;
                        bool isCorrect = question.Evaluate(userAnswer);
                        if (isCorrect) result.CorrectAnswers++;
                        MessageBox.Show(isCorrect ? "Correct!" : "Incorrect.");
                        currentIndex++;
                        form.TransitionTo(new InGameState().Render(0));
                    };
                }

                form.AddControl(promptLabel);
                form.AddControl(answerControl);
                form.AddControl(submitButton);
            }

            return this;
        }

        protected override IGameState NextState(int code) => this;
        public override IGameState HandleInput(string userInput, string userName, string action) => this;
    }
}
