using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class AdminSettingsForm : Form
    {
        public AdminSettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 mainForm = new Form2();
            mainForm.ShowDialog();
        }
    }
}
