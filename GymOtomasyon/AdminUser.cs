using System;
using System.Data;
using System.Windows.Forms;
using GymOtomasyon.Models;

namespace GymOtomasyon
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
            LoadDataToListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAdd userAdd = new UserAdd();
            userAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt16(listView1.SelectedItems[0].Text);
            this.Close();
            UserEdit userEdit = new UserEdit(userId);
            userEdit.Show();
        }

        private void LoadDataToListView()
        {
            // GetUsers metodunu kullanarak veriyi çek
            DataTable usersDataTable = DBUsers.GetUsers();

            // ListView'i temizle
            listView1.Items.Clear();

            // DataTable'daki verileri ListView'e ekle
            foreach (DataRow row in usersDataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["first_name"].ToString());
                item.SubItems.Add(row["last_name"].ToString());
                item.SubItems.Add(row["phone"].ToString());

                listView1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected user's ID from the ListView
                string userId = listView1.SelectedItems[0].Text;

                // Ask for confirmation before deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call the DeleteUser method from DBUsers class to delete the user
                    DBUsers.DeleteUser(userId);

                    // Refresh the data in the ListView after deletion
                    LoadDataToListView();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
