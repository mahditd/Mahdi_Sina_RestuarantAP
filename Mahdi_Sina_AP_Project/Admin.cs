using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sina_Mahdi_RestaurantAP
{
    class Admin
    {
        private string userName;

        public string USERNAME
        {
            get { return userName; }
        }

        private string password;

        public string PASSWORD
        {
            get { return password; }

            set { password = value; }
        }
    }
}
