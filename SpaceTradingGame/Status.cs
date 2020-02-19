using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SpaceTradingGame
{
    public class Status
    {
        public int moves = 5;
        public int years = 18;
        public int playerMoney = 50000;

        public static int fruit = 5;
        public static int meat = 10;
        public static int jewels = 100;
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
                Console.WriteLine($"You have {moves -= 1} moves remaining.");

            }
            if (moves == 0)
            {
                for (int j = 0; years < 65; j++)
                {
                    Console.WriteLine($"You are out of moves and are now {years += 1} years old.");

                }
            }
        }
        public static void tradeCounter()
        {
            int totalTrades = 10;

            for (int i = 0; totalTrades > 0; i++)
            {
                Console.WriteLine($"You have { totalTrades -= 1 } trades remaining.");
            }
        }
        public static void Inventory()
        {
            int[] items = new int[] { fruit, meat, jewels, rifles, pistols, explosives, missiles, land, residents, miningTools } ;
            string[] item = new string[] {"fruit", "meat", "jewels", "rifles", "pistols", "explosives", "missiles", "land", "residents", "miningTools"};
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{item[i]}: "); 
                Console.WriteLine(items[i]);
            }
        }
        public static void ship()
        {
            Console.WriteLine("1: Check Inventory" + "\n3: Travel");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear(); 
                Inventory();
            }
            else if (input == "2")
            {
                 
            }
            else if (input == "3")
            {
                Console.WriteLine("Input the planets the user will travel to.");
            }
            else
            {
                Console.WriteLine("Please enter only 1, 2, or 3.");
                ship(); 
            }
            //int coordinates;
        }
    }
}
