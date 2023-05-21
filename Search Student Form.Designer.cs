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
            SearchStudentLbl = new Label();
            AddStudentPnl = new Panel();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            EnterIDNumberLbl = new Label();
            StudentNumberTxtBox = new TextBox();
            StudentImagePic = new PictureBox();
            SearchBtn = new Button();
            SearchPic = new PictureBox();
            SearchStudentPnl = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentImagePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchPic).BeginInit();
            SearchStudentPnl.SuspendLayout();
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
            // SearchStudentLbl
            // 
            SearchStudentLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SearchStudentLbl.Location = new Point(198, 43);
            SearchStudentLbl.Margin = new Padding(8, 0, 8, 0);
            SearchStudentLbl.Name = "SearchStudentLbl";
            SearchStudentLbl.Size = new Size(284, 55);
            SearchStudentLbl.TabIndex = 41;
            SearchStudentLbl.Text = "Search Student";
            SearchStudentLbl.TextAlign = ContentAlignment.MiddleCenter;
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
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox2.Location = new Point(793, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            pictureBox2.Click += BackBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Orange;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(734, 42);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(201, 57);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "     Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // EnterIDNumberLbl
            // 
            EnterIDNumberLbl.AutoSize = true;
            EnterIDNumberLbl.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            EnterIDNumberLbl.Location = new Point(152, 285);
            EnterIDNumberLbl.Name = "EnterIDNumberLbl";
            EnterIDNumberLbl.Size = new Size(253, 45);
            EnterIDNumberLbl.TabIndex = 58;
            EnterIDNumberLbl.Text = "Enter ID number";
            // 
            // StudentNumberTxtBox
            // 
            StudentNumberTxtBox.BackColor = Color.Orange;
            StudentNumberTxtBox.BorderStyle = BorderStyle.None;
            StudentNumberTxtBox.Cursor = Cursors.IBeam;
            StudentNumberTxtBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            StudentNumberTxtBox.ForeColor = Color.White;
            StudentNumberTxtBox.Location = new Point(76, 11);
            StudentNumberTxtBox.Margin = new Padding(13);
            StudentNumberTxtBox.Name = "StudentNumberTxtBox";
            StudentNumberTxtBox.Size = new Size(597, 43);
            StudentNumberTxtBox.TabIndex = 1;
            // 
            // StudentImagePic
            // 
            StudentImagePic.BackColor = Color.Orange;
            StudentImagePic.Image = Properties.Resources.image_white;
            StudentImagePic.Location = new Point(15, 11);
            StudentImagePic.Name = "StudentImagePic";
            StudentImagePic.Size = new Size(46, 46);
            StudentImagePic.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentImagePic.TabIndex = 60;
            StudentImagePic.TabStop = false;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Orange;
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = SystemColors.ControlLightLight;
            SearchBtn.Location = new Point(409, 468);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(201, 57);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "      Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchPic
            // 
            SearchPic.BackColor = Color.Orange;
            SearchPic.Cursor = Cursors.Hand;
            SearchPic.Image = Properties.Resources.search_new;
            SearchPic.Location = new Point(446, 480);
            SearchPic.Name = "SearchPic";
            SearchPic.Size = new Size(34, 34);
            SearchPic.SizeMode = PictureBoxSizeMode.AutoSize;
            SearchPic.TabIndex = 62;
            SearchPic.TabStop = false;
            SearchPic.Click += SearchBtn_Click;
            // 
            // SearchStudentPnl
            // 
            SearchStudentPnl.BackColor = Color.Orange;
            SearchStudentPnl.Controls.Add(StudentImagePic);
            SearchStudentPnl.Controls.Add(StudentNumberTxtBox);
            SearchStudentPnl.Location = new Point(162, 356);
            SearchStudentPnl.Name = "SearchStudentPnl";
            SearchStudentPnl.Size = new Size(686, 68);
            SearchStudentPnl.TabIndex = 63;
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
            Controls.Add(SearchStudentPnl);
            Controls.Add(SearchPic);
            Controls.Add(SearchBtn);
            Controls.Add(EnterIDNumberLbl);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(SearchStudentLbl);
            Controls.Add(CTULogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentImagePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchPic).EndInit();
            SearchStudentPnl.ResumeLayout(false);
            SearchStudentPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CTULogo;
        private Label SearchStudentLbl;
        private Panel AddStudentPnl;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private Label EnterIDNumberLbl;
        private PictureBox StudentImagePic;
        private Button SearchBtn;
        private PictureBox SearchPic;
        private Panel SearchStudentPnl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public TextBox StudentNumberTxtBox;
    }
}