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
            this.components = new System.ComponentModel.Container();
            this.bakgrunnur = new System.Windows.Forms.Panel();
            this.spaðinn = new System.Windows.Forms.PictureBox();
            this.boltinn = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_stigtxt = new System.Windows.Forms.Label();
            this.lb_gameover = new System.Windows.Forms.Label();
            this.lb_stig = new System.Windows.Forms.Label();
            this.bakgrunnur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).BeginInit();
            this.SuspendLayout();
            // 
            // bakgrunnur
            // 
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
            this.boltinn.BackColor = System.Drawing.Color.Orange;
            this.boltinn.Location = new System.Drawing.Point(560, 380);
            this.boltinn.Name = "boltinn";
            this.boltinn.Size = new System.Drawing.Size(50, 50);
            this.boltinn.TabIndex = 0;
            this.boltinn.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_stigtxt
            // 
            this.lb_stigtxt.AutoSize = true;
            this.lb_stigtxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stigtxt.Location = new System.Drawing.Point(3, 9);
            this.lb_stigtxt.Name = "lb_stigtxt";
            this.lb_stigtxt.Size = new System.Drawing.Size(93, 44);
            this.lb_stigtxt.TabIndex = 2;
            this.lb_stigtxt.Text = "Stig";
            // 
            // lb_gameover
            // 
            this.lb_gameover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_gameover.AutoSize = true;
            this.lb_gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gameover.Location = new System.Drawing.Point(372, 202);
            this.lb_gameover.Name = "lb_gameover";
            this.lb_gameover.Size = new System.Drawing.Size(238, 156);
            this.lb_gameover.TabIndex = 3;
            this.lb_gameover.Text = "GAME-OVER\r\n\r\nF1 - Restart\r\nEsc - Hætta";
            // 
            // lb_stig
            // 
            this.lb_stig.AutoSize = true;
            this.lb_stig.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stig.Location = new System.Drawing.Point(102, 13);
            this.lb_stig.Name = "lb_stig";
            this.lb_stig.Size = new System.Drawing.Size(37, 39);
            this.lb_stig.TabIndex = 4;
            this.lb_stig.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 621);
            this.Controls.Add(this.bakgrunnur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bakgrunnur.ResumeLayout(false);
            this.bakgrunnur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bakgrunnur;
        private System.Windows.Forms.PictureBox spaðinn;
        private System.Windows.Forms.PictureBox boltinn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_stig;
        private System.Windows.Forms.Label lb_gameover;
        private System.Windows.Forms.Label lb_stigtxt;
    }
}

