using System;
using System.Windows.Forms;
using GymOtomasyon.Models; // Import your models namespace

namespace GymOtomasyon
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            LoadUserCount(); // Call the method to load user count when the form is initialized
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminUser userPanel = new AdminUser();
            userPanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoadUserCount(); // Call the method to reload user count when the label is clicked
        }

        // Method to load and display user count in label
        private void LoadUserCount()
        {
            try
            {
                int userCount = DBUsers.GetUserCount();
                label2.Text = $"Toplam Müþteri: {userCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müþteri sayýsý alýrken hata oldu: {ex.Message}");
            }
        }
    }
}
