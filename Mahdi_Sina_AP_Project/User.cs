using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    internal class User
    {
        public static User currentUser;

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
        static List<User> users = new List<User>();
        //it can be used by sign up plan and by admin
        public static void AddNewUser(User user)
        {
            users.Add(user);
        }
    }
}
