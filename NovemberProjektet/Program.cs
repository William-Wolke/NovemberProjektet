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


            PlayGame();
        }

        static void PlayGame(){

        }
    }
}
