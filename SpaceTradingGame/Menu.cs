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
        public static void UserMenu()
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

            Console.SetCursorPosition(0, 0);
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
                        Console.Clear();
                        
                        Status status = new Status();
                        Status.ship(status);
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
            using (StreamWriter sw = new StreamWriter(@"C:\Users\davon\source\repos\SpaceTradingGame\SpaceTradingGame\SaveFile.Txt"))
            {
                sw.WriteLine();
            }
        }

        public static void Load()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\davon\source\repos\SpaceTradingGame\SpaceTradingGame\SaveFile.Txt"))
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
