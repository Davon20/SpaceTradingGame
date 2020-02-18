using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame
{
    public class Status
    {
        public static void moveCounter()
        {
            int years = 18; 
            int moves = 5;
            for (int i = 0; moves > 0; i++)
            {
                Console.WriteLine($"You have {moves -=1} moves remaining.");
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
                Console.WriteLine($"You have { totalTrades -=1 } trades remaining.");
            }
        }
        public static void Inventory()
        {
            string[] items = new string[] { "fruit", "meat", "jewels", "rifles", "pistols", "explosives", "missiles", "land", "residents", "mining tools",  };
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void bankRoll()
        {
            int playerMoney = 50000;
            Console.WriteLine(playerMoney);
        }
    }
}
