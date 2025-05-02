namespace Final_Project
{
    partial class Play_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrompt = new Label();
            btnOption1 = new Button();
            btnOption3 = new Button();
            btnOption4 = new Button();
            btnOption2 = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.BackColor = SystemColors.ButtonHighlight;
            lblPrompt.BorderStyle = BorderStyle.FixedSingle;
            lblPrompt.Location = new Point(12, 17);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(776, 221);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Question";
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOption1
            // 
            btnOption1.Location = new Point(12, 250);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(381, 85);
            btnOption1.TabIndex = 1;
            btnOption1.Text = "button1";
            btnOption1.UseVisualStyleBackColor = true;
            btnOption1.Click += OptionButton_Click;
            // 
            // btnOption3
            // 
            btnOption3.Location = new Point(12, 341);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(381, 85);
            btnOption3.TabIndex = 2;
            btnOption3.Text = "button2";
            btnOption3.UseVisualStyleBackColor = true;
            // 
            // btnOption4
            // 
            btnOption4.Location = new Point(399, 341);
            btnOption4.Name = "btnOption4";
            btnOption4.Size = new Size(389, 85);
            btnOption4.TabIndex = 4;
            btnOption4.Text = "button3";
            btnOption4.UseVisualStyleBackColor = true;
            // 
            // btnOption2
            // 
            btnOption2.Location = new Point(399, 250);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(389, 85);
            btnOption2.TabIndex = 3;
            btnOption2.Text = "button4";
            btnOption2.UseVisualStyleBackColor = true;
            // 
            // Play_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOption4);
            Controls.Add(btnOption2);
            Controls.Add(btnOption3);
            Controls.Add(btnOption1);
            Controls.Add(lblPrompt);
            Name = "Play_Game";
            Text = "Play_Game";
            ResumeLayout(false);
        }

        #endregion

        private Label lblPrompt;
        private Button btnOption1;
        private Button btnOption3;
        private Button btnOption4;
        private Button btnOption2;
    }
}