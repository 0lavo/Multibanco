using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multibanco.Model
{
    internal class User
    {
        private int id;
        private string name;
        private string password;

        public User(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        public int getId() { return id; }
        public void setId(int id) {this.id = id;}
        public string getPassword() {return password;}
        public void setPassoword(string password) {this.password = password;}
        public string getName() { return name; }
        public void setName(string name) {this.name = name;}

    }
}
