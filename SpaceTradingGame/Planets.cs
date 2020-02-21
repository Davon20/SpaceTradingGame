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
        public static void alphaCenturia(Status status)//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (183, 147);

            //int currency = status.playerMoney;
            //int trades = status.totalTrades;
            //List<string> playerInventory = status.playerInventory;

            //int highGradeFuel = 2000;
            //int land = 1000;
            //int residents = 1500;
            //int rifle = 750;
            //int shipMissles = 3000;

            //string[] terminalItems = new string[] {"High-Grade Fuel","alphaCenturia Land","alphaCenturia Residents","Rifle","Ship Missiles" };
            //int[] items = new int[] { highGradeFuel, land, residents, rifle, shipMissles };
            
            //do
            //{
            //    Console.SetCursorPosition(0, 0);
            //    Console.WriteLine($"Credits: {status.playerMoney}");
            //    Console.SetCursorPosition(100, 0);
            //    Console.WriteLine($"Moves Remaining : {trades -5}");

            //    Console.SetCursorPosition(0, 2);
            //    Console.WriteLine("Please select which item you want to purchase");
            //    for (int i = 0; i < items.Length; i++)
            //    {
                    
            //        Console.Write($"{i + 1}) {items[i]}: ");
            //        Console.WriteLine(terminalItems[i]);
                    
            //    }
            //    Console.WriteLine("6) Return to Trade Terminal Main Menu");
            //    int userInput = Convert.ToInt32(Console.ReadLine());

            //    --trades;
            //    if (userInput == 1)
            //    {
            //        status.playerMoney -= highGradeFuel;
            //        playerInventory.Add(terminalItems[0]);
            //        Console.Clear();
            //        Console.WriteLine("\n***High-Grade Fuel has been added to your inventory!***");
            //        Console.SetCursorPosition(0, 0);
            //        Console.WriteLine($"Credits: {status.playerMoney}");
            //        Console.SetCursorPosition(100, 0);
            //        Console.WriteLine($"Moves Remaining : {trades-5}" );
            //    }
            //    else if (userInput == 2)
            //    {
            //        status.playerMoney -= land;
            //        playerInventory.Add(terminalItems[1]);
            //        Console.Clear();
            //        Console.WriteLine("\n***Alpha centuria land has been added to your inventory!***");
            //        Console.SetCursorPosition(0, 0);
            //        Console.WriteLine($"Credits: {status.playerMoney}");
            //        Console.SetCursorPosition(100, 0);
            //        Console.WriteLine($"Moves Remaining : {trades - 5}");
            //    }
            //    else if (userInput == 3)
            //    {
            //        status.playerMoney -= residents;
            //        playerInventory.Add(terminalItems[2]);
            //        Console.Clear();
            //        Console.WriteLine("\n***An alpha centurian resident has been added to your inventory!***");
            //        Console.SetCursorPosition(0, 0);
            //        Console.WriteLine($"Credits: {status.playerMoney}");
            //        Console.SetCursorPosition(100, 0);
            //        Console.WriteLine($"Moves Remaining : {trades - 5}");
            //    }
            //    else if (userInput == 4)
            //    {
            //        status.playerMoney -= rifle;
            //        playerInventory.Add(terminalItems[3]);
            //        Console.Clear();
            //        Console.WriteLine("\n***A rifle has been added to your inventory!***");
            //        Console.SetCursorPosition(0, 0);
            //        Console.WriteLine($"Credits: {status.playerMoney}");
            //        Console.SetCursorPosition(100, 0);
            //        Console.WriteLine($"Moves Remaining : {trades - 5}");
            //    }
            //    else if (userInput == 5)
            //    {
            //        status.playerMoney-= shipMissles;
            //        playerInventory.Add(terminalItems[4]);
            //        Console.Clear();
            //        Console.WriteLine("\n ***Ship Missles have been added to your inventory!***");
            //        Console.SetCursorPosition(0, 0);
            //        Console.WriteLine($"Credits: {status.playerMoney}");
            //        Console.SetCursorPosition(100, 0);
            //        Console.WriteLine($"Moves Remaining : {trades - 5}");
            //    }
            //    else if (userInput == 5)
            //    {
            //        //place holder for option to return to terminal main menu
            //    }
            //} while (trades > 5);
            

            //Console.Clear();
            //Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
            //Console.WriteLine("Ship");
            //Status.ship(status);
        }
       
        public static void Tatooine()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (250, 140);

            int lowGradeFuel = 1000;
            int land = 500;
            int residents = 700;
            int pistol = 250;
            int rareMetals = 3500;

            string[] terminalItems = new string[] { "Low-Grade Fuel", "Tatooine Land", "Tatooine Residents", "Pistol", "Rare Metals" };
            int[] items = new int[] { lowGradeFuel, land, residents, pistol, rareMetals };
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]}: ");
                Console.WriteLine(terminalItems[i]);
            }

            int userInput = int.Parse(Console.ReadLine()); 
            if (userInput == 1)
            {
                
            }
        }
        public static void Alderan()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            
            int lowGradeFuel = 500;
            int land = 3000;
            int residents = 2000;
            int art = 4000;
            int cigars = 2000; 

            (int, int) coordinates = (164, 300);

            string[] terminalItems = new string[] { "Low-Grade Fuel", "Alderan Land", "Alderan Residents", "art", "cigars", };
            int[] items = new int[] { lowGradeFuel, land, residents, art, cigars };

           


            for (int i = 0; i < items.Length; i++)
            {

                Console.Write($"{items[i]}: ");
                Console.WriteLine(terminalItems[i]);
            }
        }
        public static void Sentinel()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            int highGradeFuel = 1000;
            int vitaminWater = 500;
            int upgradedNavigationSystem = 3000;
            int virtualGameStation = 4000;
            int halfThePlanet = 75000; 
            
            string[] terminalItems = new string[] { "High-Grade Fuel", "Vitamin Water", "Upgraded Navigation System", "Virtual Game Station", "50% of Planet Land", };
            int[] items = new int[] { highGradeFuel, vitaminWater, upgradedNavigationSystem, virtualGameStation, halfThePlanet };

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]}: ");
                Console.WriteLine(terminalItems[i]);
            }

            (int, int) coordinates = (354, 256);
        }
        public static void September()//if(tradeMenu(pressed b) -> Buy/Sell Buttons
        {
            (int, int) coordinates = (496, 532);

            int highGradeFuel = 2500;
            int land = 4000;
            int residents = 3000;
            int missiles = 5000;
            int pistol = 750;
            
            string[] terminalItems = new string[] { "High-Grade Fuel", "September Land", "September Residents", "Missiles", "Pistol" };
            int[] items = new int[] { highGradeFuel, land, residents, missiles, pistol };

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]}: ");
                Console.WriteLine(terminalItems[i]);
            }
        }
    }
}