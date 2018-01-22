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
    public partial class GameFormm : Form
    {
        Graphics paper;
        bool gameStatePaused = false;
        Label[] lScore, lLife;
        Game game;
        int players = Settings.gamePlayers;
        public static int counter = Settings.timePlayValue;
        bool restart = false;

        public GameFormm(int GameMode)
        {
            InitializeComponent();
            game = new Game(GameMode);
            if (GameMode == 2)
            {
                lSeconds.Visible = true;
                lMinutes.Visible = true;
                ltimeLeft1.Visible = true;
                ltimeLeft2.Visible = true;
                playTimer.Interval = 600;
                playTimer.Enabled = true;
                counter = Settings.timePlayValue;
            }
        }


        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            game.drawBoard(paper);
        }


        private void GameForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            PictureBox[] labels_players = { picPlayer1, picPlayer2, picPlayer3, picPlayer4 };
            PictureBox[] labels_scores = { picScore1, picScore2, picScore3, picScore4 };
            PictureBox[] labels_hearts = { pictureBoxH1, pictureBoxH2, pictureBoxH4, pictureBoxH3 };
            lScore = new Label[] { lScore1, lScore2, lScore3, lScore4 };
            lLife = new Label[] { life1, life2, life3, life4 };

            for (int i = 0; i < players; i++)
            {
                labels_players[i].Image = Image.FromFile("..\\..\\Resources\\" + Settings.snakeColors[i] + (i + 1).ToString() + ".png");
                labels_players[i].Visible = true;
                labels_scores[i].Image = Image.FromFile("..\\..\\Resources\\" + Settings.snakeColors[i] + "S.png");
                labels_scores[i].Visible = true;
                lScore[i].ForeColor = Color.FromName(Settings.snakeColors[i]);
                lScore[i].Visible = true;
                lLife[i].ForeColor = Color.FromName(Settings.snakeColors[i]);
                lLife[i].Visible = true;
                labels_hearts[i].Visible = true;
            }
        }


        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Check if user click 'Pause' button
            if (e.KeyData == Settings.pauseKey)
            {
                if (gameStatePaused == false)
                {
                    GameTimer.Stop();
                    playTimer.Stop();
                    gameStatePaused = true;
                    pictureInfo.Image = Properties.Resources.pause_;
                    pictureInfo.Visible = true;
                }
                else
                {
                    GameTimer.Start();
                    playTimer.Start();
                    gameStatePaused = false;
                    pictureInfo.Visible = false;
                }
            }

            //Check if user click 'Quit Game' Button
            if (e.KeyData == Settings.quitKey)
            {
                //message box are you sure? or sth
                this.Close();
            }

            //Check if user choose 'Restart' Button after ded
            if (e.KeyData == Keys.Space && restart)
            {
                pictureInfo.Visible = false;
                counter = Settings.timePlayValue;
                game = new Game(players);
                GameTimer.Start();
                playTimer.Start();                
                restart = false;         
            }

            //Check if user click Any of Snake Control Button 
            game.control(e.KeyData);
        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {            
            game.move();
            game.checkCollision();
            game.updateScores(lScore);
            game.updateLifes(lLife);

            if (game.checkEndGame() == true)
            {
                pictureInfo.Image = Properties.Resources.game_over1;
                pictureInfo.Visible = true;
                GameTimer.Stop();
                restart = true;                
            }

            this.Invalidate();
        }


        private void FoodTicker_Tick(object sender, EventArgs e)
        {
            game.foodReGenerate();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            lMinutes.Text = (counter / 60).ToString();
            lSeconds.Text = (counter % 60).ToString();            
        }

        private void picPlayer1_Click(object sender, EventArgs e)
        {

        }
    }
}
