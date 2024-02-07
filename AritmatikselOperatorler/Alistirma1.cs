using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler
{
    internal class Alistirma1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Console.Write("İsminiz : ");
            string isim = Console.ReadLine();

            Console.Write("Soyisiminiz : ");
            string soyisim = Console.ReadLine();

            Console.Write("Doğum Yılınız : ");
            string yilStr = Console.ReadLine();

            Console.Clear();

            int yil = Convert.ToInt32(yilStr);
            //int mevcutYil = 2023;
            int mevcutYil = DateTime.Now.Year;
            int yas = mevcutYil - yil;

            string mesaj = "Merhaba " + isim + " " + soyisim + " " + yas + " yaşındasınız ...";
            Console.WriteLine(mesaj);
            Console.ReadLine();
        }
    }
}
