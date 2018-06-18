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
    public partial class EndGame : Form
    {
        private SoundPlayer Death;
        public EndGame()
        {
            InitializeComponent();
            Death = new SoundPlayer("Dark-Souls-Gwyn-Lord-of-Cinder.wav");

        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void lbl_titlescreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_TitleScreen newForm = new frm_TitleScreen();
            newForm.ShowDialog();
            this.Close();
        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
