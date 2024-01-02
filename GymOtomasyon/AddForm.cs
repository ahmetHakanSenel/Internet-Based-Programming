// AddForm.cs
using GymOtomasyon.Models;
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
            int workoutSet = Convert.ToInt16(txtWorkoutSet.Text);
            int workoutRepeat = Convert.ToInt16(txtWorkoutRepeat.Text);
            string workoutDay = txtWorkoutDay.Text;
            string workoutPlace = txtWorkoutPlace.Text;
            string workoutDesc = txtWorkoutDesc.Text;
            int userId = Convert.ToInt16(textBox1.Text);

            Exercises exercises = new Exercises(workoutName, workoutSet, workoutRepeat, workoutDay, workoutDesc, workoutPlace,userId);

            DBExercise.AddExercise(exercises);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
