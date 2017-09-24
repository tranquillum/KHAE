using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHAE
{
    class StartText
    {
        //Samm 0
        //EST
        string sammSamm0V1EST = "*Aeg, see on imelik asi, kas ole? Seda ei ole võimalik tunda, seda ei ole võimalik katsuda..Kui sul poleks kella ei teaks, et ta eksisteeriks kuid ta juhib meid*"+ Environment.NewLine + "Mis ma teen edasi?" + Environment.NewLine;
        string btnV1EST = "Tõuse püsti";
        string btnV2EST = "Istu edasi voodis";

        public string startText_Samm_0(string lang)
        {

            if (lang == "EST")
            {
                return sammSamm0V1EST;

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

    }
}
