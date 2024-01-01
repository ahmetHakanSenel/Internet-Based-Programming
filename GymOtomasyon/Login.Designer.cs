namespace GymOtomasyon
{
    partial class Login
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
            PictureBox pictureBox1;
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(41, 44, 51);
            pictureBox1.Image = Properties.Resources.fitness_centre_physical_fitness_logo_work_out_10b4a62ee30268610487f2bbb7f4fce6;
            pictureBox1.Location = new Point(102, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(41, 44, 51);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 302);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(130, 0, 0);
            panel1.Location = new Point(53, 351);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 2);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(41, 44, 51);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(59, 324);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 18);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(41, 44, 51);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(59, 403);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 18);
            textBox2.TabIndex = 6;
            textBox2.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(130, 0, 0);
            panel2.Location = new Point(53, 430);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 2);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(41, 44, 51);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 381);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(130, 0, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("HP Simplified", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(59, 458);
            button1.Name = "button1";
            button1.Size = new Size(144, 46);
            button1.TabIndex = 7;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("HP Simplified", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(220, 458);
            button2.Name = "button2";
            button2.Size = new Size(144, 46);
            button2.TabIndex = 8;
            button2.Text = "Kapat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(130, 0, 0);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 15);
            panel3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(416, 541);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Giriş Sayfası";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel panel3;
    }
}