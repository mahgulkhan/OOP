using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Grade Calculation System****************");
            Console.WriteLine(" ");

            Console.Write("Enter Project Name:");
            string project = Console.ReadLine();

            Console.Write("Enter name of First course:");
            string course1 = Console.ReadLine();

            Console.Write("Enter marks:");
            int marks1 = int.Parse(Console.ReadLine());

            AbsoluteGradedCourse a1 = new AbsoluteGradedCourse(course1, marks1);

            Console.Write("Enter name of Second course:");
            string course2 = Console.ReadLine();

            Console.Write("Enter marks:");
            int marks2 = int.Parse(Console.ReadLine());

            AbsoluteGradedCourse a2 = new AbsoluteGradedCourse(course2, marks2);

            Console.Write("Enter name of Third course:");
            string course3 = Console.ReadLine();

            Console.Write("Enter marks:");
            int marks3 = int.Parse(Console.ReadLine());

            GradedCourse g1 = new GradedCourse(course3, marks3);

            Console.Write("Enter name of Fourth course:");
            string course4 = Console.ReadLine();

            Console.Write("Enter marks:");
            int marks4 = int.Parse(Console.ReadLine());

            GradedCourse g2 = new GradedCourse(course4, marks4);
            List<Course> courseList = new List<Course> { a1, a2, g1, g2 };

            Project project1 = new Project(project, a1, a2, g1, g2);
            project1.Passed();


        }
    }
}
