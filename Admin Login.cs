using MySql.Data.MySqlClient;

namespace Login_Form
{
    public partial class LoginForm : Form
    {
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

            string query = "SELECT * FROM admin_credentials WHERE username='" + username + "' AND password='" + password + "'";

            command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Form2 mainForm = new Form2();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            /*
            if (adminUsername == "Admin" && adminPassword == "admin123")
            {
                MessageBox.Show("Correct username and password!");
                // If user inputs correct login credentials, hide login form and display main form
                this.Hide();
                Form2 mainForm = new Form2();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
            */
        }
    }
}