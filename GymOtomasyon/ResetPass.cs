using GymOtomasyon.Models;
using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;

namespace GymOtomasyon
{
    public partial class ResetPass : Form
    {
        private string userEmail;
        Users currentUser;

        internal ResetPass(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.userEmail = currentUser.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text.Trim();
            string confirmPassword = textBox2.Text.Trim();

            // Check if passwords match
            if (newPassword == confirmPassword)
            {
                // Hash the new password
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(newPassword));
                    newPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                }

                // Update the password in the database
                try
                {
                    DBUsers.UpdateUserPasswordByEmail(userEmail, newPassword);
                    MessageBox.Show("Şifreniz değişti!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
