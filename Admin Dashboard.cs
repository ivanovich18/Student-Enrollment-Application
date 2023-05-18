namespace Login_Form
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent(); // Initializes the AdminDashboardForm.
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current AdminDashboardForm.
            Add_Students addStudents = new Add_Students(); // Creates an instance of the Add_Students form.
            addStudents.ShowDialog(); // Displays the Add_Students form as a dialog.
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Displays a confirmation dialog with "Yes" and "No" buttons.
            if (dialogResult == DialogResult.Yes) // Checks if the user clicked "Yes" in the confirmation dialog.
            {
                this.Hide(); // Hides the current AdminDashboardForm.
                LoginForm loginForm = new LoginForm(); // Creates an instance of the LoginForm.
                loginForm.ShowDialog(); // Displays the LoginForm as a dialog.
            }
        }

        private void SearchStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current AdminDashboardForm.
            SearchStudentForm searchStudentForm = new SearchStudentForm(); // Creates an instance of the SearchStudentForm.
            searchStudentForm.ShowDialog(); // Displays the SearchStudentForm as a dialog.
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current AdminDashboardForm.
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm(); // Creates an instance of the AdminSettingsForm.
            adminSettingsForm.ShowDialog(); // Displays the AdminSettingsForm as a dialog.
        }

        private void StudentRecordsBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current AdminDashboardForm.
            StudentRecordsForm studentRecordsForm = new StudentRecordsForm(); // Creates an instance of the StudentRecordsForm.
            studentRecordsForm.ShowDialog(); // Displays the StudentRecordsForm as a dialog.
        }
    }
}
