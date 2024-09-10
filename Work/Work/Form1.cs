using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Work
{
    
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer bounce = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer bgm = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer hit = new WMPLib.WindowsMediaPlayer();
        
        bool start = false;

        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool move = false;

        int jumpSpeed = 0;
        int force = 0;


        bool goleft1 = false;
        bool goright1 = false;
        bool jumping1 = false;
        bool move1 = false;

        int jumpSpeed1 = 0;
        int force1 = 0;

        int ballx = 0;
        int bally = 0;

        int point = 0;

        int player1score=0, player2score=0;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgm.settings.setMode("loop", true);
            bgm.URL = "start.mp3";
            bgm.controls.play();
            mask.Visible = true;
            content1.Visible = true;
            content2.Visible = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            score1.Text = "Player1得分 = " + player1score;
            score2.Text = "Player2得分 = " + player2score;




            if (player1score >= 15)
                gameOver("Player1");

            if (player2score >= 15)
                gameOver("Player2");




            if (Player1.Left < 0)
                Player1.Left = 0;

            if (Player1.Right + 10 > Pillar.Left)
                Player1.Left = Pillar.Left - 70;

            if (Player2.Right > ClientSize.Width)
                Player2.Left = ClientSize.Width - 60;

            if (Player2.Left - 10 < Pillar.Right)
                Player2.Left = Pillar.Right + 10;




            if (goleft) 
                Player1.Left -= 15;

            if (goright) 
                Player1.Left += 15;

            if (jumping && force != 10)
            {
                jumpSpeed = -20;
                force += 1;
                move = true;
            }
            else
            {
                jumpSpeed = 20;
                if (Player1.Top > 290)
                {
                    force = 0;
                    jumpSpeed = 0;
                    jumping = false;
                    move = false;
                }
            }
            if(move)
                Player1.Top += jumpSpeed;




            if (goleft1) 
                Player2.Left -= 15; 
            
            if (goright1)
                 Player2.Left += 15;
            
            if (jumping1 && force1 != 10)
            {
                jumpSpeed1 = -20;
                force1 += 1;
                move1 = true;
            }
            else
            {
                jumpSpeed1 = 20;
                if (Player2.Top > 290)
                {
                    force1 = 0;
                    jumpSpeed1 = 0;
                    jumping1 = false;
                    move1 = false;
                }
            }
            if (move1)
                Player2.Top += jumpSpeed1;




            if (Ball.Bounds.IntersectsWith(Player1.Bounds))
            {
                bounce.URL = "bounce.mp3";
                bounce.controls.play();
                jumping = false;
                ballx = 1;
                bally = -20;
            }

            if (Ball.Bounds.IntersectsWith(Player2.Bounds))
            {
                bounce.URL = "bounce.mp3";
                bounce.controls.play();
                jumping1 = false;
                ballx = -1;
                bally = -20;
            }

            if (Ball.Bounds.IntersectsWith(Pillar.Bounds))
            {
                bounce.URL = "bounce.mp3";
                bounce.controls.play();
                if (Ball.Bottom - 10 > Pillar.Top) 
                    ballx = -ballx;

                else
                    bally = -bally;
            }




            if (Ball.Top <= 0)
            {
                bounce.URL = "bounce.mp3";
                bounce.controls.play();
                bally = -bally;
            }

            if (Ball.Left <= 0 || Ball.Right >= ClientSize.Width)
            {
                bounce.URL = "bounce.mp3";
                bounce.controls.play();
                ballx = -ballx;
            }

            if (Ball.Top + Ball.Height > ClientSize.Height)
            {
                jumping= false;
                jumping1= false;
                Player1.Top = 300;
                Player2.Top = 300;
                Player1.Left = 70;
                Player2.Left = ClientSize.Width - 130;
                if (Ball.Left > 280)
                {
                    player1score = player1score + 1;
                    point = 1;
                }

                else
                {
                    player2score = player2score + 1;
                    point = 2;
                }
                if (point == 1)
                {
                    Ball.Location = new Point(Player2.Left + 10, 0);
                    ballx = 0;
                    point = 0;
                }
                else if (point == 2)
                {
                    Ball.Location = new Point(Player1.Left + 10, 0);
                    ballx = 0;
                    point = 0;
                }
                bally = 5;
            }

            bally += 1;

            Ball.Left += ballx;
            Ball.Top += bally;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                goleft = true;

            if (e.KeyCode == Keys.D)
                goright = true;

            if (e.KeyCode == Keys.W && !jumping) 
                jumping = true;

            if (e.KeyCode == Keys.Z)
            {
                int X = Player1.Right - Ball.Right;
                int Y = Player1.Top - Ball.Bottom;
                if ((X < 50 && X > -50) && (Y < 50 && Y > -50))
                {
                    hit.URL = "hit.mp3";
                    hit.controls.play();
                    ballx = 20;
                    bally = 5;
                }
            }


            if (e.KeyCode == Keys.Left)
                goleft1 = true; 
            
            if (e.KeyCode == Keys.Right)
                goright1 = true;
            
            if (e.KeyCode == Keys.Up && !jumping1)
                jumping1 = true; 
            
            if (e.KeyCode == Keys.Enter)
            {
                int X = Player2.Left - Ball.Left;
                int Y = Player2.Top - Ball.Bottom;
                if ((X < 50 && X > -50) && (Y < 50 && Y > -50))
                {
                    hit.URL = "hit.mp3";
                    hit.controls.play();
                    ballx = -20;
                    bally = 5;
                }
            }

            if (e.KeyCode == Keys.Space && !start)
            {
                bgm.URL = "bgm.mp3";
                bgm.controls.play();
                mask.Visible = false;
                content1.Visible = false;
                content2.Visible = false;
                timer1.Start();
                start = true;
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                goleft = false;
            
            if (e.KeyCode == Keys.D)
                goright = false;


            if (e.KeyCode == Keys.Left)
                goleft1 = false;

            if (e.KeyCode == Keys.Right) 
                goright1 = false;
        }

        private void gameOver(string s)
        {
            timer1.Stop();
            DialogResult dr = MessageBox.Show(s + "勝利" + "\n" + "遊戲結束" + "\n" + "按確定重新開始，按取消退出", "遊戲結束", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
                Application.Restart();
            else if (dr == DialogResult.Cancel)
                Application.Exit();
        }
    }
}
