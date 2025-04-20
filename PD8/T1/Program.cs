using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", "123 Main St");
            Student student = new Student("Jane Smith", "456 Elm St", "Computer Science", 2, 15000);
            Staff staff = new Staff("Alice Johnson", "789 Oak St", "XYZ High School", 50000);

            Console.WriteLine(person.To_String());
            Console.WriteLine(student.ToString());
            Console.WriteLine(staff.ToString());
        }
    }
}
