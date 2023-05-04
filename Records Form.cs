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
        public StudentRecordsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm mainForm = new AdminDashboardForm();
            mainForm.ShowDialog();
        }

        private void StudentRecordsForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT student_number, student_id, last_name, first_name, program, department, student_type, academic_year FROM app_student_records", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            StudentRecordsTable.DataSource = table;
            connection.Close();
        }
    }
}
