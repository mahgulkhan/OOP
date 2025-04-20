using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class GradedCourse 
    {
        protected string courseName;
        protected int marks;
        protected string Grade;
        private string v1;
        private int v2;

        public GradedCourse(string courseName, string Grade)
        {
            this.courseName = courseName;
            this.Grade = Grade;
        }
        public GradedCourse(string courseName, int marks, string Grade)
        {
            this.courseName = courseName;
            this.marks = marks;
            this.SetGrade(Grade);
        }

        public GradedCourse(string courseName, int marks)
        {
            this.courseName = courseName;
            this.marks = marks;
        }

        public string  GetGrade()
        {
            if (marks >= 90)
            {
                return Grade = "12";
            }
            else if (marks >= 80)
            {
                return Grade = "10";
            }
            else if (marks >= 70)
            {
                return Grade = "7";
            }
            else if (marks >= 60)
            {
                return Grade = "4";
            }
            else if (marks >= 50)
            {
                return Grade = "2";
            }
            else if (marks >= 40)
            {
                return Grade = "0";
            }
            else
            {
                return Grade = "-3";
            }
        }
        public void SetGrade(string Grade)
        {
            this.Grade = Grade;
        }
        public string Passed()
        {
            if (Grade == "0" || Grade == "-3")
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
    }  
}