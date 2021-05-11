using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 10;

            bool turn = false;

            Board t = new Board();

            Dice[] d = new Dice[4];

            Piece[] pc1 = new Piece[7];
            Piece[] pc2 = new Piece[7];
            
            t.DrawBoard();
            Console.Write("Pieces P1:");
            for (int a = 0; a<7; a++)
            {
                pc1[a] = new Piece(1);
                Console.Write(pc1[a].DrawPiece() +" ");
               
            }
            Console.Write("Pieces P2:");
            for (int a = 0; a<7; a++)
            {
                pc2[a] = new Piece(2);
                Console.Write(pc2[a].DrawPiece() +" ");
               
            }
            
            Console.WriteLine();
            while (tmp-- >0)
            {
              if (turn)
              {
                  Console.WriteLine("Player 1 ");
              }  
              else
              {
                 Console.WriteLine("Player 2 "); 
              }
            d[0] = new Dice();
            Console.Write("Dice 1: " + d[0].RollDice() +" ");
            d[1] = new Dice();
            Console.Write("Dice 2: " + d[1].RollDice() +" ");
            d[2] = new Dice();
            Console.Write("Dice 3: " + d[2].RollDice() +" ");
            d[3] = new Dice();
            Console.Write("Dice 4: " + d[3].RollDice() +" ");

            //[TO DO] Switch plyer turn
            

            }
        }
    }
}
