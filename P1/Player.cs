namespace P1
{
    public class Player
    {
        int pnum = 0;

        char p1 = (char)0x263a;
        char p2 = (char)0x263b;

        /// <summary>
        /// Creates player and draws it with with ASCII character
        /// </summary>
        /// <param name="n"></param>
        public Player(int n)
        {
            pnum = n;
        }
        /// <summary>
        /// Checks the value of the player and returns the right on accordingly
        /// </summary>
        /// <returns></returns>
        public char DrawPlayer()
        {
            if (pnum == 1)
            {
                return p1;
            }
            else
            {
                return p2;
            }
        }
    }
}