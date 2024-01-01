// AddForm.cs
using System;
using System.Windows.Forms;

namespace GymOtomasyon
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string workoutName = txtWorkoutName.Text;
            string workoutSet = txtWorkoutSet.Text;
            string workoutRepeat = txtWorkoutRepeat.Text;
            string workoutDay = txtWorkoutDay.Text;
            string workoutPlace = txtWorkoutPlace.Text;
            string workoutDesc = txtWorkoutDesc.Text;

            // Bu verileri kullanarak işlemleri gerçekleştirin (örneğin ListView'e ekleme)
            ListViewItem newItem = new ListViewItem(new[] { "2", workoutName, workoutSet, workoutRepeat, workoutDay, workoutPlace, workoutDesc });
            // Bu örnekteki ListView1, AddForm formundaki ListView nesnesinin adı
            ((Form3)Application.OpenForms["Form3"]).listView1.Items.Add(newItem);

            // Formu kapatın
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
