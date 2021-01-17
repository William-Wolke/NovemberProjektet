using System;

namespace NovemberProjektet
{
    class Destroyer : Ship
    {
        public static int destroyerLength = 1;
        public Destroyer(int x, int y)
        {
            xPos = x;
            yPos = y;
            length = destroyerLength;
            direction = "vertical";
        }
    }
}
