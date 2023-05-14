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

namespace Login_Form
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm mainForm = new AdminDashboardForm();
            mainForm.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get the ID number from the text box
            string idNumber = StudentNumberTxtBox.Text;

            // Set up a MySQL connection string
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";

            // Create a MySQL connection
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Create a MySQL command to search for the ID number
            string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@idNumber", idNumber);

            // Open the connection and execute the command
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            // Check if the ID number exists and display a message box if it does
            if (reader.Read())
            {
                MessageBox.Show("ID number exists!");
            }
            else
            {
                MessageBox.Show("ID number does not exist.");
            }

            // Close the reader and connection
            reader.Close();
            connection.Close();
        }
    }
}
