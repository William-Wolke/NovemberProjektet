using System;

namespace NovemberProjektet
{
    public class Battleship : Ship
    {
        public static int battleshipLength = 4;
        public Battleship(int x, int y)
        {
            xPos = x;
            yPos = y;
            length = battleshipLength;
            direction = "vertical";
        }
    }
}
