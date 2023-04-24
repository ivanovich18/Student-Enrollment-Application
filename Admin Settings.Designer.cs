namespace Login_Form
{
    partial class Admin_Settings
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
            label2 = new Label();
            LoginBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(1044, 176);
            label2.TabIndex = 5;
            label2.Text = "Administrator Settings";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DodgerBlue;
            LoginBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.ControlLightLight;
            LoginBtn.Location = new Point(203, 229);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(614, 88);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Change Username";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(203, 337);
            button1.Name = "button1";
            button1.Size = new Size(614, 88);
            button1.TabIndex = 9;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(414, 508);
            button2.Name = "button2";
            button2.Size = new Size(225, 50);
            button2.TabIndex = 39;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // Admin_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 623);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Admin_Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Button LoginBtn;
        private Button button1;
        private Button button2;
    }
}