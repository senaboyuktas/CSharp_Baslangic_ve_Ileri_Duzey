using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class MetinselDegiskenler
    {
        static void Main(string[] args)
        {
            // String Tipi

            string isimSoyisim = "Sena Boyuktaş";
            Console.WriteLine(isimSoyisim);
            isimSoyisim = "Hamza Boyuktaş";
            Console.WriteLine(isimSoyisim);

            string buyukKarakter = isimSoyisim.ToUpper();
            string kucukKarakter = isimSoyisim.ToLower();
            string belirliBirBolum = isimSoyisim.Substring(2, 2);

            //---------------------------------------------------------------

            // Char Tipi

            // Kullanıcı seçimi : A
            string kullaniciSecimString = "A";
            char kullaniciSecimChar = 'A'; // Tek bir karakter saklamak istiyorsak char kullanıyoruz.
            Console.WriteLine(kullaniciSecimChar);
        }
    }
}
