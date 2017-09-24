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
        string[,] Samm0 = new string[,] { { File.ReadAllText(@"..\..\GameTexts\EST\StartLocEST.txt") }, { File.ReadAllText(@"..\..\GameTexts\ENG\StartLocENG.txt") } };
        


        //EST
        string Samm0V1EST = File.ReadAllText(@"..\..\GameTexts\EST\StartLocEST.txt");
        //string[] EST = { File.ReadAllText(@"..\..\GameTexts\EST\StartLocEST.txt") };

        string[,] btnSamm0 = new string[,] { { "Ava Silmad", "Lama Edasi" },{"","" },{"","" } };




        string btnSamm0V1EST = "Ava Silmad";
        string btnSamm0V2EST = "Lama Edasi";

        


        public string startText_Samm_0(int lang)
        {
            if (lang == 0)
            {
                return Samm0[0,0];
            }          
            else return null;
        }

        public string btnSamm0(int lang, int variant) 
        {        
            if (variant == 1)
            {
                if (lang == 0)
                {
                    return btnSamm0V1EST;
                }
                else if (lang == 1)
                {
                    return null;
                }
                else if (lang == 2)
                {
                    return null;
                }
                else return null;
            }
            else if (variant == 2)
            {
                if (lang == 0)
                {
                    return btnSamm0V2EST;
                }
                else if (lang == 1)
                {
                    return null;
                }
                else if (lang == 2)
                {
                    return null;
                }
                else return null;
            }
            else return null;
        }

       

    }
}
