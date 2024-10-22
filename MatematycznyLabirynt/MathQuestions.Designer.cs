namespace MatematycznyLabirynt
{
    partial class MathQuestions
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
            questionLabel = new Label();
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.BackColor = Color.FromArgb(255, 192, 192);
            questionLabel.Location = new Point(159, 62);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(38, 15);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "label1";
            // 
            // btnAnswer1
            // 
            btnAnswer1.Location = new Point(22, 169);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(75, 23);
            btnAnswer1.TabIndex = 1;
            btnAnswer1.Text = "btnAnswer1";
            btnAnswer1.UseVisualStyleBackColor = true;
            btnAnswer1.Click += btnAnswer1_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.Location = new Point(244, 169);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(75, 23);
            btnAnswer2.TabIndex = 2;
            btnAnswer2.Text = "button1";
            btnAnswer2.UseVisualStyleBackColor = true;
            btnAnswer2.Click += btnAnswer2_Click;
            // 
            // MathQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(363, 295);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Controls.Add(questionLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(500, 500);
            Name = "MathQuestions";
            Text = "MathQuestions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionLabel;
        private Button btnAnswer1;
        private Button btnAnswer2;
    }
}