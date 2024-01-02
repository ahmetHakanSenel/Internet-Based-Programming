using GymOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GymOtomasyon
{
    public partial class UserPanel : Form
    {
        private Users currentUser;

        internal UserPanel(Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            label1.Text = "Hoş Geldin " + currentUser.FirstName;

            // Retrieve user data from the database to get the ended_at and started_at dates
            DataTable userDataTable = DBUsers.GetUserByEmail(currentUser.Email);

            if (userDataTable.Rows.Count > 0)
            {
                DateTime startedAt = Convert.ToDateTime(userDataTable.Rows[0]["started_at"]);
                DateTime endedAt = Convert.ToDateTime(userDataTable.Rows[0]["ended_at"]);

                // Add debug statements
                Console.WriteLine($"StartedAt from Database: {startedAt}");
                Console.WriteLine($"EndedAt from Database: {endedAt}");

                // Display the end date in label3
                label3.Text = "Üyelik Bitiş Tarihi: " + endedAt.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);

                // Calculate and display the number of days since the user joined the gym
                if (endedAt > DateTime.Now)
                {
                    TimeSpan daysSinceJoined = DateTime.Now - startedAt;
                    label4.Text = "Üye Olduğun Gün Sayısı: " + daysSinceJoined.Days + " gün";
                }
                else
                {
                    label4.Text = "Üyeliğin Bitmiş";
                }
            }
            else
            {
                label3.Text = "Üyelik Bilgisi Bulunamadı";
                label4.Text = "Üyelik Bilgisi Bulunamadı";
            }
        }





        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Statics statics = new Statics();
            statics.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Schedule schedule = new Schedule(currentUser, currentUser.Email);
            schedule.ShowDialog();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetPass resetPass = new ResetPass(currentUser);
            resetPass.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
