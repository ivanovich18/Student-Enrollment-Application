namespace Login_Form
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UsernameTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 406);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 47);
            label1.TabIndex = 0;
            label1.Text = "Administrator Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.transparent_logo;
            pictureBox1.Location = new Point(123, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTxtBox.Location = new Point(550, 197);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.PlaceholderText = "Username";
            UsernameTxtBox.Size = new Size(377, 46);
            UsernameTxtBox.TabIndex = 2;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxtBox.Location = new Point(550, 271);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.Size = new Size(377, 46);
            PasswordTxtBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Orange;
            LoginBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.ControlLightLight;
            LoginBtn.Location = new Point(675, 347);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(124, 56);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // LoginForm
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 623);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UsernameTxtBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(8, 9, 8, 9);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Enrollment Application";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UsernameTxtBox;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
    }
}