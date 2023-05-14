using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Form
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
        }


        public string idNumber()
        {
            return StudentNumberTxtBox.Text;
        }
        

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm mainForm = new AdminDashboardForm();
            mainForm.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            // Establish a connection to the MySQL database
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Define a query to retrieve a row from a table based on the student number
                string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Add a parameter to the query based on the value of the TextBox
                string idNumber = StudentNumberTxtBox.Text;
                command.Parameters.AddWithValue("@idNumber", idNumber);

                // Execute the query and retrieve the row
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Convert the row into a string
                    string rowAsString = string.Format("Last Name: {0} \nFirst Name: {1}",
                        reader["last_name"], reader["first_name"]);

                    // Display the string in a MessageBox
                    MessageBox.Show(rowAsString);
                }
                reader.Close();
            }
            /*
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
                DialogResult result = MessageBox.Show("Student ID number exists!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    //Student_Found student_Found = new Student_Found();
                    //student_Found.ShowDialog();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM app_student_records WHERE student_id = @idNumber", connection);

                    // string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
                    cmd.Parameters.AddWithValue("@idNumber", idNumber);

                    // Close the reader and connection
                    reader.Close();
                    connection.Close();
                    /*
                    // execute command and retrieve count value as object
                    object last_name = cmd.ExecuteScalar();
                    // convert object to string and store in variable
                    string ln = last_name.ToString();
                    // close connection
                    conn.Close();

                    LastNameLbl.Text += " " + ln;
                    // Execute the query and retrieve the row
                    MySqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        // Convert the row into a string
                        string rowAsString = string.Format("{0}", reader["last_name"]);

                        // Display the string in a MessageBox
                        MessageBox.Show("Last Name: " + rowAsString);
                    }
                    read.Close();
                }
            }
            else
            {
                MessageBox.Show("Student ID number does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StudentNumberTxtBox.Clear();
            }
            */
        }
    }
}
