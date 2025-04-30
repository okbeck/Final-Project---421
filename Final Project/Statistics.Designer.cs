namespace Final_Project
{
    partial class Statistics
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
            vScrollBar1 = new VScrollBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(358, 1);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 450);
            vScrollBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(7, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 107);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(343, 30);
            label1.TabIndex = 2;
            label1.Text = "Search Bar";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(7, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(343, 102);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(317, 84);
            label2.TabIndex = 4;
            label2.Text = "Quiz Name\r\n-Amount of Questions\r\n-Overall Accuracy\r\n-Time to Complete\r\n-Attempts\r\n";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(21, 200);
            label3.Name = "label3";
            label3.Size = new Size(317, 79);
            label3.TabIndex = 5;
            label3.Text = "Quiz Name\r\n-Amount of Questions\r\n-Overall Accuracy\r\n-Time to Complete\r\n-Attempts\r\n";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(21, 316);
            label4.Name = "label4";
            label4.Size = new Size(317, 79);
            label4.TabIndex = 7;
            label4.Text = "Quiz Name\r\n-Amount of Questions\r\n-Overall Accuracy\r\n-Time to Complete\r\n-Attempts\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(7, 305);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(343, 102);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(vScrollBar1);
            Name = "Statistics";
            Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private VScrollBar vScrollBar1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
    }
}