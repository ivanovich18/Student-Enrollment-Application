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
            string adminUsername = UsernameTxtBox.Text;
            string adminPassword = PasswordTxtBox.Text;
            if (adminUsername == "Admin" && adminPassword == "admin123")
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
                //Added a comment by Ivan
                //Added a comment by Aldrin
            }
        }
    }
}