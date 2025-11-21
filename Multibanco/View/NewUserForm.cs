using Multibanco.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multibanco.View
{
    public partial class NewUserForm : Form
    {
        MainController controller = new MainController();
        public NewUserForm()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            if (controller.createUser(UsernameTxtBox.Text, PasswordTxtBox.Text))
            {
                MessageBox.Show("User created");
            }
            MessageBox.Show("This user allready exists");
        }
    }
}
