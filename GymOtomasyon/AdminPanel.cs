namespace GymOtomasyon
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();

            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPanel userPanel = new UserPanel();
            userPanel.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
            this.Close();
        }
    }
}