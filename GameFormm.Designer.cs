namespace Snake
{
    partial class GameFormm
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.textYouAteSomething = new System.Windows.Forms.Label();
            this.lScore1 = new System.Windows.Forms.Label();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picScore1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picScore2 = new System.Windows.Forms.PictureBox();
            this.picPlayer4 = new System.Windows.Forms.PictureBox();
            this.picScore4 = new System.Windows.Forms.PictureBox();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picScore3 = new System.Windows.Forms.PictureBox();
            this.lScore2 = new System.Windows.Forms.Label();
            this.lScore3 = new System.Windows.Forms.Label();
            this.lScore4 = new System.Windows.Forms.Label();
            this.FoodTicker = new System.Windows.Forms.Timer(this.components);
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.ltimeLeft1 = new System.Windows.Forms.Label();
            this.ltimeLeft2 = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lSeconds = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.Label();
            this.life2 = new System.Windows.Forms.Label();
            this.life4 = new System.Windows.Forms.Label();
            this.life3 = new System.Windows.Forms.Label();
            this.pictureBoxH1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH4)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // textYouAteSomething
            // 
            this.textYouAteSomething.AutoSize = true;
            this.textYouAteSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textYouAteSomething.ForeColor = System.Drawing.Color.Red;
            this.textYouAteSomething.Location = new System.Drawing.Point(400, 300);
            this.textYouAteSomething.Name = "textYouAteSomething";
            this.textYouAteSomething.Size = new System.Drawing.Size(0, 25);
            this.textYouAteSomething.TabIndex = 0;
            // 
            // lScore1
            // 
            this.lScore1.AutoSize = true;
            this.lScore1.BackColor = System.Drawing.Color.Transparent;
            this.lScore1.Font = new System.Drawing.Font("Forte", 22F);
            this.lScore1.ForeColor = System.Drawing.Color.Yellow;
            this.lScore1.Location = new System.Drawing.Point(105, 53);
            this.lScore1.Name = "lScore1";
            this.lScore1.Size = new System.Drawing.Size(31, 32);
            this.lScore1.TabIndex = 1;
            this.lScore1.Text = "0";
            this.lScore1.Visible = false;
            // 
            // pictureInfo
            // 
            this.pictureInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureInfo.Location = new System.Drawing.Point(9, 201);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(703, 280);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureInfo.TabIndex = 14;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.Visible = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer1.Location = new System.Drawing.Point(0, 0);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(130, 50);
            this.picPlayer1.TabIndex = 15;
            this.picPlayer1.TabStop = false;
            this.picPlayer1.Visible = false;
            this.picPlayer1.Click += new System.EventHandler(this.picPlayer1_Click);
            // 
            // picScore1
            // 
            this.picScore1.BackColor = System.Drawing.Color.Transparent;
            this.picScore1.Location = new System.Drawing.Point(0, 46);
            this.picScore1.Name = "picScore1";
            this.picScore1.Size = new System.Drawing.Size(105, 40);
            this.picScore1.TabIndex = 16;
            this.picScore1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer2.Location = new System.Drawing.Point(587, 2);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(135, 50);
            this.picPlayer2.TabIndex = 17;
            this.picPlayer2.TabStop = false;
            this.picPlayer2.Visible = false;
            // 
            // picScore2
            // 
            this.picScore2.BackColor = System.Drawing.Color.Transparent;
            this.picScore2.Location = new System.Drawing.Point(574, 46);
            this.picScore2.Name = "picScore2";
            this.picScore2.Size = new System.Drawing.Size(105, 40);
            this.picScore2.TabIndex = 18;
            this.picScore2.TabStop = false;
            this.picScore2.Visible = false;
            // 
            // picPlayer4
            // 
            this.picPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer4.Location = new System.Drawing.Point(586, 644);
            this.picPlayer4.Name = "picPlayer4";
            this.picPlayer4.Size = new System.Drawing.Size(135, 50);
            this.picPlayer4.TabIndex = 21;
            this.picPlayer4.TabStop = false;
            this.picPlayer4.Visible = false;
            // 
            // picScore4
            // 
            this.picScore4.BackColor = System.Drawing.Color.Transparent;
            this.picScore4.Location = new System.Drawing.Point(580, 605);
            this.picScore4.Name = "picScore4";
            this.picScore4.Size = new System.Drawing.Size(105, 40);
            this.picScore4.TabIndex = 22;
            this.picScore4.TabStop = false;
            this.picScore4.Visible = false;
            // 
            // picPlayer3
            // 
            this.picPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer3.Location = new System.Drawing.Point(1, 645);
            this.picPlayer3.Name = "picPlayer3";
            this.picPlayer3.Size = new System.Drawing.Size(135, 50);
            this.picPlayer3.TabIndex = 19;
            this.picPlayer3.TabStop = false;
            this.picPlayer3.Visible = false;
            // 
            // picScore3
            // 
            this.picScore3.BackColor = System.Drawing.Color.Transparent;
            this.picScore3.Location = new System.Drawing.Point(0, 605);
            this.picScore3.Name = "picScore3";
            this.picScore3.Size = new System.Drawing.Size(105, 40);
            this.picScore3.TabIndex = 20;
            this.picScore3.TabStop = false;
            this.picScore3.Visible = false;
            // 
            // lScore2
            // 
            this.lScore2.AutoSize = true;
            this.lScore2.BackColor = System.Drawing.Color.Transparent;
            this.lScore2.Font = new System.Drawing.Font("Forte", 22F);
            this.lScore2.ForeColor = System.Drawing.Color.Yellow;
            this.lScore2.Location = new System.Drawing.Point(689, 54);
            this.lScore2.Name = "lScore2";
            this.lScore2.Size = new System.Drawing.Size(31, 32);
            this.lScore2.TabIndex = 24;
            this.lScore2.Text = "0";
            this.lScore2.Visible = false;
            // 
            // lScore3
            // 
            this.lScore3.AutoSize = true;
            this.lScore3.BackColor = System.Drawing.Color.Transparent;
            this.lScore3.Font = new System.Drawing.Font("Forte", 22F);
            this.lScore3.ForeColor = System.Drawing.Color.Yellow;
            this.lScore3.Location = new System.Drawing.Point(105, 614);
            this.lScore3.Name = "lScore3";
            this.lScore3.Size = new System.Drawing.Size(31, 32);
            this.lScore3.TabIndex = 25;
            this.lScore3.Text = "0";
            this.lScore3.Visible = false;
            // 
            // lScore4
            // 
            this.lScore4.AutoSize = true;
            this.lScore4.BackColor = System.Drawing.Color.Transparent;
            this.lScore4.Font = new System.Drawing.Font("Forte", 22F);
            this.lScore4.ForeColor = System.Drawing.Color.Yellow;
            this.lScore4.Location = new System.Drawing.Point(689, 611);
            this.lScore4.Name = "lScore4";
            this.lScore4.Size = new System.Drawing.Size(31, 32);
            this.lScore4.TabIndex = 26;
            this.lScore4.Text = "0";
            this.lScore4.Visible = false;
            // 
            // FoodTicker
            // 
            this.FoodTicker.Enabled = true;
            this.FoodTicker.Interval = 2000;
            this.FoodTicker.Tick += new System.EventHandler(this.FoodTicker_Tick);
            // 
            // playTimer
            // 
            this.playTimer.Interval = 2000;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // ltimeLeft1
            // 
            this.ltimeLeft1.AutoSize = true;
            this.ltimeLeft1.BackColor = System.Drawing.Color.Transparent;
            this.ltimeLeft1.Font = new System.Drawing.Font("Franklin Gothic Demi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltimeLeft1.ForeColor = System.Drawing.Color.Black;
            this.ltimeLeft1.Location = new System.Drawing.Point(291, 9);
            this.ltimeLeft1.Name = "ltimeLeft1";
            this.ltimeLeft1.Size = new System.Drawing.Size(170, 41);
            this.ltimeLeft1.TabIndex = 29;
            this.ltimeLeft1.Text = "Time Left:";
            this.ltimeLeft1.Visible = false;
            // 
            // ltimeLeft2
            // 
            this.ltimeLeft2.AutoSize = true;
            this.ltimeLeft2.BackColor = System.Drawing.Color.Transparent;
            this.ltimeLeft2.Font = new System.Drawing.Font("Franklin Gothic Demi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltimeLeft2.ForeColor = System.Drawing.Color.Black;
            this.ltimeLeft2.Location = new System.Drawing.Point(350, 52);
            this.ltimeLeft2.Name = "ltimeLeft2";
            this.ltimeLeft2.Size = new System.Drawing.Size(27, 41);
            this.ltimeLeft2.TabIndex = 30;
            this.ltimeLeft2.Text = ":";
            this.ltimeLeft2.Visible = false;
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lMinutes.Font = new System.Drawing.Font("Franklin Gothic Demi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMinutes.ForeColor = System.Drawing.Color.Black;
            this.lMinutes.Location = new System.Drawing.Point(319, 53);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(39, 41);
            this.lMinutes.TabIndex = 31;
            this.lMinutes.Text = "0";
            this.lMinutes.Visible = false;
            // 
            // lSeconds
            // 
            this.lSeconds.AutoSize = true;
            this.lSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lSeconds.Font = new System.Drawing.Font("Franklin Gothic Demi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeconds.ForeColor = System.Drawing.Color.Black;
            this.lSeconds.Location = new System.Drawing.Point(367, 54);
            this.lSeconds.Name = "lSeconds";
            this.lSeconds.Size = new System.Drawing.Size(39, 41);
            this.lSeconds.TabIndex = 32;
            this.lSeconds.Text = "0";
            this.lSeconds.Visible = false;
            // 
            // life1
            // 
            this.life1.AutoSize = true;
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Font = new System.Drawing.Font("Forte", 22F);
            this.life1.ForeColor = System.Drawing.Color.Red;
            this.life1.Location = new System.Drawing.Point(34, 86);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(31, 32);
            this.life1.TabIndex = 33;
            this.life1.Text = "0";
            this.life1.Visible = false;
            // 
            // life2
            // 
            this.life2.AutoSize = true;
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Font = new System.Drawing.Font("Forte", 22F);
            this.life2.ForeColor = System.Drawing.Color.Red;
            this.life2.Location = new System.Drawing.Point(656, 86);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(31, 32);
            this.life2.TabIndex = 34;
            this.life2.Text = "0";
            this.life2.Visible = false;
            // 
            // life4
            // 
            this.life4.AutoSize = true;
            this.life4.BackColor = System.Drawing.Color.Transparent;
            this.life4.Font = new System.Drawing.Font("Forte", 22F);
            this.life4.ForeColor = System.Drawing.Color.Red;
            this.life4.Location = new System.Drawing.Point(656, 579);
            this.life4.Name = "life4";
            this.life4.Size = new System.Drawing.Size(31, 32);
            this.life4.TabIndex = 35;
            this.life4.Text = "0";
            this.life4.Visible = false;
            // 
            // life3
            // 
            this.life3.AutoSize = true;
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Font = new System.Drawing.Font("Forte", 22F);
            this.life3.ForeColor = System.Drawing.Color.Red;
            this.life3.Location = new System.Drawing.Point(34, 578);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(31, 32);
            this.life3.TabIndex = 36;
            this.life3.Text = "0";
            this.life3.Visible = false;
            // 
            // pictureBoxH1
            // 
            this.pictureBoxH1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxH1.BackgroundImage = global::Snake.Properties.Resources.static_heart;
            this.pictureBoxH1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxH1.Location = new System.Drawing.Point(0, 91);
            this.pictureBoxH1.Name = "pictureBoxH1";
            this.pictureBoxH1.Size = new System.Drawing.Size(39, 22);
            this.pictureBoxH1.TabIndex = 37;
            this.pictureBoxH1.TabStop = false;
            this.pictureBoxH1.Visible = false;
            // 
            // pictureBoxH2
            // 
            this.pictureBoxH2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxH2.BackgroundImage = global::Snake.Properties.Resources.static_heart;
            this.pictureBoxH2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxH2.Location = new System.Drawing.Point(681, 91);
            this.pictureBoxH2.Name = "pictureBoxH2";
            this.pictureBoxH2.Size = new System.Drawing.Size(39, 22);
            this.pictureBoxH2.TabIndex = 38;
            this.pictureBoxH2.TabStop = false;
            this.pictureBoxH2.Visible = false;
            // 
            // pictureBoxH3
            // 
            this.pictureBoxH3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxH3.BackgroundImage = global::Snake.Properties.Resources.static_heart;
            this.pictureBoxH3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxH3.Location = new System.Drawing.Point(681, 583);
            this.pictureBoxH3.Name = "pictureBoxH3";
            this.pictureBoxH3.Size = new System.Drawing.Size(39, 22);
            this.pictureBoxH3.TabIndex = 39;
            this.pictureBoxH3.TabStop = false;
            this.pictureBoxH3.Visible = false;
            // 
            // pictureBoxH4
            // 
            this.pictureBoxH4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxH4.BackgroundImage = global::Snake.Properties.Resources.static_heart;
            this.pictureBoxH4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxH4.Location = new System.Drawing.Point(0, 583);
            this.pictureBoxH4.Name = "pictureBoxH4";
            this.pictureBoxH4.Size = new System.Drawing.Size(39, 22);
            this.pictureBoxH4.TabIndex = 40;
            this.pictureBoxH4.TabStop = false;
            this.pictureBoxH4.Visible = false;
            // 
            // GameFormm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Snake.Properties.Resources.green_squares;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 696);
            this.Controls.Add(this.pictureBoxH4);
            this.Controls.Add(this.pictureBoxH3);
            this.Controls.Add(this.pictureBoxH2);
            this.Controls.Add(this.pictureBoxH1);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life4);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.lSeconds);
            this.Controls.Add(this.lMinutes);
            this.Controls.Add(this.ltimeLeft2);
            this.Controls.Add(this.ltimeLeft1);
            this.Controls.Add(this.lScore4);
            this.Controls.Add(this.lScore3);
            this.Controls.Add(this.lScore2);
            this.Controls.Add(this.picPlayer4);
            this.Controls.Add(this.picScore4);
            this.Controls.Add(this.picPlayer3);
            this.Controls.Add(this.picScore3);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picScore2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.pictureInfo);
            this.Controls.Add(this.lScore1);
            this.Controls.Add(this.textYouAteSomething);
            this.Controls.Add(this.picScore1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameFormm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label textYouAteSomething;
        private System.Windows.Forms.Label lScore1;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picScore1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picScore2;
        private System.Windows.Forms.PictureBox picPlayer4;
        private System.Windows.Forms.PictureBox picScore4;
        private System.Windows.Forms.PictureBox picPlayer3;
        private System.Windows.Forms.PictureBox picScore3;
        private System.Windows.Forms.Label lScore2;
        private System.Windows.Forms.Label lScore3;
        private System.Windows.Forms.Label lScore4;
        private System.Windows.Forms.Timer FoodTicker;
        private System.Windows.Forms.Timer playTimer;
        private System.Windows.Forms.Label ltimeLeft1;
        private System.Windows.Forms.Label ltimeLeft2;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label lSeconds;
        private System.Windows.Forms.Label life1;
        private System.Windows.Forms.Label life2;
        private System.Windows.Forms.Label life4;
        private System.Windows.Forms.Label life3;
        private System.Windows.Forms.PictureBox pictureBoxH1;
        private System.Windows.Forms.PictureBox pictureBoxH2;
        private System.Windows.Forms.PictureBox pictureBoxH3;
        private System.Windows.Forms.PictureBox pictureBoxH4;
    }
}

