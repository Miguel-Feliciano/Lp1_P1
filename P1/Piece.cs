namespace P1
{
    public class Piece
    {
        Player p;
        int position = -1;

        /// <summary>
        /// Creates Piece, gets and sets its position and draws it 
        /// </summary>
        /// <param name="pn"></param>
        public Piece(int pn)
        {
            p = new Player(pn);
        }
        /// <summary>
        /// Returns the piece according to the player
        /// </summary>
        /// <returns></returns>

        public char DrawPiece()
        {
            return p.DrawPlayer();
        }
        // Indice de entrada do p1 = 10 e p2 = 12

        public int Position
        {
          get
          {
              return this.position;
          }  
          set
          {
              this.position = value;
          }
        }

        /// <summary>
        /// Value given if the piece is killed 
        /// </summary>
        public void killPiece()
        {
            position = -1;
        }



    }
}