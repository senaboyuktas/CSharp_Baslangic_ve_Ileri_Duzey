using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler
{
    internal class Operatorler
    {
        static void Main(string[] args)
        {
            // Toplama Operatörü +

            // int + int
            int s1 = 10;
            int s2 = 15;
            int toplamInt = s1 + s2;

            byte s3 = 10;
            byte s4 = 10;
            var toplamByte = s3 + s4;

            // string + int ( string )
            // int + string ( string )
            string metin1 = "Merhaba";
            int s5 = 10;
            string toplamStr1 = metin1 + s5;

            // string + string ( string )

            // ---------------------------------------------------

            // Çıkartma Operatörü -

            int s6 = 100;
            int s7 = 50;
            int sonuc = s6 - s7;
            Console.WriteLine(sonuc);

            // ---------------------------------------------------

            // Çarpma Operatörü *

            double d1 = 10.4;
            double d2 = 10;
            double sonucDouble = d1 * d2;
            Console.WriteLine(sonucDouble);

            // ---------------------------------------------------

            // Bölme Operatörü /

            int s8 = 10;
            int s9 = 2;
            int sonucBolme = s8 / s9;

            // ---------------------------------------------------

            // Mod Alma Operatörü %
            int m1 = 11;
            int m2 = 2;
            int sonucMod = m1 % m2;

            // ++ Operatörü
            int m3 = 10;
            int OperatorSonucI = m3++;
            int OperatorSonucII = ++m3;
            int OperatorSonucIII = m3 + 1;

            // -- Operatörü
            int m4 = 10;
            int OperatorSonucVI = m4--;
            int OperatorSonucV = --m4;
        }
    }
}
