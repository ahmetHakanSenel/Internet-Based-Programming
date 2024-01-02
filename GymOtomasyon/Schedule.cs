using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using GymOtomasyon.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace GymOtomasyon
{
    public partial class Schedule : Form
    {
        private Users currentUser;
        public string email;

        internal Schedule(Users user, string email)
        {
            InitializeComponent();
            InitializeListView();
            DisplayExercises();
            this.currentUser = user;
            this.email = email;
            label1.Text = user.FirstName + " Antrenman Programı";
            CultureInfo trCulture = new CultureInfo("tr-TR");
            label2.Text = "Tarih: " + DateTime.Now.ToString("dd.MM.yyyy, dddd", trCulture);
            this.email = email;
        }


        private void InitializeListView()
        {
            // Set up columns in the ListView
            listViewExercises.Columns.Add("Day", 100);
            listViewExercises.Columns.Add("Title", 150);
            listViewExercises.Columns.Add("Sets", 50);
            listViewExercises.Columns.Add("Reps", 50);
            listViewExercises.Columns.Add("Description", 200);
            listViewExercises.Columns.Add("Place", 100);

            // Optionally, add more formatting or adjust the column widths
            // listViewExercises.FullRowSelect = true;
            // listViewExercises.GridLines = true;

            // Set up the ListView to allow viewing of details
            listViewExercises.View = View.Details;
        }

        private void DisplayExercises()
        {
            // Sample data for demonstration purposes
            // Replace this with actual data retrieval logic
            var exercises = DBExercise.GetExercises(this.email); // Assumes you have a method to retrieve exercises from the database

            foreach (DataRow row in exercises.Rows)
            {
                string day = row["day"].ToString();
                string title = row["title"].ToString();
                int set = Convert.ToInt32(row["set_times"]);
                int rep = Convert.ToInt32(row["rep_times"]);
                string desc = row["work_desc"].ToString();
                string workoutPlace = row["workout_place"].ToString();

                // Create a ListViewItem and add it to the ListView
                ListViewItem item = new ListViewItem(new[] { day, title, set.ToString(), rep.ToString(), desc, workoutPlace });
                listViewExercises.Items.Add(item);
            }

            // Sort the ListView based on the Day column
            listViewExercises.Sorting = SortOrder.Ascending;
            listViewExercises.Sort();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPanel userPanel = new UserPanel(currentUser);
            userPanel.Show();

        }

        private void listViewExercises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
