using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Form
{
    public partial class Add_Students : Form
    {
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
            MessageBox.Show(StudentNumberTxtBox.PlaceholderText + ": " + StudentNumberTxtBox.Text);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
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