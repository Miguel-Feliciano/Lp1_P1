using System;

namespace P1
{
    public class Dice
    {
        /// <summary>
        /// Possible dice positions and ASCII representation
        /// </summary>
        /// <returns></returns>
        char up = (char)0x25b2;

        char left = (char)0x25c4;

        char right = (char)0x25ba;

        char middle = (char)0x2666;

        int v = 0;

        /// <summary>
        /// Rolls the dice and returns the ASCII that represents the number it
        /// rolled
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Value of the dice
        /// </summary>
        /// <value></value>
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