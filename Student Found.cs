using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class Student_Found : Form
    {
        SearchStudentForm studentForm;

        public Student_Found(SearchStudentForm studentForm)
        {
            InitializeComponent();
            this.studentForm = studentForm;
        }

        private void Student_Found_Load(object sender, EventArgs e)
        {
            string idNumber = studentForm.StudentNumberTxtBox.Text;
            /*
            SearchStudentForm search = new SearchStudentForm();
            string idNumber = search.idNumberPass;
            */
            MessageBox.Show(idNumber);
            // Establish a connection to the MySQL database
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Define a query to retrieve a row from a table based on the student number
                string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Add a parameter to the query based on the value of the TextBox
                command.Parameters.AddWithValue("@idNumber", idNumber);

                // Execute the query and retrieve the row
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    
                    // MessageBox.Show(String.Format("Student Number: {0}", reader["student_number"]));
                    // last_name = string.
                    string last_name = reader.GetString(0);
                    LastNameLbl.Text += last_name;
                    // Convert the row into a string
                    //string rowAsString = string.Format("Student ID: {0}\nLast Name: {1}\nFirst Name: {2}\nEmail: {3}",
                    //  reader["student_id"], reader["last_name"], reader["first_name"], reader["email"]);
                    //MessageBox.Show(rowAsString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Display the string in a MessageBox
                    /*
                    
                    MessageBox.Show(String.Format("Student ID: {0}", reader["student_id"]));
                    MessageBox.Show(String.Format("Last Name: {0}", reader["last_name"]));
                    MessageBox.Show(String.Format("First Name: {0}", reader["first_name"]));
                    MessageBox.Show(String.Format("Middle Name: {0}", reader["middle_name"]));
                    */
                }
                reader.Close();
            }
        }
    }
}
