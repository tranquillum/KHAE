using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHAE
{
    public partial class Game : Form
    {
        // Lokatsiooni lisamine
        LangSat LangSat = new LangSat();
        Settings settings = new Settings();
        StartLoc startLoc = new StartLoc();
        StartText startText = new StartText();


        //Muutujad
        double samm = 0;
        string lang = "";
        double kord = 0;
        string texttick = "";
        int i = 0;

        public Game()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            LangSat.ShowDialog(); // peale stardis avada LangSet akken
            if (LangSat.DialogResult == DialogResult.OK)
            {
                lang = LangSat.langSat();
            }

            alusta.Text = settings.startbtn(lang);
            this.Text = "Game " + lang;

            
        }

        
        //Button 1
        private void button1_Click(object sender, EventArgs e)//vasakpoolne nupp x.1
        {
            //samm1
            if (samm == 1)//start lock
            {
                texttik(startLoc.startLoc_Samm_1(lang, 1.1));//(lang, 1.1) lang - keel, 1.1 - vastuse variant(1- samm, 1-varian)
                samm = 2;
                kord = 0;
                v1.Text = startLoc.bteV1(lang);
                v2.Text = startLoc.bteV2(lang);
                mianpic.Image = kapppic.Image;
            }
            //sam2


            if (samm==2)
            {




            }










            if (Story.Visible)
            {
                
                Story.SelectionStart = Story.Text.Length;
                Story.ScrollToCaret();
            }
        }
        //Button 2
        private void button2_Click(object sender, EventArgs e)//parempoolne nupp x.2
        {
            if (samm == 1)//start lock
            {
                kord++;

                
                
                if (kord ==2)
                {
                    Story.Text = "";
                    Story.ForeColor = System.Drawing.Color.Red;
                    Story.Text += Environment.NewLine+ startLoc.startLoc_Surm(lang) + Environment.NewLine;
                    v1.Visible = false;
                    v2.Visible = false;
                    kord = 0;
                }
                else
                {
                    texttik(startLoc.startLoc_Samm_1(lang, 1.2));


                }
            }






            if (Story.Visible)//hold scroll down
            {
                
                Story.SelectionStart = Story.Text.Length;
                Story.ScrollToCaret();
            }

        }

        private void alusta_Click(object sender, EventArgs e)
        {
            if (alusta.Text == settings.startbtn(lang)) //samm 0 start text
            {
                texttik(startText.startText_Samm_0(lang));
 
                samm = 1;
                alusta.Text = settings.resbtn(lang);
                v1.Text = startText.bteV1(lang);
                v2.Text = startText.bteV2(lang);
            }

            else
            {
                Story.Text = "";
                alusta.Text = settings.startbtn(lang);
                samm = 0;
                v1.Text = "*****";
                v2.Text = "*****";
                v1.Visible = true;
                v2.Visible = true;
                Story.ForeColor = System.Drawing.Color.Black;
                mianpic.Image = mainroompic.Image;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        







        //teksti taimer
        public void texttik(string text)
        {
            timer1.Enabled = true;
            texttick = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {         
            if(i< texttick.Length)
            {             
                Story.Text += texttick[i];
                i++;
                v1.Enabled = false;
                v2.Enabled = false;
                alusta.Enabled = false;
            }
            else
            {
                i = 0;
                timer1.Enabled = false;
                v1.Enabled = true;
                v2.Enabled = true;
                alusta.Enabled = true;
            }         
        }




    }
}
