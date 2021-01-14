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
            //Metod för att sätta ut sina skepp, tar med sig 
            PlayerPlaceShips(carriers, battleships, cruisers, submarines, destroyers);
            //kör spelet
            PlayGame(player1, player2);
        }

        static void PlayerPlaceShips(Carrier[] carriers, Battleship[] battleships, Cruiser[] cruisers, Submarine[] submarines, Destroyer[] destroyers){
            int x;
            int y;
            bool finished = false;


            Console.WriteLine("Sätt ut dina skepp:");
            Console.WriteLine("Skriv din x kordinat sedan , y kordinat (x,y) inom intervallet 0 --> 10");
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
                        bool succesX = int.TryParse(answerSplit[0], out x);
                        bool succesY = int.TryParse(answerSplit[1], out y);

                        CheckBounds(x, y, succesX, succesY, finished);
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

        static void CheckBounds(int x, int y, bool succesX, bool succesY, bool finished) {
            //Kollar så att positionen inte är out of bounds
                        if (x < 0 || x > 10 || y < 0 || y > 10)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du angav en korrdinat utanför spelfältet");
                            Console.WriteLine();
                            //kollar om x och y är värden som inte funkar så ger man feedback
                        }else if (!succesX || !succesY) //feedback till användaren
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 1,8");
                            Console.WriteLine();
                        }
                        else{ //
                            carriers[i] = new Carrier(x, y);
                            Console.WriteLine("Du har skapat alla carriers");
                            Console.ReadLine();
                            finished = true;
                        }
        }

        static void PlayGame(Player player1, Player player2){
            
            /*for (int i = 0; i < players.ships.GetLength(0); i++)
            {
                for (int j = 0; j < players.ships.GetLength(0); j++)
                {
                    Console.Write(players.ships[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

        }
    }
}
