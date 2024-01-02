using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymOtomasyon.Models
{
    internal class DBUsers
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "Server=127.0.0.1;Database=qfit;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(sql);

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex);
            }
            return connection;
        }

        public static void AddUser(Users std)
        {
            // Şifreyi hash'leyin
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(std.Password));
                std.Password = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            string sql = "INSERT INTO users (first_name, last_name, email, age, height, weight, phone, started_at, ended_at, user_pass) VALUES (@FirstName, @LastName, @Email, @Age, @Height, @Weight, @Phone, @StartedAt, @EndedAt, @Password)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = std.FirstName;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = std.LastName;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@Age", MySqlDbType.Int32).Value = std.Age; // Age is an integer
            cmd.Parameters.Add("@Height", MySqlDbType.Int32).Value = std.Height; // Height is an integer
            cmd.Parameters.Add("@Weight", MySqlDbType.Int32).Value = std.Weight; // Weight is an integer
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = std.Phone;
            cmd.Parameters.Add("@StartedAt", MySqlDbType.Timestamp).Value = std.StartedAt; // StartedAt is a timestamp
            cmd.Parameters.Add("@EndedAt", MySqlDbType.Timestamp).Value = std.EndedAt; // EndedAt is a timestamp
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = std.Password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oldu");
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }


        public static void UpdateUser(Users std, string id)
        {
            

            string sql = "UPDATE users SET first_name = @FirstName, last_name = @LastName, email = @Email, age = @Age, height = @Height, weight = @Weight, phone = @Phone, started_at = @StartedAt, ended_at = @EndedAt WHERE id = @Id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = std.FirstName;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = std.LastName;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@Age", MySqlDbType.Int32).Value = std.Age; // Age is an integer
            cmd.Parameters.Add("@Height", MySqlDbType.Int32).Value = std.Height; // Height is an integer
            cmd.Parameters.Add("@Weight", MySqlDbType.Int32).Value = std.Weight; // Weight is an integer
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = std.Phone;
            cmd.Parameters.Add("@StartedAt", MySqlDbType.Timestamp).Value = std.StartedAt; // StartedAt is a timestamp
            cmd.Parameters.Add("@EndedAt", MySqlDbType.Timestamp).Value = std.EndedAt; // EndedAt is a timestamp

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oldu");
            }
            catch
            {
                MessageBox.Show("Olmadı");
            }
            connection.Close();
        }


        public static void DeleteUser(string id)
        {
            string sql = "DELETE FROM users WHERE id = @Id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");
            }
            catch
            {
                MessageBox.Show("Silinemedi");
            }
            connection.Close();
        }

        public static Users GetUserForLogin(string email, string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                password = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }


            string sql = "SELECT * FROM users WHERE email = @Email AND user_pass = @Password";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            Users user = null;

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Users(
                            reader["first_name"].ToString(),
                            reader["last_name"].ToString(),
                            reader["email"].ToString(),
                            Convert.ToInt32(reader["age"]),
                            Convert.ToInt32(reader["height"]),
                            Convert.ToInt32(reader["weight"]),
                            reader["phone"].ToString(),
                            Convert.ToDateTime(reader["started_at"]),
                            Convert.ToDateTime(reader["ended_at"]),
                            password
                        );
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş bilgileri.", "Error");
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe, "Error");
            }
            finally
            {
                connection.Close();
            }

            return user;
        }

        public static DataTable GetUsers()
        {
            DataTable usersDataTable = new DataTable();

            string sql = "SELECT id, first_name, last_name, phone FROM Users"; // Sütunları belirttiğiniz sorgu
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            try
            {


                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    usersDataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return usersDataTable;
        }

        public static DataTable GetUserById(int userId)
        {
            DataTable userDataTable = new DataTable();

            string sql = "SELECT * FROM Users WHERE id = @UserId";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@UserId", userId);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    userDataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return userDataTable;
        }


        // In DBUsers class
        public static DataTable GetUserByEmail(string email)
        {
            DataTable userDataTable = new DataTable();

            string sql = "SELECT * FROM Users WHERE email = @Email";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Email", email);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    userDataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return userDataTable;
        }

        public static void UpdateUserPasswordByEmail(string email, string newPassword)
        {
            string sql = "UPDATE users SET user_pass = @Password WHERE email = @Email";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = newPassword;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating password in the database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Inside DBUsers class
        public static int GetUserCount()
        {
            int userCount = 0;
            string sql = "SELECT COUNT(*) FROM users";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            try
            {
                userCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user count from the database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return userCount;
        }

        internal static int GetUserIdByEmail(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
