using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    public class Snake
    {
        public Rectangle[] snakePiece;
        public Settings.Direction direction;
        private SolidBrush bodyBrush, headBrush;
        private int x, y, width, height, score, lives;
        Random RandPosition = new Random();
        public int GamePlayer { get; private set; }
        

        public Snake(int GamePlayerNr = 0)
        {
            GamePlayer = GamePlayerNr;
            snakePiece = new Rectangle[Settings.snakeStartSize[GamePlayer]];
            bodyBrush = new SolidBrush(Color.FromName(Settings.snakeColors[GamePlayer]));
            headBrush = new SolidBrush(Color.WhiteSmoke);
            x = Settings.snakeStartPositionX[GamePlayer];
            y = Settings.snakeStartPositionY[GamePlayer];
            direction = Settings.snakeDirections[GamePlayer];
            width = Settings.snakePartSizeX;
            height = Settings.snakePartSizeY;            
            lives = Settings.snakeLives;
            score = 0;

            //Setting beggining position of Snake parts
            for (int i = 0; i < snakePiece.Length; i++)
            {
                snakePiece[i] = new Rectangle(x, y, width, height);
                x -= width;
            }
        }

        //Choosing move direction of Snake
        public void move()
        {
            if (direction == Settings.Direction.Up) moveUp();
            if (direction == Settings.Direction.Down) moveDown();
            if (direction == Settings.Direction.Left) moveLeft();
            if (direction == Settings.Direction.Right) moveRight();
        }
        //Changing Snake head position
        private void moveUp()
        {
            changeSnakePiecesPosition();            
            snakePiece[0].Y -= height;
            if (snakePiece[0].Y < 0)
                snakePiece[0].Y = Settings.windowsSizeY;
        }
        private void moveDown()
        {
            changeSnakePiecesPosition();
            snakePiece[0].Y = (snakePiece[0].Y + height) % Settings.windowsSizeY;
        }
        private void moveLeft()
        {
            changeSnakePiecesPosition();
            snakePiece[0].X -= width;
            if (snakePiece[0].X < 0)
                snakePiece[0].X = Settings.windowsSizeX;
        }
        private void moveRight()
        {
            changeSnakePiecesPosition();
            snakePiece[0].X = (snakePiece[0].X + width) % Settings.windowsSizeY;
        }

        //Updating position of all Snake parts
        private void changeSnakePiecesPosition()
        {
            for (int i = snakePiece.Length - 1; i > 0; i--)
            {
                snakePiece[i] = snakePiece[i - 1];
            }
        }

        //Add score points for ate food
        private void addScorePoints(int points)
        {
            score += points;
            if (score < 0)
                score = 0;
        }

        //Drawing all Snake parts
        public void drawSnake(Graphics paper)
        {
            for (int i = 0; i < snakePiece.Length; i++)
            {
                if (i == 0)
                {
                    paper.FillEllipse(headBrush, snakePiece[i]);
                }
                else
                {
                    paper.FillEllipse(bodyBrush, snakePiece[i]);
                }
            }
        }
        

        //Eating food - growing snake
        public void eat(int points)
        {
            addScorePoints(points);
            int piecesBefore = snakePiece.Length;
            List<Rectangle> listPieces = snakePiece.ToList();
            listPieces.Add(new Rectangle(snakePiece[piecesBefore - 1].X, snakePiece[piecesBefore - 1].Y, width, height));
            snakePiece = listPieces.ToArray();
        }


        //Detecting collision head with body
        public void detectColission()
        {
            for (int i = 1; i < snakePiece.Length - 1; i++)
                if (snakePiece[0] == snakePiece[i])
                    loseLive();
        }


        //If collision with wall or other snake - snake is losing live
        public void loseLive()
        {
            if (lives > 1)
            {
                lives--;
                //set beginning position
                snakePiece[0].X = Settings.snakeStartPositionX[GamePlayer];
                snakePiece[0].Y = Settings.snakeStartPositionY[GamePlayer];
                direction = Settings.snakeDirections[GamePlayer];
            }
            else
               lives=0;
        }

        public int getScore()
        {
            return score;
        }

        public int getLifes()
        {
            return lives;
        }

        public bool isDead()
        {
            if (lives <= 0)
                return true;
            else
                return false;
        }
    }
}
