namespace Cold_Tower
{
    partial class GameOver
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
            this.lbl_Gameover = new System.Windows.Forms.Label();
            this.lbl_Retry = new System.Windows.Forms.Label();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Gameover
            // 
            this.lbl_Gameover.AutoSize = true;
            this.lbl_Gameover.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gameover.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Gameover.Location = new System.Drawing.Point(12, 39);
            this.lbl_Gameover.Name = "lbl_Gameover";
            this.lbl_Gameover.Size = new System.Drawing.Size(420, 73);
            this.lbl_Gameover.TabIndex = 0;
            this.lbl_Gameover.Text = "GAME OVER";
            // 
            // lbl_Retry
            // 
            this.lbl_Retry.AutoSize = true;
            this.lbl_Retry.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Retry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Retry.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Retry.Location = new System.Drawing.Point(12, 203);
            this.lbl_Retry.Name = "lbl_Retry";
            this.lbl_Retry.Size = new System.Drawing.Size(124, 25);
            this.lbl_Retry.TabIndex = 1;
            this.lbl_Retry.Text = "Begin anew";
            this.lbl_Retry.Click += new System.EventHandler(this.lbl_Retry_Click);
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quit.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_quit.Location = new System.Drawing.Point(12, 279);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(169, 25);
            this.lbl_quit.TabIndex = 2;
            this.lbl_quit.Text = "Leave this place";
            this.lbl_quit.Click += new System.EventHandler(this.lbl_quit_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cold_Tower.Properties.Resources.GraveofSwords_Art;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 961);
            this.Controls.Add(this.lbl_quit);
            this.Controls.Add(this.lbl_Retry);
            this.Controls.Add(this.lbl_Gameover);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Gameover;
        private System.Windows.Forms.Label lbl_Retry;
        private System.Windows.Forms.Label lbl_quit;
    }
}