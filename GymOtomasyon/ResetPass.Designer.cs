namespace GymOtomasyon
{
    partial class ResetPass
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 88);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 0;
            label1.Text = "Yeni Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 128);
            label2.Name = "label2";
            label2.Size = new Size(93, 16);
            label2.TabIndex = 1;
            label2.Text = "Yeni Şifre Tekrar";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(41, 44, 51);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(215, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 21);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(41, 44, 51);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(215, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 21);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(130, 0, 0);
            button1.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("HP Simplified", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(119, 228);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 6;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 44, 51);
            button2.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("HP Simplified", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(255, 228);
            button2.Name = "button2";
            button2.Size = new Size(104, 35);
            button2.TabIndex = 7;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(479, 299);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}