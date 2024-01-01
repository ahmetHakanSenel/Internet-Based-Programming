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
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            userId = new ColumnHeader();
            userName = new ColumnHeader();
            userSurname = new ColumnHeader();
            userPhone = new ColumnHeader();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 44);
            label1.Name = "label1";
            label1.Size = new Size(219, 34);
            label1.TabIndex = 0;
            label1.Text = "Müşteri İşlemleri";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(392, 91);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 1;
            button1.Text = "Müşteri Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(540, 91);
            button2.Name = "button2";
            button2.Size = new Size(117, 39);
            button2.TabIndex = 2;
            button2.Text = "Müşteri Düzenle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { userId, userName, userSurname, userPhone });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(32, 151);
            listView1.Name = "listView1";
            listView1.Size = new Size(625, 299);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // userId
            // 
            userId.Text = "Id";
            // 
            // userName
            // 
            userName.Text = "Name";
            userName.Width = 180;
            // 
            // userSurname
            // 
            userSurname.Text = "Surname";
            userSurname.Width = 180;
            // 
            // userPhone
            // 
            userPhone.Text = "Phone";
            userPhone.Width = 180;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("HP Simplified", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(18, 44);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 6;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(686, 480);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader userId;
        private ColumnHeader userName;
        private ColumnHeader userSurname;
        private ColumnHeader userPhone;
        private Button button3;
    }
}