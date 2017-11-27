using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KHAE
{
    class TextAdd
    {
        //Settings 
        string[,] startButns = new string[3, 2]
        {
            { "Alusta", "Uuesti"},
            { "Start", "New Game"},
            { "Начать игру", "Заново" }
        };



        public string SetBtns(int lang, int variant) //nuppud samm1
        {
            return startButns[lang, variant - 1];
        }




        //Samm 0
        string[] languages = new string[] { @"GameTexts\EST\Samm", @"GameTexts\ENG\Samm", @"GameTexts\RUS\Samm" };       
        string ver = "V";
        string format = ".txt";

        string[] btnLang = { @"GameTexts\EST\Nuppud\Samm", @"GameTexts\ENG\Nuppud\Samm", @"GameTexts\RUS\Nuppud\Samm" };

        public string GameTextAdd(int lang, int samm, int versioon)
        {
            string[] fullPath = { languages[lang]+ samm.ToString()+ ver+ versioon.ToString()+ format}; //..\..\GameTexts\EST\Samm + sammmu number + "V" + variandi number + ".txt"
            return File.ReadAllText(Path.Combine(fullPath));
            //return Samm0[0,0];            
        }

        public string BtnTextAdd(int lang, int samm, int versioon) 
        {
            string[] fullPath = { btnLang[lang] + samm.ToString() + ver + versioon.ToString() + format }; //..\..\GameTexts\EST\Samm + sammmu number + "V" + variandi number + ".txt"
            return File.ReadAllText(Path.Combine(fullPath));
        }

       

    }
}
