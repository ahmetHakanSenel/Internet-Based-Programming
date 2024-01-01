// Form3.cs
using System;
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
            // ListView'e sütunları ekleyin
            listView1.Columns.Add("Workout ID");
            listView1.Columns.Add("Workout Name");
            listView1.Columns.Add("Workout Set");
            listView1.Columns.Add("Workout Repeat");
            listView1.Columns.Add("Workout Day");
            listView1.Columns.Add("Workout Place");
            listView1.Columns.Add("Workout Description");

            // Örnek verileri ekleyin (bu kısmı uygulamanıza uygun olarak düzenleyin)
            ListViewItem item = new ListViewItem(new[] { "1", "Push-up", "3", "15", "Monday", "Home", "Upper body exercise" });
            listView1.Items.Add(item);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            // Sil butonuna tıklandığında seçili öğeyi kaldırın
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
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
    }
}
