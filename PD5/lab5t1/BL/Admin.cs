using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1.BL
{

    public class Admin
    {
        public string username;
        public int password;

        public Admin()
        {

        }
        public Admin(string username, int password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
