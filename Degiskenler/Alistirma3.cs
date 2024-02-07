using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Alistirma3
    {
        static void Main(string[] args)
        {
            // Soru 1 : string i bool tipine dönüştür
            string metin1 = "True";
            bool sb1 = bool.Parse(metin1);
            bool sb2 = Convert.ToBoolean(metin1);

            // Soru 2 : int 100 değerini byte ve float tipine dönüştür
            int s1 = 100;
            byte degisken = (byte)s1;
            float floatDegisken = s1;

            // Soru 3 : Byte ı decimal tipine dönüştür
            byte b1 = 10;
            decimal d1 = b1;
        }
    }
}
