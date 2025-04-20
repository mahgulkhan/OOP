using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using T1.BL;

namespace T1.BL
{
    public class DegreeProgramBL
    {
        StudentBL StudentBL = new StudentBL();

        public string title;
        public string duration;
        public int seats;
        public static List<SubjectBL> s;
        

        public DegreeProgramBL(string title)
        {
            this.title = title;
        }

        public DegreeProgramBL(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            s = new List<SubjectBL>();
        }
        
        public bool isSujectExists( SubjectBL sub )
        {
            return true;
        }
    }
}
