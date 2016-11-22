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

        public int hradi_vinstri = 4;
        public int hradi_efst = 4;
        public int stig = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide(); //felur músina

            this.FormBorderStyle = FormBorderStyle.None; //tekur borders í burtu
            this.TopMost = true;//setur formid fremst
            this.Bounds = Screen.PrimaryScreen.Bounds;//fullscreen


            spaðinn.Top = bakgrunnur.Bottom - (bakgrunnur.Bottom / 10); //setur stadsetningu a spadanum.

            lb_gameover.Left = (bakgrunnur.Width / 2) - (lb_gameover.Width / 2);
            lb_gameover.Top = (bakgrunnur.Height / 2) - (lb_gameover.Height / 2);
            lb_gameover.Visible = false;

        }
    }
}
