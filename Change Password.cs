using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_Form
{
    public partial class ChangePasswordLbl : Form
    {
        public ChangePasswordLbl()
        {
            InitializeComponent();
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();
            adminSettingsForm.ShowDialog();
        }

        private bool CheckPassword(string password, string newPassword)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            string query = "SELECT password FROM app_admin_credentials WHERE password=@password";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@password", password);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string dbPassword = reader.GetString("password");
                    if (dbPassword == password && dbPassword != newPassword) // check if username matches and newPassword is different
                    {
                        return true;
                    }
                }
                else if (password == newPassword)
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

        private void UpdatePassword(string password, string newPassword)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            string query = "UPDATE app_admin_credentials SET password=@newPassword WHERE password=@password";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@newPassword", newPassword);
            command.Parameters.AddWithValue("@password", password);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            string password = OldPasswordTxtBox.Text;
            string newPassword = NewPasswordTxtBox.Text;
            string confirmNewPassword = ConfirmNewPasswordTxtBox.Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                if (CheckPassword(password, newPassword))
                {
                    if (newPassword == confirmNewPassword)
                    {
                        UpdatePassword(password, newPassword);
                    }
                    else
                    {
                        MessageBox.Show("New password and confirm new password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Password doesn't match or new password is the same as the current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
            }
        }

        void ClearFields()
        {
            OldPasswordTxtBox.Clear();
            NewPasswordTxtBox.Clear();
            ConfirmNewPasswordTxtBox.Clear();
        }
    }
}
