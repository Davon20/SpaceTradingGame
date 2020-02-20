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
            //Planets planet = new Planets();
            //Planets.alphaCenturia();
            tradingTerminal.Purchase();
            //Status.ship(); 
            
            //Menu.UserMenu();
            //Console.SetCursorPosition(12, 2);
            //Console.Beep(); 
            //Console.WriteLine("Made some noise!");
            
            //Console.Beep();
            //Console.SetCursorPosition(12, 32);
            //Console.WriteLine("You made a noise!");

            //var earth = new Planets { name = "Earth" };
            //var playerStatus = new Status();

            //tradingTerminal.TerminalMenu(earth, playerStatus);

            /*Structure of Code: Objects -> Classses -> Methods 

             Project Classes: Strecth Goals                     
                Organizations(includes Characters):
                    - Space Police, Space Pirates, & Galatic Trading Federation
                    
                    
                    - Status: 
                        Novice(Arms Deals = $250k Credits, Taxes = 30%, Income = 100%, License = 5k Credits, Terminal Access = 10 Moves) 

                        Unlocks Arms Deals - 
                            Novice 
                                250k = Alpha Centuria 1
                                500k = Tattoine
                                750k = Alderan
                            Intermediate
                                1M = Sentinel 3 & September
                    
                    Merchandise: Explosives, Rifles, Pistols, Missiles 

                        Intermediate(Winnings: 1M, Taxes = 20%, Income = 200%, Terminal Access = 20 Moves)
                        Advanced(Winnings: 3M, Taxes = 10%, Income = 300%, Terminal Access = 30 Moves)

                 Trade Material - Land, Residents, Mining Tools, Jewels/Metals, Planet-based Items, Inter-Planet Foods
                 
                Intro - First Year No Player Interaction, No Counter 
                
                Post - Intro: Navigation System(Press Button) = Console Menu = Shows User Options

                Gameplay: 
                    5 Move/Year counter
                    For Loop 
                    Console.Clear(); Advance Story 
                    6 Moves = Reset

                    10 Moves Trading Terminal as Novice, 20 as Intermediate, 30 as Advanced  
                    1 Terminal per 5 Moves/Year
                    For Loop 
                    Console.Clear();
            */

        }
    }
}