using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1.UI
{
    public class DegreeInputOutput
    {
        public static void DegreeUI()
        {
            Console.Write("Enter Degree Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Enter Seats for Degree:  ");
            int seats= int.Parse(Console.ReadLine());

            Console.Write("Enter How many Subjects to Enter: ");
            int numOfSub = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Code: ");
            int code = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Subject Credit Hours: ");
            int chours = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Fee: ");
            float fee = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");
        }
    }
}
