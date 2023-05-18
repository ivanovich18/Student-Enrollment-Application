using MySql.Data.MySqlClient;

namespace Login_Form
{


    public partial class ChangeUsernameForm : Form
    {


        public ChangeUsernameForm()
        {
            InitializeComponent();
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();
            adminSettingsForm.ShowDialog();
        }

        private bool CheckUsername(string username, string newUsername)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            string query = "SELECT username FROM app_admin_credentials WHERE username=@username";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string dbUsername = reader.GetString("username");
                    if (dbUsername == username && dbUsername != newUsername) // check if username matches and newUsername is different
                    {
                        return true;
                    }
                }
                else if (username == newUsername)
                {
                    return true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        private void UpdateUsername(string username, string newUsername)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            string query = "UPDATE app_admin_credentials SET username=@newUsername WHERE username=@username";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@newUsername", newUsername);
            command.Parameters.AddWithValue("@username", username);
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // This function is called when the update button is clicked
        private void UpdateUsernameBtn_Click(object sender, EventArgs e)
        {
            string username = OldUsernameTxtBox.Text;
            string newUsername = NewUsernameTxtBox.Text;
            string confirmNewUsername = ConfirmNewUsernameTxtBox.Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change username?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (CheckUsername(username, newUsername))
                {
                    if (newUsername == confirmNewUsername)
                    {
                        UpdateUsername(username, newUsername);
                    }
                    else
                    {
                        MessageBox.Show("New username and confirm new username do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Username doesn't match or new username is the same as the current username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            }
        }

        void ClearFields()
        {
            OldUsernameTxtBox.Clear();
            NewUsernameTxtBox.Clear();
            ConfirmNewUsernameTxtBox.Clear();
        }
    }
}
