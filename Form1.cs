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
            // MessageBox.Show("hello world");
            if (UsernameTxtBox.Text == "Admin" && PasswordTxtBox.Text == "admin123")
            {
                MessageBox.Show("Correct username and password!");
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
    }
}