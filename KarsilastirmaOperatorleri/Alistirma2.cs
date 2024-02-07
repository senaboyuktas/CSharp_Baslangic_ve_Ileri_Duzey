using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    internal class Alistirma2
    {
        static void Main(string[] args)
        {
            // Kullanıcı Adı : Admin
            // Şifre : 123

            Console.Write("Kullanıcı adınızı giriniz : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifre giriniz : ");
            string sifre = Console.ReadLine();

            bool kullaniciAdiKontrol1 = kullaniciAdi == "admin";
            bool kullaniciAdiKontrol2 = kullaniciAdi != "admin";

            bool sifreKontrol1 = sifre == "123";
            bool sifreKontrol2 = sifre != "123";
        }
    }
}
