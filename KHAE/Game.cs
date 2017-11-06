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
using System.Runtime.InteropServices;

namespace KHAE
{
    public partial class Game : Form
    {
        // Lokatsiooni lisamine
        LangSat LangSat = new LangSat();             
        TextAdd textAdd = new TextAdd();


        //Muutujad
        int samm = 0;
        int lang ;// EST = 0, ENG = 1, RUS = 2
        double kord = 0;
        string texttick = "";
        int timertick = 0;

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
            else
            {
                this.Close();
            }
            
            alusta.Text = textAdd.SetBtns(lang, 1);
            this.Text = "Game " + lang;
            v1.Visible = false;
            v2.Visible = false;

            
        }

                 
  
        //Button 1
        private void button1_Click(object sender, EventArgs e)
        {
            int variant = 1;
           //Samm1
            if (samm == 0)//start lock
            {
                texttik(textAdd.GameTextAdd(lang, samm, variant));

                kord = 0;
                v1.Text = textAdd.BtnTextAdd(lang, samm+1 , variant);
                v2.Text = textAdd.BtnTextAdd(lang, samm +1, variant+1);
                mianpic.Image = kapppic.Image;
                samm++;
                
            }          
            else if (samm==1)
            //sam2


            {
                texttik(textAdd.GameTextAdd(lang, samm+1 , variant));

                kord = 0;
                v1.Text = textAdd.BtnTextAdd(lang, samm+1 , variant);
                v2.Text = textAdd.BtnTextAdd(lang, samm+1 , variant+1);
                mianpic.Image = kapppic.Image;
                samm++;
                
            }
            //samm3
            else if (samm == 2)
            {
                texttik(textAdd.GameTextAdd(lang, samm+1 , variant));

                kord = 0;
                v1.Text = textAdd.BtnTextAdd(lang, samm+1 , variant);
                v2.Text = textAdd.BtnTextAdd(lang, samm+1 , variant+1);
                mianpic.Image = kapppic.Image;
                samm++;
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
            int variant =2;
            //samm1
            if (samm==0|| samm == 1)//start lock
            {
                kord++;

                
                
                if (kord >=3)
                {
                    Story.Text = "";
                    Story.ForeColor = System.Drawing.Color.Red;
                    texttik(textAdd.GameTextAdd(lang, samm, variant+1));
                    
                    v1.Visible = false;
                    v2.Visible = false;
                    kord = 0;
                }
                else
                {
                    texttik(textAdd.GameTextAdd(lang, samm, variant));


                }
            }
            //samm2
            else if (samm ==2)
            {
                kord++;
                if (kord >= 4)
                {
                    texttik(textAdd.GameTextAdd(lang, samm, variant+1));

                }
                else
                {

                    texttik(textAdd.GameTextAdd(lang, samm, variant));
                }





            }
            //samm3
            else if (samm == 3)
            {
                





            }



            if (Story.Visible)//hold scroll down
            {
                
                Story.SelectionStart = Story.Text.Length;
                Story.ScrollToCaret();
            }

        }


        //teksti taimer
        public void texttik(string text)
        {
            Story.Text += text;
            //timer1.Enabled = true;
            //texttick = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(timertick < texttick.Length)
            {             
                Story.Text += texttick[timertick];
                timertick++;
                v1.Enabled = false;
                v2.Enabled = false;
                alusta.Enabled = false;
                if (Story.Visible)
                {

                    Story.SelectionStart = Story.Text.Length;
                    Story.ScrollToCaret();
                }
            }
            else
            {
                timertick = 0;
                timer1.Enabled = false;
                v1.Enabled = true;
                v2.Enabled = true;
                alusta.Enabled = true;
            }         
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alusta_Click_1(object sender, EventArgs e)
        {
            if (alusta.Text == textAdd.SetBtns(lang, 1)) //samm 0 start text
            {
                texttik(textAdd.GameTextAdd(lang,0,1));
                v1.Visible = true;
                v2.Visible = true;

                alusta.Text = textAdd.SetBtns(lang, 2);
                v1.Text = textAdd.BtnTextAdd(lang, 0,1);
                v2.Text = textAdd.BtnTextAdd(lang, 0,2);
                samm = 0;
            }

            else
            {
                Story.Text = "";
                alusta.Text = textAdd.SetBtns(lang,1);
                samm = 0;
                v1.Text = "";
                v2.Text = "";
                v1.Visible = false;
                v2.Visible = false;
                Story.ForeColor = System.Drawing.Color.Black;
                mianpic.Image = mainroompic.Image;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();




        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
