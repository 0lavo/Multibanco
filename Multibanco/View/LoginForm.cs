using Multibanco.Controller;
using Multibanco.Model.dao;
using Multibanco.View;

namespace Multibanco
{
    public partial class LoginForm : Form
    {
        MainController controller = new MainController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            controller.login(UsernameTxtBox.Text, PasswordTxtBox.Text);
            //MainForm mainform = new MainForm();
            //mainform.Show();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
        }
    }
}
