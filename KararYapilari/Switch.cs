using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            // switch(ifade)
            // {
            // case kontrol1 :
            // çalışacak olan işlemler
            // break;
            // case kontrol2 :
            // çalışacak olan işlemler
            // break;
            // default :
            // çalışacak olan işlemler
            // break;
            // }

            Console.Write("Hangi Ay : ");
            string kullaniciGelen = Console.ReadLine();

            switch (kullaniciGelen)
            {
                case "Ocak":
                case "Nisan":
                    Console.WriteLine("01");
                    break;
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                default:
                    Console.WriteLine("Belirtilen değerlerin dışında bir değer girişi yaptınız");
                    break;
            }
        }
    }
}
