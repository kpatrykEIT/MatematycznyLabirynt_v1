namespace MatematycznyLabirynt
{
    partial class MainMenu
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
            textBox1 = new TextBox();
            btnPlay = new Button();
            btnHowToPlay = new Button();
            btnQuit = new Button();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Teal;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(148, 144);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(996, 128);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Matematyczny Labirynt";
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.White;
            btnPlay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(574, 352);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(198, 58);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "GRAJ";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnHowToPlay
            // 
            btnHowToPlay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHowToPlay.ForeColor = Color.White;
            btnHowToPlay.Location = new Point(574, 446);
            btnHowToPlay.Name = "btnHowToPlay";
            btnHowToPlay.Size = new Size(198, 58);
            btnHowToPlay.TabIndex = 2;
            btnHowToPlay.Text = "JAK GRAĆ?";
            btnHowToPlay.UseVisualStyleBackColor = true;
            btnHowToPlay.Click += btnHowToPlay_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(574, 649);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(198, 58);
            btnQuit.TabIndex = 3;
            btnQuit.Text = "WYJDŹ";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.White;
            btnSettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(574, 548);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(198, 58);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "USTAWIENIA";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Teal;
            ClientSize = new Size(1264, 985);
            Controls.Add(btnSettings);
            Controls.Add(btnQuit);
            Controls.Add(btnHowToPlay);
            Controls.Add(btnPlay);
            Controls.Add(textBox1);
            Name = "MainMenu";
            Text = "Matematyczny Labirynt by Patryk Krukowski 193393";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnPlay;
        private Button btnHowToPlay;
        private Button btnQuit;
        private Button btnSettings;
    }
}