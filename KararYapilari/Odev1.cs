using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Odev1
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı kodunuzu giriniz : ");
            string kullaniciDeger = Console.ReadLine();
            kullaniciDeger = kullaniciDeger.ToUpper();

            if (kullaniciDeger == "ABC" || kullaniciDeger == "123" || kullaniciDeger == "236" || kullaniciDeger == "236")
            {
                Console.WriteLine("Giriş işleminiz başarılı");
            }
            else if (kullaniciDeger == "HHH" || kullaniciDeger == "BBB" || kullaniciDeger == "MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı kodu");
            }
        }
    }
}
