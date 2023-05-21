using AForge.Video;
using AForge.Video.DirectShow;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;

namespace Login_Form
{
    public partial class Add_Students : Form
    {
        string new_studentIDlbl; // Declaration of a string variable to store the student ID label.
        byte[] imageData; // Declaration of a byte array variable to store the image data.
        private bool isCaptured = false; // Declaration and initialization of a boolean variable to indicate if an image is captured.
        string countStr; // Declaration of a string variable to store a count value.

        VideoCaptureDevice videoCapture; // Declaration of a VideoCaptureDevice object for capturing video.
        FilterInfoCollection filterInfo; // Declaration of a FilterInfoCollection object to store filter information.

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application"); // Creation of a MySqlConnection object and initialization with the connection string.

        public Add_Students()
        {
            InitializeComponent(); // Initializes the components of the form.
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add new student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Displays a confirmation dialog with a question message and Yes/No buttons.
            if (result == DialogResult.Yes) // User clicked "Yes"
            {
                if (!string.IsNullOrEmpty(LastNameTxtBox.Text) && !string.IsNullOrEmpty(FirstNameTxtBox.Text) && !string.IsNullOrEmpty(MiddleNameTxtBox.Text) && !string.IsNullOrEmpty(EmailTxtBox.Text) && !string.IsNullOrEmpty(AgeTxtBox.Text) && !string.IsNullOrEmpty(BirthPlaceTxtBox.Text) && !string.IsNullOrEmpty(CurrentAddressTxtBox.Text) && !string.IsNullOrEmpty(PermanentAddressTxtBox.Text) && GenderCmbBox.SelectedIndex != 0 && AcademicYearCmbBox.SelectedIndex != 0 && StudentTypeCmbBox.SelectedIndex != 0 && DepartmentCmbBox.SelectedIndex != 0 && ProgramCmbBox.SelectedIndex != 0 && StudentActualPic.Image != null)
                {
                    // Check if all the required fields and selections are filled or selected
                    string insertQuery = "INSERT INTO app_student_records (student_id, last_name, first_name, middle_name, email, birthday, gender, age, birth_place, current_address, permanent_address, academic_year, student_type, department, program, id_photo) VALUES (@student_id, @last_name, @first_name, @middle_name, @email, @birthday, @gender, @age, @birth_place, @current_address, @permanent_address, @academic_year, @student_type, @department, @program, @id_photo)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection); // Creation of a MySqlCommand object with the INSERT query and connection.

                    // Add parameters to the command object
                    command.Parameters.AddWithValue("@student_id", new_studentIDlbl);
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
                    command.Parameters.AddWithValue("@id_photo", imageData);

                    connection.Open(); // Open the connection
                    int rowsAffected = command.ExecuteNonQuery(); // Executes the command and returns the number of rows affected.
                    connection.Close(); // Close the connection
                    ClearFields(); // Call the user-defined ClearFields function to clear the fields

                    MessageBox.Show("Successfully registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Displays a success message box.
                }
                else
                {
                    MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Displays an error message box.
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all fields?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); // Displays a warning dialog with a Yes/No option.
            if (result == DialogResult.Yes) // User clicked "Yes"
            {
                ClearFields(); // Calls the ClearFields() method to clear all input fields.
                MessageBox.Show("All fields are cleared!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Displays an information message box.
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            this.Hide(); // Hides the current form.
            AdminDashboardForm mainForm = new AdminDashboardForm(); // Creates an instance of the AdminDashboardForm.
            mainForm.ShowDialog(); // Shows the AdminDashboardForm as a dialog.
        }

        private void Add_Students_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application"); // Creates a MySqlConnection object and initializes it with the connection string.
            connection.Open(); // Opens the database connection.
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(student_number) + 1 FROM app_student_records;", connection); // Creates a MySqlCommand object with the SQL query to retrieve the count of student numbers.
            object result = cmd.ExecuteScalar(); // Executes the query and retrieves the count value as an object.
            countStr = result.ToString(); // Converts the object to a string and stores it in the countStr variable.
            connection.Close(); // Closes the database connection.

            StudentNumberCountLbl.Text = StudentNumberCountLbl.Text + " " + countStr; // Updates the StudentNumberCountLbl text by appending the count value.

            // Gender
            GenderCmbBox.Items.Insert(0, "Gender"); // Adds a default "Gender" item at index 0.
            GenderCmbBox.SelectedIndex = 0; // Sets the selected index to 0.
            GenderCmbBox.DropDownStyle = ComboBoxStyle.DropDownList; // Sets the drop-down style to DropDownList.
            GenderCmbBox.Enabled = true; // Enables the Gender ComboBox.
            GenderCmbBox.DisplayMember = "Text"; // Sets the display member property to "Text".
            GenderCmbBox.ValueMember = "Value"; // Sets the value member property to "Value".

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

            BirthdayPicker.Value = DateTime.Today; // Sets the value of the BirthdayPicker to the current date.

            StudentIDLbl.ForeColor = Color.White; // Sets the text color of the StudentIDLbl to white.

            // Adds department items to the Department ComboBox.
            DepartmentCmbBox.Items.Add("(CAS) College of Arts and Sciences");
            DepartmentCmbBox.Items.Add("(CCICT) College of Computer, Information and Communications Technology");
            DepartmentCmbBox.Items.Add("(COEd) College of Education");
            DepartmentCmbBox.Items.Add("(COE) College of Engineering");
            DepartmentCmbBox.Items.Add("(CME) College of Management and Entrepreneurship");
            DepartmentCmbBox.Items.Add("(COT) College of Technology");
        }

        private void Add_Students_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera(); // Stops the video capture when the form is closing.
        }

        private void ClearFields()
        {
            // Clears the texts in the textboxes.
            LastNameTxtBox.Clear();
            FirstNameTxtBox.Clear();
            MiddleNameTxtBox.Clear();
            EmailTxtBox.Clear();
            AgeTxtBox.Clear();
            CurrentAddressTxtBox.Clear();
            PermanentAddressTxtBox.Clear();
            BirthPlaceTxtBox.Clear();

            // Sets the selected index of the combo box to 0 (first).
            GenderCmbBox.SelectedIndex = 0;
            AcademicYearCmbBox.SelectedIndex = 0;
            StudentTypeCmbBox.SelectedIndex = 0;
            DepartmentCmbBox.SelectedIndex = 0;
            ProgramCmbBox.Items.Insert(0, "Program"); // Inserts a default "Program" item at index 0.
            ProgramCmbBox.SelectedIndex = 0;

            StopCamera(); // Stops the camera.

            OpenCameraBtn.Text = "Open Camera"; // Changes the text of OpenCameraBtn to "Open Camera".

            OpenCameraBtn.Click -= StopCameraBtn_Click; // Removes the current event handler from OpenCameraBtn's click event.
            OpenCameraBtn.Click += new EventHandler(OpenCameraBtn_Click); // Adds a new event handler to OpenCameraBtn's click event.

            CaptureBtn.Text = "Capture"; // Changes the text of CaptureBtn to "Capture".

            CaptureBtn.Click -= RetakeBtn_Click; // Removes the current event handler from CaptureBtn's click event.
            CaptureBtn.Click += new EventHandler(CaptureBtn_Click); // Adds a new event handler to CaptureBtn's click event.

            // StartCamera();
        }

        private void AcademicYearCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application"); // Creates a MySqlConnection object and initializes it with the connection string.
            connection.Open(); // Opens the database connection.
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(student_number) + 1 FROM app_student_records;", connection); // Creates a MySqlCommand object with the SQL query to retrieve the count of student numbers.
            object result = cmd.ExecuteScalar(); // Executes the query and retrieves the count value as an object.
            string countStr = result.ToString(); // Converts the object to a string and stores it in the countStr variable.
            connection.Close(); // Closes the database connection.

            object selectedItem = AcademicYearCmbBox.SelectedItem; // Gets the selected item from AcademicYearCmbBox
            string selectedText = selectedItem.ToString(); // Converts the selected item to a string.
            StudentIDLbl.Text = selectedText + "-" + "0" + countStr; // Sets the text of StudentIDLbl using the selected academic year and the count value.
            new_studentIDlbl = selectedText + "-" + "0" + countStr; // Updates the value of the new_studentIDlbl variable with the new student ID.

            if (AcademicYearCmbBox.SelectedIndex == 0)
            {
                StudentIDLbl.ForeColor = Color.White; // Sets the text color of StudentIDLbl to white if the selected index of AcademicYearCmbBox is 0.
            }
            else
            {
                StudentIDLbl.ForeColor = Color.Black; // Sets the text color of StudentIDLbl to black if the selected index of AcademicYearCmbBox is not 0.
            }
        }

        private void DepartmentCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramCmbBox.Items.Clear(); // Clears the items in the ProgramCmbBox.

            switch (DepartmentCmbBox.SelectedIndex)
            {
                case 0: // Default
                    break;
                case 1: // CAS
                    ProgramCmbBox.Items.Insert(0, "Program"); // Inserts a default "Program" item at index 0.
                    ProgramCmbBox.SelectedIndex = 0; // Sets the selected index of ProgramCmbBox to 0.
                    // Adds specific program items for the departments
                    ProgramCmbBox.Items.Add("(BAEL-ELSD) Bachelor of Arts in English Language - English Language Studies as a Discipline");
                    ProgramCmbBox.Items.Add("(BAEL-ELAP) Bachelor of Arts in English Language - English Language Across Professions");
                    ProgramCmbBox.Items.Add("(BAL-LCS) Bachelor of Arts in Literature - Literary Cultural Studies");
                    ProgramCmbBox.Items.Add("(BAL-LAP) Bachelor of Arts in Literature - Literature Across Professions");
                    ProgramCmbBox.Items.Add("(BS Bio-Ecology) Bachelor of Science in Biology - Ecology");
                    ProgramCmbBox.Items.Add("(BS Dev Com) Bachelor of Science in Development Communication");
                    ProgramCmbBox.Items.Add("(BAF) Batsilyer ng Sining sa Filipino");
                    ProgramCmbBox.Items.Add("(BS Math) Bachelor of Science in Mathematics");
                    ProgramCmbBox.Items.Add("(BS Psych) Bachelor of Science in Psychology");
                    ProgramCmbBox.Items.Add("(BS Stat) Bachelor of Science in Statistics");
                    ProgramCmbBox.Items.Add("(BSN) Bachelor of Science in Nursing at Cebu City Medical Center - College of Nursing");
                    break;
                case 2: // CCICT
                    ProgramCmbBox.Items.Insert(0, "Program");
                    ProgramCmbBox.SelectedIndex = 0;
                    ProgramCmbBox.Items.Add("(BSIT) Bachelor of Science in Information Technology");
                    ProgramCmbBox.Items.Add("(BSIS) Bachelor of Science in Information Systems");
                    ProgramCmbBox.Items.Add("(BIT-CT) Bachelor of Industrial Technology - Computer Technology");
                    break;
                case 3: // COED
                    ProgramCmbBox.Items.Insert(0, "Program");
                    ProgramCmbBox.SelectedIndex = 0;
                    ProgramCmbBox.Items.Add("(BEEd) Bachelor of Elementary Education");
                    ProgramCmbBox.Items.Add("(BSEd-Mathematics) Bachelor of Secondary Education - Mathematics");
                    ProgramCmbBox.Items.Add("(BSEd-Science) Bachelor of Secondary Education - Science");
                    ProgramCmbBox.Items.Add("(BSEd-Filipino) Bachelor of Secondary Education- Filipino");
                    ProgramCmbBox.Items.Add("(BSEd-Social Studies) Bachelor of Secondary Education - Social Studies");
                    ProgramCmbBox.Items.Add("(BTLEd-Home Economics) Bachelor of Technology and Livelihood Education - Home Economics");
                    ProgramCmbBox.Items.Add("(BTLEd-Information and Communication Technology) Bachelor of Technology and Livelihood Education - Information and Communication Technology");
                    ProgramCmbBox.Items.Add("(BTLEd-Industrial Arts) Bachelor of Technology and Livelihood Education - Industrial Arts");
                    ProgramCmbBox.Items.Add("(BECEd) Bachelor of Early Childhood Education");
                    ProgramCmbBox.Items.Add("(BSNEd) Bachelor of Special Needs Education");
                    ProgramCmbBox.Items.Add("(BTVTEd-Automotive Technology) Bachelor of Technical-Vocational Teacher Education - Automotive Technology");
                    ProgramCmbBox.Items.Add("(BTVTEd-Civil and Construction Technology) Bachelor of Technical-Vocational Teacher Education - Civil and Construction Technology");
                    ProgramCmbBox.Items.Add("(BTVTEd-Drafting Technology) Bachelor of Technical-Vocational Teacher Education - Drafting Technology");
                    ProgramCmbBox.Items.Add("(BTVTEd-Electrical Technology) Bachelor of Technical-Vocational Teacher Education - Electrical Technology");
                    ProgramCmbBox.Items.Add("(BTVTEd-Electronics Technology) Bachelor of Technical-Vocational Teacher Education - Electronics Technology");
                    ProgramCmbBox.Items.Add("(BTVTEd-Garments and Fashion Design) Bachelor of Technical-Vocational Teacher Education - Garments and Fashion Design");
                    ProgramCmbBox.Items.Add("(BTVTEd-Food and Service Management) Bachelor of Technical-Vocational Teacher Education - Food and Service Management");
                    ProgramCmbBox.Items.Add("(BTVTEd-Welding and Fabrication Technology) Bachelor of Technical-Vocational Teacher Education - Welding and Fabrication Technology");
                    ProgramCmbBox.Items.Add("(CT-Computer Technology) Certificate of Technology - Computer Technology (for deaf student-applicants only)");
                    ProgramCmbBox.Items.Add("(CT-Food Technology) Certificate of Technology - Food Technology (for deaf student-applicants only)");
                    break;
                case 4: // COE
                    ProgramCmbBox.Items.Insert(0, "Program");
                    ProgramCmbBox.SelectedIndex = 0;
                    ProgramCmbBox.Items.Add("(BSAsE) Bachelor of Science in Aerospace Engineering");
                    ProgramCmbBox.Items.Add("(BSCE) Bachelor of Science in Civil Engineering");
                    ProgramCmbBox.Items.Add("(BSCpE) Bachelor of Science in Computer Engineering");
                    ProgramCmbBox.Items.Add("(BSECE) Bachelor of Science in Electronics Engineering");
                    ProgramCmbBox.Items.Add("(BSEE) Bachelor of Science in Electrical Engineering");
                    ProgramCmbBox.Items.Add("(BSIE) Bachelor of Science in Industrial Engineering");
                    ProgramCmbBox.Items.Add("(BSME) Bachelor of Science in Mechanical Engineering");
                    break;
                case 5: // CME
                    ProgramCmbBox.Items.Insert(0, "Program");
                    ProgramCmbBox.SelectedIndex = 0;
                    ProgramCmbBox.Items.Add("(BSBA-MM) Bachelor of Science in Business Administration - Marketing Management");
                    ProgramCmbBox.Items.Add("(BSHM) Bachelor of Science in Hospitality Management");
                    ProgramCmbBox.Items.Add("(BPA) Bachelor of Public Administration");
                    ProgramCmbBox.Items.Add("(BSTM) Bachelor of Science in Tourism Management");
                    break;
                case 6: // COT
                    ProgramCmbBox.Items.Insert(0, "Program");
                    ProgramCmbBox.SelectedIndex = 0;
                    ProgramCmbBox.Items.Add("(BSGD) Bachelor of Science in Graphics and Design");
                    ProgramCmbBox.Items.Add("(BSMx) Bachelor of Science in Mechatronics");
                    ProgramCmbBox.Items.Add("(BSTechM) Bachelor of Science in Technology Management");
                    ProgramCmbBox.Items.Add("(BIT-Automotive Technology) Bachelor of Industrial Technology - Automotive Technology");
                    ProgramCmbBox.Items.Add("(BIT-Civil Technology) Bachelor of Industrial Technology - Civil Technology");
                    ProgramCmbBox.Items.Add("(BIT-Cosmetology) Bachelor of Industrial Technology - Cosmetology");
                    ProgramCmbBox.Items.Add("(BIT-Drafting Technology) Bachelor of Industrial Technology - Drafting Technology");
                    ProgramCmbBox.Items.Add("(BIT-Electrical Technology) Bachelor of Industrial Technology - Electrical Technology");
                    ProgramCmbBox.Items.Add("(BIT-Electronics Technology) Bachelor of Industrial Technology - Electronics Technology");
                    ProgramCmbBox.Items.Add("(BIT-Furniture and Cabinetmaking Technology) Bachelor of Industrial Technology - Furniture and Cabinetmaking Technology");
                    ProgramCmbBox.Items.Add("(BIT-Food Preparation and Services Technology) Bachelor of Industrial Technology - Food Preparation and Services Technology");
                    ProgramCmbBox.Items.Add("(BIT-Garments Technology) Bachelor of Industrial Technology - Garments Technology");
                    ProgramCmbBox.Items.Add("(BIT-Interior Design Technology) Bachelor of Industrial Technology - Interior Design Technology");
                    ProgramCmbBox.Items.Add("(BIT-Machine Shop Technology) Bachelor of Industrial Technology - Machine Shop Technology");
                    ProgramCmbBox.Items.Add("(BIT-Power Plant Technology) Bachelor of Industrial Technology - Power Plant Technology");
                    ProgramCmbBox.Items.Add("(BIT-Refrigeration and Air Conditioning - Technology) Bachelor of Industrial Technology - Refrigeration and Air Conditioning Technology");
                    ProgramCmbBox.Items.Add("(BIT-Welding and Fabrication Technology) Bachelor of Industrial Technology - Welding and Fabrication Technology");
                    break;
            }
        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            if (!isCaptured)
            {
                StudentActualPic.Image = (Bitmap)eventArgs.Frame.Clone(); // Sets the image of StudentActualPic to the captured frame.
            }
        }

