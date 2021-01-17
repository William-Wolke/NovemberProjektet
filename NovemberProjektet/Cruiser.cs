using System;

namespace NovemberProjektet
{
    class Cruiser
    {
        int length;
        public string direction = "vertical";
        protected int xPos;
        protected int yPos;
        //public shipRotation;
        Random generator = new Random();

        

        public int[,] BuildShip() {

            int[,] shipPosition = new int[10,10];  

            shipPosition[generator.Next(0, 10), generator.Next(0, 10)] = 1;

            return shipPosition;
        } 
    }
}
