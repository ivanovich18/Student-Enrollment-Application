namespace Login_Form
{
    partial class AdminSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettingsForm));
            ChangeUsernameBtn = new Button();
            ChangePasswordBtn = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox2 = new PictureBox();
            SettingsBackBtn = new Button();
            AddStudentPnl = new Panel();
            SettingsLbl = new Label();
            CTULogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            SuspendLayout();
            // 
            // ChangeUsernameBtn
            // 
            ChangeUsernameBtn.BackColor = Color.Orange;
            ChangeUsernameBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeUsernameBtn.ForeColor = SystemColors.ControlLightLight;
            ChangeUsernameBtn.Location = new Point(198, 300);
            ChangeUsernameBtn.Name = "ChangeUsernameBtn";
            ChangeUsernameBtn.Size = new Size(614, 88);
            ChangeUsernameBtn.TabIndex = 8;
            ChangeUsernameBtn.Text = "Change Username";
            ChangeUsernameBtn.UseVisualStyleBackColor = false;
            ChangeUsernameBtn.Click += ChangeUsernameBtn_Click;
            // 
            // ChangePasswordBtn
            // 
            ChangePasswordBtn.BackColor = Color.Orange;
            ChangePasswordBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChangePasswordBtn.ForeColor = SystemColors.ControlLightLight;
            ChangePasswordBtn.Location = new Point(198, 426);
            ChangePasswordBtn.Name = "ChangePasswordBtn";
            ChangePasswordBtn.Size = new Size(614, 88);
            ChangePasswordBtn.TabIndex = 9;
            ChangePasswordBtn.Text = "Change Password";
            ChangePasswordBtn.UseVisualStyleBackColor = false;
            ChangePasswordBtn.Click += ChangePasswordBtn_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox2.Location = new Point(793, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // SettingsBackBtn
            // 
            SettingsBackBtn.BackColor = Color.Orange;
            SettingsBackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsBackBtn.ForeColor = SystemColors.ControlLightLight;
            SettingsBackBtn.Location = new Point(734, 42);
            SettingsBackBtn.Name = "SettingsBackBtn";
            SettingsBackBtn.Size = new Size(201, 57);
            SettingsBackBtn.TabIndex = 61;
            SettingsBackBtn.Text = "     Back";
            SettingsBackBtn.UseVisualStyleBackColor = false;
            SettingsBackBtn.Click += SettingsBackBtn_Click;
            // 
            // AddStudentPnl
            // 
            AddStudentPnl.BackColor = Color.Orange;
            AddStudentPnl.Location = new Point(-6, 141);
            AddStudentPnl.Name = "AddStudentPnl";
            AddStudentPnl.Size = new Size(1020, 10);
            AddStudentPnl.TabIndex = 60;
            // 
            // SettingsLbl
            // 
            SettingsLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsLbl.Location = new Point(199, 42);
            SettingsLbl.Margin = new Padding(8, 0, 8, 0);
            SettingsLbl.Name = "SettingsLbl";
            SettingsLbl.Size = new Size(420, 55);
            SettingsLbl.TabIndex = 59;
            SettingsLbl.Text = "Administrator Settings";
            SettingsLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CTULogo
            // 
            CTULogo.Image = Properties.Resources.transparent_logo;
            CTULogo.Location = new Point(74, 21);
            CTULogo.Name = "CTULogo";
            CTULogo.Size = new Size(100, 100);
            CTULogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CTULogo.TabIndex = 58;
            CTULogo.TabStop = false;
            // 
            // AdminSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 663);
            Controls.Add(pictureBox2);
            Controls.Add(SettingsBackBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(SettingsLbl);
            Controls.Add(CTULogo);
            Controls.Add(ChangePasswordBtn);
            Controls.Add(ChangeUsernameBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ChangeUsernameBtn;
        private Button ChangePasswordBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox pictureBox2;
        private Button SettingsBackBtn;
        private Panel AddStudentPnl;
        private Label SettingsLbl;
        private PictureBox CTULogo;
    }
}