        void StartCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString); // Initializes the video capture device using the first device in the filterInfo collection.
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On); // Registers the Camera_On event handler for the NewFrame event.
                videoCapture.Start(); // Starts the video capture.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Displays an error message if an exception occurs.
            }
        }
        void StopCamera()
        {
            if (videoCapture != null && videoCapture.IsRunning)
            {
                videoCapture.SignalToStop(); // Signals the video capture to stop.
                videoCapture.WaitForStop(); // Waits for the video capture to stop.
                videoCapture = null; // Sets the video capture object to null.
            }
            StudentActualPic.Image = null; // Clears the image displayed in StudentActualPic.
            StudentImageCoverPic.Show(); // Shows the StudentImageCoverPic.
        }

        private void OpenCameraBtn_Click(object sender, EventArgs e)
        {
            StartCamera(); // Starts the camera capture.
            StudentActualPic.SizeMode = PictureBoxSizeMode.CenterImage; // Sets the picture box size mode to CenterImage.
            StudentImageCoverPic.Hide(); // Hides the StudentImageCoverPic.
            

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender; // Retrieves the button that triggered the event.
            btn.Text = "Stop Camera"; // Sets the button text to "Stop Camera".

            btn.Click -= OpenCameraBtn_Click; // Removes the current event handler.
            btn.Click += new EventHandler(StopCameraBtn_Click); // Adds the new event handler for the StopCameraBtn_Click method.
        }

        private void StopCameraBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to stop camera?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StopCamera(); // Stops the camera capture.

                System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender; // Retrieves the button that triggered the event.
                btn.Text = "Open Camera"; // Sets the button text to "Open Camera".

                btn.Click -= StopCameraBtn_Click; // Removes the current event handler.
                btn.Click += new EventHandler(OpenCameraBtn_Click); // Adds the new event handler for the OpenCameraBtn_Click method.
            }
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            if (StudentActualPic.Image == null)
            {
                MessageBox.Show("Please open camera first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Displays a warning message if the camera is not open.
            }
            if (AcademicYearCmbBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select academic year first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Displays a warning message if the academic year is not selected.
            }
            else
            {
                isCaptured = !isCaptured; // Toggles the isCaptured variable.
                string filename = @"C:\Users\ivang\Downloads\c# files\student id capture\" + StudentIDLbl.Text + "-id-photo" + ".jpg"; // Constructs the filename for the captured image.
                var bitmap = new Bitmap(StudentActualPic.Width, StudentActualPic.Height); // Creates a bitmap with the same size as StudentActualPic.
                StudentActualPic.DrawToBitmap(bitmap, StudentActualPic.ClientRectangle); // Draws the contents of StudentActualPic onto the bitmap.
                System.Drawing.Imaging.ImageFormat imageFormat = null; // Initializes the image format variable.
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg; // Sets the image format to JPEG.
                bitmap.Save(filename, imageFormat); // Saves the bitmap to the specified filename as a JPEG image.

                imageData = File.ReadAllBytes(filename); // Reads the image file into a byte array.

                System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender; // Retrieves the button that triggered the event.
                btn.Text = "Retake"; // Sets the button text to "Retake".

                btn.Click -= CaptureBtn_Click; // Removes the current event handler.
                btn.Click += new EventHandler(RetakeBtn_Click); // Adds the new event handler for the RetakeBtn_Click method.
            }
        }

        private void RetakeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to capture again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) // User clicked "Yes"
            {
                System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                btn.Text = "Capture";

                btn.Click -= RetakeBtn_Click; // Remove the current event handler
                btn.Click += new EventHandler(CaptureBtn_Click); // Add the new event handler

                isCaptured = !isCaptured; // Toggles the isCaptured variable.
                string filename = @"C:\Users\ivang\Downloads\c# files\student id capture\" + StudentIDLbl.Text + "-id-photo" + ".jpg"; // Constructs the filename for the captured image.
                var bitmap = new Bitmap(StudentActualPic.Width, StudentActualPic.Height); // Creates a bitmap with the same size as StudentActualPic.
                StudentActualPic.DrawToBitmap(bitmap, StudentActualPic.ClientRectangle); // Draws the contents of StudentActualPic onto the bitmap.
                System.Drawing.Imaging.ImageFormat imageFormat = null; // Initializes the image format variable.
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg; // Sets the image format to JPEG.
                bitmap.Save(filename, imageFormat); // Saves the bitmap to the specified filename as a JPEG image.

                if (File.Exists(filename))
                {
                    File.Delete(filename); // Deletes the captured image file.
                    MessageBox.Show("Image deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Displays a success message.
                }
                else
                {
                    MessageBox.Show("Image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Displays an error message if the image file is not found.
                }
            }
        }
    }
}