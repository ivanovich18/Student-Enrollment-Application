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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecordsForm));
            StudentRecordsTable = new DataGridView();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            pictureBox1 = new PictureBox();
            ExportBtn = new Button();
            AddStudentPnl = new Panel();
            CTULogo = new PictureBox();
            AddStudentLbl = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            DeleteBtn = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)StudentRecordsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // StudentRecordsTable
            // 
            StudentRecordsTable.AllowUserToAddRows = false;
            StudentRecordsTable.BackgroundColor = Color.Orange;
            StudentRecordsTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Orange;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            StudentRecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            StudentRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            StudentRecordsTable.DefaultCellStyle = dataGridViewCellStyle5;
            StudentRecordsTable.Location = new Point(77, 208);
            StudentRecordsTable.Name = "StudentRecordsTable";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            StudentRecordsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            StudentRecordsTable.RowTemplate.Height = 25;
            StudentRecordsTable.Size = new Size(1354, 554);
            StudentRecordsTable.TabIndex = 4;
            StudentRecordsTable.CellDoubleClick += StudentRecordsTable_CellDoubleClick;
            StudentRecordsTable.CellEndEdit += StudentRecordsTable_CellEndEdit;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Orange;
            pictureBox2.Cursor = Cursors.Hand;
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
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ControlLightLight;
            BackBtn.Location = new Point(1229, 46);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(201, 57);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "     Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.export;
            pictureBox1.Location = new Point(1053, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ExportBtn_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.BackColor = Color.Orange;
            ExportBtn.Cursor = Cursors.Hand;
            ExportBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExportBtn.ForeColor = SystemColors.ControlLightLight;
            ExportBtn.Location = new Point(1010, 46);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(201, 57);
            ExportBtn.TabIndex = 2;
            ExportBtn.Text = "       Export";
            ExportBtn.UseVisualStyleBackColor = false;
            ExportBtn.Click += ExportBtn_Click;
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
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Orange;
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(791, 46);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(201, 57);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "      Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Orange;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(833, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // StudentRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1504, 827);
            Controls.Add(pictureBox3);
            Controls.Add(DeleteBtn);
            Controls.Add(pictureBox2);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox1);
            Controls.Add(ExportBtn);
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
            Shown += StudentRecordsForm_Shown;
            ((System.ComponentModel.ISupportInitialize)StudentRecordsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTULogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView StudentRecordsTable;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private PictureBox pictureBox1;
        private Button ExportBtn;
        private Panel AddStudentPnl;
        private PictureBox CTULogo;
        private Label AddStudentLbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button DeleteBtn;
        private PictureBox pictureBox3;
    }
}