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
        string[] languages = new string[] { @"..\..\GameTexts\EST\Samm", @"..\..\GameTexts\ENG\Samm", @"..\..\GameTexts\RUS\Samm" };       
        string ver = "V";
        string format = ".txt";

        string[] btnLang = { @"..\..\GameTexts\EST\Nuppud\Samm" };

        string[,] Samm0 = new string[,] 
        { 
            { File.ReadAllText(@"..\..\GameTexts\EST\Samm0V1.txt") }, 
            { File.ReadAllText(@"..\..\GameTexts\ENG\Samm0V1.txt") }, 
            { File.ReadAllText(@"..\..\GameTexts\ENG\Samm0V1.txt") }
        };


        string[,] btnsSamm0 = new string[,] 
        {
            { File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm0V1.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm0V2.txt")},
            {"","" },
            {"","" }



        };




        public string startText_Samm_0(int lang, int samm, int versioon)
        {
            string[] fullPath = { languages[lang]+ samm.ToString()+ ver+ versioon.ToString()+ format}; //..\..\GameTexts\EST\Samm + sammmu number + "V" + variandi number + ".txt"
            return File.ReadAllText(Path.Combine(fullPath));
            //return Samm0[0,0];            
        }

        public string btnSamm0(int lang, int samm, int versioon) 
        {
            string[] fullPath = { btnLang[lang] + samm.ToString() + ver + versioon.ToString() + format }; //..\..\GameTexts\EST\Samm + sammmu number + "V" + variandi number + ".txt"
            return File.ReadAllText(Path.Combine(fullPath));
        }

       

    }
}
