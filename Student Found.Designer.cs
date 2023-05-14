namespace Login_Form
{
    partial class Student_Found
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
            LastNameLbl = new Label();
            FirstNameLbl = new Label();
            SuspendLayout();
            // 
            // LastNameLbl
            // 
            LastNameLbl.AutoSize = true;
            LastNameLbl.Location = new Point(32, 215);
            LastNameLbl.Name = "LastNameLbl";
            LastNameLbl.Size = new Size(69, 15);
            LastNameLbl.TabIndex = 0;
            LastNameLbl.Text = "Last Name: ";
            // 
            // FirstNameLbl
            // 
            FirstNameLbl.AutoSize = true;
            FirstNameLbl.Location = new Point(32, 176);
            FirstNameLbl.Name = "FirstNameLbl";
            FirstNameLbl.Size = new Size(67, 15);
            FirstNameLbl.TabIndex = 1;
            FirstNameLbl.Text = "First Name:";
            // 
            // Student_Found
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 512);
            Controls.Add(FirstNameLbl);
            Controls.Add(LastNameLbl);
            Name = "Student_Found";
            Text = "Student_Found";
            Load += Student_Found_Load;
            Controls.SetChildIndex(LastNameLbl, 0);
            Controls.SetChildIndex(FirstNameLbl, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LastNameLbl;
        private Label FirstNameLbl;
    }
}