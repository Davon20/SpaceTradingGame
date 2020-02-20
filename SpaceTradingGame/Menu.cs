using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SpaceTradingGame
{
    class Menu
    {
        public static  void UserMenu ()
        {
            Console.WriteLine("[1] New Game");
            Console.WriteLine("[2] Continue Saved Game");
            Console.WriteLine("[3] Exit");
            do
            {
                int uI = Convert.ToInt32(Console.ReadLine());
                switch (uI)
                {
                    case 1:
                        New();
                        break;

                    case 2:
                        Load();
                        break;

                    case 3:
                        Exit();
                        break;

                }
            } while (true);
        }       

        public static void New()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\turck\Documents\MSSA Cohort 8\cs projects\11FEB_SpaceTradingGame\SpaceTradingGame\SpaceTradingGame\SaveFile.Txt"))
            {
                sw.WriteLine();
            }
        }

        public static void Load()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\turck\Documents\MSSA Cohort 8\cs projects\11FEB_SpaceTradingGame\SpaceTradingGame\SpaceTradingGame\SaveFile.Txt"))
            {
                sr.ReadLine();
            }           
        }

        public static void Exit()
        {
            Console.WriteLine("Are you sure you want to exit? [Y/N]");
            var exit = Console.ReadLine();

            switch (exit)
            {
                case "Y":
                case "y":
                    Environment.Exit(0);
                    break;

                case "N":
                case "n":
                    Console.Clear();
                    UserMenu();
                    break;

            }
        }
    }
}
