using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SpaceTradingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Status status = new Status();
            Status.ship(status);
            tradingTerminal.TerminalMenu(status);

            
        }
    }
}