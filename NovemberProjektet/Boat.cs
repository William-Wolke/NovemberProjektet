using System.CodeDom.Compiler;
using System;

namespace NovemberProjektet
{
    public class Boat
    {
        enum rotation {
            Vertical,
            Horizontal
        }
        public int length;
        
        public string direction = "vertical";

        public shipRotation = rotation.Vertical;

        private Random generator = new Random();
    }

    public Boat()
    {
        int randomRotation = generator.Next()
    }
}
