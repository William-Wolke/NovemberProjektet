using System.CodeDom.Compiler;
using System;

namespace NovemberProjektet
{
    public abstract class Boat
    {

        protected int length;
        
        public string direction = "vertical";

        protected int xPos;

        protected int yPos;

        //public shipRotation;

        private Random generator = new Random();

        public Boat()
        {
            //int randomRotation = generator.Next(0, 1);

            //length = 1;
        }

        public int BuildShip() {
            return 1;
        }
    }
}

    
