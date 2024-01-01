namespace GymOtomasyon
{
    partial class Form3
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
            listView1 = new ListView();
            workoutId = new ColumnHeader();
            workoutName = new ColumnHeader();
            workoutSet = new ColumnHeader();
            workoutRepeat = new ColumnHeader();
            workoutDay = new ColumnHeader();
            workoutPlace = new ColumnHeader();
            workoutDesc = new ColumnHeader();
            ekle = new Button();
            sil = new Button();
            düzenle = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.BackColor = Color.White;
            listView1.Columns.AddRange(new ColumnHeader[] { workoutId, workoutName, workoutSet, workoutRepeat, workoutDay, workoutPlace, workoutDesc });
            listView1.Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.ForeColor = Color.Black;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(24, 105);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(753, 338);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // workoutId
            // 
            workoutId.Text = "Id";
            workoutId.Width = 50;
            // 
            // workoutName
            // 
            workoutName.Text = "Egzersiz Adı";
            workoutName.Width = 120;
            // 
            // workoutSet
            // 
            workoutSet.Text = "Set";
            workoutSet.Width = 50;
            // 
            // workoutRepeat
            // 
            workoutRepeat.Text = "Tekrar";
            // 
            // workoutDay
            // 
            workoutDay.Text = "Gün";
            workoutDay.Width = 50;
            // 
            // workoutPlace
            // 
            workoutPlace.Text = "Etkili Bölge";
            workoutPlace.Width = 120;
            // 
            // workoutDesc
            // 
            workoutDesc.Text = "Açıklama";
            workoutDesc.Width = 300;
            // 
            // ekle
            // 
            ekle.AutoSize = true;
            ekle.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            ekle.FlatAppearance.BorderSize = 2;
            ekle.FlatStyle = FlatStyle.Flat;
            ekle.Font = new Font("HP Simplified", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            ekle.ForeColor = Color.White;
            ekle.Location = new Point(454, 64);
            ekle.Name = "ekle";
            ekle.Size = new Size(89, 31);
            ekle.TabIndex = 1;
            ekle.Text = "Ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // sil
            // 
            sil.AutoSize = true;
            sil.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            sil.FlatAppearance.BorderSize = 2;
            sil.FlatStyle = FlatStyle.Flat;
            sil.Font = new Font("HP Simplified", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            sil.ForeColor = Color.White;
            sil.Location = new Point(570, 64);
            sil.Name = "sil";
            sil.Size = new Size(89, 31);
            sil.TabIndex = 2;
            sil.Text = "Sil";
            sil.UseVisualStyleBackColor = true;
            sil.Click += sil_Click;
            // 
            // düzenle
            // 
            düzenle.AutoSize = true;
            düzenle.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            düzenle.FlatAppearance.BorderSize = 2;
            düzenle.FlatStyle = FlatStyle.Flat;
            düzenle.Font = new Font("HP Simplified", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            düzenle.ForeColor = Color.White;
            düzenle.Location = new Point(688, 64);
            düzenle.Name = "düzenle";
            düzenle.Size = new Size(89, 31);
            düzenle.TabIndex = 3;
            düzenle.Text = "Düzenle";
            düzenle.UseVisualStyleBackColor = true;
            düzenle.Click += düzenle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 18);
            label1.Name = "label1";
            label1.Size = new Size(420, 34);
            label1.TabIndex = 4;
            label1.Text = "Antrenman Programı Düzenleme";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("HP Simplified", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(13, 18);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 5;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(803, 471);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(düzenle);
            Controls.Add(sil);
            Controls.Add(ekle);
            Controls.Add(listView1);
            DoubleBuffered = true;
            Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antrenman Programı Düzenleme";
            TransparencyKey = Color.FromArgb(255, 192, 255);
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListView listView1;
        private ColumnHeader workoutId;
        private ColumnHeader workoutName;
        private ColumnHeader workoutSet;
        private ColumnHeader workoutRepeat;
        private ColumnHeader workoutDay;
        private ColumnHeader workoutPlace;
        private ColumnHeader workoutDesc;
        private Button ekle;
        private Button sil;
        private Button düzenle;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}