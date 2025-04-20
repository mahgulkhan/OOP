using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1.UI
{
    
    public class SubjectInputOutput
    {
        public SubjectInputOutput()
        {
            
        }
        public static List<BL.SubjectBL> subjects = new List<BL.SubjectBL>();

        public static void AddSub(BL.SubjectBL subject)
        {
            subjects.Add(subject);
        }
    }
}
