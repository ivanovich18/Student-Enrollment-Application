using MySql.Data.MySqlClient;

namespace Login_Form
{
    public partial class LoginForm : Form
    {
        int loginAttempts = 0;

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
        MySqlCommand command;
        MySqlDataReader reader;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text;
            string password = PasswordTxtBox.Text;

            string query = "SELECT * FROM app_admin_credentials WHERE username='" + username + "' AND password='" + password + "'";

            command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminDashboardForm mainForm = new AdminDashboardForm();
                    mainForm.ShowDialog();
                }
                if (loginAttempts == 4)
                {
                    MessageBox.Show("Too many invalid login attempts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    loginAttempts++;
                    MessageBox.Show("Incorrect username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UsernameTxtBox.Clear();
                    PasswordTxtBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowPassBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBox.PasswordChar == '•')
            {
                // Show the password characters
                PasswordTxtBox.PasswordChar = '\0';
                ShowPassBtn.Image = Properties.Resources.hide_pass;
            }
            else
            {
                // Hide the password characters
                PasswordTxtBox.PasswordChar = '•';
                ShowPassBtn.Image = Properties.Resources.show_pass;
            }
        }
    }
}