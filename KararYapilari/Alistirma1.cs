using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Alistirma1
    {
        static void Main(string[] args)
        {
            // Kullanıcı Adı : Admin
            // Şifre : 123

            Console.Write("Kullanıcı adınızı giriniz : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifre giriniz : ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "123")
            {
                Console.WriteLine("Merhaba, girişiniz başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız, kullanıcı adı ve şifrenizi kontrol ediniz");
            }
        }
    }
}
