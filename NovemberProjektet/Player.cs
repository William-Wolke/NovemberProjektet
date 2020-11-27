using System;

namespace NovemberProjektet
{
    public class Player
    {
        int[,] board = new int[10,10];

        int[,] ships = new int[10, 10];

        public int[,] placeShipps(){
            return ships;
        }
    }
}
