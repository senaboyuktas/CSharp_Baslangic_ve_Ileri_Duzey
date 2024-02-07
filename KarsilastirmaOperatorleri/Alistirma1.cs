using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    internal class Alistirma1
    {
        static void Main(string[] args)
        {
            // Kullanıcadn gelen 3 farklı sınav notunun ortalaması 45 değerine eşit veya büyük mü olarak kontrol edelim

            Console.Write("Not 1 değerini giriniz : ");
            string not1 = Console.ReadLine();

            Console.Write("Not 2 değerini giriniz : ");
            string not2 = Console.ReadLine();

            Console.Write("Not 3 değerini giriniz : ");
            string not3 = Console.ReadLine();

            Console.WriteLine("Değerleriniz alındı hesaplama işlemi yapılıyor...");

            decimal dnot1 = Convert.ToDecimal(not1);
            decimal dnot2 = Convert.ToDecimal(not2);
            decimal dnot3 = Convert.ToDecimal(not3);

            decimal ortalama = (dnot1 + dnot2 + dnot3) / 3;

            bool kontrolSonuc = ortalama >= 45;
            Console.WriteLine("Ortalama değeriniz 45 değerinden büyük veya eşit mi : " + kontrolSonuc);
        }
    }
}
