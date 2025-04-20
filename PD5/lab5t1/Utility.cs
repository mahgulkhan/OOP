using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5t1.BL;

namespace lab5t1
{
    public class Utility
    {
        public static void Mains()
        {
            string path = "..//..//credential.txt";

            string[] names = new string[100];
            string[] passwords = new string[100];

            int result = UI.MainMenu.Loginscr();

            if (result == 1)
            {
                SignIn(path, names, passwords);
                Readadmindata(path, names, passwords);
            }
            if (result == 2)
            {
                    Console.Clear();
                    Console.Write("Enter New Name (Only alphabets and should not contain space): ");
                    string newuser = Console.ReadLine();

                    Console.Write("Enter New Password (Enter a numeric Password only, 5 digits): ");
                    int newpass = int.Parse(Console.ReadLine());

                    Utility.SignUp(path, newuser, newpass);
            }
            else
            {
                Console.WriteLine("Invalid option.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                UI.MainMenu.Loginscr();

            }
        }
        static bool Validusername(string usr) //username validity
        {
            if (usr == "")
            {
                return false;
            }
            for (int i = 0; i <= usr.Length; i++)
            {
                if (!(usr[i] == ' '))
                {
                    return true;
                }
            }
            for (int y = 0; y <= usr.Length; y++)
            {
                char check = usr[y];
                if (!((check >= 'A' && check <= 'Z') || (check >= 'a' && check <= 'z')))
                {
                    return false;
                }
            }
            return true;
        }
        static bool Validpass(int key)//password validity
        {
            if (key < 10000 || key > 99999)
            {
                return false;
            }
            return true;
        }
        
        static void Readadmindata(string path, string[] names, string[] passwords)//to read data from the admin.txt file
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

        static string Getfield(string record, int field)//to separate out fields from text files
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

        public static void SignIn(string path, string[] names, string[] passwords)//admim's credential
        {
            Console.Clear();
            int o, key = 0;
            string usr;
            Console.Write("Enter your username(Only alphabets and should not contain space): ");
            usr = Console.ReadLine();

            if (Validusername(usr))
            {
                Console.Write("Enter your password (Enter a numeric Password of 5 digits only): ");
                key = int.Parse(Console.ReadLine());
                if (Validpass(key))
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (usr == names[x] && key == int.Parse(passwords[x]))
                        {
                            Console.WriteLine("");
                            UI.MainMenu.Identity();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong username or password.");
                    Console.WriteLine("Enter 1 to Go back.");
                    Console.Write("Entered option: ");
                    o = int.Parse(Console.ReadLine());
                    if (o == 1)
                    {
                        UI.MainMenu.Identity();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                }
            }
            else if (!Validusername(usr))
            {
                Console.WriteLine("Invalid username or password.");
            }
            else if (!Validpass(key))
            {
                Console.WriteLine("Invalid username or password.");
            }
        }
        public static void SignUp(string path, string newuser, int newpass)//storing new users along with their password in file
        {
            StreamWriter file = new StreamWriter(path, true);
            if (Validusername(newuser) && Validpass(newpass))
            {
                file.WriteLine(newuser + "," + newpass);
                file.Close();
                Console.WriteLine("SignedUp Successfully.");
                Console.WriteLine("Press any key to continue.");
                Console.Read();
                UI.MainMenu.Identity();
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                Console.WriteLine("Enter 1 to Go back to login screen.");
                Console.Write("Entered option: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("");
                    UI.MainMenu.Loginscr();
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
        
    }
}
