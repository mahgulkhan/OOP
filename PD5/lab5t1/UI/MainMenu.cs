using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5t1.UI;

namespace lab5t1.UI
{
    public class MainMenu
    {

        public static int Identity()// confirm identity
        {
            Console.Clear();
            int login;
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                       ---------------------------------------------");
            Console.WriteLine("                       |   SELECT ONE OF THE FOLLOWING OPTIONS:    |");
            Console.WriteLine("                       |    1-Admin                                |");
            Console.WriteLine("                       |    2-User                                 |");
            Console.WriteLine("                       |    3-Exit                                 |");
            Console.WriteLine("                       ---------------------------------------------");
            Console.WriteLine("                                                                    ");
            Console.Write("                       Entered option:");
            login = int.Parse(Console.ReadLine());
            if (login == 1)
            {
                UI.AdminUI.AdminMenu();
            }
            if (login == 2)
            {
                UI.CustomerUI.CustomMenu();
            }
            if (login == 3)
            {
                return 0;
            }
            return login;
        }
        public static int Loginscr()
        {
            int login;
            Console.WriteLine("                                                                   ");
            Console.WriteLine("      ---------------------------------------------");
            Console.WriteLine("      |   SELECT ONE OF THE FOLLOWING OPTIONS:    |");
            Console.WriteLine("      |    1-SignIn                               |");
            Console.WriteLine("      |    2-SignUp                               |");
            Console.WriteLine("      |    3-Exit                                 |");
            Console.WriteLine("      ---------------------------------------------");
            
            Console.Write("                 Entered option:");
            login = int.Parse(Console.ReadLine());
            if (login == 3)
            {
                return 0;
            }
            return login;
        }
        public static void Header()
        {
            Console.WriteLine(" ___  ____ ___  ____ ____ ___ _  _ ____ _  _ ___ ____ _       ");
            Console.WriteLine(" |  \\ |___ |__] |__| |__/  |  |\\/| |___ |\\ |  |  |__| |   ");
            Console.WriteLine(" |__/ |___ |    |  | |  \\  |  |  | |___ | \\|  |  |  | |___   ");
            Console.WriteLine("                ____ ___ ____ ____ ____                             ");
            Console.WriteLine("                [__   |  |  | |__/ |___                             ");
            Console.WriteLine("                ___]  |  |__| |  \\ |___                             ");
        }
    }
}
