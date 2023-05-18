namespace Login_Form
{
    public partial class AdminSettingsForm : Form
    {
        public AdminSettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm mainForm = new AdminDashboardForm();
            mainForm.ShowDialog();
        }

        private void ChangeUsernameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUsernameForm changeUsernameForm = new ChangeUsernameForm();
            changeUsernameForm.ShowDialog();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordLbl changePasswordForm = new ChangePasswordLbl();
            changePasswordForm.ShowDialog();

        }
    }
}
