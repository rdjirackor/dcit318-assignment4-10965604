using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            usernameTextBox.Left = (this.ClientSize.Width - usernameTextBox.Width) / 2;
            usernameTextBox.Top = (this.ClientSize.Height / 2) - 50;

            passwordTextBox.Left = (this.ClientSize.Width - passwordTextBox.Width) / 2;
            passwordTextBox.Top = usernameTextBox.Bottom + 10;

            loginButton.Left = (this.ClientSize.Width - loginButton.Width) / 2;
            loginButton.Top = passwordTextBox.Bottom + 10;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Information");
        }
    }
}
