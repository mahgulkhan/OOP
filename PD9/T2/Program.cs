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
            Console.WriteLine("Welcome to the Course Grading System!");
            Console.WriteLine(" ");

            Console.WriteLine("Please enter the Project name and courses details.");
            Console.Write("Project Name:");
            string projectName = Console.ReadLine();

            Console.Write("Course 1 Name:");
            string course1Name = Console.ReadLine();

            Console.Write("Course 1 Marks:");
            int course1Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Course 2 Name:");
            string course2Name = Console.ReadLine();

            Console.Write("Course 2 Marks:");
            int course2Marks = Convert.ToInt32(Console.ReadLine());

            AbsoluteGradedCourse a1 = new AbsoluteGradedCourse(course1Name, course1Marks);
            AbsoluteGradedCourse a2 = new AbsoluteGradedCourse(course2Name, course2Marks);

            Console.Write("Course 3 Name:");
            string course3Name = Console.ReadLine();

            Console.Write("Course 3 Marks:");
            int course3Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Course 4 Name:");
            string course4Name = Console.ReadLine();

            Console.Write("Course 4 Marks:");
            int course4Marks = Convert.ToInt32(Console.ReadLine());

            GradedCourse g1 = new GradedCourse(course3Name, course3Marks);
            GradedCourse g2 = new GradedCourse(course4Name, course4Marks);

            List<Course> courses1 = new List<Course>();
            courses1.Add(a1);
            courses1.Add(a2);
            courses1.Add(g1);
            courses1.Add(g2);

            Project project1 = new Project(projectName, courses1);
            project1.Passed();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
