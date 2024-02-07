using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalOperatorler
{
    internal class Operatorler
    {
        static void Main(string[] args)
        {
            // Ve Operatörü &&
            string kullaniciAdi = "Sena";
            string sifre = "123";
            //string anahtar = "1";

            bool donenDeger = kullaniciAdi == "admin" && sifre == "123"; // True değer döner
            //bool donenDeger = kullaniciAdi == "admin" && sifre == "123" && anahtar == "1"; // True değer döner

            // Veya Operatörü ||
            string anahtar = "HGJLJSLGKŞFJH930309YOONGI";

            bool geriDonus = anahtar == "HGJLJSLGKŞFJH930309YOONGI" || anahtar == "FKGLDKGLK" || anahtar == "IFOGO56JGK";
        }
    }
}
