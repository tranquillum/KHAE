﻿using System;
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
        string sammSamm0V1EST = "#Chapter I : Start of K.H.A.E" + Environment.NewLine+Environment.NewLine+ 
            "#!?%!#!&:'Aeg, see on imelik asi, kas ole? Sa ei tunne seda, Sa ei saa seda haarata.." +
            "Kui sul poleks kella ei teaks, et see eksisteeriks, kuid siiski ta juhib meid. " +
            "See muudab meie käitumist tavapärasest, ta paneb meid tegema asju mida me tavaliselt ei teeks. " +
            "Mõned inimesed nad..nad ei saa aru selle võimust, mis tal on meie üle. " +
            "Me oleme kui nukk tema kätes, pole vahet kes sa oled või kus sa oled..Äratus'"+ Environment.NewLine + Environment.NewLine + 
            "*Kõik on pime*" + Environment.NewLine+ 
            "*Sa kuuled valju sahinat*" + Environment.NewLine + 
            "*Sa tunned külma põrandat enda all*";

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


        public string btnSamm0(string lang, int versioon) //nuppu 1 uus tekst
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
