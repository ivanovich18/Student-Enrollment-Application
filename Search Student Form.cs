using MySql.Data.MySqlClient;

namespace Login_Form
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form
            AdminDashboardForm mainForm = new AdminDashboardForm(); // Creates a new instance of the AdminDashboardForm
            mainForm.ShowDialog(); // Displays the AdminDashboardForm as a dialog
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string idNumber = StudentNumberTxtBox.Text; // Retrieves the student number from the StudentNumberTxtBox

            // Establish a connection to the MySQL database
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Opens the database connection

                // Defines a query to retrieve a row from a table based on the student number
                string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
                MySqlCommand command = new MySqlCommand(query, connection); // Creates a MySqlCommand object with the query and connection

                command.Parameters.AddWithValue("@idNumber", idNumber); // Adds a parameter to the command representing the student number

                // Executes the query and retrieves the result as a MySqlDataReader
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // Checks if a row was retrieved
                {
                    DialogResult result = MessageBox.Show("Student ID number exists!\n\nDo you want to view record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information); // Asks the user if they want to view the student record
                    if (result == DialogResult.Yes) // If the user chooses to view the record
                    {
                        Student_Found student_Found = new Student_Found(idNumber, this); // Creates a new instance of the Student_Found form, passing the student ID number
                        student_Found.Show(); // Displays the Student_Found form as a dialog
                    }
                }
                else
                {
                    MessageBox.Show("Student ID number does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Displays an error message indicating that the student ID number does not exist
                    StudentNumberTxtBox.Clear(); // Displays an error message indicating that the student ID number does not exist
                }
                reader.Close(); // Closes the reader
            }
        }
    }
}
