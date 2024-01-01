namespace GymOtomasyon
{
    public partial class UserEdit : Form
    {
        private string connectionString = "server=localhost;database=your_database_name;uid=your_username;password=your_password;";
        private int userId; // Düzenlenecek kullanıcının ID'sini saklamak için

        public UserEdit(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // Kullanıcının bilgilerini al ve TextBox'lara yerleştir
            LoadUserData();
        }

        public UserEdit()
        {
            InitializeComponent();
        }

        private void LoadUserData()
        {
           /* using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM users WHERE UserID = @UserID";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            first_name.Text = reader["FirstName"].ToString();
                            last_name.Text = reader["LastName"].ToString();
                            email.Text = reader["Email"].ToString();
                            phone.Text = reader["Phone"].ToString();
                            age.Text = reader["Age"].ToString();
                            height.Text = reader["Height"].ToString();
                            weight.Text = reader["Weight"].ToString();
                            plan_id.Text = reader["PlanID"].ToString();
                            started_at.Value = Convert.ToDateTime(reader["StartedAt"]);
                            ended_at.Value = Convert.ToDateTime(reader["EndedAt"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }*/
        }

        private void ekle_Click(object sender, EventArgs e)
        {
           /* using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE users SET FirstName = @FirstName, LastName = @LastName, " +
                               "Email = @Email, Phone = @Phone, Age = @Age, Height = @Height, " +
                               "Weight = @Weight, PlanID = @PlanID, StartedAt = @StartedAt, EndedAt = @EndedAt " +
                               "WHERE UserID = @UserID";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", first_name.Text);
                command.Parameters.AddWithValue("@LastName", last_name.Text);
                command.Parameters.AddWithValue("@Email", email.Text);
                command.Parameters.AddWithValue("@Phone", phone.Text);
                command.Parameters.AddWithValue("@Age", Convert.ToInt32(age.Text));
                command.Parameters.AddWithValue("@Height", Convert.ToDouble(height.Text));
                command.Parameters.AddWithValue("@Weight", Convert.ToDouble(weight.Text));
                command.Parameters.AddWithValue("@PlanID", Convert.ToInt32(plan_id.Text));
                command.Parameters.AddWithValue("@StartedAt", started_at.Value);
                command.Parameters.AddWithValue("@EndedAt", ended_at.Value);
                command.Parameters.AddWithValue("@UserID", userId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPanel userPanel = new UserPanel();
            userPanel.Show();

        }
    }
}
