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

namespace Cold_Tower
{
    public partial class Boss : Form
    {
        private SoundPlayer boss, jump, death;
        int life = 3, score = 0, BossLife = 4, GhX, GhY;
        int arrowCount = 5;
        int arrowX, arrowY;
        int arrowDistanceCount = 0;
        string curDirection, FiredDirection;
        bool Jump = false;
        bool right;
        bool left;
        int G = 30;
        int force;
        

        private void Boss_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            boss.PlayLooping();
        }

        private void timer1_move_Tick(object sender, EventArgs e)
        {
            PlatCollisions(); 
        }

        private void Boss_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = false;
                pbox_Player.Image = Properties.Resources.stand;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
                pbox_Player.Image = Properties.Resources.Knight_Player2_fw;
            }
            if (e.KeyCode == Keys.W)
            {
            }
        }

        private void Boss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
                pbox_Player.Image = Properties.Resources.leftMove;
            }
            if (e.KeyCode == Keys.W)
            {
                if (Jump != true)
                {
                    if (e.KeyCode == Keys.W)
                    {
                        Jump = true;
                        force = G;
                        jump.Play();
                    }
                }
            }

            if (e.KeyCode == Keys.D)
            {
                right = true;
                pbox_Player.Image = Properties.Resources.rightMove;
            }
            if (e.KeyCode == Keys.P)
            {
                arrowLocate();
                arrowCountCheck();
            }
        }

        public Boss()
        {
            InitializeComponent();
            pbox_Player.Top = panel3.Height - pbox_Player.Height;
            boss = new SoundPlayer("Dark-Souls-Gaping-Dragon.wav"); jump = new SoundPlayer("Jump.wav"); death = new SoundPlayer("Pain.wav");
        }



        private void timer1_Jump_Tick(object sender, EventArgs e)
        {
            if (Jump == true)
            {
                pbox_Player.Top -= force;
                force -= 2;
            }

            if (pbox_Player.Top + pbox_Player.Height >= panel3.Height)
            {
                pbox_Player.Top = panel3.Height - pbox_Player.Height;
                Jump = false;
            }
            else
            { }
        }
        private void Collisions()
        {
            
            if (pbox_Player.Left + pbox_Player.Width > pbox_BossWall1.Left && pbox_Player.Left + pbox_Player.Width < pbox_BossWall1.Left + pbox_BossWall1.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_BossWall1.Top && pbox_Player.Top < pbox_BossWall1.Top)
            {
                force = 0;
                Jump = false;
                right = false;
                pbox_Player.Top = pbox_BossWall1.Location.Y - pbox_Player.Height;
            }
          
        }
        private void PlatCollisions()
        {

            // side collision
            if (pbox_Player.Left < pbox_Wall3b.Right && pbox_Player.Right > pbox_Wall3b.Left + pbox_Player.Width / 2 && pbox_Player.Bottom > pbox_Wall3b.Top)
            {
                left = false;
            }
            //jump
            if (right == true)
            {
                pbox_Player.Left += 10;
            }
            if (left == true)
            {
                pbox_Player.Left -= 10;
            }
        }
        private void ArrowRight()
        {
            arrowX = pbox_arrowRight.Location.X;
            arrowY = pbox_arrowRight.Location.Y;

            pbox_arrowRight.Location = new Point(arrowX + 10, arrowY);
        }
        private void arrowLocate()
        {
            if (arrowCount == 0)
            {
                return;
            }
            //if the player has more than 0 arrows they can fire the weapon
            else if (arrowCount > 0)
            {
                //position the arrow in front on the player by setting co-ordinates accordingly
                arrowX = pbox_Player.Location.X;
                arrowY = pbox_Player.Location.Y;

                pbox_arrowRight.Location = new Point(arrowX, arrowY);
                pbox_arrowRight.Visible = true;

                timerFire.Start();
            }
        }
        
        private void timerFire_Tick(object sender, EventArgs e)
        {
            if (arrowDistanceCount < 1000)
            {
                arrowBarrierDetection();
                arrowDistanceCount = arrowDistanceCount + 10;
                ArrowRight();
                ArrowHitCheck();
            }
            else if (arrowDistanceCount >= 1000)
            {
                timerFire.Stop();
                pbox_arrowRight.Visible = false;
                pbox_arrowRight.Location = new Point(33, 1008);
                arrowDistanceCount = 0;
            }
        }

        private void arrowBarrierDetection()
        {

            
        }

        private void timer1_BossMove_Tick(object sender, EventArgs e)
        {
            BossAttack(); BossMovement();
        }

        private void ArrowHitCheck()
        {
            if (pbox_arrowRight.Bounds.IntersectsWith(pbox_Malal.Bounds))
            {
                timerFire.Stop();
                BossHealth();
                pbox_arrowRight.Visible = false;
                pbox_arrowRight.Location = new Point(33, 1008);
                arrowDistanceCount = 0;

            }
        }
        private void arrowCountCheck()
        {
            //deduct an arrow from the count
            arrowCount--;


            if (arrowCount == 5)
            {

            }
            else if (arrowCount == 4)
            {
                pbox_ammo.Visible = false;
            }
            else if (arrowCount == 3)
            {
                pbox_ammo2.Visible = false;
            }
            else if (arrowCount == 2)
            {
                pbox_ammo3.Visible = false;
            }
            else if (arrowCount == 1)
            {
                pbox_ammo4.Visible = false;
            }
            else if (arrowCount == 0)
            {
                pbox_ammo5.Visible = false;
            }

        }
        private void LifeLoss()
        {
            life--;
            if (life == 3)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = true;
                pbox_PlayerHealth3.Visible = true;
                death.Play();
            }
            else if (life == 2)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = true;
                pbox_PlayerHealth3.Visible = false;
                death.Play();
                pbox_Player.Location = new Point(13, 1026);
            }
            else if (life == 1)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = false;
                pbox_PlayerHealth3.Visible = false;
                death.Play();
                pbox_Player.Location = new Point(13, 1026);
            }
            else if (life == 0)
            {
                pbox_PlayerHealth.Visible = false;
                pbox_PlayerHealth2.Visible = false;
                pbox_PlayerHealth3.Visible = false;
                death.Play();
                this.Hide();
                GameOver newform = new GameOver();
                newform.ShowDialog();
                this.Close();
            }
        }
        private void BossAttack()
        {
            if ((pbox_Malal.Bounds.IntersectsWith(pbox_Player.Bounds)))
            {
                LifeLoss();
                
            }
        }
        private void BossHealth()
        {
            BossLife--;
            if (BossLife == 4)
            {
                pbox_BossH1.Visible = true;
                pbox_BossH2.Visible = true;
                pbox_BossH3.Visible = true;
                pbox_BossH4.Visible = true;
            }
            else if (BossLife == 3)
            {
                pbox_BossH1.Visible = true;
                pbox_BossH2.Visible = true;
                pbox_BossH3.Visible = true;
                pbox_BossH4.Visible = false;
            }
            else if (BossLife == 2)
            {
                pbox_BossH1.Visible = true;
                pbox_BossH2.Visible = true;
                pbox_BossH3.Visible = false;
                pbox_BossH4.Visible = false;
            }
            else if (BossLife == 1)
            {
                pbox_BossH1.Visible = true;
                pbox_BossH2.Visible = false;
                pbox_BossH3.Visible = false;
                pbox_BossH4.Visible = false;
            }
            else if (BossLife == 0)
            {
                pbox_BossH1.Visible = false;
                pbox_BossH2.Visible = false;
                pbox_BossH3.Visible = false;
                pbox_BossH4.Visible = false;
                this.Hide();
                EndGame newform = new EndGame();
                newform.ShowDialog();
                this.Close();
            }
        }
        private void BossMovement()
        {
            if ((pbox_Malal.Bounds.IntersectsWith(lbl_left.Bounds)))
            {
                GhX = pbox_Malal.Location.X;
                GhY = pbox_Malal.Location.Y;
                pbox_Malal.Location = new Point(GhX - 10, GhY);
            }
            else if ((pbox_Malal.Bounds.IntersectsWith(pbox_Wall3b.Bounds)))
            {
                this.Close();
            }
        }
    }
    }

 
