using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KHAE
{
    
    class StartLoc
    {
        //--------------------------Samm 1------------------
        //EST
        
        string Samm1V1EST = Environment.NewLine + Environment.NewLine+ Environment.NewLine+ 
            File.ReadAllText(@"..\..\GameTexts\EST\Samm1V1EST.txt"); //Ava silmad
        string Samm1V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\EST\Samm1V2EST.txt"); //lama edasi
        string Samm1V3EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\EST\Samm1V2EST.txt");

        string btnSamm1V1EST = "Tõuse Püsti";
        string btnSamm1V2EST = "Lama Edasi";

        //ENG

        string Samm1V1ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\ENG\Samm1V1ENG.txt"); 
        string Samm1V2ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\ENG\Samm1V2ENG.txt");
        string Samm1V3ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\ENG\Samm1V3ENG.txt");

        string btnSamm1V1ENG = "";
        string btnSamm1V2ENG = "";

        //RUS 

        string Samm1V1RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
        File.ReadAllText(@"..\..\GameTexts\RUS\Samm1V1RUS.txt");
        string Samm1V2RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\RUS\Samm1V2RUS.txt");
        string Samm1V3RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\RUS\Samm1V3RUS.txt");

        string btnSamm1V1RUS = "";
        string btnSamm1V2RUS = "";

        //Funktsionid

        public  string startLoc_Samm_1(string lang, int variant)//story samm1
        {
            if(variant == 1)
            {
                if (lang == "EST")
                {
                    return Samm1V1EST;
                }
                else if (lang == "ENG")
                {
                    return Samm1V1ENG;
                }
                else if (lang == "RUS")
                {
                    return Samm1V1RUS;
                }
                else return null;
            }
            else if (variant == 2)
            {
                if (lang == "EST")
                {
                    return Samm1V2EST;
                }
                else if (lang == "ENG")
                {
                    return Samm1V2ENG;
                }
                else if (lang == "RUS")
                {
                    return Samm1V2RUS;
                }
                else return null;
            }
            else return null;              
        }

        public string startLoc_Samm1_V3(string lang)//KORVAL STORY
        {
            if (lang == "EST")
            {
                return Samm1V3EST;
            }
            else if (lang == "ENG")
            {
                return Samm1V3ENG;
            }
            else if (lang == "RUS")
            {
                return Samm1V3RUS;
            }
            else return null;
        }
        //nuppu teksti muutmine

        public string btnSamm1(string lang, int variant) //nuppud samm1
        {
            if (variant == 1)
            {
                if (lang == "EST")
                {
                    return btnSamm1V1EST;
                }
                else if (lang == "ENG")
                {
                    return btnSamm1V1ENG;
                }
                else if (lang == "RUS")
                {
                    return btnSamm1V1RUS;
                }
                else return null;
            }
            else if (variant == 2)
            {
                if (lang == "EST")
                {
                    return btnSamm1V2EST;
                }
                else if (lang == "ENG")
                {
                    return btnSamm1V2ENG;
                }
                else if (lang == "RUS")
                {
                    return btnSamm1V2RUS;
                }
                else return null;
            }
            else return null;
        }

            
        //-------------------------------Samm 2--------------------------------------------------

        //EST
        string Samm2V1EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm2V1EST.txt");//Touse pusti
        string Samm2V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm2V2EST.txt");//lama edasi
        string Samm2V3EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\EST\Samm2V3EST.txt");

        string btnSamm2V1EST = "Uuri nurgas olevat kappi";
        string btnSamm2V2EST = "Proovi ust lahti teha";

        //ENG
        string Samm2V1ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\ENG\Samm2V1ENG.txt");//
        string Samm2V2ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\ENG\Samm2V2ENG.txt");//
        string Samm2V3ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
                 File.ReadAllText(@"..\..\GameTexts\ENG\Samm2V3ENG.txt");

        string btnSamm2V1ENG = "";
        string btnSamm2V2ENG = "";

        //RUS
        string Samm2V1RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\RUS\Samm2V1RUS.txt");//
        string Samm2V2RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\RUS\Samm2V2RUS.txt");//
        string Samm2V3RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
                 File.ReadAllText(@"..\..\GameTexts\RUS\Samm2V3RUS.txt");

        string btnSamm2V1RUS = "";
        string btnSamm2V2RUS = "";

        //Funktsionid

        public string startLoc_Samm_2(string lang, int variant) //story samm2
        {
            if (variant == 1)
            {
                if (lang == "EST")
                {
                    return Samm2V1EST;
                }
                else if (lang == "ENG")
                {
                    return null;
                }
                else if (lang == "RUS")
                {
                    return null;
                }
                else return null;
            }
            else if (variant == 2)
            {
                if (lang == "EST")
                {
                  return Samm2V2EST;            
                }
                else if (lang == "ENG")
                {
                    return null;
                }
                else if (lang == "RUS")
                {
                    return null;
                }
                else return null;
            }
            else return null;
        }

        public string startLoc_Samm_2_V3(string lang)//KORVAL STORY
        {
            if (lang == "EST")
            {
                return Samm2V3EST;
            }
            else if (lang == "ENG")
            {
                return Samm2V3ENG;
            }
            else if (lang == "RUS")
            {
                return Samm2V3RUS;
            }
            else return null;
        }

        //nuppu teksti muutmine
        public string btnSamm2(string lang, int variant) //nuppud samm2
        {
            if (variant == 1)
            {
                if (lang == "EST")
                {
                    return btnSamm2V1EST;
                }
                else if (lang == "ENG")
                {
                    return btnSamm2V1ENG;
                }
                else if (lang == "RUS")
                {
                    return btnSamm2V1RUS;
                }
                else return null;
            }
            else if (variant == 2)
            {
                if (lang == "EST")
                {
                    return btnSamm2V2EST;
                }
                else if (lang == "ENG")
                {
                    return btnSamm2V2ENG;
                }
                else if (lang == "RUS")
                {
                    return btnSamm2V2RUS;
                }
                else return null;
            }
            else return null;
        }

        //----------------SAMM3-------------------------
        //EST
        string Samm3V1EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm3V1EST.txt");//
        string Samm3V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm3V2EST.txt");//
        string Samm3V3EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\EST\Samm3V3EST.txt");

        string btnSamm3V1EST = "Võtta võtti";
        string btnSamm3V2EST = "Uuri toas edasi";

        //ENG
        string Samm3V1ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\ENG\Samm3V1ENG.txt");//Uuri nurgas olevat kappi
        string Samm3V2ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\ENG\Samm3V2ENG.txt");//proovi uks
        string Samm3V3ENG = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\ENG\Samm3V3ENG.txt");

        string btnSamm3V1ENG = "";
        string btnSamm3V2ENG = "";

        //RUS
        string Samm3V1RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\RUS\Samm3V1RUS.txt");//
        string Samm3V2RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\RUS\Samm3V2RUS.txt");//
        string Samm3V3RUS = Environment.NewLine + Environment.NewLine + Environment.NewLine +
                 File.ReadAllText(@"..\..\GameTexts\RUS\Samm3V3RUS.txt");

        string btnSamm3V1RUS = "";
        string btnSamm3V2RUS = "";
        //Funktsionid

        public string startLoc_Samm_3(string lang, int variant) //story samm3
        {
            if (variant == 1)
            {
                if (lang == "EST")
                {
                    return Samm3V1EST;
                }
                else if (lang == "ENG")
                {
                    return Samm3V1ENG;
                }
                else if (lang == "RUS")
                {
                    return Samm3V1RUS;
                }

                else return null;
            }
            else if (variant == 2)
            {
                if (lang == "EST")
                {
                    return Samm3V2EST;

                }
                else if (lang == "ENG")
                {
                    return Samm3V2ENG;
                }
                else if (lang == "RUS")
                {
                    return Samm3V2RUS;
                }
                else return null;
            }
            else return null;
        }

        public string startLock_Samm3_V3(string lang)
        {
            if (lang == "EST")
            {
                return Samm3V3EST;
            }
            else if (lang == "ENG")
            {
                return Samm3V3ENG;
            }
            else if (lang == "RUS")
            {
                return Samm3V3RUS;
            }
            else return null;
        }

        //nuppu teksti muutmine
        public string btnSamm3(string lang, int variant) //nuppud samm3
        {
            if (variant == 1)
            {
                if (lang == "EST")
                {
                    return btnSamm3V1EST;
                }
                else if (lang == "ENG")
                {
                    return btnSamm3V1ENG;
                }
                else if (lang == "RUS")
                {
                    return btnSamm3V1RUS;
                }
                else return null;
            }
            else if (variant == 2)
            {
                if (lang == "EST")
                {
                    return btnSamm3V2EST;
                }
                else if (lang == "ENG")
                {
                    return btnSamm3V2ENG;
                }
                else if (lang == "RUS")
                {
                    return btnSamm3V2RUS;
                }
                else return null;
            }
            else return null;
        }





    }
}
