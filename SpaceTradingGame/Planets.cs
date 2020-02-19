using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SpaceTradingGame
{
    public class Planets //Allen is the object that goes to every planet. Allen.Earth = new Plot(); 
    {
        public string name;

        public static void Earth() //if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (0, 0);

            Console.WriteLine("Hello");
            // REquires if statement: Status.tradeCounter();
        }
        public static void alphaCenturia()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            Status status = new Status();
            int fruit = Status.fruit;
            int meat = Status.meat;
            int jewels = Status.jewels;
            int rifles = Status.rifles;
            int pistols = Status.pistols;
            int explosives = Status.explosives;
            int missiles = Status.missiles;
            int land = Status.land;
            int residents = Status.residents;
            int miningTools = Status.miningTools; 


            string[] terminalItems = new string[] { "High-Grade Fuel", "alphaCenturia Land", "alphaCenturia Residents", "Rifle", "Ship Missiles" };
            int[] items = new int[] { fruit, meat, jewels, rifles, pistols, explosives, missiles, land, residents, miningTools };
            
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]}: ");
                Console.WriteLine(terminalItems[i]);
            }
        }
       
        public static void Tatooine()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (250, 140);

            string[] terminalItems = new string[] { "Low-Grade Fuel", "Tatooine Land", "Tatooine Residents", "Pistol", "Rare Metals" };
            foreach (string items in terminalItems)
            {
                Console.WriteLine(items);
            }

            //If the user selects a product = Product Cost - playerMoney

            int userInput = int.Parse(Console.ReadLine()); 
            if (userInput == 1)
            {
                
            }
        }
        public static void Alderan()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (164, 300);

            string[] terminalItems = new string[] { "Low-Grade Fuel", "Alderan Land", "Alderan Residents", "", "", };
            foreach (string items in terminalItems)
            {
                Console.WriteLine(items);
            }
        }
        public static void Sentinel()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (354, 256);

            //Needs Terminal Item List
        }
        public static void September()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (496, 532);


            //Needs Terminal Item List
        }
    }
}