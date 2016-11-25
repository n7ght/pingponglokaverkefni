namespace pplokav
{
    partial class Form1
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
<<<<<<< HEAD
            this.kiddipannel = new System.Windows.Forms.Panel();
            this.spaði = new System.Windows.Forms.PictureBox();
            this.bolti = new System.Windows.Forms.PictureBox();
            this.kiddipannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaði)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolti)).BeginInit();
=======
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bakgrunnur = new System.Windows.Forms.Panel();
            this.lb_newhighscore = new System.Windows.Forms.Label();
            this.lb_highscore = new System.Windows.Forms.Label();
            this.lb_Highscoretxt = new System.Windows.Forms.Label();
            this.lb_stig = new System.Windows.Forms.Label();
            this.lb_gameover = new System.Windows.Forms.Label();
            this.lb_stigtxt = new System.Windows.Forms.Label();
            this.spaðinn = new System.Windows.Forms.PictureBox();
            this.boltinn = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bakgrunnur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).BeginInit();
>>>>>>> gummi
            this.SuspendLayout();
            // 
            // bakgrunnur
            // 
<<<<<<< HEAD
            this.kiddipannel.Controls.Add(this.bolti);
            this.kiddipannel.Controls.Add(this.spaði);
            this.kiddipannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiddipannel.Location = new System.Drawing.Point(0, 0);
            this.kiddipannel.Name = "kiddipannel";
            this.kiddipannel.Size = new System.Drawing.Size(875, 480);
            this.kiddipannel.TabIndex = 0;
=======
            this.bakgrunnur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bakgrunnur.Controls.Add(this.lb_newhighscore);
            this.bakgrunnur.Controls.Add(this.lb_highscore);
            this.bakgrunnur.Controls.Add(this.lb_Highscoretxt);
            this.bakgrunnur.Controls.Add(this.lb_stig);
            this.bakgrunnur.Controls.Add(this.lb_gameover);
            this.bakgrunnur.Controls.Add(this.lb_stigtxt);
            this.bakgrunnur.Controls.Add(this.spaðinn);
            this.bakgrunnur.Controls.Add(this.boltinn);
            this.bakgrunnur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bakgrunnur.Location = new System.Drawing.Point(0, 0);
            this.bakgrunnur.Name = "bakgrunnur";
            this.bakgrunnur.Size = new System.Drawing.Size(1022, 621);
            this.bakgrunnur.TabIndex = 0;
            // 
            // lb_newhighscore
            // 
            this.lb_newhighscore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_newhighscore.AutoSize = true;
            this.lb_newhighscore.BackColor = System.Drawing.Color.Transparent;
            this.lb_newhighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newhighscore.Location = new System.Drawing.Point(329, 149);
            this.lb_newhighscore.Name = "lb_newhighscore";
            this.lb_newhighscore.Size = new System.Drawing.Size(374, 40);
            this.lb_newhighscore.TabIndex = 7;
            this.lb_newhighscore.Text = "NEW HIGHSCORE!!!";
            // 
            // lb_highscore
            // 
            this.lb_highscore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_highscore.AutoSize = true;
            this.lb_highscore.BackColor = System.Drawing.Color.Transparent;
            this.lb_highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highscore.Location = new System.Drawing.Point(594, 406);
            this.lb_highscore.Name = "lb_highscore";
            this.lb_highscore.Size = new System.Drawing.Size(38, 40);
            this.lb_highscore.TabIndex = 6;
            this.lb_highscore.Text = "0";
            // 
            // lb_Highscoretxt
            // 
            this.lb_Highscoretxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Highscoretxt.AutoSize = true;
            this.lb_Highscoretxt.BackColor = System.Drawing.Color.Transparent;
            this.lb_Highscoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Highscoretxt.Location = new System.Drawing.Point(400, 406);
            this.lb_Highscoretxt.Name = "lb_Highscoretxt";
            this.lb_Highscoretxt.Size = new System.Drawing.Size(188, 40);
            this.lb_Highscoretxt.TabIndex = 5;
            this.lb_Highscoretxt.Text = "Highscore";
            // 
            // lb_stig
            // 
            this.lb_stig.AutoSize = true;
            this.lb_stig.BackColor = System.Drawing.Color.Transparent;
            this.lb_stig.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stig.Location = new System.Drawing.Point(102, 13);
            this.lb_stig.Name = "lb_stig";
            this.lb_stig.Size = new System.Drawing.Size(37, 39);
            this.lb_stig.TabIndex = 4;
            this.lb_stig.Text = "0";
            // 
            // lb_gameover
            // 
            this.lb_gameover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_gameover.AutoSize = true;
            this.lb_gameover.BackColor = System.Drawing.Color.Transparent;
            this.lb_gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gameover.Location = new System.Drawing.Point(383, 218);
            this.lb_gameover.Name = "lb_gameover";
            this.lb_gameover.Size = new System.Drawing.Size(238, 156);
            this.lb_gameover.TabIndex = 3;
            this.lb_gameover.Text = "GAME-OVER\r\n\r\nF1 - Restart\r\nEsc - Hætta";
            // 
            // lb_stigtxt
            // 
            this.lb_stigtxt.AutoSize = true;
            this.lb_stigtxt.BackColor = System.Drawing.Color.Transparent;
            this.lb_stigtxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stigtxt.Location = new System.Drawing.Point(3, 9);
            this.lb_stigtxt.Name = "lb_stigtxt";
            this.lb_stigtxt.Size = new System.Drawing.Size(93, 44);
            this.lb_stigtxt.TabIndex = 2;
            this.lb_stigtxt.Text = "Stig";
            // 
            // spaðinn
            // 
            this.spaðinn.BackColor = System.Drawing.Color.Black;
            this.spaðinn.Location = new System.Drawing.Point(518, 533);
            this.spaðinn.Name = "spaðinn";
            this.spaðinn.Size = new System.Drawing.Size(185, 15);
            this.spaðinn.TabIndex = 1;
            this.spaðinn.TabStop = false;
            // 
            // boltinn
            // 
            this.boltinn.BackColor = System.Drawing.Color.Transparent;
            this.boltinn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boltinn.BackgroundImage")));
            this.boltinn.Location = new System.Drawing.Point(771, 290);
            this.boltinn.Name = "boltinn";
            this.boltinn.Size = new System.Drawing.Size(50, 50);
            this.boltinn.TabIndex = 0;
            this.boltinn.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
