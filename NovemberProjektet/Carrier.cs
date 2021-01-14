//using System.Reflection.Metadata.Ecma335;
using System;

namespace NovemberProjektet
{
    class Carrier
    {
       int length;
        public string direction = "vertical";
        protected int xPos;
        protected int yPos;
        //public shipRotation;
        Random generator = new Random();

        public Carrier(int x, int y)
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
