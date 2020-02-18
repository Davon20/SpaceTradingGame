using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame
{
    class tradingTerminal
    {
        public static void TerminalMenu(Planets planet, Status status)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Credits: {status.playerMoney}");

            Console.SetCursorPosition(50, 0);
            Console.WriteLine($"Welcome to the Trade Terminal {planet.name}");

            Console.SetCursorPosition(105, 0);

            status.moveCounter();

            Console.WriteLine($"Moves left: {status.moves}");

        }

        public static void Purchase()
        {

        }

        public static void sell()
        {

        }

        public static void Exit ()
        {

        }
       
    }
}
