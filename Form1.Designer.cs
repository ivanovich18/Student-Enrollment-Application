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
            textBox1 = new TextBox();
            button1 = new Button();
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
            UsernameTxtBox.Location = new Point(619, 209);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.PlaceholderText = "Username";
            UsernameTxtBox.Size = new Size(377, 46);
            UsernameTxtBox.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(619, 282);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(377, 46);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(751, 360);
            button1.Name = "button1";
            button1.Size = new Size(124, 56);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 623);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(UsernameTxtBox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
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
        private TextBox textBox1;
        private Button button1;
    }
}