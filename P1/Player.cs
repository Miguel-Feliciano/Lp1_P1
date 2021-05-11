namespace P1
{
    public class Player
    {
        int pnum = 0;

        char p1 = (char)0x263a;
        char p2 = (char)0x263b;

        public Player(int n)
        {
            pnum = n;
        }

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