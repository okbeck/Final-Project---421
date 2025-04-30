using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectQuiz_Click(object sender, EventArgs e)
        {
            SelectionForm quizSelect = new SelectionForm();
            quizSelect.Show();
            quizSelect.Closed += (s, a) => { Show(); };
            Hide();
        }

        private void btnRandomQuiz_Click(object sender, EventArgs e)
        {
            // You can optionally call Program.Controller.ChangeState(...) here
            Play_Game game = new Play_Game(Program.Controller); // pass it if needed
            game.Show();
            game.Closed += (s, a) => { Show(); };
            Hide();
        }

        private void btnUploadQuiz_Click(object sender, EventArgs e)
        {
            QuizUpload upload = new QuizUpload();
            upload.Show();
            upload.Closed += (s, a) => { Show(); };
            Hide();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            QuizCreation create = new QuizCreation();
            create.Show();
            create.Closed += (s, a) => { Show(); };
            Hide();
        }
    }
}
