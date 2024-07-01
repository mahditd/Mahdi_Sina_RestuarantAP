using Mahdi_Sina_AP_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sina_Mahdi_RestaurantAP
{
    class Admin : User
    {
        public static Admin currentAdmin;

        public Admin() { }
        public Admin(string userName, string password) : base(userName, password)
        {

        }
    }
}
