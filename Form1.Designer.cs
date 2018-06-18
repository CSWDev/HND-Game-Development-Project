namespace Cold_Tower
{
    partial class frm_TitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TitleScreen));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_StartGame = new System.Windows.Forms.Label();
            this.lbl_Controls = new System.Windows.Forms.Label();
            this.lbl_ControlLeft = new System.Windows.Forms.Label();
            this.lbl_ControlRight = new System.Windows.Forms.Label();
            this.lbl_ControlDown = new System.Windows.Forms.Label();
            this.lbl_ControlUP = new System.Windows.Forms.Label();
            this.lbl_ControlAttack = new System.Windows.Forms.Label();
            this.lbl_LeaveGame = new System.Windows.Forms.Label();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.rtxt_Instr = new System.Windows.Forms.RichTextBox();
            this.lbl_Quit = new System.Windows.Forms.Label();
            this.pbox_Control = new System.Windows.Forms.PictureBox();
            this.lbl_InstructionsClose = new System.Windows.Forms.Label();
            this.lbl_ControlList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Title.Location = new System.Drawing.Point(25, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(247, 55);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Cold Tower";
            // 
            // lbl_StartGame
            // 
            this.lbl_StartGame.AutoSize = true;
            this.lbl_StartGame.BackColor = System.Drawing.Color.Black;
            this.lbl_StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_StartGame.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartGame.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_StartGame.Location = new System.Drawing.Point(29, 152);
            this.lbl_StartGame.Name = "lbl_StartGame";
            this.lbl_StartGame.Size = new System.Drawing.Size(66, 31);
            this.lbl_StartGame.TabIndex = 1;
            this.lbl_StartGame.Text = "Start";
            this.lbl_StartGame.Click += new System.EventHandler(this.lbl_StartGame_Click);
            // 
            // lbl_Controls
            // 
            this.lbl_Controls.AutoSize = true;
            this.lbl_Controls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Controls.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Controls.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Controls.Location = new System.Drawing.Point(29, 214);
            this.lbl_Controls.Name = "lbl_Controls";
            this.lbl_Controls.Size = new System.Drawing.Size(109, 31);
            this.lbl_Controls.TabIndex = 2;
            this.lbl_Controls.Text = "Controls";
            this.lbl_Controls.Click += new System.EventHandler(this.lbl_Controls_Click);
            // 
            // lbl_ControlLeft
            // 
            this.lbl_ControlLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ControlLeft.AutoSize = true;
            this.lbl_ControlLeft.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_ControlLeft.Location = new System.Drawing.Point(510, 488);
            this.lbl_ControlLeft.Name = "lbl_ControlLeft";
            this.lbl_ControlLeft.Size = new System.Drawing.Size(55, 13);
            this.lbl_ControlLeft.TabIndex = 4;
            this.lbl_ControlLeft.Text = "Move Left";
            this.lbl_ControlLeft.Visible = false;
            // 
            // lbl_ControlRight
            // 
            this.lbl_ControlRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ControlRight.AutoSize = true;
            this.lbl_ControlRight.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_ControlRight.Location = new System.Drawing.Point(697, 488);
            this.lbl_ControlRight.Name = "lbl_ControlRight";
            this.lbl_ControlRight.Size = new System.Drawing.Size(62, 13);
            this.lbl_ControlRight.TabIndex = 5;
            this.lbl_ControlRight.Text = "Move Right";
            this.lbl_ControlRight.Visible = false;
            // 
            // lbl_ControlDown
            // 
            this.lbl_ControlDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ControlDown.AutoSize = true;
            this.lbl_ControlDown.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_ControlDown.Location = new System.Drawing.Point(602, 488);
            this.lbl_ControlDown.Name = "lbl_ControlDown";
            this.lbl_ControlDown.Size = new System.Drawing.Size(65, 13);
            this.lbl_ControlDown.TabIndex = 6;
            this.lbl_ControlDown.Text = "Move Down";
            this.lbl_ControlDown.Visible = false;
            // 
            // lbl_ControlUP
            // 
            this.lbl_ControlUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ControlUP.AutoSize = true;
            this.lbl_ControlUP.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_ControlUP.Location = new System.Drawing.Point(593, 401);
            this.lbl_ControlUP.Name = "lbl_ControlUP";
            this.lbl_ControlUP.Size = new System.Drawing.Size(81, 13);
            this.lbl_ControlUP.TabIndex = 7;
            this.lbl_ControlUP.Text = "Move Up/Jump";
            this.lbl_ControlUP.Visible = false;
            // 
            // lbl_ControlAttack
            // 
            this.lbl_ControlAttack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ControlAttack.AutoSize = true;
            this.lbl_ControlAttack.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_ControlAttack.Location = new System.Drawing.Point(830, 401);
            this.lbl_ControlAttack.Name = "lbl_ControlAttack";
            this.lbl_ControlAttack.Size = new System.Drawing.Size(64, 13);
            this.lbl_ControlAttack.TabIndex = 9;
            this.lbl_ControlAttack.Text = "Fire arrow(s)";
            this.lbl_ControlAttack.Visible = false;
            // 
            // lbl_LeaveGame
            // 
            this.lbl_LeaveGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_LeaveGame.AutoSize = true;
            this.lbl_LeaveGame.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_LeaveGame.Location = new System.Drawing.Point(379, 401);
            this.lbl_LeaveGame.Name = "lbl_LeaveGame";
            this.lbl_LeaveGame.Size = new System.Drawing.Size(55, 13);
            this.lbl_LeaveGame.TabIndex = 11;
            this.lbl_LeaveGame.Text = "Quit game";
            this.lbl_LeaveGame.Visible = false;
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Instructions.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Instructions.Location = new System.Drawing.Point(29, 273);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(142, 31);
            this.lbl_Instructions.TabIndex = 13;
            this.lbl_Instructions.Text = "Instructions";
            this.lbl_Instructions.Click += new System.EventHandler(this.lbl_Instructions_Click);
            // 
            // rtxt_Instr
            // 
            this.rtxt_Instr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxt_Instr.BackColor = System.Drawing.Color.Black;
            this.rtxt_Instr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_Instr.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxt_Instr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_Instr.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rtxt_Instr.Location = new System.Drawing.Point(342, 194);
            this.rtxt_Instr.Name = "rtxt_Instr";
            this.rtxt_Instr.ReadOnly = true;
            this.rtxt_Instr.Size = new System.Drawing.Size(722, 544);
            this.rtxt_Instr.TabIndex = 14;
            this.rtxt_Instr.Text = "";
            this.rtxt_Instr.Visible = false;
            // 
            // lbl_Quit
            // 
            this.lbl_Quit.AutoSize = true;
            this.lbl_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Quit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Quit.Location = new System.Drawing.Point(29, 331);
            this.lbl_Quit.Name = "lbl_Quit";
            this.lbl_Quit.Size = new System.Drawing.Size(132, 31);
            this.lbl_Quit.TabIndex = 15;
            this.lbl_Quit.Text = "Quit Game";
            this.lbl_Quit.Click += new System.EventHandler(this.lbl_Quit_Click);
            // 
            // pbox_Control
            // 
            this.pbox_Control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbox_Control.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Control.Image = global::Cold_Tower.Properties.Resources.controls;
            this.pbox_Control.Location = new System.Drawing.Point(354, 331);
            this.pbox_Control.Name = "pbox_Control";
            this.pbox_Control.Size = new System.Drawing.Size(583, 179);
            this.pbox_Control.TabIndex = 16;
            this.pbox_Control.TabStop = false;
            this.pbox_Control.Visible = false;
            // 
            // lbl_InstructionsClose
            // 
            this.lbl_InstructionsClose.AutoSize = true;
            this.lbl_InstructionsClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_InstructionsClose.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InstructionsClose.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_InstructionsClose.Location = new System.Drawing.Point(29, 273);
            this.lbl_InstructionsClose.Name = "lbl_InstructionsClose";
            this.lbl_InstructionsClose.Size = new System.Drawing.Size(211, 31);
            this.lbl_InstructionsClose.TabIndex = 17;
            this.lbl_InstructionsClose.Text = "Close Instructions";
            this.lbl_InstructionsClose.Visible = false;
            this.lbl_InstructionsClose.Click += new System.EventHandler(this.lbl_InstructionsClose_Click);
            // 
            // lbl_ControlList
            // 
            this.lbl_ControlList.AutoSize = true;
            this.lbl_ControlList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ControlList.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ControlList.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_ControlList.Location = new System.Drawing.Point(29, 214);
            this.lbl_ControlList.Name = "lbl_ControlList";
            this.lbl_ControlList.Size = new System.Drawing.Size(109, 31);
            this.lbl_ControlList.TabIndex = 18;
            this.lbl_ControlList.Text = "Controls";
            this.lbl_ControlList.Visible = false;
            this.lbl_ControlList.Click += new System.EventHandler(this.lbl_ControlList_Click);
            // 
            // frm_TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Cold_Tower.Properties.Resources.knightbackgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1226, 961);
            this.Controls.Add(this.lbl_ControlList);
            this.Controls.Add(this.lbl_ControlUP);
            this.Controls.Add(this.lbl_ControlAttack);
            this.Controls.Add(this.lbl_ControlRight);
            this.Controls.Add(this.lbl_ControlDown);
            this.Controls.Add(this.lbl_ControlLeft);
            this.Controls.Add(this.lbl_LeaveGame);
            this.Controls.Add(this.lbl_InstructionsClose);
            this.Controls.Add(this.lbl_Quit);
            this.Controls.Add(this.rtxt_Instr);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.lbl_Controls);
            this.Controls.Add(this.lbl_StartGame);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pbox_Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_TitleScreen";
            this.Text = "Cold Tower - Title Screen";
            this.Load += new System.EventHandler(this.frm_TitleScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TitleScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_StartGame;
        private System.Windows.Forms.Label lbl_Controls;
        private System.Windows.Forms.Label lbl_ControlLeft;
        private System.Windows.Forms.Label lbl_ControlRight;
        private System.Windows.Forms.Label lbl_ControlDown;
        private System.Windows.Forms.Label lbl_ControlUP;
        private System.Windows.Forms.Label lbl_ControlAttack;
        private System.Windows.Forms.Label lbl_LeaveGame;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.RichTextBox rtxt_Instr;
        private System.Windows.Forms.Label lbl_Quit;
        private System.Windows.Forms.PictureBox pbox_Control;
        private System.Windows.Forms.Label lbl_InstructionsClose;
        private System.Windows.Forms.Label lbl_ControlList;
    }
}

