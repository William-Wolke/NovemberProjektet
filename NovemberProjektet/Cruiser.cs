using System;

namespace NovemberProjektet
{
    class Cruiser : Ship
    {
        public static int cruiserLength = 3;
        public Cruiser(int x, int y)
        {
            xPos = x;
            yPos = y;
            length = cruiserLength;
            direction = "vertical";
        } 
    }
}
