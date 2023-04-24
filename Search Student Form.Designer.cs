namespace Login_Form
{
    partial class Search_Student
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
            textBox1 = new TextBox();
            SearchBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(1044, 204);
            label2.TabIndex = 4;
            label2.Text = "Search Student";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(275, 223);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ID Number";
            textBox1.Size = new Size(492, 61);
            textBox1.TabIndex = 6;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.Highlight;
            SearchBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = SystemColors.ControlLightLight;
            SearchBtn.Location = new Point(395, 359);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(258, 70);
            SearchBtn.TabIndex = 37;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += RegisterBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(395, 435);
            button1.Name = "button1";
            button1.Size = new Size(258, 70);
            button1.TabIndex = 38;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // Search_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 623);
            Controls.Add(button1);
            Controls.Add(SearchBtn);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Search_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Button SearchBtn;
        private Button button1;
    }
}