using GymOtomasyon.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            Users user = DBUsers.GetUserForLogin(email, password);

            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                password = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            if (user != null)
            {
                if (user.Email == "admin" && user.Password == password)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                else
                {
                    this.Hide();
                    UserPanel userPanel = new UserPanel(user);
                    userPanel.Show();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
