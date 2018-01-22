using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Piece
    {
        protected int x, y;
        protected int width, height;
        protected Image pieceImage;
        public Rectangle piece;

        public Piece()
        {

        }        

        public void drawBonus(Graphics paper)
        {
            piece.X = x;
            piece.Y = y;            
            paper.DrawImage(pieceImage, piece);
        }
    }
}
