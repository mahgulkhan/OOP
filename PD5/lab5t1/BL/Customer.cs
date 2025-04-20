using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1.BL
{
    class Customer
    {
        public string username;
        public int password;
        public string email;
        public string address;
        public int age;

        public Customer(string username, int password, string email, string address, int age)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
            this.age = age;
        }
   
        public Customer(string username, int password)
        {
            this.username = username;
            this.password = password;
        }
        
    }
}
