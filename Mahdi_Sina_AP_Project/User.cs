using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    internal class User
    {
        protected string username;

        public string USERNAME
        {
            get { return username; }
        }

        protected string password;

        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public User(string username , string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
