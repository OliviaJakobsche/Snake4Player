using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Settings
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        };

        public static bool playSound = false;
        public static int gamePlayers = 1;
        public static int windowsSizeX = 740;
        public static int windowsSizeY = 740;
        public static int scaleFactor = 50;
        public static int snakeLives = 2;
        public static int foodNumberInit = 5;
        public static int timePlayValue = 120;
        public static int snakePartSizeX = windowsSizeX / scaleFactor;
        public static int snakePartSizeY = windowsSizeX / scaleFactor;
        public static int wallPartSizeXY = (2*windowsSizeX / scaleFactor);
        public static int[] snakeStartPositionX = new int[] { scaleFactor*2, windowsSizeX - scaleFactor*2, scaleFactor*2, windowsSizeX - scaleFactor*2};
        public static int[] snakeStartPositionY = new int[] { scaleFactor*2, scaleFactor*2, windowsSizeY-scaleFactor*2, windowsSizeY - scaleFactor*2 };
        public static int[] snakeStartSize = new int[] { 3, 3, 3, 4 };
        public static string[] snakeColors = new string[] { "red", "yellow", "green", "blue" };
        public static Direction[] snakeDirections = new Direction[] { Direction.Down, Direction.Down, Direction.Up, Direction.Up };



        //Key Control settings
        //Player1 -> arrows; Player2 -> WSAD, Player3 - IKJL, Player 4 - Nums 8546 
        public static System.Windows.Forms.Keys[] snakeUpKey = new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.W, System.Windows.Forms.Keys.I, System.Windows.Forms.Keys.NumPad8 };
        public static System.Windows.Forms.Keys[] snakeDownKey = new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.S, System.Windows.Forms.Keys.K, System.Windows.Forms.Keys.NumPad5 };
        public static System.Windows.Forms.Keys[] snakeLeftKey = new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.A, System.Windows.Forms.Keys.J, System.Windows.Forms.Keys.NumPad4 };
        public static System.Windows.Forms.Keys[] snakeRightKey = new System.Windows.Forms.Keys[] { System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.D, System.Windows.Forms.Keys.L, System.Windows.Forms.Keys.NumPad6 };
        public static System.Windows.Forms.Keys quitKey = System.Windows.Forms.Keys.Escape;
        public static System.Windows.Forms.Keys pauseKey = System.Windows.Forms.Keys.P;
        public static System.Windows.Forms.Keys restartKey = System.Windows.Forms.Keys.Space;
    }
}
