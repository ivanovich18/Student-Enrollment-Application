using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
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
            MySqlCommand command = new MySqlCommand("SELECT student_number AS '#', student_id AS 'Student ID', last_name AS 'Last Name', first_name AS 'First Name', program AS 'Program', department AS 'Department', student_type AS 'Student Type', academic_year AS 'Academic Year' FROM app_student_records", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            StudentRecordsTable.DataSource = table;
            connection.Close();
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

        private void StudentRecordsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {


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

        private void DeleteRow_Click(object sender, EventArgs e)
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
    }
}