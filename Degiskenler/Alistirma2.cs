using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Alistirma2
    {
        static void Main(string[] args)
        {
            // Merhaba
            // İsminiz : Sena
            // Soyisim : Boyuktaş
            // Şehir : İstanbul
            // Yaş : 23

            Console.WriteLine("Merhaba");
            Console.Write("İsminiz : ");
            string isim = Console.ReadLine();

            Console.Write("Soyisim : ");
            string soyisim = Console.ReadLine();

            Console.Write("Şehir : ");
            string sehir = Console.ReadLine();

            Console.Write("Yaş : ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Şehir : " + sehir);
            Console.WriteLine("Yaş : " + yas);

            Console.ReadLine();
        }
    }
}
