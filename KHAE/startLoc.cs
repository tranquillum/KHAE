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
            "*Sa avad silmad*" + Environment.NewLine+ 
            "*Sa oled ruumis kus seinad on  mustad ning imevad kõik valguse endasse*" + Environment.NewLine+
            "*Näeb välja, et sa oled kuskil keldris*" + Environment.NewLine +
            "*Seinal vilgub tõrvik illumineerib natuke ruumist*" + Environment.NewLine +
            "*Ruumi paremas nurgas vedeleb kapp vastu seina*" + Environment.NewLine +
           "*Vasakul kapist on trellidest uks*" + Environment.NewLine +
            "*Sa vaatad ümberringi, veidi segaduses leides mitte kedagi*" + Environment.NewLine +
            "*Sinu kõrval on kivid ning laes on auk, arvata võib, et nad kukkusid sealt*" + Environment.NewLine + Environment.NewLine+
            "Kus ma olen?..Mis juhtus.?"
            ;



        string Samm1V2EST = Environment.NewLine + Environment.NewLine + Environment.NewLine +
            "*Sa lamad edasi*" + Environment.NewLine +
            "*Püsti tõustes sa lööd oma pea ära*" + Environment.NewLine +
            "* Su peavalu suureneb*" + Environment.NewLine +
        "!#!#Ehkki oleks targem sul silmad avada?" + Environment.NewLine +
        "*Sa kuuled häält nagu oleks keegi su kõrval*" + Environment.NewLine +
        "*Kõik on pime*" + Environment.NewLine ;



        string Samm1V3Est = "!!!!Kirjuta texti!!!!!";

        string btnV1EST = "Tõuse Püsti";
        string btnV2EST = "Lama Edasi";


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
        //nuppu teksti muutmine
        public string btnSamm1(string lang, int versioon) 
        {

            if (lang == "EST"&& versioon==1)
            {
                return btnV1EST;

            }
            else if (lang == "EST" && versioon == 2)
            {
                return btnV2EST;
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

        string Samm2V2EST = "";


       string btnSamm2V1EST = "Uuri nurgas olevat kappi";
        string btnSamm2V2EST = "Proovi ust lahti teha";





        //ENG



        //Funktsionid

        public string startLoc_Samm_2(string lang, double variant)
        {

            if (lang == "EST" && variant == 2.1)
            {
                return Samm2V1EST;

            }


            if (lang == "EST" && variant == 2.2)
            {
                return Samm2V2EST;

            }
            else return null;

        }

        //nuppu teksti muutmine
        public string btnSamm2(string lang, int versioon) 
        {

            if (lang == "EST"&& versioon==1)
            {
                return btnSamm2V1EST;

            }
            else if (lang == "EST" && versioon == 2)
            {
                return btnSamm2V2EST;
            }

            else return null;

        }
       
        

    }
}
