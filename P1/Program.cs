using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 10;

            bool turn = false;

            char option;

            bool scored = false;

            /// <summary>
            /// Calls the Board
            /// </summary>
            /// <returns></returns>
            Board t = new Board();
            /// <summary>
            /// Array for the dice
            /// </summary>
            Dice[] d = new Dice[4];
            /// <summary>
            /// Arrays for the pieces of both players
            /// </summary>
            Piece[] pc1 = new Piece[7];
            Piece[] pc2 = new Piece[7];

            Square[] squares = t.GetSquares();

            // Initial instructions for the players

            Console.WriteLine("Welcome to Royal Game of Ur!");
            Console.WriteLine();
            Console.WriteLine("The rules are simple, make all your seven " +
            "pieces reach the end of the board. The player rolls 4 dice, the " +
             "diamond shape signifies 1 move wile the arrows signify " +
             "no move.");
            Console.WriteLine("The special squares award " +
           "the player with an extra turn and prevent the player from " +
            "getting his piece eaten.  ");
            Console.WriteLine();
            Console.WriteLine("Have Fun!");
            Console.WriteLine();

            
            t.DrawBoard();
            Console.Write("Pieces Player 1:");
            for (int a = 0; a < 7; a++)
            {
                pc1[a] = new Piece(1);
                Console.Write(pc1[a].DrawPiece() + " ");

            }
            Console.Write("Pieces Player 2:");
            for (int a = 0; a < 7; a++)
            {
                pc2[a] = new Piece(2);
                Console.Write(pc2[a].DrawPiece() + " ");

            }

            Console.WriteLine();
            while (tmp-- > 0)
            {
                int whichplayer = 0;
                if (turn)
                {
                    Console.WriteLine("Player 1 ");
                    whichplayer = 1;
                }
                else
                {
                    Console.WriteLine("Player 2 ");
                    whichplayer = 2;
                }


                // Asks the player to play, if yes play, if no quit the game

                Console.WriteLine("\n\nPlayer {0} roll? y/n", (turn) ? 1 : 2);

                option = Convert.ToChar(Console.ReadLine());
                if (option == 'n')
                {
                    Console.WriteLine("Are you sure you want to quit? y/n");
                    if (Console.ReadLine() == "y")
                    {
                        break;
                    }
                }
                /// <summary>
                /// Rolls 4 dice and prints the corresponding ASCII character
                /// </summary>
                /// <returns></returns>
                d[0] = new Dice();
                Console.Write("Dice 1: " + d[0].RollDice() + " ");
                d[1] = new Dice();
                Console.Write("Dice 2: " + d[1].RollDice() + " ");
                d[2] = new Dice();
                Console.Write("Dice 3: " + d[2].RollDice() + " ");
                d[3] = new Dice();
                Console.WriteLine("Dice 4: " + d[3].RollDice() + " ");

                /// <summary>
                /// Tells the player how many spaces he can move
                /// depending on the rolls
                /// </summary>
                int add = d[0].V + d[1].V + d[2].V + d[3].V;
                Console.WriteLine($"You can move {add}:");

                // Player plays, if not, go for the next player 
                Console.WriteLine("Want to move a piece in to the board? y/n");
                option = Convert.ToChar(Console.ReadLine());
                if (option == 'y')
                {
                    int ix = 0;
                    for (; ix < 7; ix++)
                    {
                        if (whichplayer == 1) // player 1
                        {
                            if (pc1[ix].Position == -1) // got it!
                            {
                                break;
                            }
                        }
                        else if (whichplayer == 2) // player 1
                        {
                            if (pc2[ix].Position == -1) // got it!
                            {
                                break;
                            }


                        }
                    }
                    /// <summary>
                    /// Cheks the position of the initial piece of both players,
                    /// puts changes its index according to the player
                    /// Rolls the dice if it lands on a special tile
                    /// If the piece is on the board, it tells its index
                    /// </summary>

                    int pos = -1;

                    if (whichplayer == 1)
                    {
                        pos = 9;
                        while (--add > 0)
                        {
                            pos = t.Idx(9);
                        }
                        pc1[ix].Position = pos;
                    }
                    else 
                    {
                        pos = 11;
                        while (--add > 0)
                        {
                            pos = t.Idx(11);   
                        }
                        pc2[ix].Position = pos;
                    }

                    Console.WriteLine("pos" + pos);
                    
                    
                    if (squares[pos].SquareType == 1)
                    {
                        d[0] = new Dice();
                        Console.Write("Dice 1: " + d[0].RollDice() + " ");
                        d[1] = new Dice();
                        Console.Write("Dice 2: " + d[1].RollDice() + " ");
                        d[2] = new Dice();
                        Console.Write("Dice 3: " + d[2].RollDice() + " ");
                        d[3] = new Dice();
                        Console.WriteLine("Dice 4: " + d[3].RollDice() + " ");
                    }
                }
                else
                {
                    if (whichplayer == 1)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            if (pc1[i].Position > -1)
                            {
                                Console.WriteLine("Piece {0}: position {1}", 
                                i+1, pc1[i].Position );
                            }
                            
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            if (pc2[i].Position > -1)
                            {
                                Console.WriteLine("Piece {0}: position {1}", 
                                i+1, pc2[i].Position );
                            }
                            
                        }
                    }
                }
                // Prints the board again
                t.DrawBoard();
                //Next player plays
                turn = !turn;
            }
        }
    }
}
