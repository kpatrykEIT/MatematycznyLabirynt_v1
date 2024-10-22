namespace MatematycznyLabirynt
{
    partial class Game2
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
            levelTwoLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // levelTwoLabel
            // 
            levelTwoLabel.AutoSize = true;
            levelTwoLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            levelTwoLabel.ForeColor = SystemColors.ButtonFace;
            levelTwoLabel.Location = new Point(12, 9);
            levelTwoLabel.Name = "levelTwoLabel";
            levelTwoLabel.Size = new Size(300, 86);
            levelTwoLabel.TabIndex = 1;
            levelTwoLabel.Text = "Poziom 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1014, 473);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Game2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1264, 985);
            Controls.Add(label1);
            Controls.Add(levelTwoLabel);
            ForeColor = Color.White;
            Name = "Game2";
            Text = "Game2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label levelTwoLabel;
        private Label label1;
    }
}