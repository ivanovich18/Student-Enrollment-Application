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
            button1 = new Button();
            label2 = new Label();
            LoginBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(994, 190);
            label2.TabIndex = 2;
            label2.Text = "Administrator Dashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Green;
            LoginBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.ControlLightLight;
            LoginBtn.Location = new Point(257, 189);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(219, 88);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Add Student";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(257, 283);
            button2.Name = "button2";
            button2.Size = new Size(219, 88);
            button2.TabIndex = 8;
            button2.Text = "Search Student";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(506, 189);
            button3.Name = "button3";
            button3.Size = new Size(219, 88);
            button3.TabIndex = 9;
            button3.Text = "Student Records";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(506, 283);
            button4.Name = "button4";
            button4.Size = new Size(219, 88);
            button4.TabIndex = 10;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(380, 453);
            button5.Name = "button5";
            button5.Size = new Size(219, 88);
            button5.TabIndex = 11;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 618);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Enrollment Application";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label2;
        private Button LoginBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}