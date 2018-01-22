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
    public partial class Menu_Settings : Form
    {
        PictureBox[] players_pic;
        Image[] image_players;
        Image[] image_players_a;

        
        int active = Settings.gamePlayers;

        public Menu_Settings()
        {
            InitializeComponent();           
        }

        private void Menu_Settings_Load(object sender, EventArgs e)
        {            
            image_players = new Image[] { Properties.Resources.settings_1, Properties.Resources.settings_2, Properties.Resources.settings_3, Properties.Resources.settings_4 };
            image_players_a = new Image[] { Properties.Resources.settings_1_a, Properties.Resources.settings_2_a, Properties.Resources.settings_3_a, Properties.Resources.settings_4_a };
            players_pic = new PictureBox[] { picSettings1, picSettings2, picSettings3, picSettings4 };
            players_pic[Settings.gamePlayers - 1].Image = image_players_a[Settings.gamePlayers - 1];

            if (Settings.playSound)
                picSettingsON.Image = Properties.Resources.settings_ON_a;
            else
                picSettingsOFF.Image = Properties.Resources.settings_OFF_a;
        }

        private void picSettings1_MouseLeave(object sender, EventArgs e)
        {
            if (Settings.gamePlayers != 1)
                picSettings1.Image = image_players[0];
        }

        private void picSettings1_MouseMove(object sender, MouseEventArgs e)
        {
            picSettings1.Image = image_players_a[0];
        }

        private void picSettings1_MouseUp(object sender, MouseEventArgs e)
        {
            players_pic[Settings.gamePlayers - 1].Image = image_players[Settings.gamePlayers - 1];
            Settings.gamePlayers = 1;
        }

        private void picSettings2_MouseLeave(object sender, EventArgs e)
        {
            if (Settings.gamePlayers != 2)
                picSettings2.Image = image_players[1];
        }

        private void picSettings2_MouseMove(object sender, MouseEventArgs e)
        {
            picSettings2.Image = image_players_a[1];
        }

        private void picSettings2_MouseUp(object sender, MouseEventArgs e)
        {
            players_pic[Settings.gamePlayers - 1].Image = image_players[Settings.gamePlayers - 1];
            Settings.gamePlayers = 2;
        }

        private void picSettings3_MouseLeave(object sender, EventArgs e)
        {
            if (Settings.gamePlayers != 3)
                picSettings3.Image = image_players[2];
        }

        private void picSettings3_MouseMove(object sender, MouseEventArgs e)
        {
            picSettings3.Image = image_players_a[2];
        }

        private void picSettings3_MouseUp(object sender, MouseEventArgs e)
        {
            players_pic[Settings.gamePlayers - 1].Image = image_players[Settings.gamePlayers - 1];
            Settings.gamePlayers = 3;
        }
        private void picSettings4_MouseLeave(object sender, EventArgs e)
        {
            if (Settings.gamePlayers != 4)
                picSettings4.Image = image_players[3];
        }

        private void picSettings4_MouseMove(object sender, MouseEventArgs e)
        {
            picSettings4.Image = image_players_a[3];
        }

        private void picSettings4_MouseUp(object sender, MouseEventArgs e)
        {
            players_pic[Settings.gamePlayers - 1].Image = image_players[Settings.gamePlayers - 1];
            Settings.gamePlayers = 4;
        }        

        private void picSettingsON_MouseLeave(object sender, EventArgs e)
        {
            if(Settings.playSound != true)
                picSettingsON.Image = Properties.Resources.settings_ON;
        }

        private void picSettingsON_MouseMove(object sender, MouseEventArgs e)
        {
            picSettingsON.Image = Properties.Resources.settings_ON_a;
        }

        private void picSettingsON_MouseUp(object sender, MouseEventArgs e)
        {
            picSettingsON.Image = Properties.Resources.settings_ON_a;
            picSettingsOFF.Image = Properties.Resources.settings_OFF;
            Settings.playSound = true;
        }

        private void picSettingsOFF_MouseLeave(object sender, EventArgs e)
        {
            if (Settings.playSound != false)
                picSettingsOFF.Image = Properties.Resources.settings_OFF;
        }

        private void picSettingsOFF_MouseMove(object sender, MouseEventArgs e)
        {
            picSettingsOFF.Image = Properties.Resources.settings_OFF_a;
        }

        private void picSettingsOFF_MouseUp(object sender, MouseEventArgs e)
        {
            picSettingsON.Image = Properties.Resources.settings_ON;
            picSettingsOFF.Image = Properties.Resources.settings_OFF_a;
            Settings.playSound = false;
        }

        private void picBack_MouseMove(object sender, MouseEventArgs e)
        {
            picBack.Image = Properties.Resources.settings_back_a;
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            picBack.Image = Properties.Resources.settings_back;
        }

        private void picBack_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }        
    }
}
