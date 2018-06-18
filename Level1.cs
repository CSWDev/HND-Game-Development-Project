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
    public partial class Level1 : Form
    {
        private SoundPlayer boss, pain, gate, lever, walk;
        //Public variables
        int x, y, EnX, EnY, GhX, GhY, life = 3, score = 0;
        int arrowNum = 0;
        int KeyForChest = 0;
        int KeyForGate = 0;
        int arrowX, arrowY;
        int arrowDist = 0, arrowCount = 0;
        string curDirection, FiredDirection;
        int kills = 0;
        bool ArrowEnable = false;     
        //---------------------------------------------------
        public Level1()
        {
            InitializeComponent();
            string level1Score;
            life = 3;
            score = 0;
            //boss = new SoundPlayer("Boss.wav");
            pain = new SoundPlayer("Pain.wav");
            lever = new SoundPlayer("Lever.wav");
            gate = new SoundPlayer("Opengate.wav");
            //walk = new SoundPlayer("walk.wav");
        }


        //subroutines
        private void LifeLoss()
        {
            life --;
            if (life == 3)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = true;
                pbox_PlayerHealth3.Visible = true;
                pain.Play();
            }
            else if (life == 2)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = true;
                pbox_PlayerHealth3.Visible = false;
                pbox_Player.Location = new Point(11, 878);
                pain.Play();
            }
            else if (life == 1)
            {
                pbox_PlayerHealth.Visible = true;
                pbox_PlayerHealth2.Visible = false;
                pbox_PlayerHealth3.Visible = false;
                pbox_Player.Location = new Point(11, 878);
                pain.Play();
            }
            else if (life == 0)
            {
                pbox_PlayerHealth.Visible = false;
                pbox_PlayerHealth2.Visible = false;
                pbox_PlayerHealth3.Visible = false;
                pain.Play();
                this.Hide();
                GameOver newform = new GameOver();
                newform.ShowDialog();
                this.Close();
            }
        }
        private void Score()
        {
            
            if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow1.Bounds)))
            {
               score =  score + 5;
               lbl_ScoreResult.Text.ToString();

            }
        }
        private void KeyChest()
        {
            if ((pbox_Player.Bounds.IntersectsWith(pbox_Chestkey.Bounds)))
            {
                KeyForChest = 1;
                pbox_Chestkey.Visible = false;
                pbox_Chestkey.Location = new Point(1290, 1000);
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "It'll come in handy..";

            }
            else { }
        }
        private void KeyGate()
        {
            if ((pbox_Player.Bounds.IntersectsWith(pbox_Key.Bounds)))
            {
                KeyForGate = 1;
                pbox_Key.Visible = false;
                pbox_Key.Location = new Point(1290, 1200);
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "Brilliant, take the key to the gate..welp.";
            }
            else { }
        }
        private void ArrowCount()
        {
            

            if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow1.Bounds)))
            {
                score = score + 5;
                lbl_ScoreResult.Text = score.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow1.Location = new Point(1785, 167);
                pbox_Arrow1.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();

             
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow2.Bounds)))
            {
                score = score + 5;
                lbl_ScoreResult.Text = score.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow2.Location = new Point(1785, 167);
                pbox_Arrow2.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow3.Bounds)))
            {
                score = score + 5;
                lbl_ScoreResult.Text = score.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow3.Location = new Point(1785, 167);
                pbox_Arrow3.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow4.Bounds)))
            {
                score = score + 5;
                lbl_ScoreResult.Text = score.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow4.Location = new Point(1785, 167);
                pbox_Arrow4.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Arrow5.Bounds)))
            {
                score = score + 5;
                lbl_ScoreResult.Text = score.ToString();
                arrowCount = arrowCount + 1;
                pbox_Arrow5.Location = new Point(1785, 167);
                pbox_Arrow5.Visible = false;
                lbl_ArrowCount.Text = arrowCount.ToString();
            }
            
        }
        private void ArrowHitMarker()
        {
            if ((pbox_AttackArrow.Bounds.IntersectsWith(pbox_Enemy1.Bounds)))
            {
                timer1_GhostMovement1.Stop();
                pbox_Enemy1.Visible = false;
                pbox_Enemy1.Enabled = false;
                pbox_Enemy1.Location = new Point(1671, 131);
                timer1_Arrow.Stop();
                pbox_AttackArrow.Visible = false;
                pbox_AttackArrow.Location = new Point(1671, 131);
                arrowDist = 0;

            }
            if ((pbox_AttackArrow.Bounds.IntersectsWith(pbox_Enemy2.Bounds)))
            {
                timer1_GhostMovement2.Stop();
                pbox_Enemy2.Visible = false;
                pbox_Enemy2.Enabled = false;
                pbox_Enemy2.Location = new Point(1671, 131);
                timer1_Arrow.Stop();
                pbox_AttackArrow.Visible = false;
                pbox_AttackArrow.Location = new Point(1671, 131);
                arrowDist = 0;

            }
            if ((pbox_AttackArrow.Bounds.IntersectsWith(pbox_enemy3.Bounds)))
            {
                timer1_GhostMovement1.Stop();
                pbox_enemy3.Visible = false;
                pbox_enemy3.Enabled = false;
                pbox_enemy3.Location = new Point(1671, 131);
                timer1_Arrow.Stop();
                pbox_AttackArrow.Visible = false;
                pbox_AttackArrow.Location = new Point(1671, 131);
                arrowDist = 0;

            }
        }
        private void ArrowBarrier()
        {
            if ((pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall1.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall2.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall3.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall4.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall5.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall6.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall7.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall8.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall9.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall10.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall11.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall12.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall13.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall14.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall15.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall16.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall17.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall18.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall19.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall20.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall21.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall22.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall23.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall24.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall25.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall26.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall27.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall28.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall29.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall30.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall31.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall32.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall33.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_Wall34.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_FakeWall.Bounds)) ||
              (pbox_AttackArrow.Bounds.IntersectsWith(pbox_FakeWall2.Bounds)))
            {
                pbox_AttackArrow.Location = new Point(x, y);
            }
        }
        private void ChestReward()
        {

            if ((pbox_Player.Bounds.IntersectsWith(pbox_Chest.Bounds)) && KeyForChest == 1)
            {
                
                score = score + 100;
                lbl_ScoreResult.Text = score.ToString();
                pbox_Chest.Visible = false;
                pbox_Chest.Location = new Point(1800, 1290);
                
            }
            else { }
            
        }
        private void GateUnlock()
        {
            if ((pbox_Player.Bounds.IntersectsWith(pbox_barredGate.Bounds)) && KeyForGate == 1)
            {
                pbox_OpenedGate.Visible = true;
                pbox_OpenedGate.Location = new Point(244, 799);
                pbox_barredGate.Visible = false;
                pbox_barredGate.Location = new Point(1290, 1200);
                gate.Play();
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "Nicely done..";

            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_barredGate.Bounds)) && KeyForGate == 0)
            {
                pbox_Player.Location = new Point(x, y);
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "The key...yes, that one...get it..";
                

            }
        }
        private void Dialogue()
        {
            if ((pbox_Player.Bounds.IntersectsWith(lbl_dialgueTrigger.Bounds)))
            {
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "Beware, all isn't as it seems...";
                lbl_dialgueTrigger.Location = new Point(1200, 1200);

            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_TrapKey.Bounds)))
            {
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "HAHAH, Told you so..";

            }
            else if ((pbox_Player.Bounds.IntersectsWith(lbl_silence.Bounds)))
            {
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "You'll want to avoid those ghouls..";
            }
            else if ((pbox_Player.Bounds.IntersectsWith(pbox_Chest.Bounds)) && KeyForChest == 0)
            {
                lbl_GateDialogue.Text = "";
                lbl_GateDialogue.Text = "You need a key";
            }

        }


        //Managing the trap key 
        private void KeyTrap()
        {
            if (pbox_Player.Bounds.IntersectsWith(pbox_TrapKey.Bounds))
            {
                pbox_Trap1.Visible = true; pbox_Trap2.Visible = true;

                pbox_TrapKey.Visible = false;
            }
            else if (pbox_Player.Bounds.IntersectsWith(pbox_Trap1.Bounds))
            {
                LifeLoss();
            }
            else if (pbox_Player.Bounds.IntersectsWith(pbox_Trap2.Bounds))
            {
                LifeLoss();
            }
            else if (pbox_Player.Bounds.IntersectsWith(pbox_TrapKey.Bounds))
            {
                LifeLoss();
            }
        }


        //Used for the trap area
        private void LeverTrap()
        {
            if (pbox_Player.Bounds.IntersectsWith(pbox_LeverClosed.Bounds))
            {
                //relocating spikes & making them visible
                pbox_SpikeTrap.Location = new Point(1364, -33);
                pbox_SpikeTrap1.Location = new Point(1172, 151);
                pbox_SpikeTrap2.Location = new Point(1060, -12);
                pbox_SpikeTrap3.Location = new Point(946, 154);
                pbox_SpikeTrap1.Visible = true;
                pbox_SpikeTrap2.Visible = true;
                pbox_SpikeTrap3.Visible = true;
                pbox_SpikeTrap.Visible = true;

                pbox_LeverClosed.Location = new Point(850, 75);
                pbox_LeverOpen.Visible = true;

                pbox_LeverOpen.Location = new Point(850, 75);
                pbox_LeverClosed.Visible = false;
            }
            else
            { }
        }
        private void LeverTrapSpikes()
        {
            if (pbox_SpikeTrap.Bounds.IntersectsWith(pbox_Player.Bounds))
            {
                LifeLoss();
            }
            else if (pbox_SpikeTrap1.Bounds.IntersectsWith(pbox_Player.Bounds))
            {
                LifeLoss();
            }
            else if (pbox_SpikeTrap2.Bounds.IntersectsWith(pbox_Player.Bounds))
            {
                LifeLoss();
            }
            else if (pbox_SpikeTrap3.Bounds.IntersectsWith(pbox_Player.Bounds))
            {
                LifeLoss();
            }
        }
        //end


        //Used to open one of the false walls 
        private void LeverOpen1()
        {
            if (pbox_Player.Bounds.IntersectsWith(pbox_LeverOpen.Bounds))
            {
                if (pbox_FakeWall.Location.Y >= 320)
                {
                    pbox_LeverClosed.Visible = false;
                    pbox_LeverOpen.Visible = true;

                    EnX = pbox_FakeWall.Location.X;
                    EnY = pbox_FakeWall.Location.Y;

                    pbox_FakeWall.Enabled = false;
                    pbox_FakeWall.Location = new Point(1785, 137);
                    lever.Play();
                }

                else { }
            }
        }
        private void LeverOpen2()
        {
            if (pbox_Player.Bounds.IntersectsWith(pbox_LeverClosed1.Bounds))
            {
                pbox_LeverClosed1.Visible = false;
                pbox_LeverOpen1.Visible = true;

                EnX = pbox_FakeWall2.Location.X;
                EnY = pbox_FakeWall2.Location.Y;

                pbox_FakeWall2.Enabled = false;
                pbox_FakeWall2.Location = new Point(1785, 137);
                lever.Play();
            }
        }
        //end


        //stopping the player from ghosting through the walls 
        private void WallCollision()
        {
            if ((pbox_Player.Bounds.IntersectsWith(pbox_Wall1.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall2.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall3.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall4.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall5.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall6.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall7.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall8.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall9.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall10.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall11.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall12.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall13.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall14.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall15.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall16.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall17.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall18.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall19.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall20.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall21.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall22.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall23.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall24.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall25.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall26.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall27.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall28.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall29.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall30.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall31.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall32.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall33.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_Wall34.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_FakeWall.Bounds)) ||
               (pbox_Player.Bounds.IntersectsWith(pbox_FakeWall2.Bounds)))
            {
                pbox_Player.Location = new Point(x, y);
            }   
        }     
        //end

        // When this form is accessed it will automatically maximise
        private void Level1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;      
            WindowState = FormWindowState.Maximized;
           // boss.PlayLooping();
            
        }
        string level1Score;
        private void EndLevel()
        {
            level1Score = lbl_ScoreResult.Text;
            timer1_MoveLeft.Enabled = false;
            timer2_MoveRight.Enabled = false;
            timer4_MoveUp.Enabled = false;
            timer3_MoveDown.Enabled = false;
            this.Hide();
            Level2 newForm1 = new Level2(level1Score);
            newForm1.ShowDialog();
            this.Close();
        }
        //end  


        //Subroutines used for movement
        private void MoveLeft()
        {
            x = pbox_Player.Location.X;
            y = pbox_Player.Location.Y;
            pbox_Player.Image = Properties.Resources.Knight_Player2_fw;

            pbox_Player.Location = new Point(x - 10, y);
            pbox_Player.Image = Properties.Resources.Knight_Left_gif;
            

            if (pbox_Player.Left <= 0)
            {
                pbox_Player.Location = new Point(x, y);
            }
       
        }
        private void MoveRight()
        {
            x = pbox_Player.Location.X;
            y = pbox_Player.Location.Y;
            pbox_Player.Image = Properties.Resources.Knight_Right__2_;

            pbox_Player.Location = new Point(x + 10, y);
            

            if (pbox_Player.Right >= 1999)
            {
                pbox_Player.Location = new Point(x - 10, y);
            }
            else if ((pbox_Player.Bounds.IntersectsWith(lbl_EndLevel.Bounds)))
            {
                EndLevel();
            }
        }
        private void MoveUP()
        {
            x = pbox_Player.Location.X;
            y = pbox_Player.Location.Y;
            pbox_Player.Image = Properties.Resources.Knight_PlayerUP;
            
            pbox_Player.Location = new Point(x, y - 10);
        }
        private void MoveDown()
        {
            x = pbox_Player.Location.X;
            y = pbox_Player.Location.Y;
            pbox_Player.Image = Properties.Resources.Knight_PlayerDown;
            
            pbox_Player.Location = new Point(x, y + 10);

            if (pbox_Player.Bottom >= 1080)
            {
                pbox_Player.Location = new Point(x, y);
            }
        }
        //end


        //Enemy Movement
        private void Enemy1()
        {
            if ((pbox_Enemy1.Bounds.IntersectsWith(lbl_left.Bounds)))
            {
                GhX = pbox_Enemy1.Location.X;
                GhY = pbox_Enemy1.Location.Y;
                pbox_Enemy1.Location = new Point(GhX - 5, GhY);
            }
            else if ((pbox_Enemy1.Bounds.IntersectsWith(lbl_Up.Bounds)))
            {
                GhX = pbox_Enemy1.Location.X;
                GhY = pbox_Enemy1.Location.Y;
                pbox_Enemy1.Location = new Point(GhX, GhY - 5);
            }
            else if ((pbox_Enemy1.Bounds.IntersectsWith(lbl_right.Bounds)))
            {
                GhX = pbox_Enemy1.Location.X;
                GhY = pbox_Enemy1.Location.Y;
                pbox_Enemy1.Location = new Point(GhX + 5, GhY);
            }
            else if ((pbox_Enemy1.Bounds.IntersectsWith(lbl_Down.Bounds)))
            {
                GhX = pbox_Enemy1.Location.X;
                GhY = pbox_Enemy1.Location.Y;
                pbox_Enemy1.Location = new Point(GhX, GhY + 5);
            }
            
        }
        private void Enemy2()
        {
            if ((pbox_Enemy2.Bounds.IntersectsWith(lbl_Down2.Bounds)))
            {
                GhX = pbox_Enemy2.Location.X;
                GhY = pbox_Enemy2.Location.Y;
                pbox_Enemy2.Location = new Point(GhX, GhY + 5);
            }
            else if ((pbox_Enemy2.Bounds.IntersectsWith(lbl_right2.Bounds)))
            {
                GhX = pbox_Enemy2.Location.X;
                GhY = pbox_Enemy2.Location.Y;
                pbox_Enemy2.Location = new Point(GhX + 5, GhY);
            }
            else if ((pbox_Enemy2.Bounds.IntersectsWith(lbl_Up2.Bounds)))
            {
                GhX = pbox_Enemy2.Location.X;
                GhY = pbox_Enemy2.Location.Y;
                pbox_Enemy2.Location = new Point(GhX, GhY - 5);
                
            }
            else if ((pbox_Enemy2.Bounds.IntersectsWith(lbl_Down3.Bounds)))
            { 
                GhX = pbox_Enemy2.Location.X;
                GhY = pbox_Enemy2.Location.Y;
                pbox_Enemy2.Location = new Point(GhX, GhY + 5);
                pbox_Enemy2.Location = new Point(676, 268);
            }
        }
        private void Enemy3()
        {
            if ((pbox_enemy3.Bounds.IntersectsWith(lbl_Left2.Bounds)))
            {
                GhX = pbox_enemy3.Location.X;
                GhY = pbox_enemy3.Location.Y;
                pbox_enemy3.Location = new Point(GhX - 10, GhY);
            }
            else if ((pbox_enemy3.Bounds.IntersectsWith(lbl_Up3.Bounds)))
            {
                GhX = pbox_enemy3.Location.X;
                GhY = pbox_enemy3.Location.Y;
                pbox_enemy3.Location = new Point(GhX, GhY - 10);
            }
            else if ((pbox_enemy3.Bounds.IntersectsWith(lbl_right3.Bounds)))
            {
                GhX = pbox_enemy3.Location.X;
                GhY = pbox_enemy3.Location.Y;
                pbox_enemy3.Location = new Point(GhX + 10, GhY);
            }
            else if ((pbox_enemy3.Bounds.IntersectsWith(lbl_down4.Bounds)))
            {
                GhX = pbox_enemy3.Location.X;
                GhY = pbox_enemy3.Location.Y;
                pbox_enemy3.Location = new Point(GhX, GhY + 10);
            }
        }
        //end

        //Enemy attack subroutines
        private void Enemy1Attack()
        {
            if ((pbox_Enemy1.Bounds.IntersectsWith(pbox_Player.Bounds)))
            {
                score = score - 5;
                lbl_ScoreResult.Text = score.ToString();
                LifeLoss();                       
            }
        }
        private void Enemy2Attack()
        {
            if ((pbox_Enemy2.Bounds.IntersectsWith(pbox_Player.Bounds)))
            {
                score = score - 5;
                lbl_ScoreResult.Text = score.ToString();
                LifeLoss();                
            }
        }
        private void Enemy3Attack()
        {
            if ((pbox_enemy3.Bounds.IntersectsWith(pbox_Player.Bounds)))
            {
                score = score - 5;
                lbl_ScoreResult.Text = score.ToString();
                LifeLoss();               
            }
        }

   


        //end


        //Control management 
        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.A)
            {
                timer1_MoveLeft.Enabled = true;
                timer3_MoveDown.Enabled = false;
                timer4_MoveUp.Enabled = false;
                timer2_MoveRight.Enabled = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                timer2_MoveRight.Enabled = true;
                timer1_MoveLeft.Enabled = false;
                timer3_MoveDown.Enabled = false;
                timer4_MoveUp.Enabled = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                timer3_MoveDown.Enabled = true;
                timer1_MoveLeft.Enabled = false;
                timer4_MoveUp.Enabled = false;
                timer2_MoveRight.Enabled = false;
            }
            else if (e.KeyCode == Keys.W)
            {
                timer4_MoveUp.Enabled = true;
                timer2_MoveRight.Enabled = false;
                timer1_MoveLeft.Enabled = false;
                timer3_MoveDown.Enabled = false;
            }
            else if (e.KeyCode == Keys.P)
            {
                timer1_Arrow.Enabled = true;
            }
        }
        private void Level1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                timer1_MoveLeft.Enabled = false;
                timer2_MoveRight.Enabled = false;
                timer3_MoveDown.Enabled = false;
                timer4_MoveUp.Enabled = false;
                KeyTrap();
                LeverTrapSpikes();
                LeverTrap();
                LeverOpen1();
                WallCollision();
                LeverOpen2();
            }
            else if (e.KeyCode == Keys.D)
            {
                timer1_MoveLeft.Enabled = false;
                timer2_MoveRight.Enabled = false;
                timer3_MoveDown.Enabled = false;
                timer4_MoveUp.Enabled = false;
                KeyTrap();
                LeverTrapSpikes();
                LeverTrap();
                LeverOpen1();
                WallCollision();
                LeverOpen2();
            }
            else if (e.KeyCode == Keys.S)
            {
                timer1_MoveLeft.Enabled = false;
                timer2_MoveRight.Enabled = false;
                timer3_MoveDown.Enabled = false;
                timer4_MoveUp.Enabled = false;
                KeyTrap();
                LeverTrapSpikes();
                LeverTrap();
                LeverOpen1();
                WallCollision();
                LeverOpen2();
            }
            else if (e.KeyCode == Keys.W)
            {
                timer1_MoveLeft.Enabled = false;
                timer2_MoveRight.Enabled = false;
                timer3_MoveDown.Enabled = false;
                timer4_MoveUp.Enabled = false;
                KeyTrap();
                LeverTrapSpikes();
                LeverTrap();
                LeverOpen1();
                WallCollision();
                LeverOpen2();
            }
        }

        private void timer1_Arrow_Tick(object sender, EventArgs e)
        {
            if (curDirection == "Left")
            {
                if (arrowDist < 200)
                {
                    ArrowBarrier();
                    arrowDist = arrowDist + 10;
                    
                    ArrowHitMarker();

                }
                else if (arrowDist >= 200)
                {
                    timer1_Arrow.Stop();
                    pbox_AttackArrow.Visible = false;
                    pbox_AttackArrow.Location = new Point(1671, 131);
                    arrowDist = 0;
                }
            }
            else if (curDirection == "Right")
            {
                if (arrowDist < 200)
                {
                    ArrowBarrier();
                    arrowDist = arrowDist + 10;
                    
                    ArrowHitMarker();
                }
                else if (arrowDist >= 200)
                {
                    timer1_Arrow.Stop();
                    pbox_AttackArrow.Visible = false;
                    pbox_AttackArrow.Location = new Point(1671, 131);
                    arrowDist = 0;
                }
            }
            else if (curDirection == "Up")
            {
                if (arrowDist < 200)
                {
                    ArrowBarrier();
                    arrowDist = arrowDist + 10;
                    ;
                    ArrowHitMarker();
                }
                else if (arrowDist >= 200)
                {
                    timer1_Arrow.Stop();
                    pbox_AttackArrow.Visible = false;
                    pbox_AttackArrow.Location = new Point(1671, 131);
                    arrowDist = 0;
                }
            }
            else if (curDirection == "Down")
            {
                if (arrowDist < 200)
                {
                    ArrowBarrier();
                    arrowDist = arrowDist + 10;
                    
                    ArrowHitMarker();
                }
                else if (arrowDist >= 200)
                {
                    timer1_Arrow.Stop();
                    pbox_AttackArrow.Visible = false;
                    pbox_AttackArrow.Location = new Point(1671, 131);
                    arrowDist = 0;
                }
            }
        }

        //end


        //enabling the sub-routine for enemy movement
        private void timer1_GhostMovement1_Tick(object sender, EventArgs e)
        {
            Enemy1();
            Enemy1Attack();
        }
        private void timer1_GhostMovement2_Tick(object sender, EventArgs e)
        {
            Enemy2();
            Enemy2Attack();
        }
        private void timer1_GhostMovement3_Tick(object sender, EventArgs e)
        {
            Enemy3();
            Enemy3Attack();
        }
        //Stop movement here
        //end
        
        
        //Timers used for controlling the player
        private void timer3_MoveDown_Tick(object sender, EventArgs e)
        {
            MoveDown();
            ChestReward();
            KeyTrap();
            LeverTrapSpikes();
            LeverTrap();
            LeverOpen1();
            WallCollision();
            LeverOpen2();
            Score();
            ArrowCount();
            KeyChest();
            KeyGate();
            GateUnlock(); Dialogue();
        }
        private void timer4_MoveUp_Tick(object sender, EventArgs e)
        {
            
            MoveUP();
            ChestReward();
            KeyTrap();
            LeverTrapSpikes();
            LeverTrap();
            LeverOpen1();
            WallCollision();
            LeverOpen2();
            Score();
            ArrowCount();
            KeyChest();
            KeyGate();
            GateUnlock(); Dialogue();
        }
        private void timer1_MoveLeft_Tick(object sender, EventArgs e)
        {
            MoveLeft();
            ChestReward();
            KeyTrap();
            LeverTrapSpikes();
            LeverTrap();
            LeverOpen1();
            WallCollision();
            LeverOpen2();
            Score();
            ArrowCount();
            KeyChest();
            KeyGate();
            GateUnlock(); Dialogue();
        }
        private void timer2_MoveRight_Tick(object sender, EventArgs e)
        {
            MoveRight();
            ChestReward();
            LeverTrap();
            KeyTrap();
            LeverTrapSpikes();
            LeverOpen1();
            WallCollision();
            LeverOpen2();
            Score();
            ArrowCount();
            KeyChest();
            KeyGate();
            GateUnlock(); Dialogue();
        }
        //end
    }
}
