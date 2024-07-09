namespace Login_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textUsername.Text;
            password = textPassword.Text;
            MessageBox.Show($"Your username is{username} \n Your password is {password}");

        }
    }
}
