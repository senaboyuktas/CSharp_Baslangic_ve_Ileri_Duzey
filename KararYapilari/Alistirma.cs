using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Alistirma
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı kodunuzu giriniz : ");
            string kullaniciKodu = Console.ReadLine();

            switch (kullaniciKodu)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin yetkisine sahipsiniz");
                    break;
                case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz");
                    break;
                case "FF":
                case "EE":
                case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanıcı kodu");
                    break;
            }
        }
    }
}
