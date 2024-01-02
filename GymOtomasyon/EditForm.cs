// EditForm.cs
using GymOtomasyon.Models;
using System;
using System.Windows.Forms;

namespace GymOtomasyon
{
    public partial class EditForm : Form
    {
        private ListViewItem selectedItem;

        public EditForm(ListViewItem item)
        {
            InitializeComponent();

            // Düzenlenecek öğeyi al
            selectedItem = item;

            // Önceki verileri form elemanlarına doldur
            txtWorkoutName.Text = selectedItem.SubItems[1].Text;
            txtWorkoutSet.Text = selectedItem.SubItems[2].Text;
            txtWorkoutRepeat.Text = selectedItem.SubItems[3].Text;
            txtWorkoutDay.Text = selectedItem.SubItems[4].Text;
            txtWorkoutPlace.Text = selectedItem.SubItems[6].Text;
            txtWorkoutDesc.Text = selectedItem.SubItems[5].Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string workoutName = txtWorkoutName.Text;
            int workoutSet = Convert.ToInt16(txtWorkoutSet.Text);
            int workoutRepeat = Convert.ToInt16(txtWorkoutRepeat.Text);
            string workoutDay = txtWorkoutDay.Text;
            string workoutPlace = txtWorkoutPlace.Text;
            string workoutDesc = txtWorkoutDesc.Text;
            int userId = Convert.ToInt16(textBox1.Text);

            // Seçilen öğenin kimliğini veya anahtarını al
            string selectedItemId = selectedItem.SubItems[0].Text; // Örnek olarak, 0. sütunun kimliği veya anahtarı olduğunu varsayalım

            selectedItem.SubItems[1].Text = workoutName;
            selectedItem.SubItems[2].Text = Convert.ToString(workoutSet);
            selectedItem.SubItems[3].Text = Convert.ToString(workoutRepeat);
            selectedItem.SubItems[4].Text = workoutDay;
            selectedItem.SubItems[5].Text = workoutPlace;
            selectedItem.SubItems[6].Text = workoutDesc;

            Exercises exercises = new Exercises(workoutName, workoutSet, workoutRepeat, workoutDay, workoutDesc, workoutPlace, userId);

            // Seçilen öğenin kimliğini veya anahtarını kullanarak güncelleme işlemini gerçekleştir
            DBExercise.UpdateExercise(exercises, selectedItemId);

            // Formu kapatın
            this.Close();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void txtWorkoutName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWorkoutPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWorkoutDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
