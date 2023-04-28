﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace Login_Form
{
    public partial class Add_Students : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");

        public Add_Students()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 mainForm = new Form2();
            mainForm.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 mainForm = new Form2();
            mainForm.ShowDialog();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO student_records (student_id, last_name, first_name, middle_name, email, birthday, gender, age, birth_place, current_address, permanent_address, academic_year, student_type, department, program) VALUES (@student_id, @last_name, @first_name, @middle_name, @email, @birthday, @gender, @age, @birth_place, @current_address, @permanent_address, @academic_year, @student_type, @department, @program)";
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            // add parameters to the command object
            command.Parameters.AddWithValue("@student_id", StudentIDTxtBox.Text);
            command.Parameters.AddWithValue("@last_name", LastNameTxtBox.Text);
            command.Parameters.AddWithValue("@first_name", FirstNameTxtBox.Text);
            command.Parameters.AddWithValue("@middle_name", MiddleNameTxtBox.Text);
            command.Parameters.AddWithValue("@email", EmailTxtBox.Text);

            command.Parameters.AddWithValue("@birthday", BirthdayPicker.Value.Date);
            command.Parameters.AddWithValue("@gender", GenderCmbBox.SelectedItem.ToString());
            command.Parameters.AddWithValue("@age", AgeTxtBox.Text);
            command.Parameters.AddWithValue("@birth_place", BirthPlaceTxtBox.Text);
            command.Parameters.AddWithValue("@current_address", CurrentAddressTxtBox.Text);
            command.Parameters.AddWithValue("@permanent_address", PermanentAddressTxtBox.Text);
            command.Parameters.AddWithValue("@academic_year", AcademicYearCmbBox.SelectedItem.ToString());
            command.Parameters.AddWithValue("@student_type", StudentTypeCmbBox.SelectedItem.ToString());
            command.Parameters.AddWithValue("@department", DepartmentCmbBox.SelectedItem.ToString());
            command.Parameters.AddWithValue("@program", ProgramCmbBox.SelectedItem.ToString());

            // open the connection
            connection.Open();

            // execute the command
            int rowsAffected = command.ExecuteNonQuery();

            // close the connection
            connection.Close();

            /*
            DialogResult result = MessageBox.Show("Are you sure you want to add new student", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // User clicked "Yes"
            }
            else
            {
                // User clicked "No" or closed the dialog
            }
        }
            */
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all fields?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // User clicked "Yes"

                // TextBox
                StudentNumberTxtBox.Clear();
                StudentIDTxtBox.Clear();
                LastNameTxtBox.Clear();
                FirstNameTxtBox.Clear();
                MiddleNameTxtBox.Clear();
                EmailTxtBox.Clear();
                AgeTxtBox.Clear();
                CurrentAddressTxtBox.Clear();
                PermanentAddressTxtBox.Clear();
                BirthPlaceTxtBox.Clear();

                // DateTimePicker
                BirthdayPicker.Value = DateTime.Today;

                // ComboBox
                GenderCmbBox.SelectedIndex = 0;
                AcademicYearCmbBox.SelectedIndex = 0;
                StudentTypeCmbBox.SelectedIndex = 0;
                DepartmentCmbBox.SelectedIndex = 0;
                ProgramCmbBox.SelectedIndex = 0;

                MessageBox.Show("All fields are cleared!", "Cleared");
            }
            else
            {
                // User clicked "No" or closed the dialog
            }
        }

        private void Add_Students_Load(object sender, EventArgs e)
        {
            // Gender
            GenderCmbBox.Items.Insert(0, "Gender");
            GenderCmbBox.SelectedIndex = 0;
            GenderCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderCmbBox.Enabled = true;
            GenderCmbBox.DisplayMember = "Text";
            GenderCmbBox.ValueMember = "Value";

            // Academic Year
            AcademicYearCmbBox.Items.Insert(0, "Academic Year");
            AcademicYearCmbBox.SelectedIndex = 0;
            AcademicYearCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AcademicYearCmbBox.Enabled = true;
            AcademicYearCmbBox.DisplayMember = "Text";
            AcademicYearCmbBox.ValueMember = "Value";

            // Student Type
            StudentTypeCmbBox.Items.Insert(0, "Student Type");
            StudentTypeCmbBox.SelectedIndex = 0;
            StudentTypeCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentTypeCmbBox.Enabled = true;
            StudentTypeCmbBox.DisplayMember = "Text";
            StudentTypeCmbBox.ValueMember = "Value";

            // Department
            DepartmentCmbBox.Items.Insert(0, "Department");
            DepartmentCmbBox.SelectedIndex = 0;
            DepartmentCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepartmentCmbBox.Enabled = true;
            DepartmentCmbBox.DisplayMember = "Text";
            DepartmentCmbBox.ValueMember = "Value";

            // Program
            ProgramCmbBox.Items.Insert(0, "Program");
            ProgramCmbBox.SelectedIndex = 0;
            ProgramCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProgramCmbBox.Enabled = true;
            ProgramCmbBox.DisplayMember = "Text";
            ProgramCmbBox.ValueMember = "Value";
        }

    }
}