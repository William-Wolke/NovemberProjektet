using System;

namespace NovemberProjektet
{
    class Submarine
    {
       int length;
        public string direction = "vertical";
        protected int xPos;
        protected int yPos;
        //public shipRotation;
        protected Random generator = new Random();

        public Boat()
        {
            //int randomRotation = generator.Next(0, 1);

            //length = 1;
        }

        public int[,] BuildShip() {

            int[,] shipPosition = new int[10,10];  

            shipPosition[generator.Next(0, 10), generator.Next(0, 10)] = 1;

            return shipPosition;
        } 
    }
}
