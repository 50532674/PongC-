namespace Pong
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player1 = new System.Windows.Forms.PictureBox();
            this.cpuPlayer = new System.Windows.Forms.PictureBox();
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.playerScore_Label = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.DarkOrange;
            this.player1.Location = new System.Drawing.Point(12, 235);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(20, 116);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // cpuPlayer
            // 
            this.cpuPlayer.BackColor = System.Drawing.Color.DarkViolet;
            this.cpuPlayer.Location = new System.Drawing.Point(833, 235);
            this.cpuPlayer.Name = "cpuPlayer";
            this.cpuPlayer.Size = new System.Drawing.Size(20, 116);
            this.cpuPlayer.TabIndex = 1;
            this.cpuPlayer.TabStop = false;
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.SaddleBrown;
            this.pongBall.Location = new System.Drawing.Point(364, 315);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(21, 23);
            this.pongBall.TabIndex = 2;
            this.pongBall.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Pong.Properties.Resources.pong_logo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(335, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(172, 91);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // playerScore_Label
            // 
            this.playerScore_Label.AutoSize = true;
            this.playerScore_Label.BackColor = System.Drawing.Color.Transparent;
            this.playerScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore_Label.ForeColor = System.Drawing.Color.Orange;
            this.playerScore_Label.Location = new System.Drawing.Point(289, 26);
            this.playerScore_Label.Name = "playerScore_Label";
            this.playerScore_Label.Size = new System.Drawing.Size(40, 42);
            this.playerScore_Label.TabIndex = 4;
            this.playerScore_Label.Text = "0";
            this.playerScore_Label.Click += new System.EventHandler(this.playerScoreLabel_Click);
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.AutoSize = true;
            this.cpuScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.ForeColor = System.Drawing.Color.Orange;
            this.cpuScoreLabel.Location = new System.Drawing.Point(534, 26);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(40, 42);
            this.cpuScoreLabel.TabIndex = 5;
            this.cpuScoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 20;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pong.Properties.Resources._8bit_8bit_grafika_les_retro_fon_pikseli_pxl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 659);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.playerScore_Label);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.cpuPlayer);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.Logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(881, 698);
            this.MinimumSize = new System.Drawing.Size(881, 698);
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox cpuPlayer;
        private System.Windows.Forms.PictureBox pongBall;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label playerScore_Label;
        private System.Windows.Forms.Timer pongTimer;
    }
}

