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
    public partial class frm_TitleScreen : Form
    {
        private SoundPlayer boss;
        public frm_TitleScreen()
        {
            InitializeComponent();
            boss = new SoundPlayer("Boss.wav");
        }
        //Maximizes the application to fit the users screen
        private void frm_TitleScreen_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;       
            WindowState = FormWindowState.Maximized;
            boss.Play();
        }
        //when the control label is clicked it will display the controls in the bottom right 
        private void lbl_Controls_Click(object sender, EventArgs e)
        {
            pbox_Control.Visible = true;
            lbl_LeaveGame.Visible = true;
            lbl_ControlAttack.Visible = true;
            lbl_ControlLeft.Visible = true;
            lbl_ControlRight.Visible = true;
            lbl_ControlDown.Visible = true;
            lbl_ControlUP.Visible = true;
            lbl_ControlList.Visible = true;
            lbl_InstructionsClose.Visible = false;
            rtxt_Instr.Visible = false;
            rtxt_Instr.Text = "";
            lbl_Instructions.Visible = true;

        }
        //a key has been assigned to the 'escape' button to allow the player to quit the game if necessary
        private void frm_TitleScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
        //when the start game label is clicked then the current title form will be hidden, while the first level is loaded. Once it is loaded it will close the title screen in the background
        private void lbl_StartGame_Click(object sender, EventArgs e)
        {
            boss.Stop();
            this.Hide();
            Level1 newForm = new Level1();
            newForm.ShowDialog();
            this.Close();
        }
        //This is for displaying a rich textbox which has all of the user instructions within
        private void lbl_Instructions_Click(object sender, EventArgs e)
        {            
            rtxt_Instr.Visible = true;
            rtxt_Instr.ReadOnly = true;
            lbl_Instructions.Visible = false;
            lbl_InstructionsClose.Visible = true;
            pbox_Control.Visible = false;
            lbl_ControlList.Visible = false;
            lbl_LeaveGame.Visible = false;
            lbl_ControlAttack.Visible = false;
            lbl_ControlLeft.Visible = false;
            lbl_ControlRight.Visible = false;
            lbl_ControlDown.Visible = false;
            lbl_ControlUP.Visible = false;
            lbl_ControlList.Visible = false;
            lbl_Controls.Visible = true; 
            string Instruction;
            Instruction = rtxt_Instr.Text;
            rtxt_Instr.AppendText
                    ("User Instructions"
                    + Environment.NewLine
                    + Environment.NewLine
                    + "Cold Tower sees a young knight who has ventured into a cursed tower. Within this tower is a notoriously powerful and corrupt warlord known as 'Malal'. From Malal's tower he reigns supreme."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "The Knight will be tasked with navigating through the towers various levels in order to progress upwards to face Malal. Along the way there will be numerous traps and enemies that will damage the Knight. You will begin without the ability to attack enemies, there will be an emphasis on staying alive while progressing through the tower."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "Enemies are extremely dangerous and will instantly harm the Knight if they come into close proximity. Therefore, avoiding the enemies is a priority."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "The Knight in the dungeon (level 1), must collect arrows and progress though the trap and ghost filled dungeon."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "Once cleared, the Knight will find themselves in the next area of the tower.. Here they must jump on numerous platforms and collect arrows. There will be hexes that will damage the Knight if contact is made. So avoid them!"
                    + Environment.NewLine
                    + Environment.NewLine
                    + "Finally, the Warlord himself.. you have 5 chances to damage Malal, make sure you get him first or suffer death, instantly.");
            
            
            
               
            
        }
        //clicking the quit label will close the form
        private void lbl_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //clicking the controls label will hide the controls at the bottom-right of the screen
        private void lbl_ControlList_Click(object sender, EventArgs e)
        {
            pbox_Control.Visible = false;
            lbl_LeaveGame.Visible = false;
            lbl_ControlAttack.Visible = false;
            lbl_ControlLeft.Visible = false;
            lbl_ControlRight.Visible = false;
            lbl_ControlDown.Visible = false;
            lbl_ControlUP.Visible = false;
            lbl_ControlList.Visible = false;
        }
        //clcking the control label above the controls will hide them 
        private void lbl_InstructionsClose_Click(object sender, EventArgs e)
        {
            lbl_InstructionsClose.Visible = false;
            rtxt_Instr.Visible = false;
            rtxt_Instr.Text = "";
            lbl_Instructions.Visible = true;
            
        }
    }
}
