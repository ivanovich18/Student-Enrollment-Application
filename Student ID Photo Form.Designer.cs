namespace Login_Form
{
    partial class StudentIDPhotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentIDPhotoForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            departmentLbl = new Label();
            StudentPhoto = new PictureBox();
            fullNameLbl = new Label();
            ProgramLbl = new Label();
            studentIDLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentPhoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 84);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.transparent_logo;
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 17);
            label1.MaximumSize = new Size(300, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 50);
            label1.TabIndex = 3;
            label1.Text = "CEBU TECHNOLOGICAL UNIVERSITY";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(departmentLbl);
            panel2.Location = new Point(0, 430);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 84);
            panel2.TabIndex = 1;
            // 
            // departmentLbl
            // 
            departmentLbl.AutoSize = true;
            departmentLbl.BackColor = Color.Orange;
            departmentLbl.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            departmentLbl.ForeColor = Color.White;
            departmentLbl.Location = new Point(96, 9);
            departmentLbl.Name = "departmentLbl";
            departmentLbl.Size = new Size(160, 65);
            departmentLbl.TabIndex = 4;
            departmentLbl.Text = "CCICT";
            departmentLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // StudentPhoto
            // 
            StudentPhoto.BackColor = Color.LightGray;
            StudentPhoto.Location = new Point(88, 109);
            StudentPhoto.Name = "StudentPhoto";
            StudentPhoto.Size = new Size(175, 175);
            StudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            StudentPhoto.TabIndex = 2;
            StudentPhoto.TabStop = false;
            // 
            // fullNameLbl
            // 
            fullNameLbl.Anchor = AnchorStyles.None;
            fullNameLbl.AutoSize = true;
            fullNameLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fullNameLbl.Location = new Point(103, 297);
            fullNameLbl.MaximumSize = new Size(350, 20);
            fullNameLbl.Name = "fullNameLbl";
            fullNameLbl.Size = new Size(145, 20);
            fullNameLbl.TabIndex = 3;
            fullNameLbl.Text = "IVAN SURALTA";
            fullNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProgramLbl
            // 
            ProgramLbl.AutoSize = true;
            ProgramLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProgramLbl.Location = new Point(66, 328);
            ProgramLbl.MaximumSize = new Size(250, 60);
            ProgramLbl.Name = "ProgramLbl";
            ProgramLbl.Size = new Size(220, 42);
            ProgramLbl.TabIndex = 4;
            ProgramLbl.Text = "(BSCpE) Bachelor of Science in Computer Engineering";
            ProgramLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // studentIDLbl
            // 
            studentIDLbl.AutoSize = true;
            studentIDLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentIDLbl.Location = new Point(81, 386);
            studentIDLbl.MaximumSize = new Size(300, 0);
            studentIDLbl.Name = "studentIDLbl";
            studentIDLbl.Size = new Size(191, 21);
            studentIDLbl.TabIndex = 5;
            studentIDLbl.Text = "Student ID: 2023-2024-01";
            studentIDLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // StudentIDPhotoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(352, 513);
            Controls.Add(studentIDLbl);
            Controls.Add(ProgramLbl);
            Controls.Add(fullNameLbl);
            Controls.Add(StudentPhoto);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentIDPhotoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student ID Photo";
            Load += StudentIDPhotoForm_Load;
            Shown += StudentIDPhotoForm_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label departmentLbl;
        private PictureBox StudentPhoto;
        private Label fullNameLbl;
        private Label ProgramLbl;
        private Label studentIDLbl;
        private System.Windows.Forms.Timer timer1;
    }
}