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



                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Credits: {status.playerMoney}");

                Console.SetCursorPosition(50, 0);
                Console.WriteLine($"Welcome to the Trade Terminal {planet.name}");

                Console.SetCursorPosition(100, 0);

                //status.moveCounter();

                Console.WriteLine($"Moves remaining :{status.totalTrades}");
            Purchase();

                
          

            
            

        }

        public static void Purchase()
        {
            Status status = new Status();
            int currency = status.playerMoney;
            Planets.alphaCenturia();
            

           
        }

        public static void sell()
        {
            Status status = new Status();
            int currency = status.playerMoney;

            
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
                // return to trade terminal menu
            }

            
        }
       
    }
}
