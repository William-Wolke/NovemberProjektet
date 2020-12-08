using System.Reflection.Metadata.Ecma335;
using System;

namespace NovemberProjektet
{
    public class Carrier: Boat
    {
        int length = 5;
        public Carrier(int xPos, int yPos)
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
