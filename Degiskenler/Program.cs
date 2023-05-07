using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişken Nedir ?

            //// degiskenTipi degiskenAdi = değer;
            //// 1. yol
            ////string isimSoyisim = "Sena Boyuktaş";
            //// 2. yol
            //string isimSoyisim;
            //isimSoyisim = "Sena Boyuktaş";
            //Console.WriteLine(isimSoyisim);
            //Console.ReadLine();

            #endregion

            #region Değişkenlerin Davranışları

            //string degiskenVal1 = "Sena Boyuktaş";
            //string degiskenVal2 = "Hamza Boyuktaş";

            //degiskenVal1 = degiskenVal2;
            //degiskenVal2 = "Zeynep Boyuktaş";

            #endregion

            #region Değişkenlerin Faaliyet Alanları

            //static string S2 = "Zeynep Boyuktaş";
            //static void Main(string[] args)
            //{
            //    string S1 = "Sena Boyuktaş";
            //    S1 = "İkinci İsim";

            //    S2 = "Bir Alt";
            //}

            //static void Test()
            //{
            //    S2 = "İkinci Değer";
            //}

            #endregion

            #region Mantıksal Değişkenler

            //// sena.boyuktas
            //// 1
            //// Giriş Yap

            //// Değerleri kullanıcıdan al
            //// Değerleri değişkenlere kayıt et
            //// Değerleri kontrol et
            //// Değerleri veritabanından doğrula 
            //// Evet => True
            //// Hayır => False

            //bool kulanıcıSonuc = true;
            //kulanıcıSonuc = false;

            //bool kulanıcıDeger;
            //kulanıcıDeger = true;

            #endregion

            #region Metinsel Değişkenler

            //// String Tipi

            //string isimSoyisim = "Sena Boyuktaş";
            //Console.WriteLine(isimSoyisim);
            //isimSoyisim = "Hamza Boyuktaş";
            //Console.WriteLine(isimSoyisim);

            //string buyukKarakter = isimSoyisim.ToUpper();
            //string kucukKarakter = isimSoyisim.ToLower();
            //string belirliBirBolum = isimSoyisim.Substring(2, 2);

            ////---------------------------------------------------------------

            //// Char Tipi

            //// Kullanıcı seçimi : A
            //string kullaniciSecimString = "A";
            //char kullaniciSecimChar = 'A'; // Tek bir karakter saklamak istiyorsak char kullanıyoruz.
            //Console.WriteLine(kullaniciSecimChar);

            #endregion

            #region Sayısal Değişkenler

            //// Tam Sayılar
            //// 1 2 3 4 5 6 7

            //byte deger1 = 10;
            //int deger2 = 100;

            //byte byteMinValue = byte.MinValue;
            //byte byteMaxValue = byte.MaxValue;

            //int intMinValue = int.MinValue;
            //int intMaxValue = int.MaxValue;

            //Console.WriteLine(byteMinValue);
            //Console.WriteLine(byteMaxValue);

            //Console.WriteLine(intMinValue);
            //Console.WriteLine(intMaxValue);

            ////-----------------------------------------------------------

            //// Ondalıklı Sayılar

            //// Double
            //double doubleVal1 = 10.2;
            //double doubleVal2 = 10;
            //double doubleVal3 = 10.9d;

            //double doubleMinVal = double.MinValue;
            //double doubleMaxVal = double.MinValue;

            //// Decimal
            //decimal decimalVal1 = 10.2M;

            //decimal decimalMinVal = decimal.MinValue;
            //decimal decimalMaxVal = decimal.MinValue;

            //// Float
            //float floatVal1 = 10.2F;

            //float floatMinVal = float.MinValue;
            //float floatMaxVal = float.MinValue;

            #endregion

            #region Zamansal Değişkenler

            //// 1. Kullanıcı 13-17
            //// 2. Kullanıcı 17-21

            //// 1. Kullanıcı kartı okut
            //// Kartın içinde bulunan id : 1
            //// 1. Kullanıcı geldi saat 14 = true
            //// 2. Kullanıcı geldi saat 14 = false

            //DateTime tarihSaat = DateTime.Now;

            #endregion

            #region Alıştırmalar

            #region Alıştırma 1

            //Console.WriteLine("Merhaba");

            //Console.Write("İsminiz nedir ? ");
            //string isim = Console.ReadLine();

            //Console.Write("Soyisminiz nedir ? ");
            //string soyisim = Console.ReadLine();

            //Console.Write("Yaşadığınız şehri giriniz ");
            //string sehir = Console.ReadLine();

            //Console.Clear();

            //Console.WriteLine("İsim : " + isim);
            //Console.WriteLine("Soyisim : " + soyisim);
            //Console.WriteLine("Şehir : " + sehir);

            //Console.ReadLine();

            #endregion

            #region Alıştırma 2

            //// Merhaba
            //// İsminiz : Sena
            //// Soyisim : Boyuktaş
            //// Şehir : İstanbul
            //// Yaş : 23

            //Console.WriteLine("Merhaba");
            //Console.Write("İsminiz : ");
            //string isim = Console.ReadLine();

            //Console.Write("Soyisim : ");
            //string soyisim = Console.ReadLine();

            //Console.Write("Şehir : ");
            //string sehir = Console.ReadLine();

            //Console.Write("Yaş : ");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("İsim : " + isim);
            //Console.WriteLine("Soyisim : " + soyisim);
            //Console.WriteLine("Şehir : " + sehir);
            //Console.WriteLine("Yaş : " + yas);

            //Console.ReadLine();

            #endregion

            #region Alıştırma 3

            //// Soru 1 : string i bool tipine dönüştür
            //string metin1 = "True";
            //bool sb1 = bool.Parse(metin1);
            //bool sb2 = Convert.ToBoolean(metin1);

            //// Soru 2 : int 100 değerini byte ve float tipine dönüştür
            //int s1 = 100;
            //byte degisken = (byte)s1;
            //float floatDegisken = s1;

            //// Soru 3 : Byte ı decimal tipine dönüştür
            //byte b1 = 10;
            //decimal d1 = b1;

            #endregion

            #endregion

            #region Object Tipi

            //// object {int, decimal, string, bool, float, double, class custom class}

            //// Kutulama ( Boxing )
            //object o1 = 100;
            //object o2 = 10.90;
            //object o3 = true;

            #endregion

            #region Var Anahtar Kullanımı

            //int s1 = 10;
            //var s2 = "Sena";
            //var s3 = 100;

            #endregion
        }
    }
}
