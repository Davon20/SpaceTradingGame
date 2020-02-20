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
                case (0, 0):
                    Planets.alphaCenturia(status);
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
