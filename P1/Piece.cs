namespace P1
{
    public class Piece
    {
        Player p;

        public Piece(int pn)
        {
            p = new Player(pn);
        }

        public char DrawPiece()
        {
            return p.DrawPlayer();
        }
    }
}