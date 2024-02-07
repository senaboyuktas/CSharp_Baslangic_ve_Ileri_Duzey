using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler
{
    internal class Alistirma2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı 1 değerini giriniz : ");
            string strS1 = Console.ReadLine();

            Console.WriteLine("Sayı 2 değerini giriniz : ");
            string strS2 = Console.ReadLine();

            decimal s1 = Convert.ToDecimal(strS1);
            decimal s2 = Convert.ToDecimal(strS2);

            decimal sonucTopla = s1 + s2;
            decimal sonucCikart = s1 - s2;
            decimal sonucCarp = s1 * s2;
            decimal sonucBol = s1 / s2;
            decimal sonucMod = s1 % s2;

            Console.WriteLine("+ : " + sonucTopla);
            Console.WriteLine("- : " + sonucCikart);
            Console.WriteLine("* : " + sonucCarp);
            Console.WriteLine("/ : " + sonucBol);
            Console.WriteLine("% : " + sonucMod);

            Console.ReadLine();
        }
    }
}
