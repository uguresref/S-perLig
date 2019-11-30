using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LİG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        int çşpuan = 0;
        int ankpuan = 0;
        int antpuan = 0;
        int svspuan = 0;
        int akpuan = 0;
        int kaypuan = 0;
        int bspuan = 0;
        int karpuan = 0;
        int espuan = 0;
        int bskpuan = 0;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            labelfb1.Text = rnd.Next(0, 7).ToString();
            labelgs1.Text = rnd.Next(0, 7).ToString();
  

            if (Convert.ToInt32(labelgs1.Text)>Convert.ToInt32(labelfb1.Text))
            {
                gspuan += 3;
                labelgs.Text = gspuan.ToString();
            }
            else if(Convert.ToInt32(labelgs.Text)==Convert.ToInt32(labelgs1.Text))
                    {
                gspuan += 1;
                fbpuan += 1;
                labelgs.Text = gspuan.ToString();
                labelfb.Text = fbpuan.ToString();
            }
            else
            {
                fbpuan += 3;
                labelfb.Text = fbpuan.ToString();
            }
          
            labeles1.Text = rnd.Next(0, 7).ToString();
            labelank1.Text = rnd.Next(0, 7).ToString();

            if (Convert.ToInt32(labeles.Text) > Convert.ToInt32(labeles1.Text))
            {
                espuan += 3;
                labeles.Text = espuan.ToString();

            }
            else if (Convert.ToInt32(labeles.Text) == Convert.ToInt32(labeles1.Text))

            {
                espuan += 1;
                ankpuan += 1;
                labeles.Text = espuan.ToString();
                labelank.Text = ankpuan.ToString();
            }
            else
            {
                ankpuan += 3;
                labelank.Text = ankpuan.ToString();
            }


            labelçş1.Text = rnd.Next(0, 7).ToString();
            labelbjk1.Text = rnd.Next(0, 7).ToString();
            if (Convert.ToInt32(labelçş.Text) > Convert.ToInt32(labelçş1.Text))
            {
                çşpuan += 3;
                labelçş.Text = çşpuan.ToString();

            }
            else if (Convert.ToInt32(labelçş.Text) == Convert.ToInt32(labelçş1.Text))

            {
                çşpuan += 1;
                bjkpuan += 1;
                labelçş.Text = çşpuan.ToString();
                labelbjk.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan += 3;
                labelbjk.Text = bjkpuan.ToString();
            }







            labelts1.Text = rnd.Next(0, 7).ToString();
            labelbsk1.Text = rnd.Next(0, 7).ToString();

            if (Convert.ToInt32(labelts.Text) > Convert.ToInt32(labelts1.Text))
            {
                tspuan += 3;
                labelts.Text = tspuan.ToString();

            }
            else if (Convert.ToInt32(labelts.Text) == Convert.ToInt32(labelts1.Text))

            {
                tspuan += 1;
                bskpuan += 1;
                labelts.Text = tspuan.ToString();
                labelbsk.Text = bskpuan.ToString();
            }
            else
            {
                bskpuan += 3;
                labelbsk.Text = bskpuan.ToString();
            }




            labelak1.Text = rnd.Next(0, 7).ToString();

            labelant1.Text = rnd.Next(0, 7).ToString();
            if (Convert.ToInt32(labelak.Text) > Convert.ToInt32(labelak1.Text))
            {
                akpuan += 3;
                labelak.Text = akpuan.ToString();

            }
            else if (Convert.ToInt32(labelak.Text) == Convert.ToInt32(labelak1.Text))

            {
                akpuan += 1;
                antpuan += 1;
                labelak.Text = akpuan.ToString();
                labelant.Text = antpuan.ToString();
            }
            else
            {
                antpuan += 3;
                labelant.Text = antpuan.ToString();
            }


            labelbs1.Text = rnd.Next(0, 7).ToString();
            labelkay1.Text = rnd.Next(0, 7).ToString();
            if (Convert.ToInt32(labelbs.Text) > Convert.ToInt32(labelbs1.Text))
            {
                bspuan += 3;
                labelbs.Text = bspuan.ToString();

            }
            else if (Convert.ToInt32(labelbs.Text) == Convert.ToInt32(labelbs1.Text))

            {
                bspuan += 1;
                kaypuan += 1;
                labelbs.Text = bspuan.ToString();
                labelkay.Text = kaypuan.ToString();
            }
            else
            {
                kaypuan += 3;
                labelkay.Text = kaypuan.ToString();
            }


            labelsvs1.Text = rnd.Next(0, 7).ToString();
            labelkar1.Text = rnd.Next(0, 7).ToString();

            if (Convert.ToInt32(labelsvs.Text) > Convert.ToInt32(labelsvs1.Text))
            {
                svspuan += 3;
                labelsvs.Text = svspuan.ToString();

            }
            else if (Convert.ToInt32(labelbs.Text) == Convert.ToInt32(labelbs1.Text))

            {
                svspuan += 1;
                karpuan += 1;
                labelsvs.Text = svspuan.ToString();
                labelkar.Text = karpuan.ToString();
            }
            else
            {
                karpuan += 3;
                labelkar.Text = karpuan.ToString();
            }
            button1.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelgs2.Text = rnd.Next(0, 7).ToString();
            labelkar2.Text = rnd.Next(0, 7).ToString();
            labelkay2.Text = rnd.Next(0, 7).ToString();
            labelsvs2.Text = rnd.Next(0, 7).ToString();
            labelts2.Text = rnd.Next(0, 7).ToString();
            labelçş2.Text = rnd.Next(0, 7).ToString();
            labelfb2.Text = rnd.Next(0, 7).ToString();
            labeles2.Text = rnd.Next(0, 7).ToString();
            labelank2.Text = rnd.Next(0, 7).ToString();
            labelant2.Text = rnd.Next(0, 7).ToString();
            labelbs2.Text = rnd.Next(0, 7).ToString();
            labelbjk2.Text = rnd.Next(0, 7).ToString();
            labelbsk2.Text = rnd.Next(0, 7).ToString();
            labelak2.Text = rnd.Next(0, 7).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelgs3.Text = rnd.Next(0, 7).ToString();
            labelkar3.Text = rnd.Next(0, 7).ToString();
            labelkay3.Text = rnd.Next(0, 7).ToString();
            labelsvs3.Text = rnd.Next(0, 7).ToString();
            labelts3.Text = rnd.Next(0, 7).ToString();
            labelçş3.Text = rnd.Next(0, 7).ToString();
            labelfb3.Text = rnd.Next(0, 7).ToString();
            labeles3.Text = rnd.Next(0, 7).ToString();
            labelank3.Text = rnd.Next(0, 7).ToString();
            labelant3.Text = rnd.Next(0, 7).ToString();
            labelbs3.Text = rnd.Next(0, 7).ToString();
            labelbjk3.Text = rnd.Next(0, 7).ToString();
            labelbsk3.Text = rnd.Next(0, 7).ToString();
            labelak3.Text = rnd.Next(0, 7).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelgs4.Text = rnd.Next(0, 7).ToString();
            labelkar4.Text = rnd.Next(0, 7).ToString();
            labelkay4.Text = rnd.Next(0, 7).ToString();
            labelsvs4.Text = rnd.Next(0, 7).ToString();
            labelts4.Text = rnd.Next(0, 7).ToString();
            labelçş4.Text = rnd.Next(0, 7).ToString();
            labelfb4.Text = rnd.Next(0, 7).ToString();
            labeles4.Text = rnd.Next(0, 7).ToString();
            labelank4.Text = rnd.Next(0, 7).ToString();
            labelant4.Text = rnd.Next(0, 7).ToString();
            labelbs4.Text = rnd.Next(0, 7).ToString();
            labelbjk4.Text = rnd.Next(0, 7).ToString();
            labelbsk4.Text = rnd.Next(0, 7).ToString();
            labelak4.Text = rnd.Next(0, 7).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gspuan = 0;
            fbpuan = 0;
            bjkpuan = 0;
            tspuan = 0;
            çşpuan = 0;
            ankpuan = 0;
            antpuan = 0;
            svspuan = 0;
            akpuan = 0;
            kaypuan = 0;
            bspuan = 0;
            karpuan = 0;
            espuan = 0;
            bskpuan = 0;
            labelgs.Text = gspuan.ToString();
            labelfb.Text = fbpuan.ToString();
            labelbjk.Text = bjkpuan.ToString();
            labelsvs.Text = svspuan.ToString();
            labelts.Text = tspuan.ToString();
            labelbsk.Text = bskpuan.ToString();
            labelkar.Text = karpuan.ToString();
            labeles.Text = espuan.ToString();
            labelbs.Text = bspuan.ToString();
            labelçş.Text = çşpuan.ToString();
            labelank.Text = ankpuan.ToString();
            labelak.Text = akpuan.ToString();
            labelant.Text = antpuan.ToString();
            labelkay.Text = kaypuan.ToString();

            button1.Enabled = true;


        }
    }
}
