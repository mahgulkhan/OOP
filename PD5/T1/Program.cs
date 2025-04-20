using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1.UI;
using T1.BL;

namespace T1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu.Header();
            DL.ListOfStudents.getStudents();
            MainMenu.Menu();

        }
    }
}
