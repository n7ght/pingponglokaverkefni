﻿namespace pplokav
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
            this.kiddipannel = new System.Windows.Forms.Panel();
            this.spaði = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kiddipannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaði)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kiddipannel
            // 
            this.kiddipannel.Controls.Add(this.pictureBox1);
            this.kiddipannel.Controls.Add(this.spaði);
            this.kiddipannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiddipannel.Location = new System.Drawing.Point(0, 0);
            this.kiddipannel.Name = "kiddipannel";
            this.kiddipannel.Size = new System.Drawing.Size(875, 480);
            this.kiddipannel.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(349, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 480);
            this.Controls.Add(this.kiddipannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.kiddipannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaði)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kiddipannel;
        private System.Windows.Forms.PictureBox spaði;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

