using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1.BL;


namespace T1.DL
{
    
    public class ListOfDegreePrograms
    {
        public static List<DegreeProgramBL> degreePrograms = new List<DegreeProgramBL>();
        public static List<SubjectBL> s;


        public static bool AddDegree(DegreeProgramBL degree)
        {
            if (degreePrograms.Contains(degree))
            {
                return false;
            }
            else
            {
                degreePrograms.Add(degree);
                return true;
            }
        }

        public static List<DegreeProgramBL> GetAllDegrees()
        {
            return degreePrograms;
        }
        public void AddSubject(SubjectBL sub)
        {
            if (StudentBL.getCreditHours() + sub.creditHours <= 20)
            {
                s.Add(sub);
            }
            else
            {
                Console.WriteLine("Cannot exceed 20 credit hours.");
            }
        }
    }
}
