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
           
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Credits: {currency}");

                Console.SetCursorPosition(50, 0);
                Console.WriteLine($"Welcome to the Trade Terminal {planet.name}");

                Console.SetCursorPosition(100, 0);

                //status.moveCounter();

                Console.WriteLine($"Moves remaining :{status.totalTrades}");

        }

        public static void Purchase(Status status)
        {
            (int, int) coordinates = status.coordinates;
           
           
           
            
            switch (coordinates)
            {
                case (183, 147):
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
                        Console.SetCursorPosition(100, 0);
                        Console.WriteLine($"Moves Remaining : {trades - 5}");

                        Console.SetCursorPosition(0, 2);
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
                            status.playerMoney -= highGradeFuel;
                            playerInventory.Add(terminalItems[0]);
                            Console.Clear();
                            Console.WriteLine("\n***High-Grade Fuel has been added to your inventory!***");
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine($"Credits: {status.playerMoney}");
                            Console.SetCursorPosition(100, 0);
                            Console.WriteLine($"Moves Remaining : {trades - 5}");
                        }
                        else if (userInput == 2)
                        {
                            status.playerMoney -= land;
                            playerInventory.Add(terminalItems[1]);
                            Console.Clear();
                            Console.WriteLine("\n***Alpha centuria land has been added to your inventory!***");
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine($"Credits: {status.playerMoney}");
                            Console.SetCursorPosition(100, 0);
                            Console.WriteLine($"Moves Remaining : {trades - 5}");
                        }
                        else if (userInput == 3)
                        {
                            status.playerMoney -= residents;
                            playerInventory.Add(terminalItems[2]);
                            Console.Clear();
                            Console.WriteLine("\n***An alpha centurian resident has been added to your inventory!***");
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine($"Credits: {status.playerMoney}");
                            Console.SetCursorPosition(100, 0);
                            Console.WriteLine($"Moves Remaining : {trades - 5}");
                        }
                        else if (userInput == 4)
                        {
                            status.playerMoney -= rifle;
                            playerInventory.Add(terminalItems[3]);
                            Console.Clear();
                            Console.WriteLine("\n***A rifle has been added to your inventory!***");
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine($"Credits: {status.playerMoney}");
                            Console.SetCursorPosition(100, 0);
                            Console.WriteLine($"Moves Remaining : {trades - 5}");
                        }
                        else if (userInput == 5)
                        {
                            status.playerMoney -= shipMissles;
                            playerInventory.Add(terminalItems[4]);
                            Console.Clear();
                            Console.WriteLine("\n ***Ship Missles have been added to your inventory!***");
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine($"Credits: {status.playerMoney}");
                            Console.SetCursorPosition(100, 0);
                            Console.WriteLine($"Moves Remaining : {trades - 5}");
                        }
                        else if (userInput == 5)
                        {
                            //place holder for option to return to terminal main menu
                        }
                    } while (trades > 5);


                    Console.Clear();
                    Console.WriteLine("\nYou are out of trades at this terminal, you are now being returned to your ship\n");
                    Console.WriteLine("Ship");
                    Status.ship(status);
                    break;
            }
        }

        public static void sell(Status status)
        {
            
            int currency = status.playerMoney;
                    
        }

        public static void Exit (Status status)
        {
            Console.WriteLine("Are you sure you want to exit the trade terminal and return to your ship? [Y / N]");
            var userInput = Console.ReadLine();

            if (userInput == "Y" || userInput == "y")
            {
                Console.WriteLine( "Returning to ship");
                Status.ship(status);
            }else if (userInput == "N" || userInput == "n")
            {
                TerminalMenu(status);
            }
        }
    }
}
