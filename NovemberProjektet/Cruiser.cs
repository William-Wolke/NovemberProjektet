using System;

namespace NovemberProjektet
{
    public class Cruiser: Boat
    {
        int length = 3;
        public Cruiser(int xPos, int yPos)
        {
            this.xPos = xPos;

            this.yPos = yPos;
            //int randomRotation = generator.Next(0, 1);

            //length = 1;
        }

        public int BuildShip() {
            return 1;
        }
    }
}
