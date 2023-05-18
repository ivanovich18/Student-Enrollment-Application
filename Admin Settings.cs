namespace Login_Form
{
    public partial class AdminSettingsForm : Form
    {
        public AdminSettingsForm()
        {
            InitializeComponent(); // Initializes the AdminSettingsForm.
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current AdminSettingsForm.
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(); // Creates an instance of the ChangePasswordForm.
            changePasswordForm.ShowDialog(); // Displays the changePasswordForm as a dialog.
        }

        private void ChangeUsernameBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current AdminSettingsForm.
            ChangeUsernameForm changeUsernameForm = new ChangeUsernameForm(); // Creates an instance of the ChangeUsernameForm.
            changeUsernameForm.ShowDialog(); // Displays the changeUsernameForm as a dialog.
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current AdminSettingsForm.
            AdminDashboardForm dashboardForm = new AdminDashboardForm(); // Creates an instance of the AdminDashboardForm.
            dashboardForm.ShowDialog(); // Displays the dashboardForm as a dialog.
        }
    }
}
