using System;

namespace NovemberProjektet
{
    class Cruiser : Ship
    {
        public Cruiser(int i)
        {
            xPos = 0;
            yPos = 0;
            shipLength = 3;
            direction = "vertical";
            PlayerPlaceCruiser(xPos, yPos, shipLength, i);
        }

        static void PlayerPlaceCruiser(int xPos, int yPos, int shipLength, int i){
            bool finished = false;

            Console.WriteLine("Sätt ut dina skepp, det är " + shipLength +" rutor långt:");
            Console.WriteLine("Skriv din x kordinat sedan , y kordinat (x,y) inom intervallet 0 --> " + (10-shipLength));
            Console.WriteLine();
            //Sätta ut skeppen, slutar inte förens den är klar
            while (finished == false)
            {
                //Skriver ut båten och vilken längd den har så man vet hur man ska sätta ut den.
                Console.Write("Cruiser "+ (i+1) +"/" + 3 +" : ");
                string answer = Console.ReadLine();
                //Felhantering så att användaren skriver in en korrekt position x,y.
                if (answer.Contains(',')){
                    //splittar svaret så att man får svaret från kordinatsystem x,y till två positioner man kan stoppa in i en int[] array.
                    string[] answerSplit = answer.Split(',');
                    bool succesX = int.TryParse(answerSplit[0], out xPos);
                    bool succesY = int.TryParse(answerSplit[1], out yPos);

                    finished = CheckBounds(xPos, yPos, succesX, succesY, finished, shipLength);
                }
                else // feedback till användaren om vad som ska skrivas in.
                {
                    Console.WriteLine();
                    Console.WriteLine("Du måste ange 2 nuffror med kommateken mellan. Ex: 9,3");
                    Console.WriteLine();
                }
                
            }
            
        }

        static bool CheckBounds(int x, int y, bool succesX, bool succesY, bool finished, int shipLength) {
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
                            Console.WriteLine("Du har skapade skeppet");
                            return finished = true;
                        }
                        return false;
        } 
    }
}
