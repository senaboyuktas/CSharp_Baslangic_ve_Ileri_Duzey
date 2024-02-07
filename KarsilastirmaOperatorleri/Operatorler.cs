using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    internal class Operatorler
    {
        static void Main(string[] args)
        {
            int s1 = 100;
            int s2 = 150;

            // Büyüktür
            bool sonucBuyuktur = s1 > s2;

            // Küçüktür
            bool sonucKucuktur = s1 < s2;

            // Atama Operatörü =
            // Degisken = AtanacakDeger
            decimal decimalSayi1 = 10.90M;

            // Eşittir
            bool sonucEsittir = s1 == s2;

            // Eşit Değildir
            bool sonucEsitDegildir = s1 != s2;

            // Büyük Eşittir
            bool sonucBuyukEsit = s1 >= s2;

            // Küçük Eşittir
            bool sonucKucukEsit = s1 <= s2;

            // Is Operatoru
            object o1 = s1;
            Console.WriteLine(o1);
            s1 = (int)o1;
            //s1 = (byte)o1;

            bool isKontrol1 = o1 is int;
            bool isKontrol2 = o1 is byte;

            // As Operatoru
            string isimSoyisim = "Sena Boyuktaş";
            object objectString = isimSoyisim;
            string sonucStr = objectString as string;
        }
    }
}
