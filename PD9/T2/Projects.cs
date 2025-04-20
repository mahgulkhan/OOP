using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Project
    {
        private string projectName;
        private List<Course> c1;


        public Project(string projectName, List<Course> c1 )
        {
            this.projectName = projectName;
            this.c1 = c1;
        }


        public void Passed()
        {
            int passCount = 0;

            for (int i = 0; i < c1.Count; i++)
            {
                c1[i].GetGrade();
                Console.WriteLine("Course " + (i + 1) + " Grade: " + c1[i].GetGrade());
                if (c1[i].Passed() == "Pass")
                {
                    passCount++;
                }
            }

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
