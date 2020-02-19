using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SpaceTradingGame
{
    class Planets //Allen is the object that goes to every planet. Allen.Earth = new Plot(); 
    {
        public string name;

        public static void Earth() //if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            Console.WriteLine("Hello");
            // REquires if statement: Status.tradeCounter();
        }
        public static void alphaCenturia()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            string[] terminalItems = new string[] { "High-Grade Fuel", "alphaCenturia Land", "alphaCenturia Residents", "Rifle", "Ship Missiles" };
            foreach (string items in terminalItems)
            {
                Console.WriteLine(items);
            }
        }
        public static void Dathomir()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            string[] terminalItems = new string[] { "High-Grade Fuel", "Dathomir Land", "Dathomir Residents", "Expensive Meat", "Expensive Fruit" };
            foreach (string items in terminalItems)
            {
                Console.WriteLine(items);
            }
        }
        public static void Tatooine()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
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
            string[] terminalItems = new string[] { "Low-Grade Fuel", "Alderan Land", "Alderan Residents", "", "", };
            foreach (string items in terminalItems)
            {
                Console.WriteLine(items);
            }
        }
        public static void Sentinel()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            //Needs Terminal Item List
        }
        public static void September()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            //Needs Terminal Item List
        }
    }
}