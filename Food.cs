using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Food : Piece
    {
        private enum type
        {           
            chilli = -50,
            eggplant = -25,
            apple = 5,
            banana = 10,
            strawberry = 15
        };
        type foodType;

        public Food(Random RandFood)
        {            
            FoodTypeGeneration(RandFood);
            width = 35;
            height = 35;
            x = RandFood.Next(0, Settings.windowsSizeX-width);
            y = RandFood.Next(0, Settings.windowsSizeY-height);           
            piece = new Rectangle(x, y, width, height);
        }
        
        //Generating random type of Food
        private void FoodTypeGeneration(Random RandFood)
        {
            switch (RandFood.Next(1, 6))
            {
                case 1:
                    foodType = type.chilli;
                    pieceImage = Properties.Resources.chilli;
                    break;
                case 2:
                    foodType = type.eggplant;
                    pieceImage = Properties.Resources.eggplant;
                    break;
                case 3:
                    foodType = type.apple;
                    pieceImage = Properties.Resources.apple;
                    break;
                case 4:
                    foodType = type.banana;
                    pieceImage = Properties.Resources.banana;
                    break;
                case 5:
                    foodType = type.strawberry;
                    pieceImage = Properties.Resources.strawberry;
                    break;
            }
        }
        public int getValue()
        {
            return (int)foodType;
        }
    }
}
