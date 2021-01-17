using System;

namespace NovemberProjektet
{
    class Submarine : Ship
    {
        public static int submarineLength = 2;
        public Submarine(int x, int y)
        {
            xPos = x;
            yPos = y;
            length = submarineLength;
            direction = "vertical";
        }
    }
}
