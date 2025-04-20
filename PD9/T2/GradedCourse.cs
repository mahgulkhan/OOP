using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class GradedCourse: Course 
    {
        public GradedCourse(string courseName, int marks) : base(courseName, marks)
        {
            this.courseName = courseName;
            this.marks = marks;
            SetGrade(grade);
        }
        private void SetGrade(string grade)
        {
            this.grade = grade;
        }
        public string GetGrade()
        {
            if (marks >= 90)
            {
                return grade = "12";
            }
            else if (marks >= 80)
            {
                return grade = "10";
            }
            else if (marks >= 70)
            {
                return grade = "7";
            }
            else if (marks >= 60)
            {
                return grade = "4";
            }
            else if (marks >= 50)
            {
                return grade = "2";
            }
            else if (marks >= 40)
            {
                return grade = "0";
            }
            else
            {
                return grade = "-3";
            }
        }
        public override string Passed()
        {
            if (grade == "0" || grade == "-3")
            {
                return "Fail";
            }
            return "Pass";
        }
    }
}
