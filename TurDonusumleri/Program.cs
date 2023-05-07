using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bilinçli Tür Dönüşümü

            //// Bilinçli Tür Dönüşümü 

            //byte sayi1 = 100;
            //byte byteMin = byte.MinValue; // 0
            //byte byteMax = byte.MaxValue; // 255
            //                              // sayi1 = 256;

            //int sayi2 = 256;
            //int intMin = int.MinValue;
            //int intMax = int.MaxValue;

            //int sayi3 = sayi1; // Bilinçli Tür Dönüşümü

            #endregion

            #region Bilinçsiz Tür Dönüşümü

            //// Bilinçsiz Tür Dönüşümü

            //int sayi1 = 100;
            //int intMin = int.MinValue;
            //int intMax = int.MaxValue;

            //byte sayi2 = (byte)sayi1;

            #endregion

            #region String Dönüşümü

            //string metin1 = "100";

            //int s1 = int.Parse(metin1);
            //int s2 = Convert.ToInt32(metin1);

            //string metin2 = "True";

            //bool b1 = bool.Parse(metin2);
            //bool b2 = Convert.ToBoolean(metin1);

            //string metin3 = null;

            ////decimal d1 = decimal.Parse(metin2);
            //decimal d2 = Convert.ToDecimal(metin3);

            //bool b3 = Convert.ToBoolean(metin3);

            #endregion
        }
    }
}
