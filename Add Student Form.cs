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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;
using static Bunifu.UI.WinForms.Helpers.Transitions.Transition;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.Intrinsics.X86;
using System.Reflection.PortableExecutable;
using System.Web.Services.Description;
using System.Text.RegularExpressions;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Drawing2D;
using System.Diagnostics.Metrics;

namespace Login_Form
{
    public partial class Add_Students : Form
    {
        string new_studentIDlbl;
        byte[] imageData;
        private bool isCaptured = false;
        string countStr;

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
        MySqlCommand command;
        MySqlDataReader reader;

        public Add_Students()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add new student?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // User clicked "Yes"
                if (!string.IsNullOrEmpty(LastNameTxtBox.Text) && !string.IsNullOrEmpty(FirstNameTxtBox.Text) && !string.IsNullOrEmpty(MiddleNameTxtBox.Text) && !string.IsNullOrEmpty(EmailTxtBox.Text) && !string.IsNullOrEmpty(AgeTxtBox.Text) && !string.IsNullOrEmpty(BirthPlaceTxtBox.Text) && !string.IsNullOrEmpty(CurrentAddressTxtBox.Text) && !string.IsNullOrEmpty(PermanentAddressTxtBox.Text) && GenderCmbBox.SelectedIndex != 0 && AcademicYearCmbBox.SelectedIndex != 0 && StudentTypeCmbBox.SelectedIndex != 0 && DepartmentCmbBox.SelectedIndex != 0 && ProgramCmbBox.SelectedIndex != 0 && StudentActualPic != null)
                {
                    string insertQuery = "INSERT INTO app_student_records (student_id, last_name, first_name, middle_name, email, birthday, gender, age, birth_place, current_address, permanent_address, academic_year, student_type, department, program, id_photo) VALUES (@student_id, @last_name, @first_name, @middle_name, @email, @birthday, @gender, @age, @birth_place, @current_address, @permanent_address, @academic_year, @student_type, @department, @program, @id_photo)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

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

                    // Open the connection
                    connection.Open();

                    // execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    // close the connection
                    connection.Close();

                    ClearFields();

                    MessageBox.Show("Successfully registered!");
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Please fill all fields!");
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all fields?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // User clicked "Yes"
                ClearFields();
                MessageBox.Show("All fields are cleared!", "Cleared");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm mainForm = new AdminDashboardForm();
            mainForm.ShowDialog();
        }

        private void Add_Students_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(student_number) + 1 FROM app_student_records;", conn);
            // execute command and retrieve count value as object
            object result = cmd.ExecuteScalar();
            // convert object to string and store in variable
            countStr = result.ToString();
            // close connection
            conn.Close();

            StudentNumberCountLbl.Text = StudentNumberCountLbl.Text + " " + countStr;

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

            BirthdayPicker.Value = DateTime.Today;

            StudentIDLbl.ForeColor = Color.White;

