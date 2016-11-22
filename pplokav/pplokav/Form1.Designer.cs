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
            this.boltinn = new System.Windows.Forms.PictureBox();
            this.spaðinn = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bakgrunnur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).BeginInit();
            this.SuspendLayout();
            // 
            // bakgrunnur
            // 
            this.bakgrunnur.Controls.Add(this.spaðinn);
            this.bakgrunnur.Controls.Add(this.boltinn);
            this.bakgrunnur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bakgrunnur.Location = new System.Drawing.Point(0, 0);
            this.bakgrunnur.Name = "bakgrunnur";
            this.bakgrunnur.Size = new System.Drawing.Size(1022, 621);
            this.bakgrunnur.TabIndex = 0;
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
            // spaðinn
            // 
            this.spaðinn.BackColor = System.Drawing.Color.Black;
            this.spaðinn.Location = new System.Drawing.Point(518, 533);
            this.spaðinn.Name = "spaðinn";
            this.spaðinn.Size = new System.Drawing.Size(185, 15);
            this.spaðinn.TabIndex = 1;
            this.spaðinn.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bakgrunnur;
        private System.Windows.Forms.PictureBox spaðinn;
        private System.Windows.Forms.PictureBox boltinn;
        private System.Windows.Forms.Timer timer1;
    }
}

