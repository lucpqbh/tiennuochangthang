namespace ManagerApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Account invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username == "admin" && password == "123@123")
            {
                MessageBox.Show("Login cc", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // cho vao trang quan ly
                FormDashboard home = new FormDashboard();
                home.Show(); // show form dashboard
                this.Hide(); // an form login di
            }
            else
            {
                MessageBox.Show("Account invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}