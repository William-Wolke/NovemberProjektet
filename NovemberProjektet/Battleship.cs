using System;

namespace NovemberProjektet
{
    public class Battleship: Boat
    {
        int length = 4;
        public Battleship(int xPos, int yPos)
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