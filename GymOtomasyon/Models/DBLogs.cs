using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymOtomasyon.Models
{
    internal class DBLogs
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

        public static void AddLog(Logs log)
        {
            string sql = "INSERT INTO logs (entered_at, exited_at, user_id) VALUES (@Enter, @Exit, @UserId)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Enter", MySqlDbType.DateTime).Value = log.Enter;
            cmd.Parameters.Add("@Exit", MySqlDbType.DateTime).Value = log.Exit;
            cmd.Parameters.Add("@UserId", MySqlDbType.Int32).Value = log.UserId;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ekleme başarılı");
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }
        public static Dictionary<string, int> AnalyzeUserLogs(int userId)
        {
            string sql = "SELECT MONTH(entered_at) AS Month, COUNT(*) AS Count FROM logs WHERE user_id = @UserId GROUP BY Month";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserId", userId);

            // Her ay için log sayısını saklayan bir sözlük oluşturun
            Dictionary<string, int> monthlyLogCounts = new Dictionary<string, int>();

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string month = reader["Month"].ToString();
                        int count = Convert.ToInt32(reader["Count"]);
                        monthlyLogCounts[month] = count;
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

            return monthlyLogCounts;
            //foreach (var pair in monthlyLogCounts)
            //{
            //    MessageBox.Show("Ocak: " + pair.Key + "Tekrar: " + pair.Value);
            //}

        }
    }
}
