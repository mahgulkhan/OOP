using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class AbsoluteGradedCourse : Course
    {
       public AbsoluteGradedCourse(string courseName, int marks) : base(courseName, marks)
       {
            this.courseName = courseName;
            this.marks = marks;
            SetGrade(grade);
       }
        private void SetGrade(string grade)
        {
            this.grade = grade;
        }
        
        public override string GetGrade()
        {
            if (marks >= 90)
            {
                return grade = "A+";
            }
            else if (marks >= 80)
            {
                return grade = "A";
            }
            else if (marks >= 70)
            {
                return grade = "B";
            }
            else if (marks >= 60)
            {
                return grade = "C";
            }
            else if (marks >= 50)
            {
                return grade = "D";
            }
            else
            {
                return grade = "F";
            }
        }
        public override string Passed()
        {
            if (grade == "F")
            {
                return "Fail";
            }
            return "Pass";
        }
    }
}
