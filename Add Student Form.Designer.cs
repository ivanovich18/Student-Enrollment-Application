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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Students));
            AddStudentLbl = new Label();
            CTULogo = new PictureBox();
            AddStudentPnl = new Panel();
            AddStudentPic = new PictureBox();
            RegisterBtn = new Button();
            pictureBox1 = new PictureBox();
            ClearBtn = new Button();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            LastNameTxtBox = new TextBox();
            FirstNameTxtBox = new TextBox();
            MiddleNameTxtBox = new TextBox();
            AgeTxtBox = new TextBox();
            BirthdayPicker = new DateTimePicker();
            GenderCmbBox = new ComboBox();
            BirthPlaceTxtBox = new TextBox();
            CurrentAddressTxtBox = new TextBox();
            PermanentAddressTxtBox = new TextBox();
            AcademicYearCmbBox = new ComboBox();
            StudentTypeCmbBox = new ComboBox();
            DepartmentCmbBox = new ComboBox();
            ProgramCmbBox = new ComboBox();
            StudentImageCoverPic = new PictureBox();
            OpenCameraBtn = new Button();
            BirthdayPanel = new Panel();
            BirthdayLbl = new Label();
            EmailTxtBox = new TextBox();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            StudentNumberCountLbl = new Label();
            StudentIDLbl = new Label();
            label2 = new Label();
            StudentActualPic = new PictureBox();
            CaptureBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentImageCoverPic).BeginInit();
            BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentActualPic).BeginInit();
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
            // CTULogo
            // 
            CTULogo.Image = Properties.Resources.transparent_logo;
            CTULogo.Location = new Point(77, 12);
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
            AddStudentPic.Cursor = Cursors.Hand;
            AddStudentPic.Image = (Image)resources.GetObject("AddStudentPic.Image");
            AddStudentPic.Location = new Point(811, 60);
            AddStudentPic.Name = "AddStudentPic";
            AddStudentPic.Size = new Size(41, 30);
            AddStudentPic.SizeMode = PictureBoxSizeMode.StretchImage;
            AddStudentPic.TabIndex = 42;
            AddStudentPic.TabStop = false;
            AddStudentPic.Click += RegisterBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Orange;
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterBtn.ForeColor = SystemColors.ControlLightLight;
            RegisterBtn.Location = new Point(781, 46);
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
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Backspace;
            pictureBox1.Location = new Point(1053, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ClearBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Orange;
            ClearBtn.Cursor = Cursors.Hand;
            ClearBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ControlLightLight;
            ClearBtn.Location = new Point(1010, 46);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(201, 57);
            ClearBtn.TabIndex = 43;
            ClearBtn.Text = "        Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox2.Location = new Point(1287, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.Click += BackBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Orange;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(1229, 46);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(201, 57);
            BackBtn.TabIndex = 45;
            BackBtn.Text = "     Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // LastNameTxtBox
            // 
            LastNameTxtBox.BackColor = Color.White;
            LastNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxtBox.Location = new Point(464, 432);
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
            FirstNameTxtBox.Location = new Point(464, 502);
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
            MiddleNameTxtBox.Location = new Point(464, 572);
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
            AgeTxtBox.Location = new Point(970, 225);
            AgeTxtBox.Margin = new Padding(13);
            AgeTxtBox.Name = "AgeTxtBox";
            AgeTxtBox.PlaceholderText = " Age";
            AgeTxtBox.Size = new Size(394, 39);
            AgeTxtBox.TabIndex = 51;
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
            BirthdayPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
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
            GenderCmbBox.Items.AddRange(new object[] { "Male", "Female", "Non-binary", "Prefer not to say" });
            GenderCmbBox.Location = new Point(970, 501);
            GenderCmbBox.Name = "GenderCmbBox";
            GenderCmbBox.Size = new Size(394, 40);
            GenderCmbBox.TabIndex = 54;
            // 
            // BirthPlaceTxtBox
            // 
            BirthPlaceTxtBox.BackColor = Color.White;
            BirthPlaceTxtBox.BorderStyle = BorderStyle.FixedSingle;
            BirthPlaceTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BirthPlaceTxtBox.Location = new Point(970, 294);
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
            CurrentAddressTxtBox.Location = new Point(970, 363);
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
            PermanentAddressTxtBox.Location = new Point(970, 432);
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
            AcademicYearCmbBox.Items.AddRange(new object[] { "2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027-2028", "2028-2029", "2029-2030" });
            AcademicYearCmbBox.Location = new Point(464, 362);
            AcademicYearCmbBox.Name = "AcademicYearCmbBox";
            AcademicYearCmbBox.Size = new Size(394, 40);
            AcademicYearCmbBox.TabIndex = 58;
            AcademicYearCmbBox.Text = " Academic Year";
            AcademicYearCmbBox.SelectedIndexChanged += AcademicYearCmbBox_SelectedIndexChanged;
            // 
            // StudentTypeCmbBox
            // 
            StudentTypeCmbBox.AutoCompleteCustomSource.AddRange(new string[] { "2022 - 2023", "2023 - 2024", "2024 - 2025", "2025 - 2026", "2026 - 2027", "2027 - 2028", "2028 - 2029", "2029 - 2030" });
            StudentTypeCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StudentTypeCmbBox.ForeColor = Color.DimGray;
            StudentTypeCmbBox.FormattingEnabled = true;
            StudentTypeCmbBox.Items.AddRange(new object[] { "New", "Returnee", "Transferee" });
            StudentTypeCmbBox.Location = new Point(970, 571);
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
            DepartmentCmbBox.Location = new Point(970, 641);
            DepartmentCmbBox.Name = "DepartmentCmbBox";
            DepartmentCmbBox.Size = new Size(394, 40);
            DepartmentCmbBox.TabIndex = 60;
            DepartmentCmbBox.Text = " Department";
            DepartmentCmbBox.SelectedIndexChanged += DepartmentCmbBox_SelectedIndexChanged;
            // 
            // ProgramCmbBox
            // 
            ProgramCmbBox.AutoCompleteCustomSource.AddRange(new string[] { "-- College of Management and Entrepreneurship (CME) --", "", "Bachelor of Science in Business Administration major in Marketing Management (BSBA-MM)", "Bachelor of Science in Hospitality Management (BSHM)", "Bachelor of Public Administration (BPA)", "Bachelor of Science in Tourism Management (BSTM)", "", "-- College of Technology (COT) --", "", "Bachelor of Science in Graphics and Design (BSGD)", "Bachelor of Science in Mechatronics (BSMx)", "Bachelor of Science in Technology Management (BSTechM)", "Bachelor of Industrial Technology (BIT) - Automotive Technology", "Bachelor of Industrial Technology (BIT) - Civil Technology", "Bachelor of Industrial Technology (BIT) - Cosmetology", "Bachelor of Industrial Technology (BIT) - Drafting Technology", "Bachelor of Industrial Technology (BIT) - Electrical Technology", "Bachelor of Industrial Technology (BIT) - Electronics Technoloqy", "Bachelor of Industrial Technology (BIT) - Furniture and Cabinetwaking Technology", "Bachelor of Industrial Technology (BIT) - Food Preparation and Services Technology", "Bachelor of Industrial Technology (BIT) - Garments Technology", "Bachelor of Industrial Technology (BIT) - Interior Design Technology", "Bachelor of Industrial Technology (BIT) - Machine Shop Technology", "Bachelor of Industrial Technology (BIT) - Power Plant Technoloay", "Bachelor of Industrial Technology (BIT) - Refrigeration and Air Conditioning-Technology", "Bachelor of Industrial Technology (BIT) - Welding and Fabrication Technology", "", "-- College Of Education (COEd) --", "", "Bachelor of Elementary Education (BEEd)", "Bachelor of Secondary Education (BSEd) - Mathematics", "Bachelor of Secondary Education (BSEd) - Science", "Bachelor of Secondary Education (BSEd) - Filipino", "Bachelor of Secondary Education (BSEd) - Social Studies", "Bachelor of Technology and Livelihood Education (BTLEd) - Home Economics", "Bachelor of Technology and Livelihood Education (BTLEd) - Information and Communication Technology", "Bachelor of Technology and Livelihood Education (BTLEd) - Industrial Arts", "Bachelor of Early Childhood Education (BECEd)", "Bachelor of Special Needs Education (BSNEd)", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Automotive Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Civil and Construction Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Drafting Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Electrical Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Electronics Technology", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Garments and Fashion Design", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Food and Service Management", "Bachelor of Technical-Vocational Teacher Education (BTVTEd) - Welding and Fabricatipn Technology", "Certificate of Technology (CT) - Computer Technology (for deaf student-applicants only)", "Certificate of Technology (CT) - Food Technology (for deaf student-applicants only)", "", "-- College of Arts and Sciences (CAS) --", "", "Bachelor of Arts in English Languape (BAEL) - English Language Studies as a DiscipIine (ELSD)", "Bachelor of Arts in English Languape (BAEL) - English Language Across Professions (ELAP)", "Bachelor of Arts in Literature (BAL) - Literary Cultural Studies (LCS)", "Bachelor of Arts in Literature (BAL) - Literature Across Professions (LAP)", "Bachelor of Science in Biology (BS Bio) - Ecology", "Bachelor of Science in Development Communication (BS Dev Com)", "Batsilyer ng Sining sa Filipino( BAF)", "Bachelor ot Science in Mathematics (BS Math)", "Bachelor of Science in Psychology (BS Psych)", "Bachelor of Science in Statistics (BS Stat)", "Bachelor of Science in Nursing (BSN) at Cebu City Medical Center - College of Nursing (CCMC-CN)", "", "-- College of Engineering (COE) --", "", "Bachelor of Science in Aerospace Engineering (BSAsE)", "Bachelor of Science in Civil Engineering (BSCE)", "Bachelor of Science in Computer Engineering (BSCpE)", "Bachelor of Science in Electronics Engineering (BSECE)", "Bachelor of Science in Electrical Engineering (BSEE)", "Bachelor of Science in Industrial Engineering (BSIE)", "Bachelor of Science in Mechanical Engineering (BSME)", "", "-- College Of Computer, Information and Communications Technology (CCICT) --", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Information Systems (BSIS)", "Bachelor of Industrial Technology - Computer Technology (BIT-CT)" });
            ProgramCmbBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ProgramCmbBox.ForeColor = Color.DimGray;
            ProgramCmbBox.FormattingEnabled = true;
            ProgramCmbBox.Location = new Point(970, 711);
            ProgramCmbBox.Name = "ProgramCmbBox";
            ProgramCmbBox.Size = new Size(394, 40);
            ProgramCmbBox.TabIndex = 61;
            ProgramCmbBox.Text = " Program";
            // 
            // StudentImageCoverPic
            // 
            StudentImageCoverPic.Image = Properties.Resources.image;
            StudentImageCoverPic.Location = new Point(139, 225);
            StudentImageCoverPic.Name = "StudentImageCoverPic";
            StudentImageCoverPic.Size = new Size(240, 240);
            StudentImageCoverPic.SizeMode = PictureBoxSizeMode.StretchImage;
            StudentImageCoverPic.TabIndex = 62;
            StudentImageCoverPic.TabStop = false;
            // 
            // OpenCameraBtn
            // 
            OpenCameraBtn.BackColor = Color.Orange;
            OpenCameraBtn.Cursor = Cursors.Hand;
            OpenCameraBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OpenCameraBtn.ForeColor = SystemColors.ControlLightLight;
            OpenCameraBtn.Location = new Point(139, 494);
            OpenCameraBtn.Name = "OpenCameraBtn";
            OpenCameraBtn.Size = new Size(240, 43);
            OpenCameraBtn.TabIndex = 63;
            OpenCameraBtn.Text = "Open Camera";
            OpenCameraBtn.UseVisualStyleBackColor = false;
            OpenCameraBtn.Click += OpenCameraBtn_Click;
            // 
            // BirthdayPanel
            // 
            BirthdayPanel.BackColor = Color.White;
            BirthdayPanel.BorderStyle = BorderStyle.FixedSingle;
            BirthdayPanel.Controls.Add(BirthdayLbl);
            BirthdayPanel.Controls.Add(BirthdayPicker);
            BirthdayPanel.Location = new Point(464, 642);
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
            // EmailTxtBox
            // 
            EmailTxtBox.BackColor = Color.White;
            EmailTxtBox.BorderStyle = BorderStyle.FixedSingle;
            EmailTxtBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxtBox.Location = new Point(464, 711);
            EmailTxtBox.Margin = new Padding(13);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.PlaceholderText = " Email";
            EmailTxtBox.Size = new Size(394, 39);
            EmailTxtBox.TabIndex = 66;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // StudentNumberCountLbl
            // 
            StudentNumberCountLbl.AutoSize = true;
            StudentNumberCountLbl.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            StudentNumberCountLbl.ForeColor = Color.Black;
            StudentNumberCountLbl.Location = new Point(461, 225);
            StudentNumberCountLbl.Name = "StudentNumberCountLbl";
            StudentNumberCountLbl.Size = new Size(210, 35);
            StudentNumberCountLbl.TabIndex = 67;
            StudentNumberCountLbl.Text = "Student Number: ";
            StudentNumberCountLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentIDLbl
            // 
            StudentIDLbl.AutoSize = true;
            StudentIDLbl.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            StudentIDLbl.ForeColor = Color.Black;
            StudentIDLbl.Location = new Point(604, 294);
            StudentIDLbl.Name = "StudentIDLbl";
            StudentIDLbl.Size = new Size(30, 35);
            StudentIDLbl.TabIndex = 68;
            StudentIDLbl.Text = "...";
            StudentIDLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(461, 294);
            label2.Name = "label2";
            label2.Size = new Size(143, 35);
            label2.TabIndex = 69;
            label2.Text = "Student ID: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentActualPic
            // 
            StudentActualPic.Location = new Point(139, 225);
            StudentActualPic.Name = "StudentActualPic";
            StudentActualPic.Size = new Size(240, 240);
            StudentActualPic.SizeMode = PictureBoxSizeMode.CenterImage;
            StudentActualPic.TabIndex = 70;
            StudentActualPic.TabStop = false;
            // 
            // CaptureBtn
            // 
            CaptureBtn.BackColor = Color.Orange;
            CaptureBtn.Cursor = Cursors.Hand;
            CaptureBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CaptureBtn.ForeColor = SystemColors.ControlLightLight;
            CaptureBtn.Location = new Point(139, 555);
            CaptureBtn.Name = "CaptureBtn";
            CaptureBtn.Size = new Size(240, 43);
            CaptureBtn.TabIndex = 71;
            CaptureBtn.Text = "Capture";
            CaptureBtn.UseVisualStyleBackColor = false;
            CaptureBtn.Click += CaptureBtn_Click;
            // 
            // Add_Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1504, 827);
            Controls.Add(label2);
            Controls.Add(StudentIDLbl);
            Controls.Add(StudentNumberCountLbl);
            Controls.Add(EmailTxtBox);
            Controls.Add(BirthdayPanel);
            Controls.Add(OpenCameraBtn);
            Controls.Add(ProgramCmbBox);
            Controls.Add(DepartmentCmbBox);
            Controls.Add(StudentTypeCmbBox);
            Controls.Add(AcademicYearCmbBox);
            Controls.Add(PermanentAddressTxtBox);
            Controls.Add(CurrentAddressTxtBox);
            Controls.Add(BirthPlaceTxtBox);
            Controls.Add(GenderCmbBox);
            Controls.Add(AgeTxtBox);
            Controls.Add(MiddleNameTxtBox);
            Controls.Add(FirstNameTxtBox);
            Controls.Add(LastNameTxtBox);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox1);
            Controls.Add(ClearBtn);
            Controls.Add(AddStudentPic);
            Controls.Add(RegisterBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(CTULogo);
            Controls.Add(AddStudentLbl);
            Controls.Add(StudentImageCoverPic);
            Controls.Add(StudentActualPic);
            Controls.Add(CaptureBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += Add_Students_FormClosing;
            Load += Add_Students_Load;
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentImageCoverPic).EndInit();
            BirthdayPanel.ResumeLayout(false);
            BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentActualPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddStudentLbl;
        private PictureBox CTULogo;
        private Panel AddStudentPnl;
        private PictureBox AddStudentPic;
        private Button RegisterBtn;
        private PictureBox pictureBox1;
        private Button ClearBtn;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private TextBox LastNameTxtBox;
        private TextBox FirstNameTxtBox;
        private TextBox MiddleNameTxtBox;
        private TextBox AgeTxtBox;
        private DateTimePicker BirthdayPicker;
        private ComboBox GenderCmbBox;
        private TextBox BirthPlaceTxtBox;
        private TextBox CurrentAddressTxtBox;
        private TextBox PermanentAddressTxtBox;
        private ComboBox AcademicYearCmbBox;
        private ComboBox StudentTypeCmbBox;
        private ComboBox DepartmentCmbBox;
        private ComboBox ProgramCmbBox;
        private Panel BirthdayPanel;
        private Label BirthdayLbl;
        private TextBox EmailTxtBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label StudentNumberCountLbl;
        private Label StudentIDLbl;
        private Label label2;
        public PictureBox StudentImageCoverPic;
        public Button OpenCameraBtn;
        private PictureBox StudentActualPic;
        public Button CaptureBtn;
    }
}