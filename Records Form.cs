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
    }
}
