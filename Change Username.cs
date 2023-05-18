using MySql.Data.MySqlClient;

namespace Login_Form
{
    public partial class ChangeUsernameForm : Form
    {
        public ChangeUsernameForm()
        {
            InitializeComponent(); // Initialize the form's controls.
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            // Hide this form and show the AdminSettingsForm.
            this.Hide();
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();
            adminSettingsForm.ShowDialog();
        }

        private bool CheckUsername(string username, string newUsername)
        {
            // Create a new MySqlConnection object.
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");

            // Create a new MySqlCommand object and set the query.
            string query = "SELECT username FROM app_admin_credentials WHERE username=@username";
            MySqlCommand command = new MySqlCommand(query, connection);

            // Add the username parameter to the command.
            command.Parameters.AddWithValue("@username", username);

            // Try to open the connection and execute the query.
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // If the reader has data, check if the current username matches the database username.
                if (reader.Read())
                {
                    string dbUsername = reader.GetString("username");
                    if (dbUsername == username && dbUsername != newUsername) // Check if username matches and newUsername is different
                    {
                        return true; // Return true if the usernames match.
                    }
                }
                else if (username == newUsername)
                {
                    return true; // Return true if the usernames are the same.
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display an error message if there is an exception.
            }
            finally
            {
                connection.Close(); // Close the connection.
            }

            return false; // Return false if the usernames do not match.
        }

        private void UpdateUsername(string username, string newUsername)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            string query = "UPDATE app_admin_credentials SET username=@newUsername WHERE username=@username";
            MySqlCommand command = new MySqlCommand(query, connection);

            // Add the new username and current username parameters to the command.
            command.Parameters.AddWithValue("@newUsername", newUsername);
            command.Parameters.AddWithValue("@username", username);

            // If rows were affected, display a success message and clear the fields.
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Username updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display an error message if there is an exception.
            }
            finally
            {
                connection.Close(); // Close the connection.
            }
        }

        private void UpdateUsernameBtn_Click(object sender, EventArgs e)
        {
            // Get the current username, new username, and confirm new username from the text boxes.
            string username = OldUsernameTxtBox.Text;
            string newUsername = NewUsernameTxtBox.Text;
            string confirmNewUsername = ConfirmNewUsernameTxtBox.Text;

            // Display a confirmation message to the user.
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change username?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes) // If the user clicks yes, check if the current username is valid.
            {
                if (CheckUsername(username, newUsername)) // Check if the current username is valid.
                {
                    if (newUsername == confirmNewUsername) // Check if the new username and confirm new username match.
                    {
                        UpdateUsername(username, newUsername); // Update the username in the database.
                    }
                    else
                    {
                        MessageBox.Show("New username and confirm new username do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display an error message if the new username and confirm new username do not match.
                        ClearFields(); // Clear the fields.
                    }
                }
                else
                {
                    MessageBox.Show("Username doesn't match or new username is the same as the current username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display an error message if the current username is not valid.
                    ClearFields();
                }
            }
        }

        void ClearFields()
        {
            // Clear the text boxes.
            OldUsernameTxtBox.Clear();
            NewUsernameTxtBox.Clear();
            ConfirmNewUsernameTxtBox.Clear();
        }
    }
}
