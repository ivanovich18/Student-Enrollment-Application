using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class StudentRecordsForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");

        public StudentRecordsForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm mainForm = new AdminDashboardForm();
            mainForm.ShowDialog();
        }

        private void StudentRecordsForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT student_number AS '#', student_id AS 'Student ID', last_name AS 'Last Name', first_name AS 'First Name',  middle_name AS 'Middle Name', program AS 'Program', department AS 'Department', student_type AS 'Student Type', academic_year AS 'Academic Year', email AS 'Email', DATE_FORMAT(birthday, '%m-%d-%Y')  AS 'Birthday', gender AS 'Gender', age AS 'Age', birth_place AS 'Place of Birth', current_address AS 'Current Address', permanent_address AS 'Permanent Address', creation_date AS 'Date Enrolled' FROM app_student_records", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            StudentRecordsTable.DataSource = table;
            connection.Close();

            DataGridView studentRecordsTable = this.Controls["StudentRecordsTable"] as DataGridView;
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

            studentRecordsTable.Columns["#"].ReadOnly = true;
            studentRecordsTable.Columns["Student ID"].ReadOnly = true;
            studentRecordsTable.Columns["Date Enrolled"].ReadOnly = true;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to export student records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                ExportData();
            }

        }
        private void ExportData()
        {
            // MySqlCommand cmd = new MySqlCommand("SELECT * FROM app_student_records", connection);
            MySqlCommand cmd = new MySqlCommand("SELECT student_number AS 'Number', student_id AS 'Student ID', first_name AS 'First Name', middle_name AS 'Middle Name', last_name AS 'Last Name', email AS 'Email', DATE_FORMAT(birthday, '%m-%d-%Y') AS 'Birthday', gender AS 'Gender', age AS 'Age', birth_place AS 'Birth Place', current_address AS 'Current Address', permanent_address AS 'Permanent Address', student_type AS 'Student Type', academic_year AS 'Academic Year', department AS 'Department', program AS 'Program', DATE_FORMAT(creation_date, '%m-%d-%Y %H:%i:%s') AS 'Creation Date' FROM app_student_records", connection);

            try
            {
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\c# files\\student_records.csv";

                StreamWriter writer = new StreamWriter(filePath);

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    writer.Write("\"" + reader.GetName(i) + "\"");

                    if (i < reader.FieldCount - 1)
                    {
                        writer.Write(",");
                    }
                }

                writer.WriteLine();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (!reader.IsDBNull(i))
                        {
                            string value = reader.GetString(i);
                            writer.Write("\"" + value.Replace("\"", "\"\"") + "\"");
                        }

                        if (i < reader.FieldCount - 1)
                        {
                            writer.Write(",");
                        }
                    }

                    writer.WriteLine();
                }


                MessageBox.Show("Data exported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                writer.Close();
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Student_Found student_Found = new Student_Found(id_number);
                student_Found.Show();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete student?\n\nThis is irreversible.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Get the selected row index from the DataGridView
                int selectedRowIndex = StudentRecordsTable.SelectedCells[0].RowIndex;

                // Get the value of the key column from the selected row
                string keyValue = StudentRecordsTable.Rows[selectedRowIndex].Cells["Student ID"].Value.ToString();

                string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";
                string deleteQuery = $"DELETE FROM app_student_records WHERE student_id = @KeyValue";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@KeyValue", keyValue);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Remove the selected row from the DataGridView
                StudentRecordsTable.Rows.RemoveAt(selectedRowIndex);
                MessageBox.Show("Student record successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StudentRecordsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string primaryKeyValue = StudentRecordsTable.Rows[e.RowIndex].Cells["#"].Value.ToString();
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);

                    // Editable Column 1
                    string lastNameValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Last Name"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET last_name = @Column1Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column1Value", lastNameValue);
                    command.ExecuteNonQuery();

                    // Editable Column 2
                    string firstNameValue = StudentRecordsTable.Rows[e.RowIndex].Cells["First Name"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET first_name = @Column2Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column2Value", firstNameValue);
                    command.ExecuteNonQuery();

                    // Editable Column 3
                    string middleNameValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Middle Name"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET middle_name = @Column3Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column3Value", middleNameValue);
                    command.ExecuteNonQuery();

                    // Editable Column 4
                    string programValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Program"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET program = @Column4Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column4Value", programValue);
                    command.ExecuteNonQuery();

                    // Editable Column 5
                    string departmentValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Department"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET department = @Column5Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column5Value", departmentValue);
                    command.ExecuteNonQuery();

                    // Editable Column 6
                    string emailValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET email = @Column6Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column6Value", emailValue);
                    command.ExecuteNonQuery();

                    // Editable Column 7
                    string birthdayValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Birthday"].Value.ToString();

                    DateTime birthdate;
                    if (DateTime.TryParseExact(birthdayValue, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
                    {
                        string formattedBirthdate = birthdate.ToString("yyyy-MM-dd");
                        command.CommandText = $"UPDATE app_student_records SET birthday = @Column7Value WHERE student_number = @PrimaryKeyValue";
                        command.Parameters.AddWithValue("@Column7Value", formattedBirthdate);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        // Handle invalid date format
                        MessageBox.Show("Invalid date format. Please enter in MM-dd-yyyy format.\n\nChange is not saved!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Editable Column 8
                    string genderValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET gender = @Column8Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column8Value", genderValue);
                    command.ExecuteNonQuery();

                    // Editable Column 9
                    string ageValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET age = @Column9Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column9Value", ageValue);
                    command.ExecuteNonQuery();

                    // Editable Column 10
                    string birthplaceValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Place of Birth"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET birth_place = @Column10Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column10Value", birthplaceValue);
                    command.ExecuteNonQuery();

                    // Editable Column 11
                    string currentAddressValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Current Address"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET current_address = @Column11Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column11Value", currentAddressValue);
                    command.ExecuteNonQuery();

                    // Editable Column 12
                    string permanentAddressValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Permanent Address"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET permanent_address = @Column12Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column12Value", permanentAddressValue);
                    command.ExecuteNonQuery();

                    // Editable Column 13
                    string studentTypeValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Student Type"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET student_type = @Column13Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column13Value", studentTypeValue);
                    command.ExecuteNonQuery();

                    // Editable Column 14
                    string academicYearValue = StudentRecordsTable.Rows[e.RowIndex].Cells["Academic Year"].Value.ToString();
                    command.CommandText = $"UPDATE app_student_records SET academic_year = @Column14Value WHERE student_number = @PrimaryKeyValue";
                    command.Parameters.AddWithValue("@Column14Value", academicYearValue);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        private void StudentRecordsForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Changes will be saved automatically to the database.\n\nProceed with caution!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}