using System;

namespace NovemberProjektet
{
    public class Player
    {
        int[,] board = new int[10,10];

        public void DrawBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    
                    Console.Write("["+board[i, j]+ "] ");
                }
                Console.WriteLine();
            }
        }

        public int[,] PlaceShipOnBoard(){
            
            return board;
        }

        
    }
}

    
