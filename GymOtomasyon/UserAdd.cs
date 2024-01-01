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
            int userAge = Convert.ToInt32(age.Text);
            double userHeight = Convert.ToDouble(height.Text);
            double userWeight = Convert.ToDouble(weight.Text);
            int planId = Convert.ToInt32(plan_id.Text);
            DateTime startedAt = started_at.Value;
            DateTime endedAt = ended_at.Value;

            // Veritabanı bağlantısını oluştur
            /*using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // SQL sorgusunu oluştur
                string query = "INSERT INTO users (FirstName, LastName, Email, Phone, Age, Height, Weight, PlanID, StartedAt, EndedAt) " +
                               "VALUES (@FirstName, @LastName, @Email, @Phone, @Age, @Height, @Weight, @PlanID, @StartedAt, @EndedAt)";

                // Parametreleri ekleyin
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", userEmail);
                command.Parameters.AddWithValue("@Phone", userPhone);
                command.Parameters.AddWithValue("@Age", userAge);
                command.Parameters.AddWithValue("@Height", userHeight);
                command.Parameters.AddWithValue("@Weight", userWeight);
                command.Parameters.AddWithValue("@PlanID", planId);
                command.Parameters.AddWithValue("@StartedAt", startedAt);
                command.Parameters.AddWithValue("@EndedAt", endedAt);

                try
                {
                    // Veritabanı bağlantısını açın
                    connection.Open();

                    // Sorguyu çalıştırın
                    command.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı başarıyla eklenmiştir.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }*/
        }

             void button2_Click(object sender, EventArgs e)
            {
                this.Close();
                UserPanel userPanel = new UserPanel();
                userPanel.Show();
            }
             

        }
    }

