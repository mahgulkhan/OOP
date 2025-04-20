using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using T1.BL;
using T1.UI;

namespace T1.BL
{
    public class StudentBL
    {
        public string name;
        public int age;
        public float FSCMarks;
        public float EcatMarks;
        public float merit;
        public static List<DegreeProgramBL> prefrences;
        public static List<SubjectBL> regSubjects;

        public StudentBL()
        {

        }
        public StudentBL(string name, int age, float fSCMarks, float ecatMarks)

        {
            this.name = name;
            this.age = age;
            this.FSCMarks = fSCMarks;
            this.EcatMarks = ecatMarks;
            prefrences = new List<DegreeProgramBL>();
            regSubjects = new List<SubjectBL>();
        }

        public static void RegStudentSubject(SubjectBL s)
        {
            int totalhours = getCreditHours() + s.creditHours;
            if (totalhours <= 9)
            {
                List<SubjectBL> regSubjects1 = new List<SubjectBL>();
                regSubjects.Add(s);
            }
            else
            {
                Console.WriteLine("Number of hours cannot exceed than 9.");
            }
        }

        public float calculateMerit()
        {
            merit = (FSCMarks * 0.5F) + (EcatMarks * 0.5F);
            return merit;
        }
        public static int getCreditHours()
        {
            int hours = 0;

            foreach (var s in regSubjects)
            {
                hours += s.creditHours;
            }
            return hours;
        }

        public static float calculateFee()
        {
            float fees = 00F;

            List<SubjectBL> regSubjects1 = new List<SubjectBL>();
            foreach (var s in regSubjects1)
            {
                fees += s.subjectFee;
            }
            return fees;
        }
        
        public static void ReturntoMenu()
        {
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
            MainMenu.Menu();
        }
    }
}

