using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class StringDonusumu
    {
        static void Main(string[] args)
        {
            string metin1 = "100";

            int s1 = int.Parse(metin1);
            int s2 = Convert.ToInt32(metin1);

            string metin2 = "True";

            bool b1 = bool.Parse(metin2);
            bool b2 = Convert.ToBoolean(metin1);

            string metin3 = null;

            //decimal d1 = decimal.Parse(metin2);
            decimal d2 = Convert.ToDecimal(metin3);

            bool b3 = Convert.ToBoolean(metin3);
        }
    }
}
