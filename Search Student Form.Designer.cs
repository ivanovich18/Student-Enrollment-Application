namespace Login_Form
{
    partial class SearchStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudentForm));
            CTULogo = new PictureBox();
            AddStudentLbl = new Label();
            AddStudentPnl = new Panel();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            label1 = new Label();
            StudentNumberTxtBox = new TextBox();
            pictureBox1 = new PictureBox();
            RegisterBtn = new Button();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CTULogo
            // 
            CTULogo.Image = Properties.Resources.transparent_logo;
            CTULogo.Location = new Point(74, 21);
            CTULogo.Name = "CTULogo";
            CTULogo.Size = new Size(100, 100);
            CTULogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CTULogo.TabIndex = 40;
            CTULogo.TabStop = false;
            // 
            // AddStudentLbl
            // 
            AddStudentLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddStudentLbl.Location = new Point(198, 43);
            AddStudentLbl.Margin = new Padding(8, 0, 8, 0);
            AddStudentLbl.Name = "AddStudentLbl";
            AddStudentLbl.Size = new Size(284, 55);
            AddStudentLbl.TabIndex = 41;
            AddStudentLbl.Text = "Search Student";
            AddStudentLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddStudentPnl
            // 
            AddStudentPnl.BackColor = Color.Orange;
            AddStudentPnl.Location = new Point(-5, 141);
            AddStudentPnl.Name = "AddStudentPnl";
            AddStudentPnl.Size = new Size(1018, 10);
            AddStudentPnl.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox2.Location = new Point(794, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Orange;
            BackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(735, 42);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(201, 57);
            BackBtn.TabIndex = 56;
            BackBtn.Text = "     Back";
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 285);
            label1.Name = "label1";
            label1.Size = new Size(253, 45);
            label1.TabIndex = 58;
            label1.Text = "Enter ID number";
            // 
            // StudentNumberTxtBox
            // 
            StudentNumberTxtBox.BackColor = Color.Orange;
            StudentNumberTxtBox.BorderStyle = BorderStyle.None;
            StudentNumberTxtBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            StudentNumberTxtBox.ForeColor = Color.White;
            StudentNumberTxtBox.Location = new Point(76, 11);
            StudentNumberTxtBox.Margin = new Padding(13);
            StudentNumberTxtBox.Name = "StudentNumberTxtBox";
            StudentNumberTxtBox.Size = new Size(597, 43);
            StudentNumberTxtBox.TabIndex = 59;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.image_white;
            pictureBox1.Location = new Point(15, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Orange;
            RegisterBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterBtn.ForeColor = SystemColors.ControlLightLight;
            RegisterBtn.Location = new Point(409, 468);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(201, 57);
            RegisterBtn.TabIndex = 61;
            RegisterBtn.Text = "      Search";
            RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Orange;
            pictureBox3.Image = Properties.Resources.search_new;
            pictureBox3.Location = new Point(447, 480);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 62;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(StudentNumberTxtBox);
            panel1.Location = new Point(162, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 68);
            panel1.TabIndex = 63;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // SearchStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 663);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(RegisterBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(AddStudentLbl);
            Controls.Add(CTULogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CTULogo;
        private Label AddStudentLbl;
        private Panel AddStudentPnl;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private Label label1;
        private TextBox StudentNumberTxtBox;
        private PictureBox pictureBox1;
        private Button RegisterBtn;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}