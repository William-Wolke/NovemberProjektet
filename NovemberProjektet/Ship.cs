using System;

namespace NovemberProjektet
{
    public class Ship
    {
        //get set, alla klasser som ärver får variabeln och får själv seta den.
        public int shipLength {get; set;}
        protected string direction {get; set;}
        protected int xPos {get; set;}
        protected int yPos {get; set;}
    }
}
