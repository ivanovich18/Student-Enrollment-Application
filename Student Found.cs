using MySql.Data.MySqlClient;

namespace Login_Form
{
    public partial class Student_Found : Form
    {
        private string id_number;
        private Form callingForm;

        // Constructor without parameters
        public Student_Found()
        {
            InitializeComponent();
        }

        // Constructor with the student ID number parameter
        public Student_Found(string id_number, Form callingForm)
        {
            InitializeComponent();
            this.id_number = id_number;
            this.callingForm = callingForm;
        }

        private void Student_Found_Load(object sender, EventArgs e)
        {
            string idNumber;

            if (this.GetType() == typeof(SearchStudentForm)) // Constructor with the student ID number parameter
            {
                idNumber = null; // Set idNumber to null if the current form is SearchStudentForm
            }
            else
            {
                idNumber = id_number.Trim(); // Trim the id_number and assign it to idNumber variable
            }

            // Establish a connection to the MySQL database
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Open the database connection

                // Define a query to retrieve a row from a table based on the student number
                string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Add a parameter to the query based on the value of idNumber
                command.Parameters.AddWithValue("@idNumber", idNumber);

                // Execute the query and retrieve the result as a MySqlDataReader
                MySqlDataReader reader = command.ExecuteReader();

                // Check if a row was retrieved
                if (reader.Read())
                {
                    // Retrieve values from the reader for each column
                    string student_number = string.Format("{0}", reader["student_number"]);
                    string student_id = string.Format("{0}", reader["student_id"]);
                    string academic_year = string.Format("{0}", reader["academic_year"]);
                    string last_name = string.Format("{0}", reader["last_name"]);
                    string first_name = string.Format("{0}", reader["first_name"]);
                    string middle_name = string.Format("{0}", reader["middle_name"]);
                    string email = string.Format("{0}", reader["email"]);
                    string birthday = string.Format("{0}", reader["birthday"]);

                    // Convert the birthday string to a DateTime object
                    DateTime birthdayDate;
                    if (DateTime.TryParse(birthday, out birthdayDate))
                    {
                        BirthdayLblplc.Text = string.Empty;
                        // Format the birthday as "MM/dd/yyyy"
                        string formattedBirthday = birthdayDate.ToString("MM/dd/yyyy");
                        BirthdayLblplc.Text += formattedBirthday; // Append the formattedBirthday to the text of the BirthdayLbl
                        Console.WriteLine(formattedBirthday); // Output: 05/16/2023
                                                              // Use the formattedBirthday value as needed in your Windows Forms application
                    }
                    else
                    {
                        // Handle invalid or null birthday values
                        Console.WriteLine("Invalid birthday");
                    }

                    // Retrieve values from the reader for other columns
                    string gender = string.Format("{0}", reader["gender"]);
                    string age = string.Format("{0}", reader["age"]);
                    string birth_place = string.Format("{0}", reader["birth_place"]);
                    string current_address = string.Format("{0}", reader["current_address"]);
                    string permanent_address = string.Format("{0}", reader["permanent_address"]);
                    string student_type = string.Format("{0}", reader["student_type"]);
                    string department = string.Format("{0}", reader["department"]);
                    string program = string.Format("{0}", reader["program"]);
                    string creation_date = string.Format("{0}", reader["creation_date"]);

                    // Clear default value of placeholder texts
                    StudentNumberLblplc.Text = string.Empty;
                    StudentIDLblplc.Text = string.Empty;
                    LastNameLblplc.Text = string.Empty;
                    FirstNameLblplc.Text = string.Empty;
                    MiddleNameLblplc.Text = string.Empty;
                    AcademicYearLblplc.Text = string.Empty;
                    EmailLblplc.Text = string.Empty;
                    AgeLblplc.Text = string.Empty;
                    BirthplaceLblplc.Text = string.Empty;
                    CurrentAddressLblplc.Text = string.Empty;
                    PermanentAddressLblplc.Text = string.Empty;
                    GenderLblplc.Text = string.Empty;
                    StudentTypeLblplc.Text = string.Empty;
                    DepartmentLblplc.Text = string.Empty;
                    ProgramLblplc.Text = string.Empty;
                    CreationDateLblplc.Text = string.Empty;

                    // Append the retrieved values to the corresponding label controls
                    StudentNumberLblplc.Text += student_number;
                    StudentIDLblplc.Text += student_id;
                    LastNameLblplc.Text += last_name;
                    FirstNameLblplc.Text += first_name;
                    MiddleNameLblplc.Text += middle_name;
                    AcademicYearLblplc.Text += academic_year;
                    EmailLblplc.Text += email;
                    AgeLblplc.Text += age;
                    BirthplaceLblplc.Text += birth_place;
                    CurrentAddressLblplc.Text += current_address;
                    PermanentAddressLblplc.Text += permanent_address;
                    GenderLblplc.Text += gender;
                    StudentTypeLblplc.Text += student_type;
                    DepartmentLblplc.Text += department;
                    ProgramLblplc.Text += program;
                    CreationDateLblplc.Text += creation_date;

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
                reader.Close(); // Close the reader
                command.Dispose(); // Close the reader
                connection.Close(); // Close the database connection
            }
        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            callingForm.Show(); // Show the calling form
            this.Close(); // Close the main form
        }

        private void saveIDBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save student ID?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) // User clicked "Yes"
            {
                StudentIDPhotoForm photo_Form = new StudentIDPhotoForm(id_number);
                photo_Form.Show();
            }
        }
    }
}
