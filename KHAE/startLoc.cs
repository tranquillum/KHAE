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
        
        string Samm1V1EST = Environment.NewLine + "Ma parem tõusen püsti" + Environment.NewLine+"Mis ma teen edasi?"+Environment.NewLine;
        string Samm1V2EST = Environment.NewLine + "Ma parem hakken liikuma, siin in liiga kulm."+Environment.NewLine+"Aki ma hakkan midagi teha?" + Environment.NewLine;
        string Samm1V3Est = "Sa oled surnud!!!";
        string btnV1EST = "Proovin ukse lahti teha";
        string btnV2EST = "Uurin toas ringi";


        //ENG



        //Funktsionid

        public  string startLoc_Samm_1(string lang, double variant)
        {
            
            if (lang == "EST" && variant == 1.1)
            {
                return Samm1V1EST;

            }
            

            if (lang == "EST" && variant == 1.2)
            {
                return Samm1V2EST;

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

        public string bteV1(string lang) //nuppu 1 uus tekst
        {

            if (lang == "EST")
            {
                return btnV1EST;

            }

            else return null;

        }

        public string bteV2(string lang) //nuppe 2 tekst
        {

            if (lang == "EST")
            {
                return btnV2EST;

            }

            else return null;

        }


        //Samm 2

        //EST



        //ENG



        //Funktsionid





    }
}
