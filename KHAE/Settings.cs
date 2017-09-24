using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHAE
{
    class Settings
    {

        //EST start nuppud
        string starbtnEST = "Alusta";
        string restartbtnEST = "Uuesti";



        public string startbtn(string lang)
        {
            if (lang == "EST")
            {
                return starbtnEST;
            }


            else return null;
        }

        public string resbtn(string lang)
        {
            if (lang == "EST")
            {
                return restartbtnEST;
            }

            else return null;
        }
    }
}
