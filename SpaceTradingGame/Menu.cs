using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Threading; 

namespace SpaceTradingGame
{
    class Menu
    {
        public static void UserMenu(Status status)
        {
            var counter = 0;
            for (int i = 0; i < 50; i++)
            {
                Console.SetCursorPosition(40, 13);
                switch (counter % 4)
                {
                    case 0: Console.Write("WELCOME TO THE ULTIMATE SPACE TRADER!", Console.BackgroundColor = ConsoleColor.Black); break;
                    case 1: Console.Write("WELCOME TO THE ULTIMATE SPACE TRADER!", Console.ForegroundColor = ConsoleColor.White); break;
                    case 3: Console.Write("WELCOME TO THE ULTIMATE SPACE TRADER!", Console.BackgroundColor = ConsoleColor.White); break;
                    case 2: Console.Write("WELCOME TO THE ULTIMATE SPACE TRADER!", Console.ForegroundColor = ConsoleColor.Black); break;
                }
                Console.CursorVisible = false;
                counter++;
                Thread.Sleep(150);
            }

            SubMenu(status);
        }

        private static void SubMenu(Status status)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[1] New Game");
            Console.WriteLine("[2] Continue Saved Game");
            Console.WriteLine("[3] Exit");
            do
            {

                string uI = Console.ReadLine();
                if (uI == "1" || uI == "2" || uI == "3")
                {
                    switch (uI)
                    {
                        case "1":
                            New();
                            Console.Clear();
                           
                            Status.ship(status);
                            break;
                        case "2":
                            Load();
                            break;
                        case "3":
                            Exit(status);
                            break;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter either 1, 2, or 3");
                }
                Console.Clear();
                SubMenu(status);
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

        public static void Exit(Status status)
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
                    UserMenu(status);
                    break;

            }
        }
    }
}
