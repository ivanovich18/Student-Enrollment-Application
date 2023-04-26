using System.Windows.Forms;

namespace Login_Form
{
    partial class Add_Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Students));
            AddStudentLbl = new Label();
            StudentNumberTxtBox = new TextBox();
            CTULogo = new PictureBox();
            AddStudentPnl = new Panel();
            AddStudentPic = new PictureBox();
            RegisterBtn = new Button();
            pictureBox1 = new PictureBox();
            ClearBtn = new Button();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            StudentIDTxtBox = new TextBox();
            LastNameTxtBox = new TextBox();
            FirstNameTxtBox = new TextBox();
            MiddleNameTxtBox = new TextBox();
            AgeTxtBox = new TextBox();
            ExtensionNameCmbBox = new ComboBox();
            BirthdayPicker = new DateTimePicker();
            GenderCmbBox = new ComboBox();
            BirthPlaceTxtBox = new TextBox();
            CurrentAddressTxtBox = new TextBox();
            PermanentAddressTxtBox = new TextBox();
            AcademicYearCmbBox = new ComboBox();
            StudentTypeCmbBox = new ComboBox();
            DepartmentCmbBox = new ComboBox();
            ProgramCmbBox = new ComboBox();
            pictureBox3 = new PictureBox();
            OpenCameraBtn = new Button();
            UploadImageBtn = new Button();
            BirthdayPanel = new Panel();
            BirthdayLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            BirthdayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddStudentLbl
            // 
            AddStudentLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddStudentLbl.Location = new Point(216, 30);
            AddStudentLbl.Margin = new Padding(8, 0, 8, 0);
            AddStudentLbl.Name = "AddStudentLbl";
            AddStudentLbl.Size = new Size(347, 83);
            AddStudentLbl.TabIndex = 3;
            AddStudentLbl.Text = "New Student Form";
            AddStudentLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentNumberTxtBox
            // 
            StudentNumberTxtBox.BackColor = Color.White;
            StudentNumberTxtBox.BorderStyle = BorderStyle.FixedSingle;
            StudentNumberTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StudentNumberTxtBox.Location = new Point(455, 212);
            StudentNumberTxtBox.Margin = new Padding(13);
            StudentNumberTxtBox.Name = "StudentNumberTxtBox";
            StudentNumberTxtBox.PlaceholderText = " Student Number";
            StudentNumberTxtBox.Size = new Size(394, 39);
            StudentNumberTxtBox.TabIndex = 18;
            // 
            // CTULogo
            // 
            CTULogo.Image = Properties.Resources.transparent_logo;
            CTULogo.Location = new Point(75, 12);
            CTULogo.Name = "CTULogo";
            CTULogo.Size = new Size(117, 117);
            CTULogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CTULogo.TabIndex = 39;
            CTULogo.TabStop = false;
            // 
            // AddStudentPnl
            // 
            AddStudentPnl.BackColor = Color.Orange;
            AddStudentPnl.Location = new Point(-8, 141);
            AddStudentPnl.Name = "AddStudentPnl";
            AddStudentPnl.Size = new Size(1516, 10);
            AddStudentPnl.TabIndex = 40;
            // 
            // AddStudentPic
            // 
            AddStudentPic.BackColor = Color.Orange;
            AddStudentPic.Image = (Image)resources.GetObject("AddStudentPic.Image");
            AddStudentPic.Location = new Point(844, 60);
            AddStudentPic.Name = "AddStudentPic";
            AddStudentPic.Size = new Size(41, 30);
            AddStudentPic.SizeMode = PictureBoxSizeMode.StretchImage;
            AddStudentPic.TabIndex = 42;
            AddStudentPic.TabStop = false;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Orange;
            RegisterBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterBtn.ForeColor = SystemColors.ControlLightLight;
            RegisterBtn.Location = new Point(814, 46);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(201, 57);
            RegisterBtn.TabIndex = 41;
            RegisterBtn.Text = "         Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.Backspace;
            pictureBox1.Location = new Point(1086, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Orange;
            ClearBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ControlLightLight;
            ClearBtn.Location = new Point(1043, 46);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(201, 57);
            ClearBtn.TabIndex = 43;
            ClearBtn.Text = "        Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox2.Location = new Point(1320, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Orange;
            BackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(1262, 46);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(201, 57);
            BackBtn.TabIndex = 45;
            BackBtn.Text = "     Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // StudentIDTxtBox
            // 
            StudentIDTxtBox.BackColor = Color.White;
            StudentIDTxtBox.BorderStyle = BorderStyle.FixedSingle;
            StudentIDTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StudentIDTxtBox.Location = new Point(455, 281);
            StudentIDTxtBox.Margin = new Padding(13);
            StudentIDTxtBox.Name = "StudentIDTxtBox";
            StudentIDTxtBox.PlaceholderText = " Student ID";
            StudentIDTxtBox.Size = new Size(394, 39);
            StudentIDTxtBox.TabIndex = 47;
            // 
            // LastNameTxtBox
            // 
            LastNameTxtBox.BackColor = Color.White;
            LastNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxtBox.Location = new Point(455, 350);
            LastNameTxtBox.Margin = new Padding(13);
            LastNameTxtBox.Name = "LastNameTxtBox";
            LastNameTxtBox.PlaceholderText = " Last Name";
            LastNameTxtBox.Size = new Size(394, 39);
            LastNameTxtBox.TabIndex = 48;
            // 
            // FirstNameTxtBox
            // 
            FirstNameTxtBox.BackColor = Color.White;
            FirstNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxtBox.Location = new Point(455, 419);
            FirstNameTxtBox.Margin = new Padding(13);
            FirstNameTxtBox.Name = "FirstNameTxtBox";
            FirstNameTxtBox.PlaceholderText = " First Name";
            FirstNameTxtBox.Size = new Size(394, 39);
            FirstNameTxtBox.TabIndex = 49;
            // 
            // MiddleNameTxtBox
            // 
            MiddleNameTxtBox.BackColor = Color.White;
            MiddleNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            MiddleNameTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxtBox.Location = new Point(455, 489);
            MiddleNameTxtBox.Margin = new Padding(13);
            MiddleNameTxtBox.Name = "MiddleNameTxtBox";
            MiddleNameTxtBox.PlaceholderText = " Middle Name";
            MiddleNameTxtBox.Size = new Size(394, 39);
            MiddleNameTxtBox.TabIndex = 50;
            // 
            // AgeTxtBox
            // 
            AgeTxtBox.BackColor = Color.White;
            AgeTxtBox.BorderStyle = BorderStyle.FixedSingle;
            AgeTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTxtBox.Location = new Point(961, 212);
            AgeTxtBox.Margin = new Padding(13);
            AgeTxtBox.Name = "AgeTxtBox";
            AgeTxtBox.PlaceholderText = " Age";
            AgeTxtBox.Size = new Size(394, 39);
            AgeTxtBox.TabIndex = 51;
            // 
            // ExtensionNameCmbBox
            // 
            ExtensionNameCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ExtensionNameCmbBox.ForeColor = Color.DimGray;
            ExtensionNameCmbBox.FormattingEnabled = true;
            ExtensionNameCmbBox.Items.AddRange(new object[] { "Jr.", "Sr.", "I", "II", "III", "IV" });
            ExtensionNameCmbBox.Location = new Point(455, 558);
            ExtensionNameCmbBox.Name = "ExtensionNameCmbBox";
            ExtensionNameCmbBox.Size = new Size(394, 40);
            ExtensionNameCmbBox.TabIndex = 52;
            ExtensionNameCmbBox.Text = " Extension Name";
            // 
            // BirthdayPicker
            // 
            BirthdayPicker.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdayPicker.CalendarTitleBackColor = SystemColors.ControlText;
            BirthdayPicker.CalendarTitleForeColor = Color.DimGray;
            BirthdayPicker.CustomFormat = " MM/dd/yyyy";
            BirthdayPicker.DropDownAlign = LeftRightAlignment.Right;
            BirthdayPicker.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdayPicker.Format = DateTimePickerFormat.Custom;
            BirthdayPicker.Location = new Point(134, -1);
            BirthdayPicker.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            BirthdayPicker.MaximumSize = new Size(394, 39);
            BirthdayPicker.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            BirthdayPicker.Name = "BirthdayPicker";
            BirthdayPicker.Size = new Size(259, 39);
            BirthdayPicker.TabIndex = 53;
            BirthdayPicker.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // GenderCmbBox
            // 
            GenderCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCmbBox.ForeColor = Color.DimGray;
            GenderCmbBox.FormattingEnabled = true;
            GenderCmbBox.Items.AddRange(new object[] { "Male", "Female", "Non-binary" });
            GenderCmbBox.Location = new Point(455, 698);
            GenderCmbBox.Name = "GenderCmbBox";
            GenderCmbBox.Size = new Size(394, 40);
            GenderCmbBox.TabIndex = 54;
            GenderCmbBox.Text = " Gender";
            // 
            // BirthPlaceTxtBox
            // 
            BirthPlaceTxtBox.BackColor = Color.White;
            BirthPlaceTxtBox.BorderStyle = BorderStyle.FixedSingle;
            BirthPlaceTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BirthPlaceTxtBox.Location = new Point(961, 281);
            BirthPlaceTxtBox.Margin = new Padding(13);
            BirthPlaceTxtBox.Name = "BirthPlaceTxtBox";
            BirthPlaceTxtBox.PlaceholderText = " Place of Birth";
            BirthPlaceTxtBox.Size = new Size(394, 39);
            BirthPlaceTxtBox.TabIndex = 55;
            // 
            // CurrentAddressTxtBox
            // 
            CurrentAddressTxtBox.BackColor = Color.White;
            CurrentAddressTxtBox.BorderStyle = BorderStyle.FixedSingle;
            CurrentAddressTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentAddressTxtBox.Location = new Point(961, 350);
            CurrentAddressTxtBox.Margin = new Padding(13);
            CurrentAddressTxtBox.Name = "CurrentAddressTxtBox";
            CurrentAddressTxtBox.PlaceholderText = " Current Address";
            CurrentAddressTxtBox.Size = new Size(394, 39);
            CurrentAddressTxtBox.TabIndex = 56;
            // 
            // PermanentAddressTxtBox
            // 
            PermanentAddressTxtBox.BackColor = Color.White;
            PermanentAddressTxtBox.BorderStyle = BorderStyle.FixedSingle;
            PermanentAddressTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PermanentAddressTxtBox.Location = new Point(961, 419);
            PermanentAddressTxtBox.Margin = new Padding(13);
            PermanentAddressTxtBox.Name = "PermanentAddressTxtBox";
            PermanentAddressTxtBox.PlaceholderText = " Permanent Address";
            PermanentAddressTxtBox.Size = new Size(394, 39);
            PermanentAddressTxtBox.TabIndex = 57;
            // 
            // AcademicYearCmbBox
            // 
            AcademicYearCmbBox.AutoCompleteCustomSource.AddRange(new string[] { "2022 - 2023", "2023 - 2024", "2024 - 2025", "2025 - 2026", "2026 - 2027", "2027 - 2028", "2028 - 2029", "2029 - 2030" });
            AcademicYearCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AcademicYearCmbBox.ForeColor = Color.DimGray;
            AcademicYearCmbBox.FormattingEnabled = true;
            AcademicYearCmbBox.Items.AddRange(new object[] { "2023 - 2024", "2024 - 2025", "2025 - 2026", "2026 - 2027", "2027 - 2028", "2028 - 2029", "2029 - 2030" });
            AcademicYearCmbBox.Location = new Point(961, 488);
            AcademicYearCmbBox.Name = "AcademicYearCmbBox";
            AcademicYearCmbBox.Size = new Size(394, 40);
            AcademicYearCmbBox.TabIndex = 58;
            AcademicYearCmbBox.Text = " Academic Year";
            // 
            // StudentTypeCmbBox
            // 
            StudentTypeCmbBox.AutoCompleteCustomSource.AddRange(new string[] { "2022 - 2023", "2023 - 2024", "2024 - 2025", "2025 - 2026", "2026 - 2027", "2027 - 2028", "2028 - 2029", "2029 - 2030" });
            StudentTypeCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StudentTypeCmbBox.ForeColor = Color.DimGray;
            StudentTypeCmbBox.FormattingEnabled = true;
            StudentTypeCmbBox.Items.AddRange(new object[] { "New", "Returnee", "Transferee" });
            StudentTypeCmbBox.Location = new Point(961, 558);
            StudentTypeCmbBox.Name = "StudentTypeCmbBox";
            StudentTypeCmbBox.Size = new Size(394, 40);
            StudentTypeCmbBox.TabIndex = 59;
            StudentTypeCmbBox.Text = " Student Type";
            // 
            // DepartmentCmbBox
            // 
            DepartmentCmbBox.AutoCompleteCustomSource.AddRange(new string[] { "College of Arts and Sciences (CAS)", "College Of Computer, Information and Communications Technology (CCICT)", "College Of Education (COEd)", "College of Engineering (COE)", "College of Management and Entrepreneurship (CME)", "College of Technology (COT)" });
            DepartmentCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DepartmentCmbBox.ForeColor = Color.DimGray;
            DepartmentCmbBox.FormattingEnabled = true;
            DepartmentCmbBox.Items.AddRange(new object[] { "College of Arts and Sciences (CAS)", "College of Computer, Information and Communications Technology (CCICT)", "College of Education (COEd)", "College of Engineering (COE)", "College of Management and Entrepreneurship (CME)", "College of Technology (COT)" });
            DepartmentCmbBox.Location = new Point(961, 628);
            DepartmentCmbBox.Name = "DepartmentCmbBox";
            DepartmentCmbBox.Size = new Size(394, 40);
            DepartmentCmbBox.TabIndex = 60;
            DepartmentCmbBox.Text = " Department";
            // 
            // ProgramCmbBox
            // 
            ProgramCmbBox.AutoCompleteCustomSource.AddRange(new string[] { "-- College of Management and Entrepreneurship (CME) --", "", "Bachelor of Science in Business Administration major in Marketing Management (BSBA-MM)", "Bachelor of Science in Hospitality Management (BSHM)", "Bachelor of Public Administration (BPA)", "Bachelor of Science in Tourism Management (BSTM)", "", "-- College of Technology (COT) --", "", "Bachelor of Science in Graphics and Design (BSGD)", "Bachelor of Science in Mechatronics (BSMx)", "Bachelor of Science in Technology Management (BSTechM)", "Bachelor of Industrial Technology (BIT) - Automotive Technology", "Bachelor of Industrial Technology (BIT) - Civil Technology", "Bachelor of Industrial Technology (BIT) - Cosmetology", "Bachelor of Industrial Technology (BIT) - Drafting Technology", "Bachelor of Industrial Technology (BIT) - Electrical Technology", "Bachelor of Industrial Technology (BIT) - Electronics Technoloqy", "Bachelor of Industrial Technology (BIT) - Furniture and Cabinetwaking Technology", "Bachelor of Industrial Technology (BIT) - Food Preparation and Services Technology", "Bachelor of Industrial Technology (BIT) - Garments Technology", "Bachelor of Industrial Technology (BIT) - Interior Design Technology", "Bachelor of Industrial Technology (BIT) - Machine Shop Technology", "Bachelor of Industrial Technology (BIT) - Power Plant Technoloay", "Bachelor of Industrial Technology (BIT) - Refrigeration and Air Conditioning-Technology", "Bachelor of Industrial Technology (BIT) - Welding and Fabrication Technology", "", "-- College Of Education (COEd) --", "", "Bachelor of Elementary Education (BEEd)", "Bachelor of Secondary Education (BSEd) - Mathematics", "Bachelor of Secondary Education (BSEd) - Science", "Bachelor of Secondary Education (BSEd) - Filipino", "Bachelor of Secondary Education (BSEd) - Social Studies", "Bachelor of Technology and Livelihood Education (BTLEd) - Home Economics", "Bachelor of Technology and Livelihood Education (BTLEd) - Information and Communication Technology", "Bachelor of Technology and Livelihood Education (BTLEd) - Industrial Arts", "Bachelor of Early Childhood Education (BECEd)", "Bachelor of Special Needs Education (BSNEd)", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Automotive Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Civil and Construction Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Drafting Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Electrical Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Electronics Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Garments and Fashion Design", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Food and Service Management", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Welding and Fabricatipn Technology", "Certificate of Technology (CT) - Computer Technology (for deaf student-applicants only)", "Certificate of Technology (CT) - Food Technology (for deaf student-applicants only)", "", "-- College of Arts and Sciences (CAS) --", "", "Bachelor of Arts in English Languape (BAEL) - English Language Studies as a DiscipIine (ELSD)", "Bachelor of Arts in English Languape (BAEL) - English Language Across Professions (ELAP)", "Bachelor of Arts in Literature (BAL) - Literary Cultural Studies (LCS)", "Bachelor of Arts in Literature (BAL) - Literature Across Professions (LAP)", "Bachelor of Science in Biology (BS Bio) - Ecology", "Bachelor of Science in Development Communication (BS Dev Com)", "Batsilyer ng Sining sa Filipino( BAF)", "Bachelor ot Science in Mathematics (BS Math)", "Bachelor of Science in Psychology (BS Psych)", "Bachelor of Science in Statistics (BS Stat)", "Bachelor of Science in Nursing (BSN) at Cebu City Medical Center - College of Nursing (CCMC-CN)", "", "-- College of Engineering (COE) --", "", "Bachelor of Science in Aerospace Engineering (BSAsE)", "Bachelor of Science in Civil Engineering (BSCE)", "Bachelor of Science in Computer Engineering (BSCpE)", "Bachelor of Science in Electronics Engineering (BSECE)", "Bachelor of Science in Electrical Engineering (BSEE)", "Bachelor of Science in Industrial Engineering (BSIE)", "Bachelor of Science in Mechanical Engineering (BSME)", "", "-- College Of Computer, Information and Communications Technology (CCICT) --", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Information Systems (BSIS)", "Bachelor of Industrial Technology - Computer Technology (BIT-CT)" });
            ProgramCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ProgramCmbBox.ForeColor = Color.DimGray;
            ProgramCmbBox.FormattingEnabled = true;
            ProgramCmbBox.Items.AddRange(new object[] { "-- College of Management and Entrepreneurship (CME) --", "Bachelor of Science in Business Administration major in Marketing Management (BSBA-MM)", "Bachelor of Science in Hospitality Management (BSHM)", "Bachelor of Public Administration (BPA)", "Bachelor of Science in Tourism Management (BSTM)", "", "-- College of Technology (COT) --", "Bachelor of Science in Graphics and Design (BSGD)", "Bachelor of Science in Mechatronics (BSMx)", "Bachelor of Science in Technology Management (BSTechM)", "Bachelor of Industrial Technology (BIT) - Automotive Technology", "Bachelor of Industrial Technology (BIT) - Civil Technology", "Bachelor of Industrial Technology (BIT) - Cosmetology", "Bachelor of Industrial Technology (BIT) - Drafting Technology", "Bachelor of Industrial Technology (BIT) - Electrical Technology", "Bachelor of Industrial Technology (BIT) - Electronics Technoloqy", "Bachelor of Industrial Technology (BIT) - Furniture and Cabinetwaking Technology", "Bachelor of Industrial Technology (BIT) - Food Preparation and Services Technology", "Bachelor of Industrial Technology (BIT) - Garments Technology", "Bachelor of Industrial Technology (BIT) - Interior Design Technology", "Bachelor of Industrial Technology (BIT) - Machine Shop Technology", "Bachelor of Industrial Technology (BIT) - Power Plant Technoloay", "Bachelor of Industrial Technology (BIT) - Refrigeration and Air Conditioning-Technology", "Bachelor of Industrial Technology (BIT) - Welding and Fabrication Technology", "", "-- College Of Education (COEd) --", "Bachelor of Elementary Education (BEEd)", "Bachelor of Secondary Education (BSEd) - Mathematics", "Bachelor of Secondary Education (BSEd) - Science", "Bachelor of Secondary Education (BSEd) - Filipino", "Bachelor of Secondary Education (BSEd) - Social Studies", "Bachelor of Technology and Livelihood Education (BTLEd) - Home Economics", "Bachelor of Technology and Livelihood Education (BTLEd) - Information and Communication Technology", "Bachelor of Technology and Livelihood Education (BTLEd) - Industrial Arts", "Bachelor of Early Childhood Education (BECEd)", "Bachelor of Special Needs Education (BSNEd)", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Automotive Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Civil and Construction Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Drafting Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Electrical Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Electronics Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Garments and Fashion Design", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Food and Service Management", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Welding and Fabricatipn Technology", "Certificate of Technology (CT) - Computer Technology (for deaf student-applicants only)", "Certificate of Technology (CT) - Food Technology (for deaf student-applicants only)", "", "-- College of Arts and Sciences (CAS) --", "Bachelor of Arts in English Languape (BAEL) - English Language Studies as a DiscipIine (ELSD)", "Bachelor of Arts in English Languape (BAEL) - English Language Across Professions (ELAP)", "Bachelor of Arts in Literature (BAL) - Literary Cultural Studies (LCS)", "Bachelor of Arts in Literature (BAL) - Literature Across Professions (LAP)", "Bachelor of Science in Biology (BS Bio) - Ecology", "Bachelor of Science in Development Communication (BS Dev Com)", "Batsilyer ng Sining sa Filipino( BAF)", "Bachelor ot Science in Mathematics (BS Math)", "Bachelor of Science in Psychology (BS Psych)", "Bachelor of Science in Statistics (BS Stat)", "Bachelor of Science in Nursing (BSN) at Cebu City Medical Center - College of Nursing (CCMC-CN)", "", "-- College of Engineering (COE) --", "", "Bachelor of Science in Aerospace Engineering (BSAsE)", "Bachelor of Science in Civil Engineering (BSCE)", "Bachelor of Science in Computer Engineering (BSCpE)", "Bachelor of Science in Electronics Engineering (BSECE)", "Bachelor of Science in Electrical Engineering (BSEE)", "Bachelor of Science in Industrial Engineering (BSIE)", "Bachelor of Science in Mechanical Engineering (BSME)", "", "-- College Of Computer, Information and Communications Technology (CCICT) --", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Information Systems (BSIS)", "Bachelor of Industrial Technology - Computer Technology (BIT-CT)" });
            ProgramCmbBox.Location = new Point(961, 698);
            ProgramCmbBox.Name = "ProgramCmbBox";
            ProgramCmbBox.Size = new Size(394, 40);
            ProgramCmbBox.TabIndex = 61;
            ProgramCmbBox.Text = " Program";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.image;
            pictureBox3.Location = new Point(172, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 62;
            pictureBox3.TabStop = false;
            // 
            // OpenCameraBtn
            // 
            OpenCameraBtn.BackColor = Color.Orange;
            OpenCameraBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OpenCameraBtn.ForeColor = SystemColors.ControlLightLight;
            OpenCameraBtn.Location = new Point(148, 381);
            OpenCameraBtn.Name = "OpenCameraBtn";
            OpenCameraBtn.Size = new Size(196, 43);
            OpenCameraBtn.TabIndex = 63;
            OpenCameraBtn.Text = "Open Camera";
            OpenCameraBtn.UseVisualStyleBackColor = false;
            // 
            // UploadImageBtn
            // 
            UploadImageBtn.BackColor = Color.Orange;
            UploadImageBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UploadImageBtn.ForeColor = SystemColors.ControlLightLight;
            UploadImageBtn.Location = new Point(148, 441);
            UploadImageBtn.Name = "UploadImageBtn";
            UploadImageBtn.Size = new Size(196, 43);
            UploadImageBtn.TabIndex = 64;
            UploadImageBtn.Text = "Upload Image";
            UploadImageBtn.UseVisualStyleBackColor = false;
            // 
            // BirthdayPanel
            // 
            BirthdayPanel.BackColor = Color.White;
            BirthdayPanel.BorderStyle = BorderStyle.FixedSingle;
            BirthdayPanel.Controls.Add(BirthdayLbl);
            BirthdayPanel.Controls.Add(BirthdayPicker);
            BirthdayPanel.Location = new Point(455, 629);
            BirthdayPanel.Name = "BirthdayPanel";
            BirthdayPanel.Size = new Size(394, 39);
            BirthdayPanel.TabIndex = 65;
            // 
            // BirthdayLbl
            // 
            BirthdayLbl.AutoSize = true;
            BirthdayLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdayLbl.ForeColor = Color.DimGray;
            BirthdayLbl.Location = new Point(3, 2);
            BirthdayLbl.Name = "BirthdayLbl";
            BirthdayLbl.Size = new Size(102, 32);
            BirthdayLbl.TabIndex = 66;
            BirthdayLbl.Text = "Birthday";
            BirthdayLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Add_Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 827);
            Controls.Add(BirthdayPanel);
            Controls.Add(UploadImageBtn);
            Controls.Add(OpenCameraBtn);
            Controls.Add(pictureBox3);
            Controls.Add(ProgramCmbBox);
            Controls.Add(DepartmentCmbBox);
            Controls.Add(StudentTypeCmbBox);
            Controls.Add(AcademicYearCmbBox);
            Controls.Add(PermanentAddressTxtBox);
            Controls.Add(CurrentAddressTxtBox);
            Controls.Add(BirthPlaceTxtBox);
            Controls.Add(GenderCmbBox);
            Controls.Add(ExtensionNameCmbBox);
            Controls.Add(AgeTxtBox);
            Controls.Add(MiddleNameTxtBox);
            Controls.Add(FirstNameTxtBox);
            Controls.Add(LastNameTxtBox);
            Controls.Add(StudentIDTxtBox);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox1);
            Controls.Add(ClearBtn);
            Controls.Add(AddStudentPic);
            Controls.Add(RegisterBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(CTULogo);
            Controls.Add(StudentNumberTxtBox);
            Controls.Add(AddStudentLbl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            BirthdayPanel.ResumeLayout(false);
            BirthdayPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label AddStudentLbl;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox StudentNumberTxtBox;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox12;
        private TextBox textBox15;
        private Label label17;
        private TextBox textBox16;
        private PictureBox CTULogo;
        private Panel AddStudentPnl;
        private PictureBox AddStudentPic;
        private Button RegisterBtn;
        private PictureBox pictureBox1;
        private Button ClearBtn;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private TextBox StudentIDTxtBox;
        private TextBox LastNameTxtBox;
        private TextBox FirstNameTxtBox;
        private TextBox MiddleNameTxtBox;
        private TextBox AgeTxtBox;
        private ComboBox ExtensionNameCmbBox;
        private DateTimePicker BirthdayPicker;
        private ComboBox GenderCmbBox;
        private TextBox BirthPlaceTxtBox;
        private TextBox CurrentAddressTxtBox;
        private TextBox PermanentAddressTxtBox;
        private ComboBox AcademicYearCmbBox;
        private ComboBox StudentTypeCmbBox;
        private ComboBox DepartmentCmbBox;
        private ComboBox ProgramCmbBox;
        private PictureBox pictureBox3;
        private Button OpenCameraBtn;
        private Button UploadImageBtn;
        private Panel BirthdayPanel;
        private Label BirthdayLbl;
    }
}