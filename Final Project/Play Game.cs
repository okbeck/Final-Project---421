using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Play_Game : Form
    {
        private GameController controller;

        public Play_Game(GameController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        // Optional fallback constructor
        public Play_Game() : this(Program.Controller) { }

        private void LoadQuestion()
        {
            var question = controller.GetCurrentQuestion();
            if (question == null)
            {
                lblPrompt.Text = "Quiz Complete!";
                //txtAnswer.Enabled = false;
                //btnSubmit.Enabled = false;
                btnOption1.Visible = false;
                btnOption2.Visible = false;
                btnOption3.Visible = false;
                btnOption4.Visible = false;
                return;
            }

            if (question is AbstractQuestion aq)
                lblPrompt.Text = aq.GetPrompt();

            if (question is MultipleChoice mc)
            {
                var options = mc.GetOptions(); // implement GetOptions() in MultipleChoice
                btnOption1.Text = options.Count > 0 ? options[0] : "";
                btnOption2.Text = options.Count > 1 ? options[1] : "";
                btnOption3.Text = options.Count > 2 ? options[2] : "";
                btnOption4.Text = options.Count > 3 ? options[3] : "";

                btnOption1.Visible = true;
                btnOption2.Visible = true;
                btnOption3.Visible = true;
                btnOption4.Visible = true;

                //txtAnswer.Visible = false;
                //btnSubmit.Visible = false;
            }
            else
            {
                // Open-ended question
               // txtAnswer.Visible = true;
                //btnSubmit.Visible = true;

                btnOption1.Visible = false;
                btnOption2.Visible = false;
                btnOption3.Visible = false;
                btnOption4.Visible = false;
            }
        }


        private void OptionButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var current = controller.GetCurrentQuestion();

            if (current is MultipleChoice mc)
            {
                mc.SetUserChoice(button.Text); // Implement SetUserChoice in MultipleChoice
                controller.SubmitAnswer();
                LoadQuestion();
            }
        }


    }
}
