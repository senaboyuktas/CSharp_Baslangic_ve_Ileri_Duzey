﻿using System; // Bir kutuphane dosyasını uygulamamızın içerisine eklemektir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uzun bir şekilde yazım. 
            //System.Console.Write("Merhaba");
            // using kısmında kütüphane eklenmiş hali ile yazımı.
            //Console.Write("Merhaba");
            Selamla();

            Ogrenci O1 = new Ogrenci();
            O1.OgrenciMetot2();
            //O1.selamlaOgrenci();
        }
        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
