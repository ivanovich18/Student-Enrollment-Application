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
            LoginBtn = new Button();
            button1 = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            AddStudentPnl = new Panel();
            SettingsLbl = new Label();
            CTULogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Orange;
            LoginBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.ControlLightLight;
            LoginBtn.Location = new Point(214, 278);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(614, 88);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Change Username";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(214, 404);
            button1.Name = "button1";
            button1.Size = new Size(614, 88);
            button1.TabIndex = 9;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
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
            pictureBox2.Location = new Point(827, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Orange;
            BackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(768, 41);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(201, 57);
            BackBtn.TabIndex = 61;
            BackBtn.Text = "     Back";
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // AddStudentPnl
            // 
            AddStudentPnl.BackColor = Color.Orange;
            AddStudentPnl.Location = new Point(-6, 138);
            AddStudentPnl.Name = "AddStudentPnl";
            AddStudentPnl.Size = new Size(1058, 10);
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
            CTULogo.Location = new Point(75, 18);
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
            ClientSize = new Size(1044, 623);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(SettingsLbl);
            Controls.Add(CTULogo);
            Controls.Add(button1);
            Controls.Add(LoginBtn);
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
        private Button LoginBtn;
        private Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private Panel AddStudentPnl;
        private Label SettingsLbl;
        private PictureBox CTULogo;
    }
}