namespace Cold_Tower
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.lbl_Gameover = new System.Windows.Forms.Label();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.lbl_titlescreen = new System.Windows.Forms.Label();
            this.lbl_storyText = new System.Windows.Forms.Label();
            this.lbl_Scores = new System.Windows.Forms.Label();
            this.lbl_scoreLevel1 = new System.Windows.Forms.Label();
            this.lbl_scoreLevel2 = new System.Windows.Forms.Label();
            this.lbl_scoreBoss = new System.Windows.Forms.Label();
            this.lbl_score1 = new System.Windows.Forms.Label();
            this.lbl_score2 = new System.Windows.Forms.Label();
            this.lbl_score3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Gameover
            // 
            this.lbl_Gameover.AutoSize = true;
            this.lbl_Gameover.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gameover.ForeColor = System.Drawing.Color.White;
            this.lbl_Gameover.Location = new System.Drawing.Point(12, 28);
            this.lbl_Gameover.Name = "lbl_Gameover";
            this.lbl_Gameover.Size = new System.Drawing.Size(312, 73);
            this.lbl_Gameover.TabIndex = 1;
            this.lbl_Gameover.Text = "THE END";
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quit.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_quit.Location = new System.Drawing.Point(20, 244);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(57, 25);
            this.lbl_quit.TabIndex = 5;
            this.lbl_quit.Text = "Quit ";
            this.lbl_quit.Click += new System.EventHandler(this.lbl_quit_Click);
            // 
            // lbl_titlescreen
            // 
            this.lbl_titlescreen.AutoSize = true;
            this.lbl_titlescreen.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_titlescreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlescreen.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_titlescreen.Location = new System.Drawing.Point(20, 168);
            this.lbl_titlescreen.Name = "lbl_titlescreen";
            this.lbl_titlescreen.Size = new System.Drawing.Size(127, 25);
            this.lbl_titlescreen.TabIndex = 4;
            this.lbl_titlescreen.Text = "Title Screen";
            this.lbl_titlescreen.Click += new System.EventHandler(this.lbl_titlescreen_Click);
            // 
            // lbl_storyText
            // 
            this.lbl_storyText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_storyText.AutoSize = true;
            this.lbl_storyText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_storyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storyText.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_storyText.Location = new System.Drawing.Point(176, 342);
            this.lbl_storyText.Name = "lbl_storyText";
            this.lbl_storyText.Size = new System.Drawing.Size(1023, 100);
            this.lbl_storyText.TabIndex = 6;
            this.lbl_storyText.Text = resources.GetString("lbl_storyText.Text");
            // 
            // lbl_Scores
            // 
            this.lbl_Scores.AutoSize = true;
            this.lbl_Scores.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Scores.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Scores.Location = new System.Drawing.Point(262, 261);
            this.lbl_Scores.Name = "lbl_Scores";
            this.lbl_Scores.Size = new System.Drawing.Size(79, 25);
            this.lbl_Scores.TabIndex = 7;
            this.lbl_Scores.Text = "Scores";
            this.lbl_Scores.Visible = false;
            // 
            // lbl_scoreLevel1
            // 
            this.lbl_scoreLevel1.AutoSize = true;
            this.lbl_scoreLevel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_scoreLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreLevel1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_scoreLevel1.Location = new System.Drawing.Point(262, 311);
            this.lbl_scoreLevel1.Name = "lbl_scoreLevel1";
            this.lbl_scoreLevel1.Size = new System.Drawing.Size(67, 20);
            this.lbl_scoreLevel1.TabIndex = 8;
            this.lbl_scoreLevel1.Text = "Level 1 :";
            this.lbl_scoreLevel1.Visible = false;
            // 
            // lbl_scoreLevel2
            // 
            this.lbl_scoreLevel2.AutoSize = true;
            this.lbl_scoreLevel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_scoreLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreLevel2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_scoreLevel2.Location = new System.Drawing.Point(262, 346);
            this.lbl_scoreLevel2.Name = "lbl_scoreLevel2";
            this.lbl_scoreLevel2.Size = new System.Drawing.Size(67, 20);
            this.lbl_scoreLevel2.TabIndex = 9;
            this.lbl_scoreLevel2.Text = "Level 2 :";
            this.lbl_scoreLevel2.Visible = false;
            // 
            // lbl_scoreBoss
            // 
            this.lbl_scoreBoss.AutoSize = true;
            this.lbl_scoreBoss.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_scoreBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreBoss.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_scoreBoss.Location = new System.Drawing.Point(262, 381);
            this.lbl_scoreBoss.Name = "lbl_scoreBoss";
            this.lbl_scoreBoss.Size = new System.Drawing.Size(53, 20);
            this.lbl_scoreBoss.TabIndex = 10;
            this.lbl_scoreBoss.Text = "Boss :";
            this.lbl_scoreBoss.Visible = false;
            // 
            // lbl_score1
            // 
            this.lbl_score1.AutoSize = true;
            this.lbl_score1.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_score1.Location = new System.Drawing.Point(345, 311);
            this.lbl_score1.Name = "lbl_score1";
            this.lbl_score1.Size = new System.Drawing.Size(0, 20);
            this.lbl_score1.TabIndex = 11;
            // 
            // lbl_score2
            // 
            this.lbl_score2.AutoSize = true;
            this.lbl_score2.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_score2.Location = new System.Drawing.Point(345, 346);
            this.lbl_score2.Name = "lbl_score2";
            this.lbl_score2.Size = new System.Drawing.Size(0, 20);
            this.lbl_score2.TabIndex = 12;
            // 
            // lbl_score3
            // 
            this.lbl_score3.AutoSize = true;
            this.lbl_score3.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score3.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_score3.Location = new System.Drawing.Point(345, 381);
            this.lbl_score3.Name = "lbl_score3";
            this.lbl_score3.Size = new System.Drawing.Size(0, 20);
            this.lbl_score3.TabIndex = 13;
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cold_Tower.Properties.Resources.End;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 961);
            this.Controls.Add(this.lbl_score3);
            this.Controls.Add(this.lbl_score2);
            this.Controls.Add(this.lbl_score1);
            this.Controls.Add(this.lbl_scoreBoss);
            this.Controls.Add(this.lbl_scoreLevel2);
            this.Controls.Add(this.lbl_scoreLevel1);
            this.Controls.Add(this.lbl_Scores);
            this.Controls.Add(this.lbl_storyText);
            this.Controls.Add(this.lbl_quit);
            this.Controls.Add(this.lbl_titlescreen);
            this.Controls.Add(this.lbl_Gameover);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Gameover;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label lbl_titlescreen;
        private System.Windows.Forms.Label lbl_storyText;
        private System.Windows.Forms.Label lbl_Scores;
        private System.Windows.Forms.Label lbl_scoreLevel1;
        private System.Windows.Forms.Label lbl_scoreLevel2;
        private System.Windows.Forms.Label lbl_scoreBoss;
        private System.Windows.Forms.Label lbl_score1;
        private System.Windows.Forms.Label lbl_score2;
        private System.Windows.Forms.Label lbl_score3;
    }
}