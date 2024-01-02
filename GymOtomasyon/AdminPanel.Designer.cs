namespace GymOtomasyon
{
    partial class AdminPanel
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
            panel1 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 450);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 386);
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
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 42);
            label1.TabIndex = 0;
            label1.Text = "QFit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("HP Simplified", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(166, 0);
            button4.Name = "button4";
            button4.Size = new Size(317, 450);
            button4.TabIndex = 1;
            button4.Text = "Antrenman İşlemleri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("HP Simplified", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(483, 0);
            button5.Name = "button5";
            button5.Size = new Size(316, 450);
            button5.TabIndex = 2;
            button5.Text = "Kullanıcı İşlemleri";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 219);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // AdminPanel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button4;
        private Button button5;
        private Label label2;
    }
}