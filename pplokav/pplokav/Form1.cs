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

        private void timer1_Tick(object sender, EventArgs e)
        {
            spaðinn.Left = Cursor.Position.X - (spaðinn.Width / 2); //setur spadann tar sem musinn er
            boltinn.Left += hradi_vinstri;
            boltinn.Top += hradi_efst;

            if (boltinn.Bottom >= spaðinn.Top && boltinn.Bottom <= spaðinn.Bottom && boltinn.Right >= spaðinn.Left && boltinn.Right <= spaðinn.Right)
            {
                hradi_efst += 2;
                hradi_vinstri += 2;
                hradi_efst = -hradi_efst;//breytir um att
                stig += 1;
                lb_stig.Text = stig.ToString();

                Random rand = new Random();
                bakgrunnur.BackColor = Color.FromArgb(rand.Next(150, 255), rand.Next(150, 255), rand.Next(150, 255));//nyr bakgrunnur
            }

            if (boltinn.Left <= bakgrunnur.Left)
            {
                hradi_vinstri = -hradi_vinstri;
            }
            if (boltinn.Right >= bakgrunnur.Right)
            {
                hradi_vinstri = -hradi_vinstri;
            }
            if (boltinn.Top <= bakgrunnur.Top)
            {
                hradi_efst = -hradi_efst;
            }
            if (boltinn.Bottom >= bakgrunnur.Bottom)
            {
                timer1.Enabled = false;//stoppar leik ef bolti fer utaf
                lb_gameover.Visible = true;//synir GAME-OVER
            }

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)//ef ytt er a Esc takkan ta lokast forritid
            {
                this.Close();
                bakgrunnur.BackColor = Color.White;
                return true;
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F1)//ef ytt er a F1 ta resettast leikurinn
            {
                boltinn.Top = 50;
                boltinn.Left = 50;
                hradi_vinstri = 4;
                hradi_efst = 4;
                stig = 0;
                lb_stig.Text = "0";
                timer1.Enabled = true;
                lb_gameover.Visible = false;
                bakgrunnur.BackColor = Color.White;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
