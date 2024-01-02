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

namespace GymOtomasyon
{
    public partial class UserAdd : Form
    {

        private string connectionString = "server=localhost;database=your_database_name;uid=your_username;password=your_password;";

        public UserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan değerleri al
            string firstName = first_name.Text;
            string lastName = last_name.Text;
            string userEmail = email.Text;
            string userPhone = phone.Text;
            int userAge = Convert.ToInt16(age.Text);
            int userHeight = Convert.ToInt16(height.Text);
            int userWeight = Convert.ToInt16(weight.Text);
            DateTime startedAt = started_at.Value;
            DateTime endedAt = ended_at.Value;
            string password = textBox1.Text; 

            Users user = new Users(firstName, lastName, userEmail, userAge, userHeight, userWeight, userPhone, startedAt, endedAt, password);
         
            DBUsers.AddUser(user);

            AdminUser adminUser = new AdminUser();
            adminUser.Show();
            this.Close();
        }


        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUser user = new AdminUser();
            user.Show();
        }

        
    }
}

