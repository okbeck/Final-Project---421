namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectQuiz = new Button();
            btnCreateQuiz = new Button();
            btnRandomQuiz = new Button();
            label1 = new Label();
            btnUploadQuiz = new Button();
            SuspendLayout();
            // 
            // btnSelectQuiz
            // 
            btnSelectQuiz.Location = new Point(12, 69);
            btnSelectQuiz.Name = "btnSelectQuiz";
            btnSelectQuiz.Size = new Size(305, 43);
            btnSelectQuiz.TabIndex = 0;
            btnSelectQuiz.Text = "Select Quiz";
            btnSelectQuiz.UseVisualStyleBackColor = true;
            btnSelectQuiz.Click += btnSelectQuiz_Click;
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.Location = new Point(12, 167);
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.Size = new Size(305, 43);
            btnCreateQuiz.TabIndex = 1;
            btnCreateQuiz.Text = "Create Quiz";
            btnCreateQuiz.UseVisualStyleBackColor = true;
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // btnRandomQuiz
            // 
            btnRandomQuiz.Location = new Point(12, 118);
            btnRandomQuiz.Name = "btnRandomQuiz";
            btnRandomQuiz.Size = new Size(305, 43);
            btnRandomQuiz.TabIndex = 2;
            btnRandomQuiz.Text = "Start Random Quiz";
            btnRandomQuiz.UseVisualStyleBackColor = true;
            btnRandomQuiz.Click += btnRandomQuiz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Quiz Game";
            // 
            // btnUploadQuiz
            // 
            btnUploadQuiz.Location = new Point(12, 216);
            btnUploadQuiz.Name = "btnUploadQuiz";
            btnUploadQuiz.Size = new Size(305, 43);
            btnUploadQuiz.TabIndex = 4;
            btnUploadQuiz.Text = "Upload Quiz";
            btnUploadQuiz.UseVisualStyleBackColor = true;
            btnUploadQuiz.Click += btnUploadQuiz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 275);
            Controls.Add(btnUploadQuiz);
            Controls.Add(label1);
            Controls.Add(btnRandomQuiz);
            Controls.Add(btnCreateQuiz);
            Controls.Add(btnSelectQuiz);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectQuiz;
        private Button btnCreateQuiz;
        private Button btnRandomQuiz;
        private Label label1;
        private Button btnUploadQuiz;
    }
}
