using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Game
    {
        private Random randFood = new Random();
        private List<Food> food = new List<Food>();
        private Wall wall = new Wall();
        private int count = 0;
        public Snake[] snakes;
        int _players = Settings.gamePlayers;
        int gameType = 0;
        int nr = 0;

        public Game(int playType)
        {
            gameType = playType;
            snakes = new Snake[_players];
            GameFormm.counter = Settings.timePlayValue;
            //creating snakes;
            for (int i = 0; i < _players; i++)
            {
                snakes[i] = new Snake(i);
            }       

            //creating food
            while (food.Count < Settings.foodNumberInit)
            {
                food.Add(new Food(randFood));
            }            
        }


        //Draw all pieces of graphics on board
        public void drawBoard(Graphics paper)
        {
            foreach (Snake nr in snakes) nr.drawSnake(paper);
            foreach (Food foo in food) foo.drawBonus(paper);
            wall.drawBonus(paper);
        }

        //Move the snakes
        public void move()
        {
            foreach (Snake snake in snakes) snake.move();
        }

        //Update scores
        public void updateScores(Label[] lScore)
        {
            for (int i = 0; i < snakes.Length; i++)
            {
                nr = snakes[i].GamePlayer;
                lScore[nr].Text = snakes[i].getScore().ToString();
            }
        }

        //Update lifes
        public void updateLifes(Label[] lLife)
        {
            for (int i = 0; i < snakes.Length; i++)
            {
                nr = snakes[i].GamePlayer;
                lLife[nr].Text = snakes[i].getLifes().ToString();
            }
        }

        //Generating food parts on board
        public void foodReGenerate()
        {
            int x = randFood.Next(1, 16);
            if (food.Count > Settings.foodNumberInit)
            {
                if (x % 5 == 0)
                    food.Add(new Food(randFood));
                if (x % 15 == 0)
                    food.RemoveAt(0);
            }
            else
                food.Add(new Food(randFood));
        }

        //Check if user click Any of Snake Control Button 
        public void control(Keys key)
        {
            for (int i = 0; i < snakes.Length; i++)
            {
                nr = snakes[i].GamePlayer;
                if (key == Settings.snakeDownKey[nr] && snakes[i].direction != Settings.Direction.Up) snakes[i].direction = Settings.Direction.Down;
                if (key == Settings.snakeUpKey[nr] && snakes[i].direction != Settings.Direction.Down) snakes[i].direction = Settings.Direction.Up;
                if (key == Settings.snakeLeftKey[nr] && snakes[i].direction != Settings.Direction.Right) snakes[i].direction = Settings.Direction.Left;
                if (key == Settings.snakeRightKey[nr] && snakes[i].direction != Settings.Direction.Left) snakes[i].direction = Settings.Direction.Right;
            }
        }        

        //Checking for collisions on board
        public void checkCollision()
        {
            foreach (Snake snake in snakes)
            {
                // --- Detect colission with food
                for (int i = 0; i < snake.snakePiece.Length; i++)
                {
                    for (int k = 0; k < food.Count; k++)
                    {
                        if (snake.snakePiece[i].IntersectsWith(food[k].piece))
                        {
                            snake.eat(food[k].getValue());
                            food.RemoveAt(k);
                        }
                    }
                }

                // --- Detect colission with walls           
                for (int i = 0; i < wall.wallPieces.Length; i++)
                {
                    if (snake.snakePiece[0].IntersectsWith(wall.wallPieces[i]))
                        snake.loseLive();
                }

                // --- Detect colission with other snakes
                for (int i = 0; i < snakes.Length; i++) //for every other snake
                {
                    if (i != count) //if snake is not actual  main snake                    
                        for (int p = 0; p < snakes[i].snakePiece.Length; p++)
                        {
                            if (snake.snakePiece[0].IntersectsWith(snakes[i].snakePiece[p]))
                                snake.loseLive();
                        }
                }
                
                snake.detectColission();
               
               
                count++;
            }
            count = 0;
        }

        public static void RemoveAt<T>(ref T[] snakes, int index)
        {
            for (int a = index; a < snakes.Length - 1; a++)
            {
                // moving elements downwards, to fill [index]
                snakes[a] = snakes[a + 1];
            }
            // resize array -1
            Array.Resize(ref snakes, snakes.Length - 1);
        }

        public bool checkEndGame()
        {
            bool end = false;

            //FREE PLAY - game ends when all snakes are ded
            if (gameType == 1)
            {
                for (int i = 0; i < snakes.Length; i++)
                {
                    if (snakes[i].isDead() == true) //if actual snake is ded
                    {
                        RemoveAt(ref snakes, i);
                        if (snakes.Length == 0)
                        {
                            end = true;                            
                        }
                        break;

                    }
                }
            }
            //VERSUS PLAY - game ends when only 1 snake left on board
            if (gameType == 3)
            {
                for (int i = 0; i < snakes.Length; i++)
                {
                    if (snakes[i].isDead() == true) //if actual snake is alive
                    {
                        RemoveAt(ref snakes, i);
                        if (snakes.Length <= 1)
                        {
                            end = true;
                            break;
                        }

                    }
                }
            }

            //TIME PLAY - game ends when only all snakes are ded OR Timer Stopped
            if (gameType == 2)
            {
                //if all snakes are ded
                for (int i = 0; i < snakes.Length; i++)
                {
                    if (snakes[i].isDead() == true) //if actual snake is alive
                    {
                        RemoveAt(ref snakes, i);
                        if (snakes.Length == 0)
                        {
                            end = true;
                            break;
                        }

                    }
                }

                //if time ended
                if ( GameFormm.counter <= 0)
                    end = true;
            }
            return end;
        }    
        
        
            
    }
}
