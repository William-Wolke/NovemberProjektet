using System;

namespace NovemberProjektet
{
    public abstract class Ship
    {
        //get set, alla klasser som ärver får variabeln och får själv seta den.
        public int length {get; set;}
        protected string direction {get; set;}
        public int xPos {get; set;}
        public int yPos {get; set;}
    }
}
