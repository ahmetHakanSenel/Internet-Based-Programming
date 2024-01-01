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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserEdit userEdit1 = new UserEdit();
            userEdit1.Show();
        }
    }
}
 