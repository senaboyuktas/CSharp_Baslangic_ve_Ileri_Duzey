using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Odev2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsim ve Soyisim");
            string isimSoyisim = Console.ReadLine();

            Console.WriteLine("Not 1 : ");
            string notStr1 = Console.ReadLine();

            Console.WriteLine("Not 2 : ");
            string notStr2 = Console.ReadLine();

            Console.WriteLine("Not 3 : ");
            string notStr3 = Console.ReadLine();

            decimal not1 = Convert.ToDecimal(notStr1);
            decimal not2 = Convert.ToDecimal(notStr2);
            decimal not3 = Convert.ToDecimal(notStr3);

            decimal ortalama = (not1 + not2 + not3) / 3;

            if (ortalama < 45)
            {
                Console.WriteLine("Kaldınız");
            }
            else if (ortalama >= 45 && ortalama < 70)
            {
                Console.WriteLine("Orta ile geçtiniz");
            }
            else if (ortalama >= 70 && ortalama < 90)
            {
                Console.WriteLine("İyi ile geçtiniz");
            }
            else if (ortalama >= 90 && ortalama <= 100)
            {
                Console.WriteLine("Başarılı tebrikler");
            }
            else
            {
                Console.WriteLine("Lütfen not değerlerinizi kontrol ediniz");
            }
            Console.WriteLine("Uygulama sonu");
        }
    }
}
