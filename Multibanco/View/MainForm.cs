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
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            welcomeTxtBox.Text = $"Welcome {user.getName()}";
            balanceTxtBox.Text = user.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
