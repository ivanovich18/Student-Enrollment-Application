using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                    MessageBox.Show("Username updated successfully!");
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
            
            

            if (CheckUsername(username, newUsername))
            {
                if (newUsername == confirmNewUsername) 
                {
                    UpdateUsername(username, newUsername);
                }
                else 
                {
                    MessageBox.Show("New username and confirm new username do not match.");
                }
            }
            else
            {
                MessageBox.Show("Username doesn't match or new username is the same as the current username.");
            }


        }
    }
}
