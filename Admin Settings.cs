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
            AdminDashboardForm mainForm = new AdminDashboardForm();
            mainForm.ShowDialog();
        }

        private void ChangeUsernameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUsernameForm changeUsernameForm = new ChangeUsernameForm();
            changeUsernameForm.ShowDialog();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordLbl changePasswordForm = new ChangePasswordLbl();
            changePasswordForm.ShowDialog();
            
        }
    }
}
