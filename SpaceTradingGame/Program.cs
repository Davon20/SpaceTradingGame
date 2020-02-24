using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Enumeration;
using System.Threading; 


namespace SpaceTradingGame
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Status status = new Status();
            Menu menu = new Menu();
            Menu.UserMenu();

            Status status = new Status();
            Status.ship(status);            
        }
        
    }
}