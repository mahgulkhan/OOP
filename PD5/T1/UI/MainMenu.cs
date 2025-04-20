using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1.BL;
using T1.DL;

namespace T1.UI
{
    public class MainMenu
    {
        SubjectBL s = new SubjectBL();
        StudentBL stu = new StudentBL();
        public static void Header ()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("                    $$\\   $$\\  $$$$$$\\  $$\\      $$\\  $$$$$$\\   ");
            Console.WriteLine("                    $$ |  $$ |$$  __$$\\ $$$\\    $$$ |$$  __$$\\     ");
            Console.WriteLine("                    $$ |  $$ |$$ /  $$ |$$$$\\  $$$$ |$$ /  \\__| ");
            Console.WriteLine("                    $$ |  $$ |$$$$$$$$ |$$\\$$\\$$ $$ |\\$$$$$$\\     ");
            Console.WriteLine("                    $$ |  $$ |$$  __$$ |$$ \\$$$  $$ | \\____$$\\     ");
            Console.WriteLine("                    $$ |  $$ |$$ |  $$ |$$ |\\$  /$$ |$$\\   $$ |     ");
            Console.WriteLine("                    \\$$$$$$  |$$ |  $$ |$$ | \\_/ $$ |\\$$$$$$  |    ");
            Console.WriteLine("                     \\______/ \\__|  \\__|\\__|     \\__| \\______/  ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(" ");
        }
        public static void Menu()
        { 
            Console.WriteLine("1.Add Student ");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit ");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Students of a Specific Program ");
            Console.WriteLine("6.Register Subjects for a Specific Students ");
            Console.WriteLine("7.Calculate Fees for all Registered Students ");
            Console.WriteLine("8.Exit ");
            Console.WriteLine(" ");
            Console.Write("Entered option: ");
            int option = int.Parse(Console.ReadLine());
            while (true)
            {
                if (option == 1)
                {
                    StudentBL.ReturntoMenu();
                }
                else if (option == 2)
                {
                    DegreeInputOutput.DegreeUI();
                    StudentBL.ReturntoMenu();
                }
                else if (option == 3)
                {
                    foreach (var student in ListOfStudents.registered)
                    {
                        student.calculateMerit();
                        Console.WriteLine($"{student.name} Merit: {student.merit}");
                        StudentBL.ReturntoMenu();
                    }
                }
                else if (option == 4)
                {
                    foreach (var student in ListOfStudents.registered)
                    {
                        Console.WriteLine($"{student.name} - Student Age: {student.age},Obtained Marks in FSC: {student.FSCMarks},Obtained Marks in ECAT: {student.EcatMarks}");
                        StudentBL.ReturntoMenu();
                    }
                }
                else if (option == 5)
                {
                    StudentBL.ReturntoMenu();
                }
                else if (option == 6)
                {
                    StudentBL.ReturntoMenu();
                }
                else if (option == 7)
                {
                    BL.StudentBL.calculateFee();
                    StudentBL.ReturntoMenu();
                }
                else if (option == 8)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
