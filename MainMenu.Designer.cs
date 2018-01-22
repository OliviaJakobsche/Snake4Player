namespace Snake
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.picMenuQuitGame = new System.Windows.Forms.PictureBox();
            this.picMenuSettings = new System.Windows.Forms.PictureBox();
            this.picMenuVersusMode = new System.Windows.Forms.PictureBox();
            this.picMenuTimeMode = new System.Windows.Forms.PictureBox();
            this.picMenuFreeMode = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuQuitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuVersusMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuTimeMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFreeMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // picMenuQuitGame
            // 
            this.picMenuQuitGame.BackColor = System.Drawing.Color.Transparent;
            this.picMenuQuitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMenuQuitGame.Image = global::Snake.Properties.Resources.quit_game;
            this.picMenuQuitGame.Location = new System.Drawing.Point(3, 568);
            this.picMenuQuitGame.Name = "picMenuQuitGame";
            this.picMenuQuitGame.Size = new System.Drawing.Size(718, 110);
            this.picMenuQuitGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenuQuitGame.TabIndex = 12;
            this.picMenuQuitGame.TabStop = false;
            this.picMenuQuitGame.Click += new System.EventHandler(this.picMenuQuitGame_Click);
            this.picMenuQuitGame.MouseLeave += new System.EventHandler(this.picMenuQuitGame_MouseLeave);
            this.picMenuQuitGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMenuQuitGame_MouseMove);
            // 
            // picMenuSettings
            // 
            this.picMenuSettings.BackColor = System.Drawing.Color.Transparent;
            this.picMenuSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMenuSettings.Image = global::Snake.Properties.Resources.settingss;
            this.picMenuSettings.Location = new System.Drawing.Point(2, 473);
            this.picMenuSettings.Name = "picMenuSettings";
            this.picMenuSettings.Size = new System.Drawing.Size(719, 89);
            this.picMenuSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenuSettings.TabIndex = 11;
            this.picMenuSettings.TabStop = false;
            this.picMenuSettings.Click += new System.EventHandler(this.picMenuSettings_Click);
            this.picMenuSettings.MouseLeave += new System.EventHandler(this.picMenuSettings_MouseLeave);
            this.picMenuSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMenuSettings_MouseMove);
            // 
            // picMenuVersusMode
            // 
            this.picMenuVersusMode.BackColor = System.Drawing.Color.Transparent;
            this.picMenuVersusMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMenuVersusMode.Image = global::Snake.Properties.Resources.mode_versus;
            this.picMenuVersusMode.Location = new System.Drawing.Point(2, 376);
            this.picMenuVersusMode.Name = "picMenuVersusMode";
            this.picMenuVersusMode.Size = new System.Drawing.Size(719, 91);
            this.picMenuVersusMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenuVersusMode.TabIndex = 10;
            this.picMenuVersusMode.TabStop = false;
            this.picMenuVersusMode.Click += new System.EventHandler(this.picMenuVersusMode_Click);
            this.picMenuVersusMode.MouseLeave += new System.EventHandler(this.picMenuVersusMode_MouseLeave);
            this.picMenuVersusMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMenuVersusMode_MouseMove);
            // 
            // picMenuTimeMode
            // 
            this.picMenuTimeMode.BackColor = System.Drawing.Color.Transparent;
            this.picMenuTimeMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMenuTimeMode.Image = global::Snake.Properties.Resources.mode_time;
            this.picMenuTimeMode.Location = new System.Drawing.Point(2, 293);
            this.picMenuTimeMode.Name = "picMenuTimeMode";
            this.picMenuTimeMode.Size = new System.Drawing.Size(719, 86);
            this.picMenuTimeMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenuTimeMode.TabIndex = 9;
            this.picMenuTimeMode.TabStop = false;
            this.picMenuTimeMode.Click += new System.EventHandler(this.picMenuTimeMode_Click);
            this.picMenuTimeMode.MouseLeave += new System.EventHandler(this.picMenuTimeMode_MouseLeave);
            this.picMenuTimeMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMenuTimeMode_MouseMove);
            // 
            // picMenuFreeMode
            // 
            this.picMenuFreeMode.BackColor = System.Drawing.Color.Transparent;
            this.picMenuFreeMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMenuFreeMode.Image = global::Snake.Properties.Resources.mode_free;
            this.picMenuFreeMode.Location = new System.Drawing.Point(2, 198);
            this.picMenuFreeMode.Name = "picMenuFreeMode";
            this.picMenuFreeMode.Size = new System.Drawing.Size(719, 97);
            this.picMenuFreeMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenuFreeMode.TabIndex = 8;
            this.picMenuFreeMode.TabStop = false;
            this.picMenuFreeMode.Click += new System.EventHandler(this.picMenuFreeMode_Click);
            this.picMenuFreeMode.MouseLeave += new System.EventHandler(this.picMenuFreeMode_MouseLeave);
            this.picMenuFreeMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMenuFreeMode_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Snake.Properties.Resources.snake;
            this.pictureBox3.Location = new System.Drawing.Point(3, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(718, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.green_squares;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 696);
            this.Controls.Add(this.picMenuQuitGame);
            this.Controls.Add(this.picMenuSettings);
            this.Controls.Add(this.picMenuVersusMode);
            this.Controls.Add(this.picMenuTimeMode);
            this.Controls.Add(this.picMenuFreeMode);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Fo(u)r Players";
            ((System.ComponentModel.ISupportInitialize)(this.picMenuQuitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuVersusMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuTimeMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFreeMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMenuQuitGame;
        private System.Windows.Forms.PictureBox picMenuSettings;
        private System.Windows.Forms.PictureBox picMenuVersusMode;
        private System.Windows.Forms.PictureBox picMenuTimeMode;
        private System.Windows.Forms.PictureBox picMenuFreeMode;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}