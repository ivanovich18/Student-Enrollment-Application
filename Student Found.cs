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
                    string student_number = string.Format("{0}", reader["student_number"]);
                    string student_id = string.Format("{0}", reader["student_id"]);
                    string academic_year = string.Format("{0}", reader["academic_year"]);
                    string last_name = string.Format("{0}", reader["last_name"]);
                    string first_name = string.Format("{0}", reader["first_name"]);
                    string middle_name = string.Format("{0}", reader["middle_name"]);
                    string email = string.Format("{0}", reader["email"]);
                    string birthday = string.Format("{0}", reader["birthday"]);

                    DateTime birthdayDate;
                    if (DateTime.TryParse(birthday, out birthdayDate))
                    {
                        string formattedBirthday = birthdayDate.ToString("MM/dd/yyyy");
                        BirthdayLbl.Text += formattedBirthday;
                        Console.WriteLine(formattedBirthday); // Output: 05/16/2023
                                                              // Use the formattedBirthday value as needed in your Windows Forms application
                    }
                    else
                    {
                        // Handle invalid or null birthday values
                        Console.WriteLine("Invalid birthday");
                    }

                    string gender = string.Format("{0}", reader["gender"]);
                    string age = string.Format("{0}", reader["age"]);
                    string birth_place = string.Format("{0}", reader["birth_place"]);
                    string current_address = string.Format("{0}", reader["current_address"]);
                    string permanent_address = string.Format("{0}", reader["permanent_address"]);
                    string student_type = string.Format("{0}", reader["student_type"]);
                    string department = string.Format("{0}", reader["department"]);
                    string program = string.Format("{0}", reader["program"]);
                    string creation_date = string.Format("{0}", reader["creation_date"]);

                    StudentNumberLbl.Text += student_number;
                    StudentIDLbl.Text += student_id;
                    LastNameLbl.Text += last_name;
                    FirstNameLbl.Text += first_name;
                    MiddleNameLbl.Text += middle_name;
                    AcademicYearLbl.Text += academic_year;
                    // BirthdayLbl.Text += formattedBirthday;
                    EmailLbl.Text += email;
                    AgeLbl.Text += age;
                    BirthplaceLbl.Text += birth_place;
                    CurrentAddressLbl.Text += current_address;
                    PermanentAddressLbl.Text += permanent_address;
                    GenderLbl.Text += gender;
                    StudentTypeLbl.Text += student_type;
                    DepartmentLbl.Text += department;
                    ProgramLbl.Text += program;
                    CreationDateLbl.Text += creation_date;

                    // Create a MemoryStream object to store the binary data of the picture blob
                    MemoryStream stream = new MemoryStream();

                    // Read the binary data of the picture blob and write it to the MemoryStream object
                    byte[] buffer = (byte[])reader["id_photo"];
                    stream.Write(buffer, 0, buffer.Length);

                    // Convert the binary data of the picture blob to an Image object
                    Image image = Image.FromStream(stream);

                    // Set the Image property of the PictureBox control to the Image object
                    StudentPhoto.Image = image;
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            SearchStudentForm searchStudentForm = new SearchStudentForm();
            this.Hide();
            searchStudentForm.Show();
        }
    }
}
