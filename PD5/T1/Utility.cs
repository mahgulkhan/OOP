using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1.BL;
using T1.UI;

namespace T1
{
    public class Utility
    {
        StudentBL Student = new StudentBL();

        public string path = "..// ..//..//..//credentials.txt";
        public static List<BL.StudentBL> Students = new List<StudentBL>();

        public static void Readdata( string path, string[] names, string[] passwords)
        {
            int idx = 0;
            if (File.Exists(path))
            {
                string record;
                StreamReader data = new StreamReader(path);
                while ((record = data.ReadLine()) != null)
                {
                    names[idx] = Getfield(record, 1);
                    passwords[idx] = Getfield(record, 2);
                    idx += 1;
                }
                data.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }

        static string Getfield(string record, int field)
        {
            int commacount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commacount = commacount + 1;
                }
                else if (commacount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

       
        public static void Store(string path, string newuser, int newpass)
        {
            StreamWriter file = new StreamWriter(path, true);
            
            
            {
               
                
            }
        }
    }
}
   