using GymOtomasyon.Models;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GymOtomasyon
{
    public partial class UserEdit : Form
    {
        private int userId;

        public UserEdit(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            DataTable userData = DBUsers.GetUserById(userId);


            if (userData.Rows.Count > 0)
            {
                DataRow row = userData.Rows[0];
                first_name.Text = row["first_name"].ToString();
                last_name.Text = row["last_name"].ToString();
                age.Text = row["age"].ToString();
                height.Text = row["height"].ToString();
                weight.Text = row["weight"].ToString();
                phone.Text = row["phone"].ToString();
                email.Text = row["email"].ToString();
                started_at.Value = Convert.ToDateTime(row["started_at"].ToString());
                ended_at.Value = Convert.ToDateTime(row["ended_at"].ToString());

            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string firstName = first_name.Text;
            string lastName = last_name.Text;
            string userEmail = email.Text;
            string userPhone = phone.Text;
            int userAge = Convert.ToInt16(age.Text);
            int userHeight = Convert.ToInt16(height.Text);
            int userWeight = Convert.ToInt16(weight.Text);
            DateTime startedAt = started_at.Value;
            DateTime endedAt = ended_at.Value;

            Users user = new Users(firstName, lastName, userEmail, userAge, userHeight, userWeight, userPhone, startedAt, endedAt);



            // Update the user in the database
            DBUsers.UpdateUser(user, userId.ToString());

            MessageBox.Show("Kullanıcı başarıyla güncellendi.");

            // Close this form
            this.Close();

            // Open AdminUser form
            AdminUser adminUser = new AdminUser();
            adminUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUser adminUser = new AdminUser();
            adminUser.Show();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            // Load user data when the form is loaded
            LoadUserData();
        }



        






    }
}
