using System.Windows.Forms;

// Main Windows Forms interface for the quiz game
namespace QuizGame
{
    public class MainForm : Form
    {
        private GameController controller;

        public MainForm()
        {
            this.Text = "Quiz Game";
            this.Width = 600;
            this.Height = 400;

            this.Load += (s, e) =>
            {
                controller = new GameController(this);
                controller.StartGame();
            };
        }

        public void ClearUI()
        {
            this.Controls.Clear();
        }

        public void AddControl(Control ctrl)
        {
            this.Controls.Add(ctrl);
        }

        public void TransitionTo(IGameState newState)
        {
            controller.ChangeState(newState);
        }
    }
}
