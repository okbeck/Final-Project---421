using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public partial class Play_Game : Form
    {
        private GameController controller;

        public Play_Game(GameController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.Load += Play_Game_Load;
        }

        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnSubmit;

        private void Play_Game_Load(object sender, EventArgs e)
        {
            // Create UI controls manually
            lblQuestion = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20),
                Font = new System.Drawing.Font("Segoe UI", 12),
                Width = 500
            };
            txtAnswer = new TextBox
            {
                Location = new System.Drawing.Point(20, 60),
                Width = 300
            };
            btnSubmit = new Button
            {
                Text = "Submit",
                Location = new System.Drawing.Point(330, 58),
                Width = 80
            };

            btnSubmit.Click += BtnSubmit_Click;

            this.Controls.Add(lblQuestion);
            this.Controls.Add(txtAnswer);
            this.Controls.Add(btnSubmit);

            LoadQuestion();
        }

        private void LoadQuestion()
        {
            var question = controller.GetCurrentQuestion();
            if (question != null)
            {
                lblQuestion.Text = question is AbstractQuestion aq ? aq.GetPrompt() : "Question loaded.";
                txtAnswer.Text = "";
            }
            else
            {
                lblQuestion.Text = "Quiz Complete!";
                txtAnswer.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // You can capture txtAnswer.Text if needed
            controller.SubmitAnswer();  // This evaluates and moves to next
            LoadQuestion();
        }
    }
}
