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



        public string startbtn(int lang)
        {
            if (lang == 0)
            {
                return starbtnEST;
            }


            else return null;
        }

        public string resbtn(int lang)
        {
            if (lang == 0)
            {
                return restartbtnEST;
            }

            else return null;
        }
    }
}
