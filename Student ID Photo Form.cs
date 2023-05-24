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
using System.Xml;

namespace Login_Form
{
    public partial class StudentIDPhotoForm : Form
    {
        private string id_number;
        private string newDepartment;
        string fullName;
        System.Windows.Forms.Timer timer;

        public StudentIDPhotoForm(string id_number)
        {
            InitializeComponent();
            this.id_number = id_number;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000; // 10 seconds
            timer.Tick += Timer_Tick;
        }

        private void StudentIDPhotoForm_Load(object sender, EventArgs e)
        {
            // Establish a connection to the MySQL database
            string connectionString = "server=localhost;user=root;password=;database=student_enrollment_application";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Open the database connection

                // Define a query to retrieve a row from a table based on the student number
                string query = "SELECT * FROM app_student_records WHERE student_id = @idNumber";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Add a parameter to the query based on the value of idNumber
                command.Parameters.AddWithValue("@idNumber", id_number);

                // Execute the query and retrieve the result as a MySqlDataReader
                MySqlDataReader reader = command.ExecuteReader();

                // Check if a row was retrieved
                if (reader.Read())
                {
                    // Retrieve values from the reader for each column
                    string last_name = string.Format("{0}", reader["last_name"]);
                    string first_name = string.Format("{0}", reader["first_name"]);
                    string student_id = string.Format("{0}", reader["student_id"]);
                    string program = string.Format("{0}", reader["program"]);
                    string department = string.Format("{0}", reader["department"]);

                    if (department == "(CAS) College of Arts and Sciences")
                    {
                        newDepartment = " CAS ";
                    }
                    if (department == "(CCICT) College of Computer, Information and Communications Technology")
                    {
                        newDepartment = "CCICT";
                    }
                    if (department == "(COEd) College of Education")
                    {
                        newDepartment = " COED";
                    }
                    if (department == "(COE) College of Engineering")
                    {
                        newDepartment = " COE ";
                    }
                    if (department == "(CME) College of Management and Entrepreneurship")
                    {
                        newDepartment = " CME ";
                    }
                    if (department == "(COT) College of Technology")
                    {
                        newDepartment = " COT ";
                    }

                    // Clear default value of placeholder texts
                    fullNameLbl.Text = string.Empty;
                    ProgramLbl.Text = string.Empty;
                    studentIDLbl.Text = string.Empty;
                    departmentLbl.Text = string.Empty;

                    // Append the retrieved values to the corresponding label controls
                    fullNameLbl.Text = first_name + " " + last_name;
                    fullName = first_name + " " + last_name;
                    fullNameLbl.Text = fullNameLbl.Text.ToUpper();
                    ProgramLbl.Text = program;
                    studentIDLbl.Text = "Student ID: " + student_id;
                    departmentLbl.Text = newDepartment;

                    int nameoffsetY = 50;
                    // Place the label in the center of the form or container
                    fullNameLbl.Location = new Point((this.ClientSize.Width - fullNameLbl.Width) / 2, (this.ClientSize.Height - fullNameLbl.Height) / 2 + nameoffsetY);

                    int programoffsetY = 93;
                    ProgramLbl.Location = new Point((this.ClientSize.Width - ProgramLbl.Width) / 2, (this.ClientSize.Height - ProgramLbl.Height) / 2 + programoffsetY);

                    int studentIDoffsetY = 140;
                    studentIDLbl.Location = new Point((this.ClientSize.Width - studentIDLbl.Width) / 2, (this.ClientSize.Height - studentIDLbl.Height) / 2 + studentIDoffsetY);

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
                SaveFormAsImage();
            }
        }
        private void SaveFormAsImage()
        {
            // Calculate the size of the client area of the form
            Size clientSize = this.ClientSize;

            // Create a bitmap with the size of the client area
            Bitmap bitmap = new Bitmap(clientSize.Width, clientSize.Height);

            // Draw the contents of the form onto the bitmap
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, clientSize.Width, clientSize.Height));

            // Specify the file path and name to save the image
            string filePath = @"C:\Users\ivang\Downloads\c# files\Student ID\" + fullName + "-ID" + ".png";

            // Save the bitmap as an image file
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            // Display a success message or perform any other desired actions
            MessageBox.Show("ID saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StudentIDPhotoForm_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Visible = false;
        }
    }
}
