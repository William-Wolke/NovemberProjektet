using System.Collections.Generic;
using System;

namespace NovemberProjektet
{
    class Program
    {
        /*enum rotation {
            Vertical,
            Horizontal
        }*/
        static void Main(string[] args)
        {
            //instansierar de båda spelarna
            Player player1 = new Player();
            Player player2 = new Player();

            Console.WriteLine("Sänka skepp");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
            //Gör arrays med alla skepptyper
            Carrier[] carriers = new Carrier[1];
            Battleship[] battleships = new Battleship[2];
            Cruiser[] cruisers = new Cruiser[3];
            Submarine[] submarines = new Submarine[4];
            Destroyer[] destroyers = new Destroyer[5];
            
            for (int i = 0; i < carriers.Length; i++)
            {   //Skapar en instans av alla carriers
                carriers[0] = new Carrier(i);
            } 
            for (int i = 0; i < battleships.Length; i++)
            {   //Skapar en instans av varje battleship
                battleships[i] = new Battleship(i);
            }
            for (int i = 0; i < cruisers.Length; i++)
            {
                cruisers[i] = new Cruiser(i);
            }
            for (int i = 0; i < submarines.Length; i++)
            {
                submarines[i] = new Submarine(i);
            }
            for (int i = 0; i < destroyers.Length; i++)
            {
                destroyers[i] = new Destroyer(i);
            }
        }
    }
}
            
        /*

        //För att porta spelet till andra plattformar så hade jag använt mig av unity. Unity skrivs också i C# vilket gör det lättare att byta till den plattformen
        //I unity hade man kunnat göra så att spelet kan komma till andra plattformar genom att t.ex. göra ett skärmtangentbord på skämen som man anger position i.
        //Eller göra en visuel spelplan som man navigerar med en kontroll, datormus, touchskärm och sätter ut skepp, dessa lösningar hade man kunnat spela på samung smart fridge eller xbox eller telefon eller något liknande.
        
        //För att göra koden otroligt mycket enklare att läsa och göra prestandan bättre för programmet och gjort det mindre så hade jag velat göra en metod som PLayerPlaceShips som hade gjort
        //istället för att ha en egen metod för den datatypen en universiell metod som hade tagit in olika datatyper i parametern och då kunnat göra samma jobb med mindre kod och bättre prestanda. 
        //Jag hade velat använda mig av en enum för om skeppet var vertical eller horizontal, detta hade gjort det lättare när man kodade då man inte kan skriva stringen fel utan istället haft en boolliknande variabel,
        //i eftertanke hade man kunnat göra en bool som heter isHorizontal som antingen är true eller false, det hade varit en mycket enklare lösning... 
    }
}*/