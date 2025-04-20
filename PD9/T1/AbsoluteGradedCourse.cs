using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class AbsoluteGradedCourse 
    {
        protected string courseName;
        protected int marks;
        protected string Grade;

        public AbsoluteGradedCourse(string courseName, int marks)
        {
            this.courseName = courseName;
            this.marks = marks;
            SetGrade(Grade);
        }
        public void SetGrade(string Grade)
        {
            this.Grade = Grade;
        }
        public string GetGrade()
        {
            if (marks >= 90)
            {
                return Grade = "A+";
            }
            else if (marks >= 80)
            {
                return Grade = "A";
            }
            else if (marks >= 70)
            {
                return Grade = "B";
            }
            else if (marks >= 60)
            {
                return Grade = "C";
            }
            else if (marks >= 50)
            {
                return Grade = "D";
            }
            else
            {
                return Grade = "F";
            }
        }
        public string Passed()
        {
            if(Grade == "F")
            {
                return "Fail";
            }
            return "Pass";
        }
    }
}
