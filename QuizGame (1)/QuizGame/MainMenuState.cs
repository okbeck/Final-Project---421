using System.Drawing;
using System.Windows.Forms;

// Game state for the main menu screen
namespace QuizGame
{
    public class MainMenuState : GameState
    {
        public override IGameState Render(int eventCode)
        {
            MainForm form = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f is MainForm mf)
                {
                    form = mf;
                    break;
                }
            }
            if (form == null) return this;

            form.ClearUI();

            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Label title = new Label
            {
                Text = "Quiz Game Main Menu",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(180, 30)
            };

            Button startBtn = new Button
            {
                Text = "Start Quiz",
                Size = new Size(200, 40),
                Location = new Point(200, 100)
            };

            Button uploadBtn = new Button
            {
                Text = "Upload Quiz",
                Size = new Size(200, 40),
                Location = new Point(200, 160)
            };

            Button createBtn = new Button
            {
                Text = "Create Quiz",
                Size = new Size(200, 40),
                Location = new Point(200, 220)
            };

            Button exitBtn = new Button
            {
                Text = "Exit",
                Size = new Size(200, 40),
                Location = new Point(200, 280)
            };

            startBtn.Click += (s, e) => form.TransitionTo(new InGameState());
            uploadBtn.Click += (s, e) => form.TransitionTo(new UploadQuizState());
            createBtn.Click += (s, e) => form.TransitionTo(new CreateQuizState());
            exitBtn.Click += (s, e) => Application.Exit();

            panel.Controls.Add(title);
            panel.Controls.Add(startBtn);
            panel.Controls.Add(uploadBtn);
            panel.Controls.Add(createBtn);
            panel.Controls.Add(exitBtn);


            startBtn.Click += (s, e) => form.TransitionTo(new InGameState());
            uploadBtn.Click += (s, e) => form.TransitionTo(new UploadQuizState());
            exitBtn.Click += (s, e) => Application.Exit();

            panel.Controls.Add(title);
            panel.Controls.Add(startBtn);
            panel.Controls.Add(uploadBtn);
            panel.Controls.Add(exitBtn);
            form.AddControl(panel);

            return this;
        }

        public override IGameState HandleInput(string apply, string save, string revert) => this;
        protected override IGameState NextState(int eventCode) => this;
    }
}
