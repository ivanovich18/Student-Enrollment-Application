﻿namespace Login_Form
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            CTULogo = new PictureBox();
            UsernameTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ShowPassBtn = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            AppExitBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowPassBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AppExitBtn).BeginInit();
            SuspendLayout();
            // 
            // CTULogo
            // 
            CTULogo.Image = Properties.Resources.transparent_logo;
            CTULogo.Location = new Point(151, 49);
            CTULogo.Name = "CTULogo";
            CTULogo.Size = new Size(154, 154);
            CTULogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CTULogo.TabIndex = 1;
            CTULogo.TabStop = false;
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.BackColor = SystemColors.Control;
            UsernameTxtBox.BorderStyle = BorderStyle.None;
            UsernameTxtBox.Cursor = Cursors.IBeam;
            UsernameTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTxtBox.ForeColor = SystemColors.WindowText;
            UsernameTxtBox.Location = new Point(61, 13);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.PlaceholderText = "Username";
            UsernameTxtBox.Size = new Size(270, 36);
            UsernameTxtBox.TabIndex = 1;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = SystemColors.Control;
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.Cursor = Cursors.IBeam;
            PasswordTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxtBox.Location = new Point(61, 13);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '•';
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.Size = new Size(270, 36);
            PasswordTxtBox.TabIndex = 2;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Orange;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.ControlLightLight;
            LoginBtn.Location = new Point(58, 508);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(341, 65);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(UsernameTxtBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(58, 312);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 65);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(ShowPassBtn);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(PasswordTxtBox);
            panel2.Location = new Point(58, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 65);
            panel2.TabIndex = 7;
            // 
            // ShowPassBtn
            // 
            ShowPassBtn.Cursor = Cursors.Hand;
            ShowPassBtn.Image = Properties.Resources.hide_pass;
            ShowPassBtn.Location = new Point(296, 20);
            ShowPassBtn.Name = "ShowPassBtn";
            ShowPassBtn.Size = new Size(33, 26);
            ShowPassBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            ShowPassBtn.TabIndex = 7;
            ShowPassBtn.TabStop = false;
            ShowPassBtn.Click += ShowPassBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 224);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 42);
            label1.TabIndex = 8;
            label1.Text = "Administrator Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppExitBtn
            // 
            AppExitBtn.Cursor = Cursors.Hand;
            AppExitBtn.Image = Properties.Resources.app_exit;
            AppExitBtn.Location = new Point(402, 20);
            AppExitBtn.Name = "AppExitBtn";
            AppExitBtn.Size = new Size(34, 34);
            AppExitBtn.TabIndex = 9;
            AppExitBtn.TabStop = false;
            AppExitBtn.Click += AppExitBtn_Click;
            // 
            // LoginForm
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 663);
            Controls.Add(AppExitBtn);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(LoginBtn);
            Controls.Add(CTULogo);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(8, 9, 8, 9);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowPassBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AppExitBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox CTULogo;
        private TextBox UsernameTxtBox;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox AppExitBtn;
        private PictureBox ShowPassBtn;
    }
}