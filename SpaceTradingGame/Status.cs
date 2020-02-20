﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows;

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
                Status status = new Status();
                int currency = status.playerMoney;
                Console.WriteLine($"You have {currency}");
            }
            else if (input == "3")
            {
                Console.Clear();
                Console.Write("Travel To: ");
                Console.WriteLine("\n(1) Alpha Centuria" + "\n(2) Tatooine" + "\n(3) Alderan" + "\n(4) Sentinel" + "\n(5) September");
                int travel = int.Parse(Console.ReadLine());

                switch (travel)
                {
                    case 1:
                        //changes color of console; Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        //changes color of text; Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome to Alpha Centuria");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Welcome to Tatooine");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Welcome to Alpha Centuria");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome to Alpha Centuria");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome to Alpha Centuria");
                        Console.ReadLine();
                        break;
                }
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
