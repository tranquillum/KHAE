using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHAE
{
    class ImgAdd
    {
        string path = @"GameImg\InGameImgs\";

        public string GameImgAdd (int samm)
        {
            string fullPath =  path  + samm + ".jpg" ;
            return fullPath;

        }



    }
}
