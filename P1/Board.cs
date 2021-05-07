using System;


namespace P1
{
    public class Board
    {

        /// <summary>
        /// Array to contain the board
        /// </summary>
        private State[,] board;

        /// <summary>
        /// Draw Board 
        /// </summary>
        public void DrawBoard()
        {
            board = new State[3, 8];

            Square[] Squares = new Square[20];

            Console.Write("|");
            Squares[0] = new Square();
            Squares[0].SquareType = 1;
            Squares[0].PrintSquare();
            
            /*Console.WriteLine("|_|_|_|");
            Console.WriteLine("|_|_|_|");
            Console.WriteLine("|_|_|_|");
            Console.WriteLine("|_|_|_|");
            Console.WriteLine("  |_|  ");
            Console.WriteLine("  |_|  ");
            Console.WriteLine("|_|_|_|");
            Console.WriteLine("|_|_|_|");*/

        }


    }
    public class Square
    {
        /// <summary>
        /// 1 = On, 0 = Off
        /// </summary>
        int on = 1;
        int off = 0;
        
        /// <summary>
        /// 0 = no player, 1 = player 1, 2 = player 2
        /// </summary>
        int player = 0;

        /// <summary>
        /// special = free turn square, normal = normal square
        /// </summary>
        char special = (char)0xa9; 
        char normal = (char)0xff;

        int squareType;


        private void NormalSquares()
        {
             Console.Write(0xff.ToString("X2"));
        }

        private void SpecialSquares()
        {
            Console.Write(0xa9.ToString("X2"));
        }

        public int Player
        {
            get
            {
                return this.player;
            }
            set
            {
                this.player = value;
            }
        }

        public char Special
        {
            get
            {
                return this.special;
            }
            set
            {
                this.special = value;
            }
        }

        public char Normal
        {
            get
            {
                return this.normal;
            }
            set
            {
                this.normal = value;
            }
        }
        public int SquareType
        {
            get
            {
                return this.squareType;
            }
            set
            {
                this.squareType = value;
            }
        }
        public int On
        {
            get
            {
                return this.on;
            }
            set
            {
                this.on = value;
            }
        }
        public int Off
        {
            get
            {
                return this.off;
            }
            set
            {
                this.off = value;
            }
        }

        public Square()
        {
            this.Player = 0;
            this.squareType = 0;
            this.On = 1;

        }

        public void PrintSquare()
        {
            if ( squareType == 0)
            {
                this.NormalSquares();
            }
            else
            {
                this.SpecialSquares();
            }
        }


    }
}