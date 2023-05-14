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
        public Student_Found()
        {
            InitializeComponent();
        }

        private void Student_Found_Load(object sender, EventArgs e)
        {
            var searchStudentForm = new SearchStudentForm();
            string textBoxValue = searchStudentForm.idNumber();
            MessageBox.Show(textBoxValue);

            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM app_student_records WHERE student_id = @idNumber", conn);

            // string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
            cmd.Parameters.AddWithValue("@idNumber", textBoxValue);
            /*
            // execute command and retrieve count value as object
            object last_name = cmd.ExecuteScalar();
            // convert object to string and store in variable
            string ln = last_name.ToString();
            // close connection
            conn.Close();

            LastNameLbl.Text += " " + ln;
            */
            // Execute the query and retrieve the row
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Convert the row into a string
                string rowAsString = string.Format("{0}", reader["last_name"]);

                // Display the string in a MessageBox
                LastNameLbl.Text = LastNameLbl + rowAsString;
            }
            reader.Close();
        }
    }
}
