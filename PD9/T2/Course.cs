using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Course
    {
        protected string courseName;
        protected int marks;
        protected string grade;

        protected Course(string courseName, int marks)
        {
            this.courseName = courseName;
            this.marks = marks;
        }

        public virtual string GetGrade()
        {
            return grade;
        }
        public virtual string Passed()
        {
            if (marks < 40)
            {
                return "Fail";
            }
            return "Pass";
        }
    }
}
