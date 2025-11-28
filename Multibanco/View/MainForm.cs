using Multibanco.Controller;
using Multibanco.Model;
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
    public partial class MainForm : Form
    {
        private User user;
        private MainController controller = new MainController();
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            welcomeTxtBox.Text = $"Welcome {user.getName()}";
            balanceTxtBox.Text = user.getBalance().ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (controller.deposit(Convert.ToDouble(amountTxtBox.Text), user))
            {
                balanceTxtBox.Text = user.getBalance().ToString();
                return;
            }
            MessageBox.Show("The amount of deposit must me bigger than 0");

        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {   
            if (controller.withdraw(Convert.ToDouble(amountTxtBox.Text), user))
            {
                balanceTxtBox.Text = user.getBalance().ToString();
                return;
            }
            MessageBox.Show("The amount of deposit must be smaller than your balance and bigger than 0");
        }
    }
}
