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
            int currency = status.playerMoney;
           
           
                
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

                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;

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
                } while (trades > 5);

              
                    Console.Clear();
                    Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
                    Console.WriteLine("Ship");
                    Status.ship(status);
               

            }else if (coordinates == (250,140)) //Tattooine
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;

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
                } while (trades > 5);


                Console.Clear();
                Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
                Console.WriteLine("Ship");
                Status.ship(status);
            }else if (coordinates == (164,300))//Alderan
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;

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
                } while (trades > 5);


                Console.Clear();
                Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
                Console.WriteLine("Ship");
                Status.ship(status);
            }else if (coordinates == (354,256)) // Sentinel
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;

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
                } while (trades > 5);


                Console.Clear();
                Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
                Console.WriteLine("Ship");
                Status.ship(status);
            }else if (coordinates == (496,532))// September
            {
                int currency = status.playerMoney;
                int trades = status.totalTrades;
                List<string> playerInventory = status.playerInventory;

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
                } while (trades > 5);


                Console.Clear();
                Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
                Console.WriteLine("Ship");
                Status.ship(status);
            }
        }

        public static void Sell(Status status)
        {
            int highGradeFuel = 6000;
            int shipMissles = 6000;
            int lowGradeFuel = 2000;
            int rareMetals = 7000;
            int vitaminWater = 1000;
            int upgradedNavigationSystem = 6000;
            int virtualGameStation = 8000;
            int halfThePlanet = 150000;
            
            List<string> playerInventory = status.playerInventory;

            int[] gameItems = new int[]
            {status.fruit,status.meat, status.jewels,status.rifles,status.pistols,status.explosives,status.missiles, status.land, highGradeFuel,status.residents, status.miningTools,
             shipMissles, lowGradeFuel,  rareMetals, vitaminWater, upgradedNavigationSystem,virtualGameStation, halfThePlanet, };

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
                    for (int i = 0; i < playerInventory.Count; i++)
                    {

                        Console.Write($"{i + 1}) {playerInventory[i]}: ");
                        Console.WriteLine(gameItems[i]*2);

                    }
                    Console.WriteLine("6) Return to Trade Terminal Main Menu");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    --status.totalTrades;

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
    }
}
