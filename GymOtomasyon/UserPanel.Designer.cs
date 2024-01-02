namespace GymOtomasyon
{
    partial class UserPanel
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button6 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 38);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Hoş Geldin ";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 480);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 247);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 189);
            label3.Name = "label3";
            label3.Size = new Size(37, 16);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 416);
            button6.Name = "button6";
            button6.Size = new Size(165, 64);
            button6.TabIndex = 3;
            button6.Text = "Çıkış Yap";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(130, 0, 0);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 100);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(30, 28);
            label2.Name = "label2";
            label2.Size = new Size(102, 42);
            label2.TabIndex = 0;
            label2.Text = "QFit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("HP Simplified", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(180, 154);
            button1.Name = "button1";
            button1.Size = new Size(229, 81);
            button1.TabIndex = 2;
            button1.Text = "Programım";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("HP Simplified", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(445, 154);
            button2.Name = "button2";
            button2.Size = new Size(229, 81);
            button2.TabIndex = 3;
            button2.Text = "İstatistikler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("HP Simplified", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(310, 288);
            button4.Name = "button4";
            button4.Size = new Size(229, 81);
            button4.TabIndex = 5;
            button4.Text = "Şifre Değiştirme";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(686, 480);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPanel";
            Load += UserPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button6;
        private Panel panel2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label label3;
        private Label label4;
    }
}