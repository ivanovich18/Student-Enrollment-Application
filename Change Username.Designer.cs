namespace Login_Form
{
    partial class ChangeUsernameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUsernameForm));
            pictureBox2 = new PictureBox();
            SettingsBackBtn = new Button();
            AddStudentPnl = new Panel();
            SettingsLbl = new Label();
            CTULogo = new PictureBox();
            ChangeUsernameLbl = new Label();
            panel1 = new Panel();
            OldUsernameLbl = new Label();
            OldUsernameTxtBox = new TextBox();
            NewUsernameTxtBox = new TextBox();
            NewUsernameLbl = new Label();
            ConfirmNewUsernameTxtBox = new TextBox();
            ConfirmNewUsernameLbl = new Label();
            UpdateUsernameBtn = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            SuspendLayout();
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
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            pictureBox2.Click += SettingsBackBtn_Click;
            // 
            // SettingsBackBtn
            // 
            SettingsBackBtn.BackColor = Color.Orange;
            SettingsBackBtn.Cursor = Cursors.Hand;
            SettingsBackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsBackBtn.ForeColor = SystemColors.ControlLightLight;
            SettingsBackBtn.Location = new Point(734, 42);
            SettingsBackBtn.Name = "SettingsBackBtn";
            SettingsBackBtn.Size = new Size(201, 57);
            SettingsBackBtn.TabIndex = 5;
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
            AddStudentPnl.TabIndex = 65;
            // 
            // SettingsLbl
            // 
            SettingsLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsLbl.Location = new Point(199, 42);
            SettingsLbl.Margin = new Padding(8, 0, 8, 0);
            SettingsLbl.Name = "SettingsLbl";
            SettingsLbl.Size = new Size(420, 55);
            SettingsLbl.TabIndex = 64;
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
            CTULogo.TabIndex = 63;
            CTULogo.TabStop = false;
            // 
            // ChangeUsernameLbl
            // 
            ChangeUsernameLbl.AutoSize = true;
            ChangeUsernameLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeUsernameLbl.Location = new Point(75, 204);
            ChangeUsernameLbl.Name = "ChangeUsernameLbl";
            ChangeUsernameLbl.Size = new Size(321, 50);
            ChangeUsernameLbl.TabIndex = 68;
            ChangeUsernameLbl.Text = "Change Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(75, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 1);
            panel1.TabIndex = 66;
            // 
            // OldUsernameLbl
            // 
            OldUsernameLbl.AutoSize = true;
            OldUsernameLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            OldUsernameLbl.Location = new Point(142, 294);
            OldUsernameLbl.Name = "OldUsernameLbl";
            OldUsernameLbl.Size = new Size(166, 32);
            OldUsernameLbl.TabIndex = 69;
            OldUsernameLbl.Text = "Old Username";
            OldUsernameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OldUsernameTxtBox
            // 
            OldUsernameTxtBox.BackColor = Color.Orange;
            OldUsernameTxtBox.BorderStyle = BorderStyle.None;
            OldUsernameTxtBox.Cursor = Cursors.IBeam;
            OldUsernameTxtBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            OldUsernameTxtBox.ForeColor = Color.White;
            OldUsernameTxtBox.Location = new Point(148, 329);
            OldUsernameTxtBox.Margin = new Padding(13);
            OldUsernameTxtBox.Name = "OldUsernameTxtBox";
            OldUsernameTxtBox.Size = new Size(302, 43);
            OldUsernameTxtBox.TabIndex = 1;
            // 
            // NewUsernameTxtBox
            // 
            NewUsernameTxtBox.BackColor = Color.Orange;
            NewUsernameTxtBox.BorderStyle = BorderStyle.None;
            NewUsernameTxtBox.Cursor = Cursors.IBeam;
            NewUsernameTxtBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            NewUsernameTxtBox.ForeColor = Color.White;
            NewUsernameTxtBox.Location = new Point(148, 456);
            NewUsernameTxtBox.Margin = new Padding(13);
            NewUsernameTxtBox.Name = "NewUsernameTxtBox";
            NewUsernameTxtBox.Size = new Size(302, 43);
            NewUsernameTxtBox.TabIndex = 2;
            // 
            // NewUsernameLbl
            // 
            NewUsernameLbl.AutoSize = true;
            NewUsernameLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NewUsernameLbl.Location = new Point(142, 421);
            NewUsernameLbl.Name = "NewUsernameLbl";
            NewUsernameLbl.Size = new Size(176, 32);
            NewUsernameLbl.TabIndex = 71;
            NewUsernameLbl.Text = "New Username";
            NewUsernameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ConfirmNewUsernameTxtBox
            // 
            ConfirmNewUsernameTxtBox.BackColor = Color.Orange;
            ConfirmNewUsernameTxtBox.BorderStyle = BorderStyle.None;
            ConfirmNewUsernameTxtBox.Cursor = Cursors.IBeam;
            ConfirmNewUsernameTxtBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmNewUsernameTxtBox.ForeColor = Color.White;
            ConfirmNewUsernameTxtBox.Location = new Point(571, 329);
            ConfirmNewUsernameTxtBox.Margin = new Padding(13);
            ConfirmNewUsernameTxtBox.Name = "ConfirmNewUsernameTxtBox";
            ConfirmNewUsernameTxtBox.Size = new Size(302, 43);
            ConfirmNewUsernameTxtBox.TabIndex = 3;
            // 
            // ConfirmNewUsernameLbl
            // 
            ConfirmNewUsernameLbl.AutoSize = true;
            ConfirmNewUsernameLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmNewUsernameLbl.Location = new Point(566, 294);
            ConfirmNewUsernameLbl.Name = "ConfirmNewUsernameLbl";
            ConfirmNewUsernameLbl.Size = new Size(269, 32);
            ConfirmNewUsernameLbl.TabIndex = 73;
            ConfirmNewUsernameLbl.Text = "Confirm New Username";
            ConfirmNewUsernameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateUsernameBtn
            // 
            UpdateUsernameBtn.BackColor = Color.Orange;
            UpdateUsernameBtn.Cursor = Cursors.Hand;
            UpdateUsernameBtn.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateUsernameBtn.ForeColor = SystemColors.ControlLightLight;
            UpdateUsernameBtn.Location = new Point(404, 546);
            UpdateUsernameBtn.Name = "UpdateUsernameBtn";
            UpdateUsernameBtn.Size = new Size(201, 57);
            UpdateUsernameBtn.TabIndex = 4;
            UpdateUsernameBtn.Text = "Update";
            UpdateUsernameBtn.UseVisualStyleBackColor = false;
            UpdateUsernameBtn.Click += UpdateUsernameBtn_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // ChangeUsernameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 663);
            Controls.Add(UpdateUsernameBtn);
            Controls.Add(ConfirmNewUsernameTxtBox);
            Controls.Add(ConfirmNewUsernameLbl);
            Controls.Add(NewUsernameTxtBox);
            Controls.Add(NewUsernameLbl);
            Controls.Add(OldUsernameTxtBox);
            Controls.Add(OldUsernameLbl);
            Controls.Add(panel1);
            Controls.Add(ChangeUsernameLbl);
            Controls.Add(pictureBox2);
            Controls.Add(SettingsBackBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(SettingsLbl);
            Controls.Add(CTULogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeUsernameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Username";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button SettingsBackBtn;
        private Panel AddStudentPnl;
        private Label SettingsLbl;
        private PictureBox CTULogo;
        private Label ChangeUsernameLbl;
        private Panel panel1;
        private Label OldUsernameLbl;
        private TextBox OldUsernameTxtBox;
        private TextBox NewUsernameTxtBox;
        private Label NewUsernameLbl;
        private TextBox ConfirmNewUsernameTxtBox;
        private Label ConfirmNewUsernameLbl;
        private Button UpdateUsernameBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}