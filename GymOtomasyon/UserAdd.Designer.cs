namespace GymOtomasyon
{
    partial class UserAdd
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            first_name = new TextBox();
            last_name = new TextBox();
            started_at = new DateTimePicker();
            ended_at = new DateTimePicker();
            email = new TextBox();
            phone = new TextBox();
            label8 = new Label();
            age = new TextBox();
            height = new TextBox();
            label9 = new Label();
            weight = new TextBox();
            label10 = new Label();
            button2 = new Button();
            ekle = new Button();
            label11 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(225, 37);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Ekleme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 105);
            label2.Name = "label2";
            label2.Size = new Size(20, 16);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(255, 105);
            label3.Name = "label3";
            label3.Size = new Size(37, 16);
            label3.TabIndex = 1;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(118, 345);
            label4.Name = "label4";
            label4.Size = new Size(85, 16);
            label4.TabIndex = 2;
            label4.Text = "Başlangıç Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(255, 345);
            label5.Name = "label5";
            label5.Size = new Size(61, 16);
            label5.TabIndex = 3;
            label5.Text = "Bitiş Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(255, 177);
            label6.Name = "label6";
            label6.Size = new Size(29, 16);
            label6.TabIndex = 4;
            label6.Text = "GSM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(118, 177);
            label7.Name = "label7";
            label7.Size = new Size(34, 16);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // first_name
            // 
            first_name.BackColor = Color.FromArgb(41, 44, 51);
            first_name.BorderStyle = BorderStyle.FixedSingle;
            first_name.ForeColor = Color.White;
            first_name.Location = new Point(118, 124);
            first_name.Name = "first_name";
            first_name.Size = new Size(117, 21);
            first_name.TabIndex = 6;
            // 
            // last_name
            // 
            last_name.BackColor = Color.FromArgb(41, 44, 51);
            last_name.BorderStyle = BorderStyle.FixedSingle;
            last_name.ForeColor = Color.White;
            last_name.Location = new Point(255, 124);
            last_name.Name = "last_name";
            last_name.Size = new Size(117, 21);
            last_name.TabIndex = 7;
            // 
            // started_at
            // 
            started_at.CalendarMonthBackground = Color.FromArgb(41, 44, 51);
            started_at.Location = new Point(118, 364);
            started_at.Name = "started_at";
            started_at.Size = new Size(117, 21);
            started_at.TabIndex = 8;
            // 
            // ended_at
            // 
            ended_at.Location = new Point(255, 364);
            ended_at.Name = "ended_at";
            ended_at.Size = new Size(117, 21);
            ended_at.TabIndex = 9;
            // 
            // email
            // 
            email.BackColor = Color.FromArgb(41, 44, 51);
            email.BorderStyle = BorderStyle.FixedSingle;
            email.ForeColor = Color.White;
            email.Location = new Point(118, 196);
            email.Name = "email";
            email.Size = new Size(117, 21);
            email.TabIndex = 10;
            // 
            // phone
            // 
            phone.BackColor = Color.FromArgb(41, 44, 51);
            phone.BorderStyle = BorderStyle.FixedSingle;
            phone.ForeColor = Color.White;
            phone.Location = new Point(255, 196);
            phone.Name = "phone";
            phone.Size = new Size(117, 21);
            phone.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 288);
            label8.Name = "label8";
            label8.Size = new Size(24, 16);
            label8.TabIndex = 12;
            label8.Text = "Yaş";
            // 
            // age
            // 
            age.BackColor = Color.FromArgb(41, 44, 51);
            age.BorderStyle = BorderStyle.FixedSingle;
            age.ForeColor = Color.White;
            age.Location = new Point(118, 307);
            age.Name = "age";
            age.Size = new Size(50, 21);
            age.TabIndex = 13;
            // 
            // height
            // 
            height.BackColor = Color.FromArgb(41, 44, 51);
            height.BorderStyle = BorderStyle.FixedSingle;
            height.ForeColor = Color.White;
            height.Location = new Point(219, 307);
            height.Name = "height";
            height.Size = new Size(50, 21);
            height.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(219, 288);
            label9.Name = "label9";
            label9.Size = new Size(26, 16);
            label9.TabIndex = 14;
            label9.Text = "Boy";
            // 
            // weight
            // 
            weight.BackColor = Color.FromArgb(41, 44, 51);
            weight.BorderStyle = BorderStyle.FixedSingle;
            weight.ForeColor = Color.White;
            weight.Location = new Point(322, 307);
            weight.Name = "weight";
            weight.Size = new Size(50, 21);
            weight.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(333, 288);
            label10.Name = "label10";
            label10.Size = new Size(26, 16);
            label10.TabIndex = 16;
            label10.Text = "Kilo";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 44, 41);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(255, 416);
            button2.Name = "button2";
            button2.Size = new Size(87, 33);
            button2.TabIndex = 21;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ekle
            // 
            ekle.BackColor = Color.FromArgb(130, 0, 0);
            ekle.FlatAppearance.BorderSize = 0;
            ekle.FlatStyle = FlatStyle.Flat;
            ekle.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            ekle.ForeColor = Color.White;
            ekle.Location = new Point(148, 416);
            ekle.Name = "ekle";
            ekle.Size = new Size(87, 33);
            ekle.TabIndex = 20;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(118, 237);
            label11.Name = "label11";
            label11.Size = new Size(32, 16);
            label11.TabIndex = 22;
            label11.Text = "Şifre";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(41, 44, 51);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(118, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 21);
            textBox1.TabIndex = 23;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(508, 492);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(ekle);
            Controls.Add(weight);
            Controls.Add(label10);
            Controls.Add(height);
            Controls.Add(label9);
            Controls.Add(age);
            Controls.Add(label8);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(ended_at);
            Controls.Add(label1);
            Controls.Add(started_at);
            Controls.Add(label3);
            Controls.Add(last_name);
            Controls.Add(label2);
            Controls.Add(first_name);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox first_name;
        private TextBox last_name;
        private DateTimePicker started_at;
        private DateTimePicker ended_at;
        private TextBox email;
        private TextBox phone;
        private Label label8;
        private TextBox age;
        private TextBox height;
        private Label label9;
        private TextBox weight;
        private Label label10;
        private Button button2;
        private Button ekle;
        private Label label11;
        private TextBox textBox1;
    }
}