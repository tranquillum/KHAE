using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KHAE
{
    class StartText
    {
        //Samm 0
        //EST
        string sammSamm0V1EST = File.ReadAllText(@"..\..\GameTexts\StartLoc.txt", System.Text.Encoding.UTF8);

        string btnSamm0V1EST = "Ava Silmad";
        string btnSamm0V2EST = "Lama Edasi";

        public string startText_Samm_0(string lang)
        {

            if (lang == "EST")
            {
                return sammSamm0V1EST;

            }
            
            else return null;

        }


        public string btnSamm0(string lang, int versioon) 
        {

            if ( versioon ==1)
            {
                if (lang == "EST")
                {
                    return btnSamm0V1EST;
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
            else if (versioon == 2)
            {
                if (lang == "EST")
                {
                    return btnSamm0V2EST;
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
