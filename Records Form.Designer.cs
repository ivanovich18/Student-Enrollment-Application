namespace Login_Form
{
    partial class StudentRecordsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecordsForm));
            StudentRecordsTable = new DataGridView();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            pictureBox1 = new PictureBox();
            ClearBtn = new Button();
            AddStudentPnl = new Panel();
            CTULogo = new PictureBox();
            AddStudentLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentRecordsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            SuspendLayout();
            // 
            // StudentRecordsTable
            // 
            StudentRecordsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentRecordsTable.BackgroundColor = Color.Orange;
            StudentRecordsTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Orange;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            StudentRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            StudentRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentRecordsTable.Location = new Point(77, 208);
            StudentRecordsTable.Name = "StudentRecordsTable";
            StudentRecordsTable.RowTemplate.Height = 25;
            StudentRecordsTable.Size = new Size(1354, 554);
            StudentRecordsTable.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Image = Properties.Resources.Back;
            pictureBox2.Location = new Point(1287, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            pictureBox2.Click += BackBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Orange;
            BackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(1229, 46);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(201, 57);
            BackBtn.TabIndex = 54;
            BackBtn.Text = "     Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = Properties.Resources.export;
            pictureBox1.Location = new Point(1053, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Orange;
            ClearBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.ForeColor = SystemColors.ControlLightLight;
            ClearBtn.Location = new Point(1010, 46);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(201, 57);
            ClearBtn.TabIndex = 52;
            ClearBtn.Text = "       Export";
            ClearBtn.UseVisualStyleBackColor = false;
            // 
            // AddStudentPnl
            // 
            AddStudentPnl.BackColor = Color.Orange;
            AddStudentPnl.Location = new Point(-6, 141);
            AddStudentPnl.Name = "AddStudentPnl";
            AddStudentPnl.Size = new Size(1516, 10);
            AddStudentPnl.TabIndex = 49;
            // 
            // CTULogo
            // 
            CTULogo.Image = Properties.Resources.transparent_logo;
            CTULogo.Location = new Point(77, 12);
            CTULogo.Name = "CTULogo";
            CTULogo.Size = new Size(117, 117);
            CTULogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CTULogo.TabIndex = 48;
            CTULogo.TabStop = false;
            // 
            // AddStudentLbl
            // 
            AddStudentLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddStudentLbl.Location = new Point(218, 30);
            AddStudentLbl.Margin = new Padding(8, 0, 8, 0);
            AddStudentLbl.Name = "AddStudentLbl";
            AddStudentLbl.Size = new Size(305, 83);
            AddStudentLbl.TabIndex = 47;
            AddStudentLbl.Text = "Student Records";
            AddStudentLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1504, 827);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox1);
            Controls.Add(ClearBtn);
            Controls.Add(AddStudentPnl);
            Controls.Add(CTULogo);
            Controls.Add(AddStudentLbl);
            Controls.Add(StudentRecordsTable);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentRecordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Records";
            Load += StudentRecordsForm_Load;
            ((System.ComponentModel.ISupportInitialize)StudentRecordsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView StudentRecordsTable;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private PictureBox pictureBox1;
        private Button ClearBtn;
        private Panel AddStudentPnl;
        private PictureBox CTULogo;
        private Label AddStudentLbl;
    }
}