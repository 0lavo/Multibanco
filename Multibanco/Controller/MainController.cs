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
        public bool login(string username, string password)
        {
            User user = userDao.readUser(username, password);

            if (user != null)
            {
                MainForm form = new MainForm(user);
                form.Show();
                return true;
            }
            return false;
        }

        public bool createUser(string username, string password)
        {
            if (userDao.createUser(username, password) == null)
            {
                return false;
            }

            return true;
        }

        public bool deposit(double amount, User user)
        {
            if (amount > 0)
            {
                user.setBalance(user.getBalance() + amount);
                return true;
            }
            return false;
        }

        public bool withdraw(double amount, User user)
        {
            if (amount > 0 && amount <= user.getBalance())
            {
                user.setBalance(user.getBalance() - amount);
                return true;
            }
            return false;
        }
    }
}

