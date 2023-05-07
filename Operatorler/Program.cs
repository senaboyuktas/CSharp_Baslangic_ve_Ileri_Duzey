using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmatiksel Operatörler

            //// Toplama Operatörü +

            //// int + int
            //int s1 = 10;
            //int s2 = 15;
            //int toplamInt = s1 + s2;

            //byte s3 = 10;
            //byte s4 = 10;
            //var toplamByte = s3 + s4;

            //// string + int ( string )
            //// int + string ( string )
            //string metin1 = "Merhaba";
            //int s5 = 10;
            //string toplamStr1 = metin1 + s5;

            //// string + string ( string )

            //// ---------------------------------------------------

            //// Çıkartma Operatörü -

            //int s6 = 100;
            //int s7 = 50;
            //int sonuc = s6 - s7;
            //Console.WriteLine(sonuc);

            //// ---------------------------------------------------

            //// Çarpma Operatörü *

            //double d1 = 10.4;
            //double d2 = 10;
            //double sonucDouble = d1 * d2;
            //Console.WriteLine(sonucDouble);

            //// ---------------------------------------------------

            //// Bölme Operatörü /

            //int s8 = 10;
            //int s9 = 2;
            //int sonucBolme = s8 / s9;

            //// ---------------------------------------------------

            //// Mod Alma Operatörü %
            //int m1 = 11;
            //int m2 = 2;
            //int sonucMod = m1 % m2;

            //// ++ Operatörü
            //int m3 = 10;
            //int OperatorSonucI = m3++;
            //int OperatorSonucII = ++m3;
            //int OperatorSonucIII = m3 + 1;

            //// -- Operatörü
            //int m4 = 10;
            //int OperatorSonucVI = m4--;
            //int OperatorSonucV = --m4;

            #region Alıştırma 1
            
            //Console.WriteLine("Merhaba");
            //Console.Write("İsminiz : ");
            //string isim = Console.ReadLine();

            //Console.Write("Soyisiminiz : ");
            //string soyisim = Console.ReadLine();

            //Console.Write("Doğum Yılınız : ");
            //string yilStr = Console.ReadLine();

            //Console.Clear();

            //int yil = Convert.ToInt32(yilStr);
            ////int mevcutYil = 2023;
            //int mevcutYil = DateTime.Now.Year;
            //int yas = mevcutYil - yil;

            //string mesaj = "Merhaba " + isim + " " + soyisim + " " + yas + " yaşındasınız ...";
            //Console.WriteLine(mesaj);
            //Console.ReadLine();
           
            #endregion

            #region Alıştırma 2
            
            //Console.WriteLine("Sayı 1 değerini giriniz : ");
            //string strS1 = Console.ReadLine();

            //Console.WriteLine("Sayı 2 değerini giriniz : ");
            //string strS2 = Console.ReadLine();

            //decimal s1 = Convert.ToDecimal(strS1);
            //decimal s2 = Convert.ToDecimal(strS2);

            //decimal sonucTopla = s1 + s2;
            //decimal sonucCikart = s1 - s2;
            //decimal sonucCarp = s1 * s2;
            //decimal sonucBol = s1 / s2;
            //decimal sonucMod = s1 % s2;

            //Console.WriteLine("+ : " + sonucTopla);
            //Console.WriteLine("- : " + sonucCikart);
            //Console.WriteLine("* : " + sonucCarp);
            //Console.WriteLine("/ : " + sonucBol);
            //Console.WriteLine("% : " + sonucMod);

            //Console.ReadLine();
            
            #endregion

            #endregion

            #region Karşılaştırma Operatörleri

            //int s1 = 100;
            //int s2 = 150;

            //// Büyüktür
            //bool sonucBuyuktur = s1 > s2;

            //// Küçüktür
            //bool sonucKucuktur = s1 < s2;

            //// Atama Operatörü =
            //// Degisken = AtanacakDeger
            //decimal decimalSayi1 = 10.90M;

            //// Eşittir
            //bool sonucEsittir = s1 == s2;

            //// Eşit Değildir
            //bool sonucEsitDegildir = s1 != s2;

            //// Büyük Eşittir
            //bool sonucBuyukEsit = s1 >= s2;

            //// Küçük Eşittir
            //bool sonucKucukEsit = s1 <= s2;

            //// Is Operatoru
            //object o1 = s1;
            //Console.WriteLine(o1);
            //s1 = (int)o1;
            ////s1 = (byte)o1;

            //bool isKontrol1 = o1 is int;
            //bool isKontrol2 = o1 is byte;

            //// As Operatoru
            //string isimSoyisim = "Sena Boyuktaş";
            //object objectString = isimSoyisim;
            //string sonucStr = objectString as string;

            #region Alıştırma 1
           
            //// Kullanıcadn gelen 3 farklı sınav notunun ortalaması 45 değerine eşit veya büyük mü olarak kontrol edelim

            //Console.Write("Not 1 değerini giriniz : ");
            //string not1 = Console.ReadLine();

            //Console.Write("Not 2 değerini giriniz : ");
            //string not2 = Console.ReadLine();

            //Console.Write("Not 3 değerini giriniz : ");
            //string not3 = Console.ReadLine();

            //Console.WriteLine("Değerleriniz alındı hesaplama işlemi yapılıyor...");

            //decimal dnot1 = Convert.ToDecimal(not1);
            //decimal dnot2 = Convert.ToDecimal(not2);
            //decimal dnot3 = Convert.ToDecimal(not3);

            //decimal ortalama = (dnot1 + dnot2 + dnot3) / 3;

            //bool kontrolSonuc = ortalama >= 45;
            //Console.WriteLine("Ortalama değeriniz 45 değerinden büyük veya eşit mi : " + kontrolSonuc);
            
            #endregion

            #region Alıştırma 2
            
            //// Kullanıcı Adı : Admin
            //// Şifre : 123

            //Console.Write("Kullanıcı adınızı giriniz : ");
            //string kullaniciAdi = Console.ReadLine();

            //Console.Write("Şifre giriniz : ");
            //string sifre = Console.ReadLine();

            //bool kullaniciAdiKontrol1 = kullaniciAdi == "admin";
            //bool kullaniciAdiKontrol2 = kullaniciAdi != "admin";

            //bool sifreKontrol1 = sifre == "123";
            //bool sifreKontrol2 = sifre != "123";
           
            #endregion

            #endregion

            #region Mantıksal Operatörler

            //// Ve Operatörü &&
            //string kullaniciAdi = "Sena";
            //string sifre = "123";
            ////string anahtar = "1";

            //bool donenDeger = kullaniciAdi == "admin" && sifre == "123"; // True değer döner
            ////bool donenDeger = kullaniciAdi == "admin" && sifre == "123" && anahtar == "1"; // True değer döner

            //// Veya Operatörü ||
            //string anahtar = "HGJLJSLGKŞFJH930309YOONGI";

            //bool geriDonus = anahtar == "HGJLJSLGKŞFJH930309YOONGI" || anahtar == "FKGLDKGLK" || anahtar == "IFOGO56JGK";

            #endregion
        }
    }
}
