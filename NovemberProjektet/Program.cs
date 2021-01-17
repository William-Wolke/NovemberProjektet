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

            int shipLength = 0;

            Console.WriteLine("Sänka skepp");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
            //Gör arrays med alla skepptyper
            Carrier[] carriers = new Carrier[1];
            Battleship[] battleships = new Battleship[2];
            Cruiser[] cruisers = new Cruiser[3];
            Submarine[] submarines = new Submarine[4];
            Destroyer[] destroyers = new Destroyer[5];

            //Metod för att sätta ut sina skepp, tar med sig 
            PlayerPlaceCarriers(carriers, battleships, cruisers, submarines, destroyers, shipLength);
            PlayerPlaceBattleships(carriers, battleships, cruisers, submarines, destroyers, shipLength);
            PlayerPlaceCruisers(carriers, battleships, cruisers, submarines, destroyers, shipLength);
            PlayerPlaceSubmarines(carriers, battleships, cruisers, submarines, destroyers, shipLength);
            PlayerPlaceDestroyers(carriers, battleships, cruisers, submarines, destroyers, shipLength);
            /*//kör spelet
            PlayGame(player1, player2);*/
            Console.ReadLine();
        }

        static void PlayerPlaceCarriers(Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers, int shipLength){
            int xPos;
            int yPos;
            shipLength = Carrier.carrierLength;
            bool finished = false;

            Console.WriteLine("Sätt ut dina skepp, det är " + shipLength +" rutor långt:");
            Console.WriteLine("Skriv din x kordinat sedan , y kordinat (x,y) inom intervallet 0 --> " + (10-shipLength));
            Console.WriteLine();
            //Sätta ut skeppen, slutar inte förens den är klar
            while (finished == false)
            {
                for (int i = 0; i < carriers.Length; i++)
                {   //Skriver ut båten och vilken längd den har så man vet hur man ska sätta ut den.
                    Console.Write("Carrier "+ (i+1) +"/" + carriers.Length +" : ");
                    string answer = Console.ReadLine();
                    //Felhantering så att användaren skriver in en korrekt position x,y.
                    if (answer.Contains(',')){
                        //splittar svaret så att man får svaret från kordinatsystem x,y till två positioner man kan stoppa in i en int[] array.
                        string[] answerSplit = answer.Split(',');
                        bool succesX = int.TryParse(answerSplit[0], out xPos);
                        bool succesY = int.TryParse(answerSplit[1], out yPos);

                        finished = CheckBounds(xPos, yPos, succesX, succesY, finished, carriers, battleships, cruisers, submarines, destroyers, i, shipLength);
                    }
                    else // feedback till användaren om vad som ska skrivas in.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 9,3");
                        Console.WriteLine();
                    }
                }
            }
            
        }

        static void PlayerPlaceBattleships(Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers, int shipLength){
            int xPos;
            int yPos;
            shipLength = Battleship.battleshipLength;
            bool finished = false;

            Console.WriteLine("Sätt ut dina skepp, det är " + shipLength +" rutor långt:");
            Console.WriteLine("Skriv din x kordinat sedan , y kordinat (x,y) inom intervallet 0 --> " + (10-shipLength));
            Console.WriteLine();
            //Sätta ut skeppen, slutar inte förens den är klar
            while (finished == false)
            {
                for (int i = 0; i < battleships.Length; i++)
                {   //Skriver ut båten och vilken längd den har så man vet hur man ska sätta ut den.
                    Console.Write("Battleship "+ (i+1) +"/" + battleships.Length +" : ");
                    string answer = Console.ReadLine();
                    //Felhantering så att användaren skriver in en korrekt position x,y.
                    if (answer.Contains(',')){
                        //splittar svaret så att man får svaret från kordinatsystem x,y till två positioner man kan stoppa in i en int[] array.
                        string[] answerSplit = answer.Split(',');
                        bool succesX = int.TryParse(answerSplit[0], out xPos);
                        bool succesY = int.TryParse(answerSplit[1], out yPos);

                        finished = CheckBounds(xPos, yPos, succesX, succesY, finished, carriers, battleships, cruisers, submarines, destroyers, i, shipLength);
                    }
                    else // feedback till användaren om vad som ska skrivas in.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 9,3");
                        Console.WriteLine();
                    }
                }
            }   
        }

        static void PlayerPlaceCruisers(Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers, int shipLength){
            int xPos;
            int yPos;
            shipLength = Cruiser.cruiserLength;
            bool finished = false;

            Console.WriteLine("Sätt ut dina skepp, det är " + shipLength +" rutor långt:");
            Console.WriteLine("Skriv din x kordinat sedan , y kordinat (x,y) inom intervallet 0 --> " + (10-shipLength));
            Console.WriteLine();
            //Sätta ut skeppen, slutar inte förens den är klar
            while (finished == false)
            {
                for (int i = 0; i < cruisers.Length; i++)
                {   //Skriver ut båten och vilken längd den har så man vet hur man ska sätta ut den.
                    Console.Write("Battleship "+ (i+1) +"/" + cruisers.Length +" : ");
                    string answer = Console.ReadLine();
                    //Felhantering så att användaren skriver in en korrekt position x,y.
                    if (answer.Contains(',')){
                        //splittar svaret så att man får svaret från kordinatsystem x,y till två positioner man kan stoppa in i en int[] array.
                        string[] answerSplit = answer.Split(',');
                        bool succesX = int.TryParse(answerSplit[0], out xPos);
                        bool succesY = int.TryParse(answerSplit[1], out yPos);

                        finished = CheckBounds(xPos, yPos, succesX, succesY, finished, carriers, battleships, cruisers, submarines, destroyers, i, shipLength);
                    }
                    else // feedback till användaren om vad som ska skrivas in.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 9,3");
                        Console.WriteLine();
                    }
                }
            }   
        }

        static void PlayerPlaceSubmarines(Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers, int shipLength){
            int xPos;
            int yPos;
            shipLength = Submarine.submarineLength;
            bool finished = false;

            Console.WriteLine("Sätt ut dina skepp, det är " + shipLength +" rutor långt:");
            Console.WriteLine("Skriv din x kordinat sedan , y kordinat (x,y) inom intervallet 0 --> " + (10-shipLength));
            Console.WriteLine();
            //Sätta ut skeppen, slutar inte förens den är klar
            while (finished == false)
            {
                for (int i = 0; i < submarines.Length; i++)
                {   //Skriver ut båten och vilken längd den har så man vet hur man ska sätta ut den.
                    Console.Write("Battleship "+ (i+1) +"/" + submarines.Length +" : ");
                    string answer = Console.ReadLine();
                    //Felhantering så att användaren skriver in en korrekt position x,y.
                    if (answer.Contains(',')){
                        //splittar svaret så att man får svaret från kordinatsystem x,y till två positioner man kan stoppa in i en int[] array.
                        string[] answerSplit = answer.Split(',');
                        bool succesX = int.TryParse(answerSplit[0], out xPos);
                        bool succesY = int.TryParse(answerSplit[1], out yPos);

                        finished = CheckBounds(xPos, yPos, succesX, succesY, finished, carriers, battleships, cruisers, submarines, destroyers, i, shipLength);
                    }
                    else // feedback till användaren om vad som ska skrivas in.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 9,3");
                        Console.WriteLine();
                    }
                }
            }   
        }

        static void PlayerPlaceDestroyers(Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers, int shipLength){
            int xPos;
            int yPos;
            shipLength = Destroyer.destroyerLength;
            bool finished = false;

            Console.WriteLine("Sätt ut dina skepp, det är " + shipLength +" rutor långt:");
            Console.WriteLine("Skriv din x kordinat sedan , y kordinat (x,y) inom intervallet 0 --> " + (10-shipLength));
            Console.WriteLine();
            //Sätta ut skeppen, slutar inte förens den är klar
            while (finished == false)
            {
                for (int i = 0; i < destroyers.Length; i++)
                {   //Skriver ut båten och vilken längd den har så man vet hur man ska sätta ut den.
                    Console.Write("Battleship "+ (i+1) +"/" + destroyers.Length +" : ");
                    string answer = Console.ReadLine();
                    //Felhantering så att användaren skriver in en korrekt position x,y.
                    if (answer.Contains(',')){
                        //splittar svaret så att man får svaret från kordinatsystem x,y till två positioner man kan stoppa in i en int[] array.
                        string[] answerSplit = answer.Split(',');
                        bool succesX = int.TryParse(answerSplit[0], out xPos);
                        bool succesY = int.TryParse(answerSplit[1], out yPos);

                        finished = CheckBounds(xPos, yPos, succesX, succesY, finished, carriers, battleships, cruisers, submarines, destroyers, i, shipLength);
                    }
                    else // feedback till användaren om vad som ska skrivas in.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 9,3");
                        Console.WriteLine();
                    }
                }
            }   
        }

        static bool CheckBounds(int x, int y, bool succesX, bool succesY, bool finished, Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers, int i, int shipLength) {
            //Kollar så att positionen inte är out of bounds eller att skeppet inte får plats.
                        if (x < 0 || x > 10 - shipLength || y < 0 || y > 10)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du angav en korrdinat utanför spelfältet eller så får ditt skepp inte plats");
                            Console.WriteLine();
                            //kollar om x och y är värden som inte funkar, text etc.
                        }else if (!succesX || !succesY) //feedback till användaren
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 1,8");
                            Console.WriteLine();
                        }
                        else{ //Skeppet får plats och är innanför bounds.
                            CreateShip(i, carriers, battleships, cruisers, submarines, destroyers, x, y, shipLength);
                            Console.WriteLine("Du har skapade skeppet");
                            return finished = true;
                        }
                        return false;
        }

        static void CreateShip(int i,Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers, int x, int y, int shipLength){
            
            if (shipLength == 5)
            {
                carriers[i] = new Carrier(x, y);
            }
            else if (shipLength == 4)
            {
                battleships[i] = new Battleship(x, y);
            }
            else if (shipLength == 3)
            {
                cruisers[i] = new Cruiser(x, y);
            }
            else if (shipLength == 2)
            {
                submarines[i] = new Submarine(x, y);
            }
            else if (shipLength == 1)
            {
                destroyers[i] = new Destroyer(x, y);
            }
        }

        //För att porta spelet till andra plattformar så hade jag använt mig av unity. Unity skrivs också i C# vilket gör det lättare att byta till den plattformen
        //I unity hade man kunnat göra så att spelet kan komma till andra plattformar genom att t.ex. göra ett skärmtangentbord på skämen som man anger position i.
        //Eller göra en visuel spelplan som man navigerar med en kontroll, datormus, touchskärm och sätter ut skepp, dessa lösningar hade man kunnat spela på samung smart fridge eller xbox eller telefon eller något liknande.
        
        //För att göra koden otroligt mycket enklare att läsa och göra prestandan bättre för programmet och gjort det mindre så hade jag velat göra en metod som PLayerPlaceShips som hade gjort
        //istället för att ha en egen metod för den datatypen en universiell metod som hade tagit in olika datatyper i parametern och då kunnat göra samma jobb med mindre kod och bättre prestanda. 
    }
}