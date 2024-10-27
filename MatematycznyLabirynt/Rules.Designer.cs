namespace MatematycznyLabirynt
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            btnHomeForm = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnHomeForm
            // 
            btnHomeForm.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomeForm.Location = new Point(910, 856);
            btnHomeForm.Name = "btnHomeForm";
            btnHomeForm.Size = new Size(320, 89);
            btnHomeForm.TabIndex = 0;
            btnHomeForm.Text = "POWRÓT";
            btnHomeForm.UseVisualStyleBackColor = true;
            btnHomeForm.Click += btnHomeForm_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Teal;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(57, 310);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1183, 275);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Teal;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(364, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(701, 128);
            textBox2.TabIndex = 2;
            textBox2.Text = "ZASADY GRY";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Teal;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 48F, FontStyle.Italic, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(743, 675);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(445, 86);
            textBox3.TabIndex = 3;
            textBox3.Text = "Powodzenia!";
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1264, 985);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnHomeForm);
            Name = "Rules";
            Text = "Zasady gry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHomeForm;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}