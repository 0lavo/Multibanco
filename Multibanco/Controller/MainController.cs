using Multibanco.Model;
using Multibanco.Model.dao;
using Multibanco.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multibanco.Controller
{
    
    internal class MainController
    {
        UserDao userDao = new UserDao();
        public void login(string username, string password)
        {
            User user = userDao.readUser(username, password);

            if (user != null)
            {
                MainForm form = new MainForm();
                form.Show();
                return;
            }

            MessageBox.Show("This user dont exist");
        }
    }
}

// test git in college git
