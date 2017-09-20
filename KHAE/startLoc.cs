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
        //Samm 1
        //EST
        
        string Samm1V1EST = Environment.NewLine + Environment.NewLine+ Environment.NewLine+ 
            File.ReadAllText(@"..\..\GameTexts\EST\Samm1V1EST.txt"); //Ava silmad



        string Samm1V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\EST\Samm1V2EST.txt"); //lama edasi



        string Samm1V3Est = "!!!!Kirjuta texti!!!!!";

        string btnSamm1V1EST = "Tõuse Püsti";
        string btnSamm1V2EST = "Lama Edasi";


        //ENG



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
                    return Samm1V2EST;
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
        public string startLoc_Surm(string lang)
        {
            if (lang == "EST")
            {
                return Samm1V3Est;

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
                    return btnSamm1V2EST;
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

       

        


        //-------------------------------Samm 2--------------------------------------------------

        //EST
        string Samm2V1EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm2V1EST.txt");//Touse pusti

        string Samm2V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm2V2EST.txt");//lama edasi

        string Samm2VfuckOff = Environment.NewLine + "Ei viitsi enam seda teha." + Environment.NewLine + "Fuck off!"+Environment.NewLine ;


        string btnSamm2V1EST = "Uuri nurgas olevat kappi";
        string btnSamm2V2EST = "Proovi ust lahti teha";
        




        //ENG



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
                    return btnSamm2V2EST;
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
        //----------------SAMM3-------------------------
        //EST
        string Samm3V1EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm3V1EST.txt");//Uuri nurgas olevat kappi

        string Samm3V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            File.ReadAllText(@"..\..\GameTexts\EST\Samm3V2EST.txt");//proovi uks

        string Samm3VfuckOff = Environment.NewLine + Environment.NewLine + "Ei viitsi enam seda teha." + Environment.NewLine + "Fuck off!" + Environment.NewLine;


        string btnSamm3V1EST = "Võtta võtti";
        string btnSamm3V2EST = "Uuri toas edasi";





        //ENG



        //Funktsionid

        public string startLoc_Samm_3(string lang, int variant) //story samm2
        {


            if (variant == 1)
            {
                if (lang == "EST")
                {
                    return Samm3V1EST;
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
                    return Samm3V2EST;

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

        public string satrtLock_FuckOff(string lang)
        {

            if (lang == "EST")
            {
                return Samm3VfuckOff;

            }
            else return null;

        }


        //nuppu teksti muutmine
        public string btnSamm3(string lang, int variant) //nuppud samm2
        {

            if (variant == 1)
            {
                if (lang == "EST")
                {
                    return btnSamm3V1EST;
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
                    return btnSamm3V2EST;
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



    }
}
