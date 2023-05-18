using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Login_Form
{
    public partial class LoginForm : Form
    {
        int loginAttempts = 0; // Global int variable to store the login attempts for later use.

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application"); // Creates a new instance of the MySqlConnection class and initializes it with the connection string.
        MySqlCommand command; // Declares a variable of type MySqlCommand that will be used to execute SQL commands on the MySQL database.
        MySqlDataReader reader; // Declares a variable of type MySqlDataReader that will be used to read and retrieve data from the result of executing a SQL command.

        public LoginForm()
        {
            InitializeComponent(); // Initializes the LoginForm.
        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Displays a confirmation dialog with "Yes" and "No" buttons.
            if (dialogResult == DialogResult.Yes) // Checks if the user clicked "Yes" in the confirmation dialog.
            {
                Application.Exit(); // Exits the application.
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text; // Retrieves the text entered in the UsernameTxtBox and stores it in a local string variable.
            string password = PasswordTxtBox.Text; // Retrieves the text entered in the PasswordTxtBox and stores it in a local string variable.

            string query = "SELECT * FROM app_admin_credentials WHERE username='" + username + "' AND password='" + password + "'"; // Constructs a SQL query string to select data from the app_admin_credentials table based on the provided username and password.

            command = new MySqlCommand(query, connection); // Initializes the MySqlCommand object with the query and connection to execute it.

            try
            {
                connection.Open(); // Opens the database connection.
                reader = command.ExecuteReader(); // Executes the SQL query and retrieves the data.

                if (reader.Read()) // Checks if there is at least one row returned from the query.
                {
                    MessageBox.Show("Login Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Displays a success message.
                    this.Hide(); // Hides the current form.
                    AdminDashboardForm dashboard = new AdminDashboardForm(); // Creates an instance of the AdminDashboardForm.
                    dashboard.ShowDialog(); // Displays the AdminDashboardForm as a dialog.
                }
                if (loginAttempts == 4) // Checks if the number of login attempts is equal to 4.
                {
                    MessageBox.Show("Too many invalid login attempts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Displays an error message for too many invalid attempts.
                    Application.Exit(); // Exits the application.
                }
                else
                {
                    loginAttempts++; // Increments the number of login attempts.
                    MessageBox.Show("Incorrect username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Displays a warning message for incorrect credentials.
                    UsernameTxtBox.Clear(); // Clears the username text box.
                    PasswordTxtBox.Clear(); // Clears the password text box.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Displays an error message if an exception occurs.
            }
            finally
            {
                if (reader != null) // Checks if the reader object is not null.
                {
                    reader.Close(); // Closes the data reader.
                }
                if (connection != null) // Checks if the connection object is not null.
                {
                    connection.Close(); // Closes the database connection.
                }
            }
        }

        private void ShowPassBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBox.PasswordChar == '•') // Checks if the PasswordTxtBox is currently hiding the password characters.
            {
                // Show the password characters
                PasswordTxtBox.PasswordChar = '\0'; // Sets the PasswordChar property of the PasswordTxtBox to '\0' (null character) to display the password characters.
                ShowPassBtn.Image = Properties.Resources.show_pass; // Updates the image of the ShowPassBtn to show_pass pic.
            }
            else
            {
                // Hide the password characters
                PasswordTxtBox.PasswordChar = '•'; // Sets the PasswordChar property of the PasswordTxtBox to '•' (bullet character) to hide the password characters.
                ShowPassBtn.Image = Properties.Resources.hide_pass; // Updates the image of the ShowPassBtn to hide_pass pic. 
            }
        }
    }
}