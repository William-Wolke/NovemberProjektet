using System;

namespace NovemberProjektet
{
    class Carrier : Ship
    {
        public static int carrierLength = 5;
        public Carrier(int x, int y)
        {
            xPos = x;
            yPos = y;
            length = carrierLength;
            direction = "vertical";
        }
    }
}
