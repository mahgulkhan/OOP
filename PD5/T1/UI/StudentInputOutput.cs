using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using T1.BL;

namespace T1.UI
{
    public class StudentInputOutput
    {
        public static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Student FSc Marks: ");
            int interMarks = int.Parse(Console.ReadLine());

            Console.Write("Enter Student ECAT Marks: ");
            int EcatMarks = int.Parse(Console.ReadLine());

            List<DegreeProgramBL> prefrences = new List<DegreeProgramBL>();
            Console.Write("Enter number of prefrences: ");
            int prefrence = int.Parse(Console.ReadLine());
             
            for (int i=0; i < prefrence; i++)
            {
                string degreeTitle = Console.ReadLine();
                DegreeProgramBL degree = new DegreeProgramBL(degreeTitle);

            }

            Console.Write("Available Degree Programs: ");
            string availableProg = Console.ReadLine();

            Console.WriteLine(" ");
            List<DegreeProgramBL> prefrences1 = prefrences;
            StudentBL student = new StudentBL(name, age, interMarks, EcatMarks);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
