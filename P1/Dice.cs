using System;

namespace P1
{
    public class Dice
    {
        /// <summary>
        /// Possible dice positions
        /// </summary>
        /// <returns></returns>
        char up = (char)0x25b2;

        char left = (char)0x25c4;

        char right = (char)0x25ba;

        char middle = (char)0x2666;

        int v = 0;


        public char RollDice()
        {
            var rnd = new Random();

            int r = rnd.Next(0,4);
            
            switch (r)
            {
                case 0: return (up);
                case 1: return (left);
                case 2: return (right);
                case 3:
                {
                    v = 1; 
                    return (middle);
                }
            }
            return '/';
        }
        public int V
        {
            get
            {
                return this.v;
            }
            set
            {
                this.v = value;
            }
        }
    }
}