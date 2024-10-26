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
            btnChangeFontSize = new Button();
            numericUpDownFontSize = new NumericUpDown();
            settingsTextBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).BeginInit();
            SuspendLayout();
            // 
            // btnChangeBackColor
            // 
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
            btnBackToMenu.Location = new Point(779, 793);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(420, 79);
            btnBackToMenu.TabIndex = 1;
            btnBackToMenu.Text = "POWRÓT";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // btnChangeFontSize
            // 
            btnChangeFontSize.Location = new Point(87, 505);
            btnChangeFontSize.Name = "btnChangeFontSize";
            btnChangeFontSize.Size = new Size(124, 75);
            btnChangeFontSize.TabIndex = 2;
            btnChangeFontSize.Text = "ZMIEŃ";
            btnChangeFontSize.UseVisualStyleBackColor = true;
            btnChangeFontSize.Click += btnChangeFontSize_Click;
            // 
            // numericUpDownFontSize
            // 
            numericUpDownFontSize.Location = new Point(243, 557);
            numericUpDownFontSize.Name = "numericUpDownFontSize";
            numericUpDownFontSize.Size = new Size(120, 23);
            numericUpDownFontSize.TabIndex = 3;
            // 
            // settingsTextBox
            // 
            settingsTextBox.BackColor = Color.Teal;
            settingsTextBox.BorderStyle = BorderStyle.None;
            settingsTextBox.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            settingsTextBox.ForeColor = Color.White;
            settingsTextBox.Location = new Point(377, 79);
            settingsTextBox.Name = "settingsTextBox";
            settingsTextBox.Size = new Size(646, 128);
            settingsTextBox.TabIndex = 4;
            settingsTextBox.Text = "USTAWIENIA";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Teal;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(87, 282);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 39);
            textBox1.TabIndex = 5;
            textBox1.Text = "Zmień kolor tła:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Teal;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(87, 443);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 39);
            textBox2.TabIndex = 6;
            textBox2.Text = "Zmień rozmiar czcionki:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1264, 985);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(settingsTextBox);
            Controls.Add(numericUpDownFontSize);
            Controls.Add(btnChangeFontSize);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnChangeBackColor);
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeBackColor;
        private Button btnBackToMenu;
        private Button btnChangeFontSize;
        private NumericUpDown numericUpDownFontSize;
        private TextBox settingsTextBox;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}