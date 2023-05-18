using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace Login_Form
{
    public partial class StudentRecordsForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
        // Create a MySqlConnection object with connection string to the MySQL database.

        public StudentRecordsForm()
        {
            InitializeComponent(); // Initialize the form components and controls.
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            // Event handler for the Back button click event.
            // Hide this form and show the AdminDashboardForm.
            this.Hide();
            AdminDashboardForm dashboard = new AdminDashboardForm();
            dashboard.ShowDialog();
        }

        private void StudentRecordsForm_Load(object sender, EventArgs e)
        {
            connection.Open(); // Open the connection to the database.
            // Create a MySqlCommand object with the SQL command to fetch student records.
            MySqlCommand command = new MySqlCommand("SELECT student_number AS '#', student_id AS 'Student ID', last_name AS 'Last Name', first_name AS 'First Name',  middle_name AS 'Middle Name', program AS 'Program', department AS 'Department', student_type AS 'Student Type', academic_year AS 'Academic Year', email AS 'Email', DATE_FORMAT(birthday, '%m-%d-%Y')  AS 'Birthday', gender AS 'Gender', age AS 'Age', birth_place AS 'Place of Birth', current_address AS 'Current Address', permanent_address AS 'Permanent Address', creation_date AS 'Date Enrolled' FROM app_student_records", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command); // Create a MySqlDataAdapter object with the MySqlCommand.
            DataTable table = new DataTable(); // Create a new DataTable object to hold the fetched data.
            adapter.Fill(table); // Fill the DataTable with the data from the database using the adapter.
            StudentRecordsTable.DataSource = table; // Set the DataGridView's data source to the filled DataTable.
            connection.Close(); // Close the database connection.

            // Get a reference to the DataGridView control named "StudentRecordsTable" on the form.
            DataGridView studentRecordsTable = this.Controls["StudentRecordsTable"] as DataGridView;

            // Set the column widths for the DataGridView control.
            studentRecordsTable.Columns["#"].Width = 50;
            studentRecordsTable.Columns["Student ID"].Width = 130;
            studentRecordsTable.Columns["Last Name"].Width = 140;
            studentRecordsTable.Columns["First Name"].Width = 140;
            studentRecordsTable.Columns["Middle Name"].Width = 160;
            studentRecordsTable.Columns["Program"].Width = 340;
            studentRecordsTable.Columns["Department"].Width = 200;
            studentRecordsTable.Columns["Student Type"].Width = 150;
            studentRecordsTable.Columns["Academic Year"].Width = 170;
            studentRecordsTable.Columns["Email"].Width = 170;
            studentRecordsTable.Columns["Birthday"].Width = 120;
            studentRecordsTable.Columns["Gender"].Width = 90;
            studentRecordsTable.Columns["Age"].Width = 80;
            studentRecordsTable.Columns["Place of Birth"].Width = 200;
            studentRecordsTable.Columns["Current Address"].Width = 200;
            studentRecordsTable.Columns["Permanent Address"].Width = 230;
            studentRecordsTable.Columns["Date Enrolled"].Width = 180;

            // Set certain columns as read-only.
            studentRecordsTable.Columns["#"].ReadOnly = true;
            studentRecordsTable.Columns["Student ID"].ReadOnly = true;
            studentRecordsTable.Columns["Date Enrolled"].ReadOnly = true;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog to ensure the user wants to export student records.
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to export student records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                ExportData(); // If the user confirms, call the ExportData method to perform the export.
            }

        }
        private void ExportData()
        {
            // Create a MySqlCommand object with the SQL command to select the desired student records.
            MySqlCommand cmd = new MySqlCommand("SELECT student_number AS 'Number', student_id AS 'Student ID', first_name AS 'First Name', middle_name AS 'Middle Name', last_name AS 'Last Name', email AS 'Email', DATE_FORMAT(birthday, '%m-%d-%Y') AS 'Birthday', gender AS 'Gender', age AS 'Age', birth_place AS 'Birth Place', current_address AS 'Current Address', permanent_address AS 'Permanent Address', student_type AS 'Student Type', academic_year AS 'Academic Year', department AS 'Department', program AS 'Program', DATE_FORMAT(creation_date, '%m-%d-%Y %H:%i:%s') AS 'Creation Date' FROM app_student_records", connection);

            try
            {
                connection.Open(); // Open the connection to the database.

                MySqlDataReader reader = cmd.ExecuteReader(); // Execute the SQL command and obtain a MySqlDataReader object to read the data.
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\c# files\\student_records.csv"; // Define the file path and name where the exported data will be saved.

                StreamWriter writer = new StreamWriter(filePath); // Create a StreamWriter object to write the data to the file.


                for (int i = 0; i < reader.FieldCount; i++)
                {
                    writer.Write("\"" + reader.GetName(i) + "\""); // Write the column headers enclosed in double quotes.

                    if (i < reader.FieldCount - 1)
                    {
                        writer.Write(","); // Add a comma separator if it's not the last column.
                    }
                }

                writer.WriteLine(); // Start a new line after writing the column headers

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (!reader.IsDBNull(i))
                        {
                            string value = reader.GetString(i); // Read the value from the reader for the current field.
                            writer.Write("\"" + value.Replace("\"", "\"\"") + "\""); // Write the value enclosed in double quotes, escaping any double quotes within the value.
                        }

                        if (i < reader.FieldCount - 1)
                        {
                            writer.Write(","); // Add a comma separator if it's not the last column.
                        }
                    }
                writer.WriteLine(); // Start a new line after writing the values for each record.
            }

                MessageBox.Show("Data exported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Display a success message box.

                // Close the writer and reader objects.
                writer.Close();
                reader.Close();

                connection.Close(); // Close the database connection.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display an error message box if an exception occurs.
            }
        }

        private void StudentRecordsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                DataGridViewRow row = StudentRecordsTable.Rows[e.RowIndex];

                // Retrieve the data from the clicked row
                string id_number = row.Cells["Student ID"].Value.ToString();

                // Create and show the new form, passing the number as a parameter
                Student_Found student_Found = new Student_Found(id_number); // Create an instance of the Student_Found form, passing the id_number as a parameter
                student_Found.Show(); // Show the Student_Found form
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete student?\n\nThis is irreversible.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Display a confirmation dialog to ensure the user wants to delete the student.

            if (dialogResult == DialogResult.Yes)
            {
                // Get the selected row index from the DataGridView
                int selectedRowIndex = StudentRecordsTable.SelectedCells[0].RowIndex;

                // Get the value of the key column from the selected row
                string keyValue = StudentRecordsTable.Rows[selectedRowIndex].Cells["Student ID"].Value.ToString();

                // Connection string for connecting to the database
                string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";

                // SQL query to delete the student record with the specified student_id
                string deleteQuery = $"DELETE FROM app_student_records WHERE student_id = @KeyValue";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@KeyValue", keyValue); // Add the keyValue parameter to the command with the value of the student_id
                        connection.Open(); // Open the database connection
                        command.ExecuteNonQuery(); // Execute the DELETE query to delete the student record
                    }
                }

                StudentRecordsTable.Rows.RemoveAt(selectedRowIndex); // Remove the row at the selectedRowIndex from the StudentRecordsTable
                MessageBox.Show("Student record successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Display a success message box.
            }
        }

        private void StudentRecordsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieves the value of the primary key from the cell that triggered the event
            string primaryKeyValue = StudentRecordsTable.Rows[e.RowIndex].Cells["#"].Value.ToString();
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application"; // Connection string for the MySQL database

            // Establishes a MySqlConnection using the provided connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Initializes a new MySqlCommand
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection; // Sets the MySqlConnection object as the connection for the MySqlCommand
                    command.CommandType = CommandType.Text; // Specifies the command type as a text-based command
                    connection.Open(); // Opens the database connection
                    command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue); // Adds a parameter to the command representing the primary key value

                    // Last Name Column 1
                    // Retrieves the value from the "Last Name" column of the edited row
                    string lastNameValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Last Name"].Value.ToString();
                    // Constructs an SQL update command to update the "last_name" column in the "app_student_records" table
                    command.CommandText = $"UPDATE app_student_records SET last_name = @Column1Value WHERE student_number = @PrimaryKeyValue";
                    // Adds a parameter to the command representing the value to be updated in the "last_name" column
                    command.Parameters.AddWithValue("@Column1Value", lastNameValue);
                    // Executes the SQL command to update the database
                    command.ExecuteNonQuery();

                    // First Name Column 2
                    string firstNameValue = StudentRecordsTable.Rows[e.RowIndex].Cells["First Name"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET first_name = @Column2Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column2Value", firstNameValue);
                    command.ExecuteNonQuery();

                    // Middle Name Column 3
                    string middleNameValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Middle Name"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET middle_name = @Column3Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column3Value", middleNameValue);
                    command.ExecuteNonQuery();

                    // Program Column 4
                    string programValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Program"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET program = @Column4Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column4Value", programValue);
                    command.ExecuteNonQuery();

                    // Department Column 5
                    string departmentValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Department"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET department = @Column5Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column5Value", departmentValue);
                    command.ExecuteNonQuery();

                    // Email Column 6
                    string emailValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET email = @Column6Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column6Value", emailValue);
                    command.ExecuteNonQuery();

                    // Birthday Column 7
                    string birthdayValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Birthday"].Value.ToString();

                    DateTime birthdate;

                    // Attempts to parse the string value of the birthday from a specific format ("MM-dd-yyyy")
                    // and assigns the resulting DateTime value to the 'birthdate' variable
                    if (DateTime.TryParseExact(birthdayValue, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
                    {
                        string formattedBirthdate = birthdate.ToString("yyyy-MM-dd"); // Formats the birthdate value to a specific format ("yyyy-MM-dd")
                        command.CommandText = $"UPDATE app_student_records SET birthday = @Column7Value WHERE student_number = @PrimaryKeyValue"; // Constructs an SQL update command to update the "birthday" column in the "app_student_records" table
                        command.Parameters.AddWithValue("@Column7Value", formattedBirthdate); // Adds a parameter to the command representing the formatted birthdate value
                        command.ExecuteNonQuery(); // Executes the SQL command to update the database
                    }
                    else
                    {
                        // Handle invalid date format
                        MessageBox.Show("Invalid date format. Please enter in MM-dd-yyyy format.\n\nChange is not saved!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Displays a warning message box for an invalid date format
                    }

                    // Gender Column 8
                    string genderValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET gender = @Column8Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column8Value", genderValue);
                    command.ExecuteNonQuery();

                    // Age Column 9
                    string ageValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET age = @Column9Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column9Value", ageValue);
                    command.ExecuteNonQuery();

                    // Place of Birth Column 10
                    string birthplaceValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Place of Birth"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET birth_place = @Column10Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column10Value", birthplaceValue);
                    command.ExecuteNonQuery();

                    // Current Address Column 11
                    string currentAddressValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Current Address"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET current_address = @Column11Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column11Value", currentAddressValue);
                    command.ExecuteNonQuery();

                    // Permanent Address Column 12
                    string permanentAddressValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Permanent Address"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET permanent_address = @Column12Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column12Value", permanentAddressValue);
                    command.ExecuteNonQuery();

                    // Student Type Column 13
                    string studentTypeValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Student Type"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET student_type = @Column13Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column13Value", studentTypeValue);
                    command.ExecuteNonQuery();

                    // Editable Column 14
                    string academicYearValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Academic Year"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET academic_year = @Column14Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column14Value", academicYearValue);
                    command.ExecuteNonQuery();

                    connection.Close(); // Closes the connection
                }
            }
        }

        private void StudentRecordsForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Changes will be saved automatically to the database.\n\nProceed with caution!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Display a warning dialog as the change will be saved automatically.
        }
    }
}