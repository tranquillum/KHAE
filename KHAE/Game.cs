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
        ImgAdd ImgAdd = new ImgAdd();


        //Muutujad
        int samm = 0;
        int lang ;// EST = 0, ENG = 1, RUS = 2
        double kord = 0;
        string texttick = "";
        int timertick = 0;
        int kang = 0;
        string VorP = "";
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
            mianpic.Image = Image.FromFile(ImgAdd.GameImgAdd(samm));

            
        }

                 
  
        //Button 1
        private void button1_Click(object sender, EventArgs e)
        {
            int variant = 1;
            if (samm == 7 && kang > 0)
            {
                samm += 2;
            }
            else
            {
                samm++;
            }
            if (samm == 20)
            {
                Samm17andmoer();
                v1.Visible = false;
                v2.Visible = false;
            }
                    
            else if (samm==12 || samm==10)
            {

                texttik(textAdd.GameTextAdd(lang, samm, variant));

                kord = 0;
                v1.Text = textAdd.BtnTextAdd(lang, samm, variant);


                v2.Visible = false;
            }
            else if (samm == 17)
            {
                VorP = "V";
                Var1();

            }
            else if (samm > 17)
            {
                
                Samm17andmoer();

            }
            else
            {
                Var1();
            }



            mianpic.Image = Image.FromFile(ImgAdd.GameImgAdd(samm));
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
            
            if (samm==0)
            {
                kord++;
                Var2End2();
 
               
            }
            
            else if (samm ==1 || samm ==5)
            {
                Var2End1();

            }
            
            else if (samm == 17)
            {
                samm++;
                VorP = "P";
                texttik(textAdd.GameTextAdd(lang, samm, variant));
                v1.Text = textAdd.BtnTextAdd(lang, samm, variant);
                v2.Text = textAdd.BtnTextAdd(lang, samm, variant + 1);
                

            }
            else if (samm > 17)
            {
                
                Back();

            }
            else if (samm == 2||samm==3 || samm ==4 || samm ==6 || samm ==7 || samm == 8 || samm ==9 || samm ==11 || samm ==13 || samm ==14 || samm ==15 || samm ==16)
            {

                Var2Inf();

            }


            mianpic.Image = Image.FromFile(ImgAdd.GameImgAdd(samm));
            if (Story.Visible)//hold scroll down
            {
                
                Story.SelectionStart = Story.Text.Length;
                Story.ScrollToCaret();
            }

        }
        public void Var1()
        {
            int variant = 1;
            texttik(textAdd.GameTextAdd(lang, samm, variant));

            kord = 0;
            v1.Text = textAdd.BtnTextAdd(lang, samm, variant);
            v2.Text = textAdd.BtnTextAdd(lang, samm, variant + 1);
            mianpic.Image = kapppic.Image;

            v1.Visible = true;
            v2.Visible = true;

        }

        public void Back()
        {
            texttik(textAdd.GameTextAdd(lang, samm, 3));

        }

        public void Samm17andmoer()
        {
            if (VorP == "V")
            {
                texttik(textAdd.GameTextAdd(lang, samm, 1));
                if (samm < 20)
                {
                    v1.Text = textAdd.BtnTextAdd(lang, samm, 1);
                    v2.Text = textAdd.BtnTextAdd(lang, samm, 3);
                }

            }
            else if (VorP == "P")
            {
                texttik(textAdd.GameTextAdd(lang, samm, 2));
                if (samm < 20)
                {
                    v1.Text = textAdd.BtnTextAdd(lang, samm, 2);
                    v2.Text = textAdd.BtnTextAdd(lang, samm, 3);
                }

            }

        }



        public void Var2Inf()
        {
            int variant = 2;
            texttik(textAdd.GameTextAdd(lang, samm, variant));
            v2.Text = textAdd.BtnTextAdd(lang, samm, variant + 1);

        }

        public void Var2End1()
        {
            int variant = 2;

            Story.Text = "";
            texttik(textAdd.GameTextAdd(lang, samm, variant));

            v1.Visible = false;
            v2.Visible = false;
            kord = 0;
        }

        public void Var2End2()
        {
            int variant = 2;

            if (kord >= 2)
            {
                Story.Text = "";
                texttik(textAdd.GameTextAdd(lang, samm, variant + 1));

                v1.Visible = false;
                v2.Visible = false;
                kord = 0;
            }
            else
            {
                texttik(textAdd.GameTextAdd(lang, samm, variant));


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
