using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1.UI
{
    class AdminUI
    {
        public static int AdminMenu()
        {
            Console.WriteLine("1. Add Product.\r\n2. View All Products.\r\n3. Find Product with Highest Unit Price.\r\n4. View Sales Tax of All Products.\r\n5. Products to be Ordered. (less than threshold)\r\n6. View Profile (Username, Password)\r\n7. Exit");
            Console.WriteLine(" ");
            Console.Write("Entered Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
