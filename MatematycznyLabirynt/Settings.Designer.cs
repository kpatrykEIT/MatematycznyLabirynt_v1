namespace MatematycznyLabirynt
{
    partial class Settings
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
            btnChangeBackColor = new Button();
            btnBackToMenu = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnChangeBackColor
            // 
            btnChangeBackColor.ForeColor = SystemColors.ButtonFace;
            btnChangeBackColor.Location = new Point(87, 348);
            btnChangeBackColor.Name = "btnChangeBackColor";
            btnChangeBackColor.Size = new Size(124, 75);
            btnChangeBackColor.TabIndex = 0;
            btnChangeBackColor.Text = "ZMIEŃ";
            btnChangeBackColor.UseVisualStyleBackColor = true;
            btnChangeBackColor.Click += btnChangeBackColor_Click;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackToMenu.ForeColor = SystemColors.ButtonFace;
            btnBackToMenu.Location = new Point(779, 793);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(420, 79);
            btnBackToMenu.TabIndex = 1;
            btnBackToMenu.Text = "POWRÓT";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(87, 295);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 4;
            label1.Text = "Zmień kolor tła:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(87, 84);
            label3.Name = "label3";
            label3.Size = new Size(594, 128);
            label3.TabIndex = 6;
            label3.Text = "USTAWIENIA";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1264, 985);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnChangeBackColor);
            Name = "Settings";
            Text = "Ustawienia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeBackColor;
        private Button btnBackToMenu;
        private Label label1;
        private Label label3;
    }
}