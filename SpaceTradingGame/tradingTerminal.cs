using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame
{
    class tradingTerminal
    {
        public static void TerminalMenu(Status status)
        {
            Planets planet = new Planets();
           // int currency = status.playerMoney;

           
           
                
            Console.WriteLine("Welcome to this planet's Trade Terminal! Please Select from the Following Options");
            Console.WriteLine("1) Purchase");
            Console.WriteLine("2) Sell");
            Console.WriteLine("3) Exit");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                Purchase(status);

            }else if (userInput == "2")
            {
                Console.Clear();
                Sell(status);

            }else if (userInput == "3")
            {
                Console.Clear();
                Exit(status);
            }
           

            

        }

        public static void Purchase(Status status)
        {
            (int, int) coordinates = status.coordinates;

          


            if (coordinates == (183,147)) // Alpha Centuria 1
            {

               
                List<string> playerInventory = status.playerInventory;
                List<int> playerInventoryPrice = status.playerInventoryPrice;

                int currency = status.playerMoney;
                int trades = status.totalTrades;

                int highGradeFuel = 2000;
                int land = 1000;
                int residents = 1500;
                int rifle = 750;
                int shipMissles = 3000;

                string[] terminalItems = new string[] { "High-Grade Fuel", "alphaCenturia Land", "alphaCenturia Residents", "Rifle", "Ship Missiles" };
                int[] items = new int[] { highGradeFuel, land, residents, rifle, shipMissles };

                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Credits: {status.playerMoney}");
                    Console.SetCursorPosition(35, 0);
                    Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                    Console.SetCursorPosition(100, 0);
                    Console.WriteLine($"Moves Remaining : {trades - 5}");

                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Please select which item you want to purchase");
                    for (int i = 0; i < items.Length; i++)
                    {

                        Console.Write($"{i + 1}) {items[i]}: ");
                        Console.WriteLine(terminalItems[i]);

                    }
                    Console.WriteLine("6) Return to Trade Terminal Main Menu");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    --trades;
                    if (userInput == 1)
                    {
                        status.playerMoney -= items[0];
                        playerInventory.Add(terminalItems[0]);
                        playerInventoryPrice.Add(items[0]);
                        status.inventorySize++;
                        Console.Clear();
                        Console.WriteLine("\n***High-Grade Fuel has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 2)
                    {
                        status.playerMoney -= items[1];
                        playerInventory.Add(terminalItems[1]);
                        playerInventoryPrice.Add(items[1]);
                        Console.Clear();
                        Console.WriteLine("\n***Alpha centuria land has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 3)
                    {
                        status.playerMoney -= items[2];
                        playerInventory.Add(terminalItems[2]);
                        playerInventoryPrice.Add(items[2]);
                        Console.Clear();
                        Console.WriteLine("\n***An alpha centurian resident has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 4)
                    {
                        status.playerMoney -= items[3];
                        playerInventory.Add(terminalItems[3]);
                        playerInventoryPrice.Add(items[3]);
                        Console.Clear();
                        Console.WriteLine("\n***A rifle has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 5)
                    {
                        status.playerMoney -= items[4];
                        playerInventory.Add(terminalItems[4]);
                        playerInventoryPrice.Add(items[4]);
                        Console.Clear();
                        Console.WriteLine("\n ***Ship Missles have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 6)
                    {
                        Console.Clear();
                        TerminalMenu(status);
                    }
                } while (trades > 5 && status.inventorySize <= 20 && status.playerMoney > 0);

                ExitConditions(status, trades);


            }
            else if (coordinates == (250,140)) //Tattooine
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;
                List<int> playerInventoryPrice = status.playerInventoryPrice;

                int lowGradeFuel = 1000;
                int land = 500;
                int residents = 700;
                int pistol = 250;
                int rareMetals = 3500;

                string[] terminalItems = new string[] { "Low-Grade Fuel", "Tatooine Land", "Tatooine Residents", "Pistol", "Rare Metals" };
                int[] items = new int[] { lowGradeFuel, land, residents, pistol, rareMetals };

                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Credits: {status.playerMoney}");
                    Console.SetCursorPosition(35, 0);
                    Console.WriteLine($"Welcome to the Trade Terminal in Tattooine");
                    Console.SetCursorPosition(100, 0);
                    Console.WriteLine($"Moves Remaining : {trades - 5}");

                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Please select which item you want to purchase");
                    for (int i = 0; i < items.Length; i++)
                    {

                        Console.Write($"{i + 1}) {items[i]}: ");
                        Console.WriteLine(terminalItems[i]);

                    }
                    Console.WriteLine("6) Return to Trade Terminal Main Menu");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    --trades;
                    if (userInput == 1)
                    {
                        status.playerMoney -= items[0];
                        playerInventory.Add(terminalItems[0]);
                        playerInventoryPrice.Add(items[0]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[0]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Tattooine");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 2)
                    {
                        status.playerMoney -= items[1];
                        playerInventory.Add(terminalItems[1]);
                        playerInventoryPrice.Add(items[1]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[1]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Tattooine");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 3)
                    {
                        status.playerMoney -= items [2];
                        playerInventory.Add(terminalItems[2]);
                        playerInventoryPrice.Add(items[2]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[2]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Tattooine");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 4)
                    {
                        status.playerMoney -= items[3];
                        playerInventory.Add(terminalItems[3]);
                        playerInventoryPrice.Add(items[3]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[3]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Tattooine");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 5)
                    {
                        status.playerMoney -= items[4];
                        playerInventory.Add(terminalItems[4]);
                        playerInventoryPrice.Add(items[4]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[4]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Tattooine");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 6)
                    {
                        Console.Clear();
                        TerminalMenu(status);
                    }
                } while (trades > 5 && status.inventorySize <= 20 && status.playerMoney > 0);

                ExitConditions(status, trades);


            }else if (coordinates == (164,300))//Alderan
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;
                List<int> playerInventoryPrice = status.playerInventoryPrice;

                int lowGradeFuel = 500;
                int land = 3000;
                int residents = 2000;
                int art = 4000;
                int cigars = 2000;


                string[] terminalItems = new string[] { "Low-Grade Fuel", "Alderan Land", "Alderan Residents", "art", "cigars", };
                int[] items = new int[] { lowGradeFuel, land, residents, art, cigars };

                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Credits: {status.playerMoney}");
                    Console.SetCursorPosition(35, 0);
                    Console.WriteLine($"Welcome to the Trade Terminal in Alderan");
                    Console.SetCursorPosition(100, 0);
                    Console.WriteLine($"Moves Remaining : {trades - 5}");

                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Please select which item you want to purchase");
                    for (int i = 0; i < items.Length; i++)
                    {

                        Console.Write($"{i + 1}) {items[i]}: ");
                        Console.WriteLine(terminalItems[i]);

                    }
                    Console.WriteLine("6) Return to Trade Terminal Main Menu");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    --trades;
                    if (userInput == 1)
                    {
                        status.playerMoney -= items[0];
                        playerInventory.Add(terminalItems[0]);
                        playerInventoryPrice.Add(items[0]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[0]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alderan");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 2)
                    {
                        status.playerMoney -= items[1];
                        playerInventory.Add(terminalItems[1]);
                        playerInventoryPrice.Add(items[1]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[1]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alderan");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 3)
                    {
                        status.playerMoney -= items[2];
                        playerInventory.Add(terminalItems[2]);
                        playerInventoryPrice.Add(items[2]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[2]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alderan");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 4)
                    {
                        status.playerMoney -= items[3];
                        playerInventory.Add(terminalItems[3]);
                        playerInventoryPrice.Add(items[3]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[3]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alderan");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 5)
                    {
                        status.playerMoney -= items[4];
                        playerInventory.Add(terminalItems[4]);
                        playerInventoryPrice.Add(items[4]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[4]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alderan");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 6)
                    {
                        Console.Clear();
                        TerminalMenu(status);
                    }
                } while (trades > 5 && status.inventorySize <= 20 && status.playerMoney > 0);

                ExitConditions(status, trades);


                
            }else if (coordinates == (354,256)) // Sentinel
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;
                List<int> playerInventoryPrice = status.playerInventoryPrice;

                int highGradeFuel = 1000;
                int vitaminWater = 500;
                int upgradedNavigationSystem = 3000;
                int virtualGameStation = 4000;
                int halfThePlanet = 75000;

                string[] terminalItems = new string[] { "High-Grade Fuel", "Vitamin Water", "Upgraded Navigation System", "Virtual Game Station", "50% of Planet Land", };
                int[] items = new int[] { highGradeFuel, vitaminWater, upgradedNavigationSystem, virtualGameStation, halfThePlanet };

                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Credits: {status.playerMoney}");
                    Console.SetCursorPosition(35, 0);
                    Console.WriteLine($"Welcome to the Trade Terminal in Sentinel");
                    Console.SetCursorPosition(100, 0);
                    Console.WriteLine($"Moves Remaining : {trades - 5}");

                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Please select which item you want to purchase");
                    for (int i = 0; i < items.Length; i++)
                    {

                        Console.Write($"{i + 1}) {items[i]}: ");
                        Console.WriteLine(terminalItems[i]);

                    }
                    Console.WriteLine("6) Return to Trade Terminal Main Menu");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    --trades;
                    if (userInput == 1)
                    {
                        status.playerMoney -= items[0];
                        playerInventory.Add(terminalItems[0]);
                        playerInventoryPrice.Add(items[0]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[0]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Sentinel");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 2)
                    {
                        status.playerMoney -= items[1];
                        playerInventory.Add(terminalItems[1]);
                        playerInventoryPrice.Add(items[1]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[1]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Sentinel");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 3)
                    {
                        status.playerMoney -= items[2];
                        playerInventory.Add(terminalItems[2]);
                        playerInventoryPrice.Add(items[2]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[2]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Sentinel");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 4)
                    {
                        status.playerMoney -= items[3];
                        playerInventory.Add(terminalItems[3]);
                        playerInventoryPrice.Add(items[3]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[3]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Sentinel");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 5)
                    {
                        status.playerMoney -= items[4];
                        playerInventory.Add(terminalItems[4]);
                        playerInventoryPrice.Add(items[4]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[4]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Sentinel");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                        
                    }
                    else if (userInput == 6)
                    {
                        Console.Clear();
                        TerminalMenu(status);
                    }
                } while (trades > 5 && status.inventorySize <=20 && status.playerMoney > 0);

                ExitConditions(status, trades);
           
            }else if (coordinates == (496,532))// September
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;
                List<int> playerInventoryPrice = status.playerInventoryPrice;

                int highGradeFuel = 2500;
                int land = 4000;
                int residents = 3000;
                int missiles = 5000;
                int pistol = 750;

                string[] terminalItems = new string[] { "High-Grade Fuel", "September Land", "September Residents", "Missiles", "Pistol" };
                int[] items = new int[] { highGradeFuel, land, residents, missiles, pistol };

                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Credits: {status.playerMoney}");
                    Console.SetCursorPosition(35, 0);
                    Console.WriteLine($"Welcome to the Trade Terminal in September");
                    Console.SetCursorPosition(100, 0);
                    Console.WriteLine($"Moves Remaining : {trades - 5}");

                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Please select which item you want to purchase");
                    for (int i = 0; i < items.Length; i++)
                    {

                        Console.Write($"{i + 1}) {items[i]}: ");
                        Console.WriteLine(terminalItems[i]);

                    }
                    Console.WriteLine("6) Return to Trade Terminal Main Menu");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    --trades;
                    if (userInput == 1)
                    {
                        status.playerMoney -= items[0];
                        playerInventory.Add(terminalItems[0]);
                        playerInventoryPrice.Add(items[0]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[0]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in September");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 2)
                    {
                        status.playerMoney -= items[1];
                        playerInventory.Add(terminalItems[1]);
                        playerInventoryPrice.Add(items[1]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[1]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in September");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 3)
                    {
                        status.playerMoney -= items[2];
                        playerInventory.Add(terminalItems[2]);
                        playerInventoryPrice.Add(items[2]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[2]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in September");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 4)
                    {
                        status.playerMoney -= items[3];
                        playerInventory.Add(terminalItems[3]);
                        playerInventoryPrice.Add(items[3]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[3]} has been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in September");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");
                    }
                    else if (userInput == 5)
                    {
                        status.playerMoney -= items[4];
                        playerInventory.Add(terminalItems[4]);
                        playerInventoryPrice.Add(items[4]);
                        Console.Clear();
                        Console.WriteLine($"\n***{terminalItems[4]} have been added to your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in September");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");

                    }
                    else if (userInput == 6)
                    {
                        Console.Clear();
                        TerminalMenu(status);
                    }
                } while (trades > 5 && status.inventorySize <= 20 && status.playerMoney > 0);


                ExitConditions(status, trades);
               
            }
        }

        private static void ExitConditions(Status status, int trades)
        {
            List<string> playerInventory = status.playerInventory;
            List<int> playerInventoryPrice = status.playerInventoryPrice;
            if (trades <= 5)
            {
                Console.Clear();
                Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
                Console.WriteLine("Ship");
                Status.ship(status);

            }
            else if (status.inventorySize >= 20)
            {
                status.playerMoney += playerInventoryPrice[20];
                playerInventory.RemoveAt(20);
                playerInventoryPrice.RemoveAt(20);
                Console.Clear();
                Console.WriteLine("You have reached that max limit of your inventory (Totals 20 Items).");
                Console.WriteLine("You are now being returned to your ship");
                Status.ship(status);
            }
            else if (status.playerMoney < 0)
            {
                Console.Clear();
                Console.WriteLine("You have ran out of credits and are now in debt. You Lose!!");
                Console.Read();
                Environment.Exit(0);
            }
        }

        public static void Sell(Status status)
        {
            
            
            List<string> playerInventory = status.playerInventory;
            List<int> playerInventoryPrice = status.playerInventoryPrice;
            

            if (status.coordinates == (183,147))
            {
                do
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Credits: {status.playerMoney}");
                    Console.SetCursorPosition(35, 0);
                    Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                    Console.SetCursorPosition(100, 0);
                    Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");

                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Please select which item you want to sell");
                   // Console.WriteLine("1) Return to Trade Terminal Main Menu");
                    for (int i = 0; i < playerInventory.Count; i++)
                    {
                        Console.Write($"{i + 1}) {playerInventory[i]}: ");
                        Console.WriteLine(playerInventoryPrice[i] * 2);


                    }
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    --status.totalTrades;
                    if (userInput == 1)
                    {
                        status.playerMoney += playerInventoryPrice[0];
                        playerInventory.RemoveAt(0);
                        playerInventoryPrice.RemoveAt(playerInventoryPrice[0]);
                        Console.Clear();
                        Console.WriteLine($"\n***{playerInventory[0]} has been removed from  your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");
                    }
                    else if (userInput == 2)
                    {
                        status.playerMoney += playerInventoryPrice[1];
                        playerInventory.RemoveAt(1);
                        playerInventoryPrice.RemoveAt(playerInventoryPrice[1]);
                        Console.Clear();
                        Console.WriteLine($"\n***{playerInventory[1]} has been removed from  your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");
                    }
                    else if (userInput == 3)
                    {
                        status.playerMoney += playerInventoryPrice[2];
                        playerInventory.RemoveAt(2);
                        playerInventoryPrice.RemoveAt(playerInventoryPrice[2]);
                        Console.Clear();
                        Console.WriteLine($"\n***{playerInventory[2]} has been removed from  your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");
                    }
                    else if (userInput == 4)
                    {
                        status.playerMoney += playerInventoryPrice[3];
                        playerInventory.RemoveAt(3);
                        playerInventoryPrice.RemoveAt(playerInventoryPrice[3]);
                        Console.Clear();
                        Console.WriteLine($"\n***{playerInventory[3]} has been removed from  your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");
                    }
                    else if (userInput == 5)
                    {
                        status.playerMoney += playerInventoryPrice[4];
                        playerInventory.RemoveAt(4);
                        playerInventoryPrice.RemoveAt(playerInventoryPrice[4]);
                        Console.Clear();
                        Console.WriteLine($"\n***{playerInventory[4]} has been removed from  your inventory!***");
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"Credits: {status.playerMoney}");
                        Console.SetCursorPosition(35, 0);
                        Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");

                    }
                    else if (userInput == 6)
                    {
                        Console.Clear();
                        TerminalMenu(status);
                    }


                } while (status.totalTrades > 5);
            }


            
                    
        }

        public static void Exit (Status status)
        {
            Console.WriteLine("Are you sure you want to exit the trade terminal and return to your ship? [Y / N]");
            var userInput = Console.ReadLine();

            if (userInput == "Y" || userInput == "y")
            {
                Console.Clear();
                Console.WriteLine( "Returning to ship");
                Status.ship(status);
            }else if (userInput == "N" || userInput == "n")
            {
                Console.Clear();
                TerminalMenu(status);
            }
        }
        static string Nagivation(Status status )
        {
            int index = 0;
            List<string> playerInventory = status.playerInventory;

            for (int i = 0; i < playerInventory.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(playerInventory[i]);

                }
                else
                {

                    Console.WriteLine(playerInventory[i]);

                }
                Console.ResetColor();

            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == playerInventory.Count - 1)
                {
                    index = 0;
                }
                else { index++; }

            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = playerInventory.Count - 1;

                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return playerInventory[index];
            }
            else
            {
                return "";
            }
            Console.Clear();
            return "";

        }
    }
}
