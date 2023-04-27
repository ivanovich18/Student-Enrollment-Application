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
    public partial class ChangeUsernameForm : Form
    {
        public ChangeUsernameForm()
        {
            InitializeComponent();
        }

        private void SettingsBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();
            adminSettingsForm.ShowDialog();
        }
    }
}
