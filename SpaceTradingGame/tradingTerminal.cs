using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame
{
    class tradingTerminal
    {
        public static void TerminalMenu()
        {
           Planets planet = new Planets();
            Status status = new Status();
            int currency = status.playerMoney;
           
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Credits: {currency}");

                Console.SetCursorPosition(50, 0);
                Console.WriteLine($"Welcome to the Trade Terminal {planet.name}");

                Console.SetCursorPosition(100, 0);

                //status.moveCounter();

                Console.WriteLine($"Moves remaining :{status.totalTrades}");

            

        }

        public static void Purchase()
        {
            Status status = new Status();
            int currency = status.playerMoney;
            (int, int) coordinates = status.coordinates;
            
            Planets.alphaCenturia();
            
           
            switch (coordinates)
            {
                case (0, 0):
                    Planets.alphaCenturia();
                    break;
                    
            }
            
 
           
        }

        public static void Sell()
        {
            Status status = new Status();
            int currency = status.playerMoney;
            (int, int) coordinates = status.coordinates;



            Status.Inventory(); 
            
        }

        public static void Exit ()
        {
            Console.WriteLine("Are you sure you want to exit the trade terminal and return to your ship? [Y / N]");
            var userInput = Console.ReadLine();

            if (userInput == "Y" || userInput == "y")
            {
                Console.WriteLine( "Returning to ship");
                Status.ship();
            }else if (userInput == "N" || userInput == "n")
            {
                TerminalMenu();
            }

            
        }
        public static void A1Purchase()
        {
            Planets.alphaCenturia();



            

        }
    }
}
