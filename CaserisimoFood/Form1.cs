namespace CaserisimoFood
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = "piñata";
            string password = "123456";
            if (user == txtUser.Text && password == txtPassword.Text)
            {
                Form mainForm = new frmMain();
                mainForm.ShowDialog();
            }

        }
    }
}
