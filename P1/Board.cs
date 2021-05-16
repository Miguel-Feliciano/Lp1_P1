using System;


namespace P1
{
    public class Board
    {
        Square[] Squares = new Square[20];
        Square[] FakeSquares = new Square[4];
        /// <summary>
        /// Array to contain the board
        /// </summary>

        public Square[] GetSquares()
        {
            return Squares;
        }

        /// <summary>
        /// Draw Board 
        /// </summary>
        public void DrawBoard()
        {

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
        /// <summary>
        /// Positions that each player can move to 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Idx(int id)
        {
            switch (id)
            {
                case 9: return 6;
                case 6: return 3;
                case 3: return 0;
                case 0: return 1;
                case 11: return 8;
                case 8: return 5;
                case 5: return 2;
                case 2: return 1;
                case 1: return 4;
                case 4: return 7;
                case 7: return 10;
                case 10: return 13;
                case 13: return 16;
                case 16: return 19;
                case 19: return 22;
                case 22: return 21;
                case 21: return 18;
                case 18: return 100;

            }
            return -1;
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

        /// <summary>
        /// Returns what type of square it is on the board
        /// </summary>
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
        /// <summary>
        /// Gets and sets the value of the player, special and normal squares,
        /// the square type and if its on or off
        /// </summary>
        /// <value></value>

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
        /// <summary>
        /// Created a value for the player and for the squares that can say
        /// if it is on or off, specially for the squares that can't exist
        /// </summary>
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