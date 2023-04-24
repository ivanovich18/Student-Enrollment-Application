namespace Login_Form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (e.KeyCode == Keys.Enter)
            //   LoginBtn.PerformClick();
            // MainForm
            if (UsernameTxtBox.Text == "Admin" && PasswordTxtBox.Text == "admin123")
            {
                MessageBox.Show("Correct username and password!");
                // If user inputs correct login credentials, hide login form and display main form
                this.Hide();
                Form2 mainForm = new Form2();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }

        private void LoginBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
                MessageBox.Show("Enter!");
            }
               
        }
    }
}