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
<<<<<<< HEAD
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

=======
            (int, int) coordinates = (183, 147);

            int highGradeFuel = 2000;
            int land = 1000;
            int residents = 1500;
            int rifle = 750;
            int shipMissles = 3000;
>>>>>>> a807a1774e220e143b61ba6ea30f03353876dd5a

            string[] terminalItems = new string[] { "High-Grade Fuel", "alphaCenturia Land", "alphaCenturia Residents", "Rifle", "Ship Missiles" };
            int[] items = new int[] { highGradeFuel, land, residents, rifle, shipMissles };
            
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]}: ");
                Console.WriteLine(terminalItems[i]);
            }
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

            //If the user selects a product = Product Cost - playerMoney

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

            string[] terminalItems = new string[] { "Low-Grade Fuel", "Alderan Land", "Alderan Residents", "", "", };
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
            int rifles = 1500;




            string[] terminalItems = new string[] { "High-Grade Fuel", "September Land", "September Residents", "Missiles", "Pistol", "Rifles" };
            int[] items = new int[] { highGradeFuel, land, residents, missiles, pistol, rifles };

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]}: ");
                Console.WriteLine(terminalItems[i]);
            }

            //Needs Terminal Item List
        }
    }
}