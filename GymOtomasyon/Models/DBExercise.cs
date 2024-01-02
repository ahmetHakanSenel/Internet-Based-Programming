using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymOtomasyon.Models
{
    internal class DBExercise
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

        // AddExercise Metodu
        public static void AddExercise(Exercises exercise)
        {
            string sql = "INSERT INTO exercises (title, set_times, rep_times, day, work_desc, workout_place, user_id) VALUES (@Title, @SetTimes, @RepTimes, @Day, @WorkDesc, @WorkoutPlace, @UserId)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Title", exercise.Title);
            cmd.Parameters.AddWithValue("@SetTimes", exercise.Set);
            cmd.Parameters.AddWithValue("@RepTimes", exercise.Rep);
            cmd.Parameters.AddWithValue("@Day", exercise.Day);
            cmd.Parameters.AddWithValue("@WorkDesc", exercise.Desc);
            cmd.Parameters.AddWithValue("@WorkoutPlace", exercise.WorkoutPlace);
            cmd.Parameters.AddWithValue("@UserId", exercise.UserId);
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

        // UpdateExercise Metodu
        public static void UpdateExercise(Exercises exercise, string id)
        {
            string sql = "UPDATE exercises SET title=@Title, set_times=@SetTimes, rep_times=@RepTimes, day=@Day, work_desc=@WorkDesc, workout_place=@WorkoutPlace WHERE user_id=@UserId";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Title", exercise.Title);
            cmd.Parameters.AddWithValue("@SetTimes", exercise.Set);
            cmd.Parameters.AddWithValue("@RepTimes", exercise.Rep);
            cmd.Parameters.AddWithValue("@Day", exercise.Day);
            cmd.Parameters.AddWithValue("@WorkDesc", exercise.Desc);
            cmd.Parameters.AddWithValue("@WorkoutPlace", exercise.WorkoutPlace);
            cmd.Parameters.AddWithValue("@UserId", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı");
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }

        // DeleteExercise Metodu
        public static void DeleteExercise(string id)
        {
            string sql = "DELETE FROM exercises WHERE id = @Id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı");
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }

        public static DataTable GetExercisesAdmin()
        {
            DataTable exercisesDataTable = new DataTable();

            string sql = "SELECT * FROM exercises"; // Tüm sütunları belirttiğiniz sorgu
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    exercisesDataTable.Load(reader);
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

            return exercisesDataTable;
        }
        public static DataTable GetExercises(string userEmail)
        {
            DataTable exercisesDataTable = new DataTable();

            try
            {
                int userId = DBUsers.GetUserIdByEmail(userEmail);
                if (userId != -1)
                {
                    using (MySqlConnection connection = GetConnection())
                    {
                        string sql = "SELECT * FROM exercises WHERE user_id = @UserId";
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            exercisesDataTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            return exercisesDataTable;
        }


        public static int GetUserIdByEmail(string userEmail)
        {
            int userId = -1;

            using (MySqlConnection connection = GetConnection())
            {
                string sql = "SELECT id FROM users WHERE email = @UserEmail";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@UserEmail", userEmail);

                try
                {
                    object result = cmd.ExecuteScalar();
                    MessageBox.Show(result.ToString());
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }


            return userId;
        }



        public static DataTable GetExercisesForUser(int userId)
        {
            DataTable exercisesDataTable = new DataTable();

            string sql = "SELECT * FROM exercises WHERE user_id = @UserId";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@UserId", userId);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    exercisesDataTable.Load(reader);
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

            return exercisesDataTable;
        }


    }
}
