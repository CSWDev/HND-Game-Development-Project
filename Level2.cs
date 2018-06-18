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
    public partial class Level2 : Form
    {
        private SoundPlayer boss, jump;
        //Public variables
        int EnX, EnY, life = 3, score;
        int arrowNum = 0;
        int arrowX, arrowY;
        int arrowDist = 0, arrowCount = 0;
        string curDirection, FiredDirection;
        bool Jump = false;
        bool right;
        bool left;
        int G = 30;
        int force;
        int index = 0;
        

        public Level2(string level1Score)
        {
            InitializeComponent();
            lbl_ScoreResult.Text = level1Score;
            pbox_Player.Top = panel1.Height - pbox_Player.Height;
            //  boss = new SoundPlayer("Boss.wav");
            jump = new SoundPlayer("Jump.wav");
        }
        private void LifeLoss()
        {
            life--;
            if (life == 3)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = true;
                pbox_PlayerHealth3.Visible = true;
            }
            else if (life == 2)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = true;
                pbox_PlayerHealth3.Visible = false;
                pbox_Player.Location = new Point(528, 990);
            }
            else if (life == 1)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = false;
                pbox_PlayerHealth3.Visible = false;
                pbox_Player.Location = new Point(528, 990);
            }
            else if  (life == 0) 
            {
                pbox_PlayerHealth.Visible = false;
                pbox_PlayerHealth2.Visible = false;
                pbox_PlayerHealth3.Visible = false;
                this.Hide();
                GameOver newform = new GameOver();
                newform.ShowDialog();
                this.Close();
            }
        }
        private void heal()
        {
            if ((pbox_Player.Bounds.IntersectsWith(pbox_heal.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);

                if (life == 2)
                {
                    newscore = newscore + 10;
                    lbl_ScoreResult.Text = newscore.ToString();
                    life = life + 1;
                    pbox_PlayerHealth.Visible = true;
                    pbox_PlayerHealth2.Visible = true;
                    pbox_PlayerHealth3.Visible = true;
                }
                else if (life == 1)
                {
                    newscore = newscore + 15;
                    lbl_ScoreResult.Text = newscore.ToString();
                    life = life + 2;
                    pbox_PlayerHealth.Visible = true;
                    pbox_PlayerHealth2.Visible = true;
                    pbox_PlayerHealth3.Visible = true;
                }
                else { }
            }
        }
        private void ArrowCount()
        {


            if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow1.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore + 5;
                lbl_ScoreResult.Text = newscore.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow1.Location = new Point(1785, 167);
                pbox_Arrow1.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();


            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow2.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore + 5;
                lbl_ScoreResult.Text = newscore.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow2.Location = new Point(1785, 167);
                pbox_Arrow2.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow3.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore + 5;
                lbl_ScoreResult.Text = newscore.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow3.Location = new Point(1785, 167);
                pbox_Arrow3.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow4.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore + 5;
                lbl_ScoreResult.Text = newscore.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow4.Location = new Point(1785, 167);
                pbox_Arrow4.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow5.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore + 5;
                lbl_ScoreResult.Text = newscore.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow5.Location = new Point(1785, 167);
                pbox_Arrow5.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }

        }
        private void EndLevel2()
        {
            if ((pbox_Player.Bounds.IntersectsWith(lbl_EndLevel2.Bounds)))
            {
                timer1_ManaBall.Enabled = false;
                timer1_MoveLeft.Enabled = false;
                timer1_MoveRight.Enabled = false;
                timer1_MoveUp.Enabled = false;
                this.Hide();
                Boss newForm2 = new Boss();
                newForm2.ShowDialog();
                this.Close();             
            }
        }
       
        private void Level2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
          //  boss.PlayLooping();
        }

        private void timer1_MoveLeft_Tick(object sender, EventArgs e)
        {
            PlatCollisions();
            Collisions();
            ArrowCount();
            heal();
            EndLevel2();
        }
        private void timer1_Plat14Up_Tick(object sender, EventArgs e)
        {
            Plat14();
        }

       

        //movement for the player
        private void timer1_MoveUp_Tick(object sender, EventArgs e)
        {     
            if (Jump == true)
            {
                pbox_Player.Top -= force;
                force -= 2;
            }

            if (pbox_Player.Top + pbox_Player.Height >= panel1.Height)
            {
                pbox_Player.Top = panel1.Height - pbox_Player.Height;
                Jump = false;
            }
            else
            {
                pbox_Player.Top += 5;
            }               
        }

        //end

        //Enviroment controls
        private void Plat14()
        {
            if ((pbox_Plat14.Bounds.IntersectsWith(lbl_Up.Bounds)))
            {
                EnX = pbox_Plat14.Location.X;
                EnY = pbox_Plat14.Location.Y;
                pbox_Plat14.Location = new Point(EnX, EnY - 5);
            }
            else if ((pbox_Plat14.Bounds.IntersectsWith(lbl_Down.Bounds)))
            {
                EnX = pbox_Plat14.Location.X;
                EnY = pbox_Plat14.Location.Y;
                pbox_Plat14.Location = new Point(EnX, EnY + 5);
            }
            else if ((pbox_Plat14.Bounds.IntersectsWith(lbl_Right.Bounds)))
            {
                EnX = pbox_Plat14.Location.X;
                EnY = pbox_Plat14.Location.Y;
                pbox_Plat14.Location = new Point(EnX + 5, EnY);
            }
            else if ((pbox_Plat14.Bounds.IntersectsWith(lbl_Left.Bounds)))
            {
                EnX = pbox_Plat14.Location.X;
                EnY = pbox_Plat14.Location.Y;
                pbox_Plat14.Location = new Point(EnX - 5, EnY);
            }
        }
        private void HazardHex()
        {
            if ((pbox_M.Bounds.IntersectsWith(lbl_left23.Bounds)))
            {
                EnY = pbox_M.Location.Y;
                EnX = pbox_M.Location.X;
                pbox_M.Location = new Point(EnX - 5, EnY);
                pbox_M.Enabled = true;
            }
            else if ((pbox_M.Bounds.IntersectsWith(pbox_Wall3b.Bounds)))
            {
                pbox_M.Location = new Point(1236, 404);
                pbox_M.Enabled = false;
            }
            
        }
        private void HazardHexAttack()
        {
            if ((pbox_M.Bounds.IntersectsWith(pbox_Player.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore - 5;
                lbl_ScoreResult.Text = newscore.ToString();
                LifeLoss();
            }
            else { }
        }
        private void HazardHex1()
        {
            if ((pbox_Mana2.Bounds.IntersectsWith(lbl_right1.Bounds)))
            {
                EnX = pbox_Mana2.Location.X;
                EnY = pbox_Mana2.Location.Y;
                pbox_Mana2.Location = new Point(EnX + 5, EnY);
                pbox_Mana2.Enabled = true;
            }
            else if ((pbox_Mana2.Bounds.IntersectsWith(lbl_altercourse2.Bounds)))
            {
                EnX = pbox_Mana2.Location.X;
                EnY = pbox_Mana2.Location.Y;
                pbox_Mana2.Location = new Point(512, 688);
            }
            else if ((pbox_Mana2.Bounds.IntersectsWith(pbox_Wall2b.Bounds)))
            {
                pbox_Mana2.Enabled = false;
            }    
        }
        private void HazardHex2()
        {
            if ((pbox_M3.Bounds.IntersectsWith(lbl_downMana.Bounds)))
            {
                EnX = pbox_M3.Location.X;
                EnY = pbox_M3.Location.Y;
                pbox_M3.Location = new Point(EnX, EnY + 5);
            }
            else if ((pbox_M3.Bounds.IntersectsWith(pbox_Plat3.Bounds)))
            {
                pbox_M3.Location = new Point(905, 233);
            }

        }
        private void HazardHexAttack1()
        {
            if ((pbox_Mana2.Bounds.IntersectsWith(pbox_Player.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore - 5;
                lbl_ScoreResult.Text = newscore.ToString();
                LifeLoss();
            }
            else { }
        }
        private void HazardHexAttack3()
        {
            if ((pbox_M3.Bounds.IntersectsWith(pbox_Player.Bounds)))
            {
                int newscore = int.Parse(lbl_ScoreResult.Text);
                newscore = newscore - 5;
                lbl_ScoreResult.Text = newscore.ToString();
                LifeLoss();
            }
            else { }
        }
        private void PlatCollisions()
        {          
                        
           // side collision
             if (pbox_Player.Left < pbox_Wall3b.Right && pbox_Player.Right > pbox_Wall3b.Left + pbox_Player.Width / 2 && pbox_Player.Bottom > pbox_Wall3b.Top)
               {
                   left = false;
               }

            else if (pbox_Player.Left < pbox_Wall1b.Right && pbox_Player.Right > pbox_Wall1b.Left + pbox_Player.Width / 2 && pbox_Player.Bottom > pbox_Wall1b.Top)
               {
                   left = false;
               }

            else if (pbox_Player.Right > pbox_Wall2b.Left && pbox_Player.Left < pbox_Wall2b.Right + pbox_Player.Width / 2 && pbox_Player.Bottom > pbox_Wall2b.Top)
               {
                   right = false;
               }

            else if (pbox_Player.Right > pbox_Wall4b.Left && pbox_Player.Left < pbox_Wall4b.Right + pbox_Player.Width / 2 && pbox_Player.Bottom > pbox_Wall4b.Top)
               {
                   right = false;
               }


          
            //jump
            if (right == true)
            {
                pbox_Player.Left += 5;
            }
            if (left == true)
            {
                pbox_Player.Left -= 5;
            }
        }


        private void timer1_ManaBall_Tick(object sender, EventArgs e)
        {
            HazardHex(); HazardHex1(); HazardHexAttack(); HazardHexAttack1(); HazardHex2(); HazardHexAttack3();
        }
        //end


        //player controlls
        private void Level2_KeyDown(object sender, KeyEventArgs e)
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
           
        }
        private void Level2_KeyUp(object sender, KeyEventArgs e)
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

       
        //end
        private void Collisions()
        {
            if (pbox_Player.Left + pbox_Player.Width > pbox_Plat.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat.Left + pbox_Plat.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat.Top && pbox_Player.Top < pbox_Plat.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat.Location.Y - pbox_Player.Height;
            }
            else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat2.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat2.Left + pbox_Plat2.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat2.Top && pbox_Player.Top < pbox_Plat2.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat2.Location.Y - pbox_Player.Height;
            }
           else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat3.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat3.Left + pbox_Plat3.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat3.Top && pbox_Player.Top < pbox_Plat3.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat3.Location.Y - pbox_Player.Height;
            }
           else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat4.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat4.Left + pbox_Plat4.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat4.Top && pbox_Player.Top < pbox_Plat4.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat4.Location.Y - pbox_Player.Height;
            }
           else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat5.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat5.Left + pbox_Plat5.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat5.Top && pbox_Player.Top < pbox_Plat5.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat5.Location.Y - pbox_Player.Height;
            }
           else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat6.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat6.Left + pbox_Plat6.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat6.Top && pbox_Player.Top < pbox_Plat6.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat6.Location.Y - pbox_Player.Height;
            }
            else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat7.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat7.Left + pbox_Plat7.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat7.Top && pbox_Player.Top < pbox_Plat7.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat7.Location.Y - pbox_Player.Height;
            }
           else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat8.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat8.Left + pbox_Plat8.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat8.Top && pbox_Player.Top < pbox_Plat8.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat8.Location.Y - pbox_Player.Height;
            }
           else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat9.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat9.Left + pbox_Plat9.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat9.Top && pbox_Player.Top < pbox_Plat9.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat9.Location.Y - pbox_Player.Height;
            }
          else  if (pbox_Player.Left + pbox_Player.Width > pbox_Plat10.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat10.Left + pbox_Plat10.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat10.Top && pbox_Player.Top < pbox_Plat10.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat10.Location.Y - pbox_Player.Height;
            }
         else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat11.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat11.Left + pbox_Plat11.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat11.Top && pbox_Player.Top < pbox_Plat11.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat11.Location.Y - pbox_Player.Height;
            }
         else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat12.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat12.Left + pbox_Plat12.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat12.Top && pbox_Player.Top < pbox_Plat12.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat12.Location.Y - pbox_Player.Height;
            }
         else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat13.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat13.Left + pbox_Plat13.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat13.Top && pbox_Player.Top < pbox_Plat13.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat13.Location.Y - pbox_Player.Height;
            }
         else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat14.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat14.Left + pbox_Plat14.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat14.Top && pbox_Player.Top < pbox_Plat14.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat14.Location.Y - pbox_Player.Height;
            }
            else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat15.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat15.Left + pbox_Plat15.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat15.Top && pbox_Player.Top < pbox_Plat15.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat15.Location.Y - pbox_Player.Height;
            }
            else if (pbox_Player.Left + pbox_Player.Width > pbox_Plat16.Left && pbox_Player.Left + pbox_Player.Width < pbox_Plat16.Left + pbox_Plat16.Width + pbox_Player.Width && pbox_Player.Top + pbox_Player.Height >= pbox_Plat16.Top && pbox_Player.Top < pbox_Plat16.Top)
            {
                force = 0;
                Jump = false;
                pbox_Player.Top = pbox_Plat16.Location.Y - pbox_Player.Height;
            }
        }
    }
}