>>>>>>> gummi
            // 
            // spaði
            // 
            this.spaði.BackColor = System.Drawing.SystemColors.HotTrack;
            this.spaði.Location = new System.Drawing.Point(322, 434);
            this.spaði.Name = "spaði";
            this.spaði.Size = new System.Drawing.Size(200, 20);
            this.spaði.TabIndex = 0;
            this.spaði.TabStop = false;
            // 
            // bolti
            // 
            this.bolti.Location = new System.Drawing.Point(349, 161);
            this.bolti.Name = "bolti";
            this.bolti.Size = new System.Drawing.Size(100, 50);
            this.bolti.TabIndex = 1;
            this.bolti.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(875, 480);
            this.Controls.Add(this.kiddipannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.kiddipannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaði)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolti)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(1022, 621);
            this.Controls.Add(this.bakgrunnur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bakgrunnur.ResumeLayout(false);
            this.bakgrunnur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).EndInit();
>>>>>>> gummi
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Panel kiddipannel;
        private System.Windows.Forms.PictureBox spaði;
        private System.Windows.Forms.PictureBox bolti;
=======
        private System.Windows.Forms.Panel bakgrunnur;
        private System.Windows.Forms.PictureBox spaðinn;
        private System.Windows.Forms.PictureBox boltinn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_stig;
        private System.Windows.Forms.Label lb_gameover;
        private System.Windows.Forms.Label lb_stigtxt;
        private System.Windows.Forms.Label lb_highscore;
        private System.Windows.Forms.Label lb_Highscoretxt;
        private System.Windows.Forms.Label lb_newhighscore;
>>>>>>> gummi
    }
}

