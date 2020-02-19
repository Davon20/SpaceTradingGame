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
            string[] items = new string[] { "fruit", "meat", "jewels", "rifles", "pistols", "explosives", "missiles", "land", "residents", "mining tools", };
            
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
      
        public static void ship()
        {
            Console.WriteLine("1: Check Inventory" + "\n2: Check Bankroll" + "\n3: Travel");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Inventory();
            }
            else if (input == "2")
            {
                Status status = new Status();
                int currency = status.playerMoney;
                Console.WriteLine($"You have {currency}");
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
