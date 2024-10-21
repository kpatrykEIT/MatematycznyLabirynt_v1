namespace MatematycznyLabirynt
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
            textBox1 = new TextBox();
            btnPlay = new Button();
            btnHowToPlay = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 64, 0);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(148, 144);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(996, 128);
            textBox1.TabIndex = 0;
            textBox1.Text = "Matematyczny Labirynt";
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.Location = new Point(505, 381);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(277, 109);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "GRAJ";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnHowToPlay
            // 
            btnHowToPlay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnHowToPlay.Location = new Point(505, 546);
            btnHowToPlay.Name = "btnHowToPlay";
            btnHowToPlay.Size = new Size(277, 109);
            btnHowToPlay.TabIndex = 2;
            btnHowToPlay.Text = "JAK GRAĆ?";
            btnHowToPlay.UseVisualStyleBackColor = true;
            btnHowToPlay.Click += btnHowToPlay_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.Location = new Point(505, 690);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(277, 109);
            btnQuit.TabIndex = 3;
            btnQuit.Text = "WYJDŹ";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(1264, 985);
            Controls.Add(btnQuit);
            Controls.Add(btnHowToPlay);
            Controls.Add(btnPlay);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Matematyczny Labirynt by Patryk Krukowski 193393";
            TransparencyKey = Color.Black;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnPlay;
        private Button btnHowToPlay;
        private Button btnQuit;
    }
}