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
            Square[] FakeSquares = new Square[4];

            int ix = 0;

            int fix = 0;

                    //Line 1
                    Console.Write("|");
                    Squares[ix] = new Square(1);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(1);
                    Squares[ix++].PrintSquare();
                    Console.WriteLine("|");
                    //Line 2
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.WriteLine("|");
                    //Line 3
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.WriteLine("|");
                    //Line 4
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(1);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.WriteLine("|");
                    //Line 5
                    Console.Write("  ");
                    FakeSquares[fix] = new Square(2);
                    FakeSquares[fix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    FakeSquares[fix] = new Square(2);
                    FakeSquares[fix++].PrintSquare();
                    Console.WriteLine(" ");
                    //Line 6
                    Console.Write("  ");
                    FakeSquares[fix] = new Square(2);
                    FakeSquares[fix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    FakeSquares[fix] = new Square(2);
                    FakeSquares[fix++].PrintSquare();
                    Console.WriteLine(" ");
                    //Line 7
                    Console.Write("|");
                    Squares[ix] = new Square(1);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(1);
                    Squares[ix++].PrintSquare();
                    Console.WriteLine("|");
                    //Line 8
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.Write("|");
                    Squares[ix] = new Square(0);
                    Squares[ix++].PrintSquare();
                    Console.WriteLine("|");

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
        char special = (char)0x40;
        char normal = (char)0xfe;

        char fake = (char)0x00;

        int squareType;


        private void NormalSquares()
        {
            Console.Write(normal);
        }

        private void SpecialSquares()
        {
            Console.Write(special);
        }

        private void FakeSquares()
        {
            Console.Write(fake);
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
        public Square(int t)
        {
            squareType = t;
        }

        public void PrintSquare()
        {
            if (squareType == 0)
            {
                this.NormalSquares();
            }
            else if (squareType == 1)
            {
                this.SpecialSquares();
            }
            else
            {
                this.FakeSquares();
            }
        }


    }
}