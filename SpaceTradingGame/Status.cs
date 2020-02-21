using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows;

namespace SpaceTradingGame
{
    public class Status
    {
        public  List<string> playerInventory = new List<string>() { "fruit", "meat", "jewels", "rifles", "pistols", "explosives", "missiles", "land", "residents", "miningTools" };

        public int moves = 5;
        public int totalTrades = 10;
        public int years = 18;
        public int playerMoney = 50000;
        public (int, int) coordinates = (0, 0);
        
        public static int fruit = 5;
        public static int meat = 10;
        public static int jewels = 1000;
        public static int rifles = 1500;
        public static int pistols = 750;
        public static int explosives = 2000;
        public static int missiles = 2500;
        public static int land = 5000;
        public static int residents = 3000;
        public static int miningTools = 1000;
        public void moveCounter()
        {
            for (int i = 0; moves > 0; i++)
            {
                Console.WriteLine($" {moves -= 1}");
            }
            if (moves == 0)
            {
                for (int j = 0; years < 65; j++)
                {
                    Console.WriteLine($"You are out of moves and are now {years += 1} years old.");
                }
            }
        }
        public  void tradeCounter()
        {
            for (int i = 0; totalTrades > 0; i++)
            {
                Console.WriteLine($"You have { totalTrades -= 1 } trades remaining.");
            }
        }
        public static void Inventory(List<string> item)
        {
            //List<int> items = new List<int>() { fruit, meat, jewels, rifles, pistols, explosives, missiles, land, residents, miningTools };
            
            
            foreach (string i in item)
            {
                Console.WriteLine(i);
            }
        }
        public static void ship(Status status)
        {
            (int, int) shipCoordinates = status.coordinates;

            List<string> playerInv = status.playerInventory;
            
            Console.WriteLine("1: Check Inventory" + "\n2: Travel");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear(); 
                Inventory(playerInv);
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.Write("Travel To: ");
                Console.WriteLine("\n(1) Alpha Centuria" + "\n(2) Tatooine" + "\n(3) Alderan" + "\n(4) Sentinel" + "\n(5) September");
                int travel = int.Parse(Console.ReadLine());

                switch (travel)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nWelcome to Alpha Centuria, a low income planet. Feel free to trade at your leisure.");
                        break;
                    case 2:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Welcome to Tatooine, you've arrived to a desert planet.");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Welcome to Alderan, a planet full of life, actvity, and space pirates.");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome to Sentinel, a highly advanced civilization resides here.");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome to September, home of the Space Police Academy.");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter only 1 or 2.");
                Console.Clear();
                ship(status); 
            }
        }
    }
}
