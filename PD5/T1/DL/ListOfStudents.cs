using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T1.DL
{
    internal class ListOfStudents
    {
        public static List<BL.StudentBL> registered = new List<BL.StudentBL>();

        public static string path = "..// ..//..//..//credentials.txt";
        public ListOfStudents()
        {
              
        }

        public static void getStudents()
        {
            if (File.Exists(path))
            {
                foreach (var x in File.ReadAllLines(path))
                {
                    var space = x.Split(',');
                    registered.Add(new BL.StudentBL( space[0], int.Parse(space[1]), float.Parse(space[2]), float.Parse(space[3])));
                }
            }
        }

        public static void ADD(BL.StudentBL newstudent)
        {
            registered.Add(newstudent);
            File.AppendAllText(path, $"{newstudent.name}, {newstudent.age}, {newstudent.FSCMarks}, {newstudent.EcatMarks}\n");
        }
    }
}
