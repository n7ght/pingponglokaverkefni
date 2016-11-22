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
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();                 // felur cursor

            this.FormBorderStyle = FormBorderStyle.None; // tekur burt borders
            this.TopMost = true;                        // færir formið fremst
            this.Bounds = Screen.PrimaryScreen.Bounds;  // setur í fullscreen

            spaði.Top = kiddipannel.Bottom - (kiddipannel.Bottom / 10); // setur stöðu á spaðanum


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
