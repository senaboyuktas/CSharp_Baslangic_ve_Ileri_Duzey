using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Alistirma2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiniz : ");
            string kullaniciSecim = Console.ReadLine();

            double sayi1 = 0;
            double sayi2 = 0;

            if (kullaniciSecim == "1" || kullaniciSecim == "2" || kullaniciSecim == "3" || kullaniciSecim == "4")
            {
                Console.WriteLine("Sayı 1 değerini giriniz : ");
                string s1 = Console.ReadLine();

                Console.WriteLine("Sayı 2 değerini giriniz : ");
                string s2 = Console.ReadLine();

                sayi1 = Convert.ToDouble(s1);
                sayi2 = Convert.ToDouble(s2);
            }

            if (kullaniciSecim == "1")
            {
                double toplam = sayi1 + sayi2;
                Console.WriteLine("Toplam : " + toplam);
            }
            else if (kullaniciSecim == "2")
            {
                double cikartma = sayi1 - sayi2;
                Console.WriteLine("Çıkartma : " + cikartma);
            }
            else if (kullaniciSecim == "3")
            {
                double carpma = sayi1 * sayi2;
                Console.WriteLine("Çarpma : " + carpma);
            }
            else if (kullaniciSecim == "4")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bölen değer 0 olamaz...");
                }
                else
                {
                    double bolum = sayi1 / sayi2;
                    Console.WriteLine("Kalan : " + bolum);
                }
            }
            else 
            {
                Console.WriteLine("Seçim dışı değer girişi yaptınız...");
            }
            Console.WriteLine("Uygulama sonu");
        }
    }
}
