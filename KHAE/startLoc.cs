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
        string textFolder = @"..\..\GameTexts\" ;
        
        //--------------------------Samm 1------------------
        //EST

        string[,] Samm1 = new string[3,3]
        {
            { File.ReadAllText(@"..\..\GameTexts\EST\Samm1V1.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Samm1V2.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Samm1V3.txt") },
            { File.ReadAllText(@"..\..\GameTexts\ENG\Samm1V1.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Samm1V2.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Samm1V3.txt") },
            { File.ReadAllText(@"..\..\GameTexts\RUS\Samm1V1.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Samm1V2.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Samm1V3.txt") }
        };


        string[,] btnSamm1 = new string[3, 3]
        {
            { File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm1V1.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm1V2.txt"),File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm1V3.txt")},
            { File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm1V1.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm1V2.txt"),File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm1V3.txt")},
            { File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm1V1.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm1V2.txt"),File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm1V3.txt") }
        };

    
        //Funktsionid

        public  string startLoc_Samm_1(int lang, int variant)//story samm1
        {
            return Samm1[lang, variant - 1];
        }
        //nuppu teksti muutmine

        public string startLoc_btnSamm_1(int lang, int variant) //nuppud samm1
        {
            return btnSamm1[lang, variant - 1];
        }


        //-------------------------------Samm 2--------------------------------------------------


        string[,] Samm2 = new string[3, 3]
                {
            { File.ReadAllText(@"..\..\GameTexts\EST\Samm2V1.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Samm2V2.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Samm2V3.txt") },
            { File.ReadAllText(@"..\..\GameTexts\ENG\Samm2V1.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Samm2V2.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Samm2V3.txt") },
            { File.ReadAllText(@"..\..\GameTexts\RUS\Samm2V1.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Samm2V2.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Samm2V3.txt") }
                };


        string[,] btnSamm2 = new string[3, 3]
        {
            { File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm2V1.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm2V2.txt"),File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm2V3.txt")},
            { File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm2V1.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm2V2.txt"),File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm2V3.txt")},
            { File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm2V1.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm2V2.txt"),File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm2V3.txt") }
        };


        //Funktsionid

        public string startLoc_Samm_2(int lang, int variant)//story samm1
        {
            return Samm2[lang, variant - 1];
        }
        //nuppu teksti muutmine

        public string startLoc_btnSamm_2(int lang, int variant) //nuppud samm1
        {
            return btnSamm2[lang, variant - 1];
        }

        //----------------SAMM3-------------------------

        string[,] Samm3 = new string[3, 3]
                {
            { File.ReadAllText(@"..\..\GameTexts\EST\Samm3V1.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Samm3V2.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Samm3V3.txt") },
            { File.ReadAllText(@"..\..\GameTexts\ENG\Samm3V1.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Samm3V2.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Samm3V3.txt") },
            { File.ReadAllText(@"..\..\GameTexts\RUS\Samm3V1.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Samm3V2.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Samm3V3.txt") }
                };


        string[,] btnSamm3 = new string[3, 3]
        {
            { File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm3V1.txt"), File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm3V2.txt"),File.ReadAllText(@"..\..\GameTexts\EST\Nuppud\Samm3V3.txt")},
            { File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm3V1.txt"), File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm3V2.txt"),File.ReadAllText(@"..\..\GameTexts\ENG\Nuppud\Samm3V3.txt")},
            { File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm3V1.txt"), File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm3V2.txt"),File.ReadAllText(@"..\..\GameTexts\RUS\Nuppud\Samm3V3.txt") }
        };


        //Funktsionid

        public string startLoc_Samm_3(int lang, int variant)//story samm1
        {
            return Samm3[lang, variant - 1];
        }
        //nuppu teksti muutmine

        public string startLoc_btnSamm_3(int lang, int variant) //nuppud samm1
        {
            return btnSamm3[lang, variant - 1];
        }






    }
}
