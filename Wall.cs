using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;

namespace Snake
{
    class Wall
    {
        public Rectangle[] wallPieces;
        protected int width, height;
        protected Image pieceImage;        

        public Wall(int level = 1)
        {
            width = Settings.wallPartSizeXY;
            height = Settings.wallPartSizeXY;
            pieceImage = Properties.Resources.wall;
            readLevel();
        }

        //Reading wall coordinates from file
        private void readLevel()
        {
            XmlDocument XmlDoc = new XmlDocument();                       
            XmlDoc.Load(@"..\..\Resources\levels.xml");            
            int Count = XmlDoc.GetElementsByTagName("kostka").Count;
            wallPieces = new Rectangle[Count];            


            for (int i = 0; i < Count; i++)
            {
                wallPieces[i].X = Convert.ToInt32(XmlDoc.GetElementsByTagName("x").Item(i).InnerText)* width;
                wallPieces[i].Y = Convert.ToInt32(XmlDoc.GetElementsByTagName("y").Item(i).InnerText)* height;
                wallPieces[i].Width = width;
                wallPieces[i].Height = height;               
            }
        }

        public void drawBonus(Graphics paper)
        {
            foreach (Rectangle wallPiece in wallPieces)           
            paper.DrawImage(pieceImage, wallPiece);
        }
    }
}
