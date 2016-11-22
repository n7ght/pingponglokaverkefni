using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pplokav
{
    public partial class Form1 : Form
    {
        public int speed_left = 4; //hraði boltans
        public int speed_top = 4;
        public int point = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide(); //felur cursor

            this.FormBorderStyle = FormBorderStyle.None; //fjarlægir borders
            this.TopMost = true;                        //Bring The Form To The Front
            this.Bounds = Screen.PrimaryScreen.Bounds;   //Setur í full screen

            spaði.Top = kiddipannel.Bottom - (kiddipannel.Bottom / 10); //Setur stöðu á spaða



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spaði.Left = Cursor.Position.X - (spaði.Width / 2); //Setur miðju spaðans þar sem að músinn bendir

            bolti.Left += speed_left; //hreifir boltan
            bolti.Top += speed_top;

            if (bolti.Bottom >= spaði.Top && bolti.Bottom <= spaði.Bottom && bolti >= spaði.Left && bolti.Right <= spaði.Right ) // spaði collision
            {
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {this.Close()} // Escape til að hætta
        }
    }
}
