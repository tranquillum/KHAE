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
            File.ReadAllText(@"..\..\GameTexts\Samm1V1EST.txt");



        string Samm1V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
             File.ReadAllText(@"..\..\GameTexts\Samm1V2EST.txt");



        string Samm1V3Est = "!!!!Kirjuta texti!!!!!";

        string btnSamm1V1EST = "Tõuse Püsti";
        string btnSamm1V2EST = "Lama Edasi";


        //ENG



        //Funktsionid







        public  string startLoc_Samm_1(string lang, int variant)
        {
            
            if (lang == "EST" && variant == 1)
            {
                return Samm1V1EST;

            }
            

            if (lang == "EST" && variant == 2)
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
        //nuppu teksti muutmine

        public string btnSamm1(string lang, int versioon) //nuppu 1 uus tekst
        {

            if (versioon == 1)
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
            else if (versioon == 2)
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

       

        


        //Samm 2

        //EST
        string Samm2V1EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            "*Sa tõused, kloppides oma riideid tolmust*" + Environment.NewLine +
            "* Sa uurid toas veidi segaduses olles ringi*" + Environment.NewLine +
            "..Kuidas ma siia sain" + Environment.NewLine +
            "*Tugev pea valu lööb sulle pähe*" + Environment.NewLine +
            "*Mingi hääl hakkab rääkima*" + Environment.NewLine +
           "!#!@%:..Aeg ütleb.." + Environment.NewLine +
            "*Sa vaatad segaduses ringi, leides mitte kedagi*" + Environment.NewLine +
            "..Mul on vaja siit ära saada" + Environment.NewLine 
            ;

        string Samm2V2EST = Environment.NewLine + File.ReadAllText(@"..\..\GameTexts\StartLoc.txt", System.Text.Encoding.UTF8);


        string btnSamm2V1EST = "Uuri nurgas olevat kappi";
        string btnSamm2V2EST = "Proovi ust lahti teha";





        //ENG



        //Funktsionid

        public string startLoc_Samm_2(string lang, int variant)
        {

            if (lang == "EST" && variant == 1)
            {
                return Samm2V1EST;

            }


            if (lang == "EST" && variant == 2)
            {
                return Samm2V2EST;

            }
            else return null;

        }

        //nuppu teksti muutmine
        public string btnSamm2(string lang, int versioon) //nuppu 1 uus tekst
        {

            if (versioon == 1)
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
            else if (versioon == 2)
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



    }
}
