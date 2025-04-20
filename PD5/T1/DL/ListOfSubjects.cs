using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1.BL;

namespace T1.DL
{
    internal class ListOfSubjects
    {
        public ListOfSubjects()
        {

        }
        public static List<DegreeProgramBL> Programs = new List<DegreeProgramBL>();

        public static void AddProgram(DegreeProgramBL pg)
        {
            Programs.Add(pg);
        }
    }
}
