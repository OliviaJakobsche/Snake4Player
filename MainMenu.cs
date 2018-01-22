using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Snake
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            SoundPlayer sound_player = new SoundPlayer(Properties.Resources.Plants_vs_Zombies___Roof_Stage);
            //sound_player.Play();
        }       
        
        private void picMenuFreeMode_MouseMove(object sender, MouseEventArgs e)
        {
            picMenuFreeMode.Image = Properties.Resources.mode_free_a;
        }

        private void picMenuFreeMode_MouseLeave(object sender, EventArgs e)
        {
            picMenuFreeMode.Image = Properties.Resources.mode_free;
        }

        private void picMenuTimeMode_MouseMove(object sender, MouseEventArgs e)
        {
            picMenuTimeMode.Image = Properties.Resources.mode_time_a;
        }

        private void picMenuTimeMode_MouseLeave(object sender, EventArgs e)
        {
            picMenuTimeMode.Image = Properties.Resources.mode_time;
        }

        private void picMenuVersusMode_MouseMove(object sender, MouseEventArgs e)
        {
            picMenuVersusMode.Image = Properties.Resources.mode_versus_a;
        }

        private void picMenuVersusMode_MouseLeave(object sender, EventArgs e)
        {
            picMenuVersusMode.Image = Properties.Resources.mode_versus;
        }

        private void picMenuSettings_MouseMove(object sender, MouseEventArgs e)
        {
            picMenuSettings.Image = Properties.Resources.settings_a;
        }

        private void picMenuSettings_MouseLeave(object sender, EventArgs e)
        {
            picMenuSettings.Image = Properties.Resources.settingss;
        }

        private void picMenuQuitGame_MouseMove(object sender, MouseEventArgs e)
        {
            picMenuQuitGame.Image = Properties.Resources.quit_game_a;
        }

        private void picMenuQuitGame_MouseLeave(object sender, EventArgs e)
        {
            picMenuQuitGame.Image = Properties.Resources.quit_game;
        }

        private void picMenuFreeMode_Click(object sender, EventArgs e)
        {
            ActiveForm.Visible = false;
            GameFormm game_form = new GameFormm(1);
            game_form.Closed += (s, args) => this.Show(); //creates a function "in place" that is called when the game_form.Closed event is fired. 
            game_form.Show();
        }

        private void picMenuTimeMode_Click(object sender, EventArgs e)
        {
            ActiveForm.Visible = false;
            GameFormm game_form = new GameFormm(2);
            game_form.Closed += (s, args) => this.Show();
            game_form.Show();
        }

        private void picMenuVersusMode_Click(object sender, EventArgs e)
        {
            ActiveForm.Visible = false;
            GameFormm game_form = new GameFormm(3);
            game_form.Closed += (s, args) => this.Show();
            game_form.Show();
        }

        private void picMenuSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Settings settings_form = new Menu_Settings();
            settings_form.Closed += (s, args) => this.Show();
            settings_form.Show();
        }

        private void picMenuQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
