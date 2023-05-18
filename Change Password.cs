using MySql.Data.MySqlClient;

namespace Login_Form
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent(); // Initialize the form's controls.
        }

        private bool CheckPassword(string password, string newPassword)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application"); // Create a new MySqlConnection object.
            
            string query = "SELECT password FROM app_admin_credentials WHERE password=@password"; // Create a new MySqlCommand object and set the query.
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@password", password); // Add the password parameter to the command.

            try // Try to open the connection and execute the query.
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // If the reader has data, check if the current password matches the database password.
                {
                    string dbPassword = reader.GetString("password");
                    if (dbPassword == password && dbPassword != newPassword) // // Check if username matches and newPassword is different.
                    {
                        return true; // Return true if the passwords match.
                    }
                }
                else if (password == newPassword)
                {
                    return true; // Return true if the passwords are the same.
                }
                reader.Close(); // Close the reader.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display an error message if there is an exception.
            }
            finally
            {
                connection.Close(); // Close the connection.
            }

            return false; // Return false if the passwords do not match.
        }

        void ClearFields()
        {
            // Clear the text boxes.
            OldPasswordTxtBox.Clear();
            NewPasswordTxtBox.Clear();
            ConfirmNewPasswordTxtBox.Clear();
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            // Hide this form and show the AdminSettingsForm.
            this.Hide();
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();
            adminSettingsForm.ShowDialog();
        }

        private void UpdatePassword(string password, string newPassword)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            string query = "UPDATE app_admin_credentials SET password=@newPassword WHERE password=@password";
            MySqlCommand command = new MySqlCommand(query, connection);

            // Add the new password and current password parameters to the command.
            command.Parameters.AddWithValue("@newPassword", newPassword);
            command.Parameters.AddWithValue("@password", password);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) // If rows were affected, display a success message and clear the fields.
                {
                    MessageBox.Show("Password updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            // Get the current password, new password, and confirm new password from the text boxes.
            string password = OldPasswordTxtBox.Text;
            string newPassword = NewPasswordTxtBox.Text;
            string confirmNewPassword = ConfirmNewPasswordTxtBox.Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Display a confirmation message to the user.
            if (dialogResult == DialogResult.Yes) // If the user clicks yes, check if the current password is valid.
            {
                if (CheckPassword(password, newPassword)) 
                {
                    // If the current password is valid, check if the new password and confirm new password match.
                    if (newPassword == confirmNewPassword)
                    {
                        // If the new password and confirm new password match, update the password in the database.
                        UpdatePassword(password, newPassword);
                    }
                    else
                    {
                        // If the new password and confirm new password do not match, display an error message.
                        MessageBox.Show("New password and confirm new password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                    }
                }
                else
                {
                    // If the current password is not valid, display an error message.
                    MessageBox.Show("Password doesn't match or new password is the same as the current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            }
        }
    }
}
