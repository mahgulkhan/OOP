using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Project
    {
        private string projectName;
        private AbsoluteGradedCourse c1;
        private AbsoluteGradedCourse c2;
        private GradedCourse c3;
        private GradedCourse c4;

        public Project(string projectName, AbsoluteGradedCourse c1, AbsoluteGradedCourse c2, GradedCourse c3, GradedCourse c4)
        {
            this.projectName = projectName;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            this.c4 = c4;

        }

        public string GetProjectName()
        {
            return projectName;
        }

        public void Passed()
        {
            int passCount = 0;

            c1.GetGrade();
            if (c1.Passed() == "Pass")
            {
                passCount++;
            }

            c2.GetGrade();
            if (c2.Passed() == "Pass")
            {
                passCount++;
            }

            c3.GetGrade();
            if (c3.Passed() == "Passed")
            {
                passCount++;
            }

            c4.GetGrade();
            if (c4.Passed() == "Pass")
            {
                passCount++;
            }
            Console.WriteLine("Your Grades are : " + c1.GetGrade() + ", "+ c2.GetGrade()+ ", " + c3.GetGrade()+ ", " + c4.GetGrade());

            if (passCount >= 3)
            {
                Console.WriteLine("You have passed " + projectName);

            }
            else
            {
                Console.WriteLine("You have failed " + projectName);
            }

        }
    }
}
