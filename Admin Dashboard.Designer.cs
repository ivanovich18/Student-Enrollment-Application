namespace Login_Form
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label2 = new Label();
            AddStudentBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            LeftPnl = new Panel();
            pictureBox3 = new PictureBox();
            LogoutBtn = new Button();
            ProjectTitleLbl = new Label();
            CTULogo = new PictureBox();
            FooterLbl = new Label();
            AddStudentPic = new PictureBox();
            RecordsPic = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            LeftPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecordsPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1304, 12);
            button1.Name = "button1";
            button1.Size = new Size(141, 64);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(458, 57);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(466, 48);
            label2.TabIndex = 2;
            label2.Text = "Administrator Dashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddStudentBtn
            // 
            AddStudentBtn.BackColor = Color.Orange;
            AddStudentBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddStudentBtn.ForeColor = SystemColors.ControlLightLight;
            AddStudentBtn.Location = new Point(517, 147);
            AddStudentBtn.Name = "AddStudentBtn";
            AddStudentBtn.Size = new Size(347, 98);
            AddStudentBtn.TabIndex = 7;
            AddStudentBtn.Text = "       Add Student";
            AddStudentBtn.UseVisualStyleBackColor = false;
            AddStudentBtn.Click += AddStudentBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(517, 389);
            button2.Name = "button2";
            button2.Size = new Size(347, 98);
            button2.TabIndex = 8;
            button2.Text = "           Search Student";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(517, 268);
            button3.Name = "button3";
            button3.Size = new Size(347, 98);
            button3.TabIndex = 9;
            button3.Text = "             Student Records";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(517, 510);
            button4.Name = "button4";
            button4.Size = new Size(347, 98);
            button4.TabIndex = 10;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // LeftPnl
            // 
            LeftPnl.BackColor = Color.Orange;
            LeftPnl.Controls.Add(pictureBox3);
            LeftPnl.Controls.Add(LogoutBtn);
            LeftPnl.Controls.Add(ProjectTitleLbl);
            LeftPnl.Controls.Add(CTULogo);
            LeftPnl.Controls.Add(FooterLbl);
            LeftPnl.Location = new Point(0, 0);
            LeftPnl.Name = "LeftPnl";
            LeftPnl.Size = new Size(372, 663);
            LeftPnl.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Orange;
            pictureBox3.Image = Properties.Resources.logout;
            pictureBox3.Location = new Point(34, 63);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 40);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // LogoutBtn
            // 
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatAppearance.MouseDownBackColor = Color.Orange;
            LogoutBtn.FlatAppearance.MouseOverBackColor = Color.Orange;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(34, 57);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(147, 48);
            LogoutBtn.TabIndex = 18;
            LogoutBtn.Text = "       Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ProjectTitleLbl
            // 
            ProjectTitleLbl.AutoSize = true;
            ProjectTitleLbl.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            ProjectTitleLbl.ForeColor = Color.White;
            ProjectTitleLbl.Location = new Point(35, 375);
            ProjectTitleLbl.Name = "ProjectTitleLbl";
            ProjectTitleLbl.Size = new Size(301, 70);
            ProjectTitleLbl.TabIndex = 14;
            ProjectTitleLbl.Text = "STUDENT ENROLLMENT\r\nAPPLICATION\r\n";
            ProjectTitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CTULogo
            // 
            CTULogo.Image = Properties.Resources.transparent_logo;
            CTULogo.Location = new Point(75, 147);
            CTULogo.Name = "CTULogo";
            CTULogo.Size = new Size(222, 222);
            CTULogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CTULogo.TabIndex = 13;
            CTULogo.TabStop = false;
            // 
            // FooterLbl
            // 
            FooterLbl.AutoSize = true;
            FooterLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FooterLbl.ForeColor = Color.White;
            FooterLbl.Location = new Point(116, 534);
            FooterLbl.Name = "FooterLbl";
            FooterLbl.Size = new Size(145, 75);
            FooterLbl.TabIndex = 13;
            FooterLbl.Text = "Ivan G. Suralta\r\nAldrin A. Felices\r\nBSCpE II-G\r\n";
            FooterLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddStudentPic
            // 
            AddStudentPic.BackColor = Color.Orange;
            AddStudentPic.Image = (Image)resources.GetObject("AddStudentPic.Image");
            AddStudentPic.Location = new Point(548, 173);
            AddStudentPic.Name = "AddStudentPic";
            AddStudentPic.Size = new Size(64, 48);
            AddStudentPic.TabIndex = 13;
            AddStudentPic.TabStop = false;
            // 
            // RecordsPic
            // 
            RecordsPic.BackColor = Color.Orange;
            RecordsPic.Image = Properties.Resources.records;
            RecordsPic.Location = new Point(548, 294);
            RecordsPic.Name = "RecordsPic";
            RecordsPic.Size = new Size(64, 48);
            RecordsPic.TabIndex = 14;
            RecordsPic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(552, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Image = Properties.Resources.settings;
            pictureBox2.Location = new Point(553, 531);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 56);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 663);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(RecordsPic);
            Controls.Add(AddStudentPic);
            Controls.Add(LeftPnl);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(AddStudentBtn);
            Controls.Add(label2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Enrollment Application";
            LeftPnl.ResumeLayout(false);
            LeftPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecordsPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Button LoginBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel LeftPnl;
        private Label FooterLbl;
        private Label ProjectTitleLbl;
        private PictureBox CTULogo;
        private Panel Add;
        private Button AddStudentBtn;
        private Panel AddStudentPnl;
        private PictureBox AddStudentPic;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox RecordsPic;
        private PictureBox pictureBox3;
        private Button LogoutBtn;
    }
}