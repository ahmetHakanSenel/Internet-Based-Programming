namespace GymOtomasyon
{
    partial class Schedule
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
            listViewExercises = new ListView();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listViewExercises
            // 
            listViewExercises.Location = new Point(36, 153);
            listViewExercises.Name = "listViewExercises";
            listViewExercises.Size = new Size(612, 293);
            listViewExercises.TabIndex = 0;
            listViewExercises.UseCompatibleStateImageBehavior = false;
            listViewExercises.SelectedIndexChanged += listViewExercises_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("HP Simplified", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(36, 33);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 7;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 109);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 9;
            label2.Text = "Tarih: ";
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(686, 480);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(listViewExercises);
            Font = new Font("HP Simplified", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Schedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule";
            Load += Schedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewExercises;
        private Button button3;
        private Label label1;
        private Label label2;
    }
}