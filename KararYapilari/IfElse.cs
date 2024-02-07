using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            // if(şart/şartlar(&& ||))
            // {
            //    şart veya şartlar sağlandı ise yapılacak işlemler
            // }
            // else
            // {
            //    şart veya şartlar doğru değil ise o zaman çalışacak olan kodlar
            // }

            Console.WriteLine("Sayı 1 değerini giriniz : ");
            string sStr1 = Console.ReadLine();

            Console.WriteLine("Sayı 2 değerini giriniz : ");
            string sStr2 = Console.ReadLine();

            decimal sayi1 = Convert.ToDecimal(sStr1);
            decimal sayi2 = Convert.ToDecimal(sStr2);
            decimal toplam = sayi1 + sayi2;

            if (toplam > 50)
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den küçük");
            }
        }
    }
}