            DepartmentCmbBox.Items.Add("(CAS) College of Arts and Sciences");
            DepartmentCmbBox.Items.Add("(CCICT) College of Computer, Information and Communications Technology");
            DepartmentCmbBox.Items.Add("(COEd) College of Education");
            DepartmentCmbBox.Items.Add("(COE) College of Engineering");
            DepartmentCmbBox.Items.Add("(CME) College of Management and Entrepreneurship");
            DepartmentCmbBox.Items.Add("(COT) College of Technology");

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, StudentActualPic.Width, StudentActualPic.Height);
            StudentActualPic.Region = new Region(gp);
        }

        private void ClearFields()
        {
            // Textboxes
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
            ProgramCmbBox.Items.Insert(0, "Program");
            ProgramCmbBox.SelectedIndex = 0;

            // Picture Box
            StudentImageCoverPic.Show();
            StudentActualPic.Image = null;
        }

        private void AcademicYearCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=student_enrollment_application");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(student_number) + 1 FROM app_student_records;", conn);
            // execute command and retrieve count value as object
            object result = cmd.ExecuteScalar();
            // convert object to string and store in variable
            string countStr = result.ToString();
            // close connection
            conn.Close();

            object selectedItem = AcademicYearCmbBox.SelectedItem;
            string selectedText = selectedItem.ToString();
            StudentIDLbl.Text = selectedText + "-" + "0" + countStr;
            new_studentIDlbl = selectedText + "-" + "0" + countStr;

            if (AcademicYearCmbBox.SelectedIndex == 0)
            {
                StudentIDLbl.ForeColor = Color.White;
            }
            else
            {
                StudentIDLbl.ForeColor = Color.Black;
            }
        }

        private void DepartmentCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramCmbBox.Items.Clear();

            switch (DepartmentCmbBox.SelectedIndex)
            {
                case 0: // Default
                    break;
                case 1: // CAS
                    ProgramCmbBox.Items.Insert(0, "Program");
                    ProgramCmbBox.SelectedIndex = 0;
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
                case 3: // COEd
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

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;

        void StartCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void OpenCameraBtn_Click(object sender, EventArgs e)
        {
            StudentActualPic.SizeMode = PictureBoxSizeMode.CenterImage;
            StudentImageCoverPic.Hide();
            StartCamera();
            // Change the button text
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.Text = "Stop Camera";

            // Change the button click function
            btn.Click -= OpenCameraBtn_Click; // Remove the current event handler
            btn.Click += new EventHandler(StopCameraBtn_Click); // Add the new event handler
        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            if (!isCaptured)
            {
                StudentActualPic.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        private void Add_Students_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the video capture
            if (videoCapture != null && videoCapture.IsRunning)
            {
                videoCapture.SignalToStop();
                videoCapture.WaitForStop();
                videoCapture = null;
            }
            StudentActualPic.Image = null;
        }

        private void StopCameraBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to stop camera?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // User clicked "Yes"
                // Stop the video capture
                if (videoCapture != null && videoCapture.IsRunning)
                {
                    videoCapture.SignalToStop();
                    videoCapture.WaitForStop();
                    videoCapture = null;
                }
                StudentActualPic.Image = null;
                StudentImageCoverPic.Show();

                // Change the button text
                System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                btn.Text = "Open Camera";

                // Change the button click function
                btn.Click -= StopCameraBtn_Click; // Remove the current event handler
                btn.Click += new EventHandler(OpenCameraBtn_Click); // Add the new event handler
            }
            else
            {
                // User clicked "No" or closed the dialog
            }
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            isCaptured = !isCaptured;
            string filename = @"C:\Users\ivang\Downloads\c# files\student id capture\" + StudentIDLbl.Text + "-student-id" + ".jpg";
            var bitmap = new Bitmap(StudentActualPic.Width, StudentActualPic.Height);
            StudentActualPic.DrawToBitmap(bitmap, StudentActualPic.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(filename, imageFormat);
            MessageBox.Show("Image successfully captured!");

            // Read the image file into a byte array
            imageData = File.ReadAllBytes(filename);

            // Change the button text
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.Text = "Retake";

            // Change the button click function
            btn.Click -= CaptureBtn_Click; // Remove the current event handler
            btn.Click += new EventHandler(RetakeBtn_Click); // Add the new event handler
        }

        private void RetakeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to capture again?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // User clicked "Yes"
                // Change the button text
                System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                btn.Text = "Capture";

                // Change the button click function
                btn.Click -= RetakeBtn_Click; // Remove the current event handler
                btn.Click += new EventHandler(CaptureBtn_Click); // Add the new event handler

                isCaptured = !isCaptured;
                string filename = @"C:\Users\ivang\Downloads\c# files\student id capture\" + StudentIDLbl.Text + "-student-id" + ".jpg";
                var bitmap = new Bitmap(StudentActualPic.Width, StudentActualPic.Height);
                StudentActualPic.DrawToBitmap(bitmap, StudentActualPic.ClientRectangle);
                System.Drawing.Imaging.ImageFormat imageFormat = null;
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                bitmap.Save(filename, imageFormat);
            }
            else
            {
                // User clicked "No" or closed the dialog
            }
        }

        private void UploadImageBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the default filter and title
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All Files (*.*)|*.*";
            openFileDialog.Title = "Open Image";

            // Display the file dialog box
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StudentImageCoverPic.Hide();

                // Get the selected file name
                string fileName = openFileDialog.FileName;

                // Set the Image property of the PictureBox control
                StudentActualPic.Image = Image.FromFile(fileName);
                StudentActualPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}