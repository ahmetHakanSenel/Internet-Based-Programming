// Form3.cs
using GymOtomasyon.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GymOtomasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Verileri DBExercise sınıfından çekerek ListView'e ekle
            DataTable exercisesTable = DBExercise.GetExercisesAdmin();

            foreach (DataRow row in exercisesTable.Rows)
            {
                ListViewItem item = new ListViewItem(row.ItemArray.Select(x => x.ToString()).ToArray());
                listView1.Items.Add(item);
            }
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            this.Close();
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            // Sil butonuna tıklandığında seçili öğeyi kaldırın
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string exerciseId = selectedItem.SubItems[0].Text; 

                DBExercise.DeleteExercise(exerciseId);

                listView1.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğeyi seçin.");
            }
            this.Close();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }



        private void düzenle_Click(object sender, EventArgs e)
        {
            // Düzenle butonuna tıklandığında seçili öğeyi alın ve EditForm'u açın
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                EditForm editForm = new EditForm(selectedItem);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz öğeyi seçin.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
