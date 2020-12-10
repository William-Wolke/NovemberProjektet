using System.Collections.Generic;
using System;

namespace NovemberProjektet
{
    class Program
    {
        enum rotation {
            Vertical,
            Horizontal
        }
        static void Main(string[] args)
        {
            //instansierar de båda spelarna
            Player player1 = new Player();
            Player player2 = new Player();
            
            Console.WriteLine("Sänka skepp");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();

            Carrier[] carriers = new Carrier[1];
            Battleship[] battleships = new Battleship[2];
            Cruiser[] cruisers = new Cruiser[3];
            Submarine[] submarines = new Submarine[4];
            Destroyer[] destroyers = new Destroyer[5];
            
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
            while (finished == false)
            {
                for (int i = 0; i < carriers.Length; i++)
                {
                    Console.Write("Carrier "+ (i+1) +"/" + carriers.Length +" : ");
                    string answer = Console.ReadLine();

                    if (answer.Contains(',')){
                        string[] answerSplit = answer.Split(',');
                        bool succesX = int.TryParse(answerSplit[0], out x);
                        bool succesY = int.TryParse(answerSplit[1], out y);

                        if (x < 0 || x > 10 || y < 0 || y > 10)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du angav en korrdinat utanför spelfältet");
                            Console.WriteLine();
                        }else if (!succesX || !succesY)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 1,8");
                            Console.WriteLine();
                        }
                        else{
                            carriers[i] = new Carrier(x, y);
                            Console.WriteLine("Du har skapat alla carriers");
                            Console.ReadLine();
                            finished = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 9,3");
                        Console.WriteLine();
                    }
                }
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
