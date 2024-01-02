namespace GymOtomasyon
{
    partial class AddForm
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
            txtWorkoutName = new TextBox();
            txtWorkoutSet = new TextBox();
            txtWorkoutRepeat = new TextBox();
            txtWorkoutDay = new TextBox();
            txtWorkoutPlace = new TextBox();
            txtWorkoutDesc = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtWorkoutName
            // 
            txtWorkoutName.BackColor = Color.FromArgb(41, 44, 51);
            txtWorkoutName.BorderStyle = BorderStyle.FixedSingle;
            txtWorkoutName.ForeColor = Color.White;
            txtWorkoutName.Location = new Point(120, 138);
            txtWorkoutName.Name = "txtWorkoutName";
            txtWorkoutName.Size = new Size(135, 21);
            txtWorkoutName.TabIndex = 0;
            // 
            // txtWorkoutSet
            // 
            txtWorkoutSet.BackColor = Color.FromArgb(41, 44, 51);
            txtWorkoutSet.BorderStyle = BorderStyle.FixedSingle;
            txtWorkoutSet.ForeColor = Color.White;
            txtWorkoutSet.Location = new Point(336, 138);
            txtWorkoutSet.Name = "txtWorkoutSet";
            txtWorkoutSet.Size = new Size(135, 21);
            txtWorkoutSet.TabIndex = 1;
            // 
            // txtWorkoutRepeat
            // 
            txtWorkoutRepeat.BackColor = Color.FromArgb(41, 44, 51);
            txtWorkoutRepeat.BorderStyle = BorderStyle.FixedSingle;
            txtWorkoutRepeat.ForeColor = Color.White;
            txtWorkoutRepeat.Location = new Point(120, 212);
            txtWorkoutRepeat.Name = "txtWorkoutRepeat";
            txtWorkoutRepeat.Size = new Size(135, 21);
            txtWorkoutRepeat.TabIndex = 2;
            // 
            // txtWorkoutDay
            // 
            txtWorkoutDay.BackColor = Color.FromArgb(41, 44, 51);
            txtWorkoutDay.BorderStyle = BorderStyle.FixedSingle;
            txtWorkoutDay.ForeColor = Color.White;
            txtWorkoutDay.Location = new Point(336, 212);
            txtWorkoutDay.Name = "txtWorkoutDay";
            txtWorkoutDay.Size = new Size(135, 21);
            txtWorkoutDay.TabIndex = 3;
            // 
            // txtWorkoutPlace
            // 
            txtWorkoutPlace.BackColor = Color.FromArgb(41, 44, 51);
            txtWorkoutPlace.BorderStyle = BorderStyle.FixedSingle;
            txtWorkoutPlace.ForeColor = Color.White;
            txtWorkoutPlace.Location = new Point(120, 293);
            txtWorkoutPlace.Name = "txtWorkoutPlace";
            txtWorkoutPlace.Size = new Size(135, 21);
            txtWorkoutPlace.TabIndex = 4;
            // 
            // txtWorkoutDesc
            // 
            txtWorkoutDesc.BackColor = Color.FromArgb(41, 44, 51);
            txtWorkoutDesc.BorderStyle = BorderStyle.FixedSingle;
            txtWorkoutDesc.ForeColor = Color.White;
            txtWorkoutDesc.Location = new Point(336, 293);
            txtWorkoutDesc.Name = "txtWorkoutDesc";
            txtWorkoutDesc.Size = new Size(135, 21);
            txtWorkoutDesc.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(130, 0, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 376);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 6;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 141);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 7;
            label1.Text = "Antrenman Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(277, 141);
            label2.Name = "label2";
            label2.Size = new Size(24, 16);
            label2.TabIndex = 8;
            label2.Text = "Set";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 221);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 9;
            label3.Text = "Tekrar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 297);
            label4.Name = "label4";
            label4.Size = new Size(91, 16);
            label4.TabIndex = 10;
            label4.Text = "Çalıştırdığı Bölge";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(278, 215);
            label5.Name = "label5";
            label5.Size = new Size(26, 16);
            label5.TabIndex = 11;
            label5.Text = "Gün";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(278, 297);
            label6.Name = "label6";
            label6.Size = new Size(52, 16);
            label6.TabIndex = 12;
            label6.Text = "Açıklama";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("HP Simplified", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 34);
            label7.Name = "label7";
            label7.Size = new Size(212, 34);
            label7.TabIndex = 13;
            label7.Text = "Antrenman Ekle";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 44, 41);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(278, 376);
            button2.Name = "button2";
            button2.Size = new Size(87, 33);
            button2.TabIndex = 14;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(41, 44, 51);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(360, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 21);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(538, 454);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtWorkoutDesc);
            Controls.Add(txtWorkoutPlace);
            Controls.Add(txtWorkoutDay);
            Controls.Add(txtWorkoutRepeat);
            Controls.Add(txtWorkoutSet);
            Controls.Add(txtWorkoutName);
            Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWorkoutName;
        private TextBox txtWorkoutSet;
        private TextBox txtWorkoutRepeat;
        private TextBox txtWorkoutDay;
        private TextBox txtWorkoutPlace;
        private TextBox txtWorkoutDesc;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private TextBox textBox1;
    }
}