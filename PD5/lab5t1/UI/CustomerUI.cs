using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1.UI
{
    class CustomerUI
    {
        public static int CustomMenu()
        {
            Console.WriteLine("1. View all the products\r\n2. Buy the products\r\n3. Generate invoice\r\n4. View Profile (Username, Password, Email, Address and Contact Number)\r\n5. Exit");
            Console.WriteLine(" ");
            Console.Write("Entered Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
