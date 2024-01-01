// EditForm.cs
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
            txtWorkoutPlace.Text = selectedItem.SubItems[5].Text;
            txtWorkoutDesc.Text = selectedItem.SubItems[6].Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği verileri alın (bu kısmı uygulamanıza uygun olarak düzenleyin)
            string workoutName = txtWorkoutName.Text;
            string workoutSet = txtWorkoutSet.Text;
            string workoutRepeat = txtWorkoutRepeat.Text;
            string workoutDay = txtWorkoutDay.Text;
            string workoutPlace = txtWorkoutPlace.Text;
            string workoutDesc = txtWorkoutDesc.Text;

            // Bu verileri kullanarak işlemleri gerçekleştirin (örneğin ListView'de güncelleme)
            selectedItem.SubItems[1].Text = workoutName;
            selectedItem.SubItems[2].Text = workoutSet;
            selectedItem.SubItems[3].Text = workoutRepeat;
            selectedItem.SubItems[4].Text = workoutDay;
            selectedItem.SubItems[5].Text = workoutPlace;
            selectedItem.SubItems[6].Text = workoutDesc;

            // Formu kapatın
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
