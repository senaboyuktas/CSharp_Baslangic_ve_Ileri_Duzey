using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If 
            
            //// if(şart/şartlar(&& ||))
            //// {
            ////    şart veya şartlar sağlandı ise yapılacak işlemler
            //// }

            //Console.WriteLine("Sayı 1 değerini giriniz : ");
            //string sStr1 = Console.ReadLine();

            //Console.WriteLine("Sayı 2 değerini giriniz : ");
            //string sStr2 = Console.ReadLine();

            //decimal sayi1 = Convert.ToDecimal(sStr1);
            //decimal sayi2 = Convert.ToDecimal(sStr2);
            //decimal toplam = sayi1 + sayi2;

            ////bool toplamKontrol = toplam > 50;

            ////if(toplamKontrol)
            ////{
            ////    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");
            ////}

            //if (toplam > 50)
            //{
            //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");
            //}
            
            #endregion

            #region If Else
            
            //// if(şart/şartlar(&& ||))
            //// {
            ////    şart veya şartlar sağlandı ise yapılacak işlemler
            //// }
            //// else
            //// {
            ////    şart veya şartlar doğru değil ise o zaman çalışacak olan kodlar
            //// }

            //Console.WriteLine("Sayı 1 değerini giriniz : ");
            //string sStr1 = Console.ReadLine();

            //Console.WriteLine("Sayı 2 değerini giriniz : ");
            //string sStr2 = Console.ReadLine();

            //decimal sayi1 = Convert.ToDecimal(sStr1);
            //decimal sayi2 = Convert.ToDecimal(sStr2);
            //decimal toplam = sayi1 + sayi2;

            //if (toplam > 50)
            //{
            //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den küçük");
            //}
            
            #endregion

            #region If Else If
            
            //// if(şart/şartlar(&& ||))
            //// {
            ////    şart veya şartlar sağlandı ise yapılacak işlemler
            //// }
            //// else if
            //// {
            ////    şart veya şartlar sağlandı ise yapılacak işlemler
            //// }
            //// else if
            //// {
            ////    şart veya şartlar sağlandı ise yapılacak işlemler
            //// }
            //// else
            //// {
            ////    şart veya şartlar doğru değil ise o zaman çalışacak olan kodlar
            //// }

            //Console.WriteLine("Sayı 1 değerini giriniz : ");
            //string sStr1 = Console.ReadLine();

            //Console.WriteLine("Sayı 2 değerini giriniz : ");
            //string sStr2 = Console.ReadLine();

            //decimal sayi1 = Convert.ToDecimal(sStr1);
            //decimal sayi2 = Convert.ToDecimal(sStr2);
            //decimal toplam = sayi1 + sayi2;

            //if (toplam >= 100)
            //{
            //    Console.WriteLine("Girmiş olduğunuz değer 100 e eşit veya büyük");
            //}
            //else if (toplam >= 50)
            //{
            //    Console.WriteLine("Girmiş olduğunuz değer 50 ye eşit veya büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Girmiş olduğunuz değer 50 den küçük");
            //}
           
            #endregion

            #region Switch
           
            //// switch(ifade)
            //// {
            //// case kontrol1 :
            //// çalışacak olan işlemler
            //// break;
            //// case kontrol2 :
            //// çalışacak olan işlemler
            //// break;
            //// default :
            //// çalışacak olan işlemler
            //// break;
            //// }

            //Console.Write("Hangi Ay : ");
            //string kullaniciGelen = Console.ReadLine();

            //switch (kullaniciGelen)
            //{
            //    case "Ocak":
            //    case "Nisan":
            //        Console.WriteLine("01");
            //        break;
            //    case "Şubat":
            //        Console.WriteLine("02");
            //        break;
            //    case "Mart":
            //        Console.WriteLine("03");
            //        break;
            //    default:
            //        Console.WriteLine("Belirtilen değerlerin dışında bir değer girişi yaptınız");
            //        break;
            //}
            
            #endregion

            #region Alıştırmalar

            #region Alıştırma 1
           
            //Console.Write("Kullanıcı kodunuzu giriniz : ");
            //string kullaniciKodu = Console.ReadLine();

            //switch (kullaniciKodu)
            //{
            //    case "AA":
            //    case "BB":
            //    case "CC":
            //        Console.WriteLine("Admin yetkisine sahipsiniz");
            //        break;
            //    case "DD":
            //        Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz");
            //        break;
            //    case "FF":
            //    case "EE":
            //    case "GG":
            //        Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı kullanıcı kodu");
            //        break;
            //}
            
            #endregion

            #region Alıştırma 2
           
            //// Kullanıcı Adı : Admin
            //// Şifre : 123

            //Console.Write("Kullanıcı adınızı giriniz : ");
            //string kullaniciAdi = Console.ReadLine();

            //Console.Write("Şifre giriniz : ");
            //string sifre = Console.ReadLine();

            //if (kullaniciAdi == "admin" && sifre == "123")
            //{
            //    Console.WriteLine("Merhaba, girişiniz başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş başarısız, kullanıcı adı ve şifrenizi kontrol ediniz");
            //}
            
            #endregion

            #region Alıştırma 3
            
            //Console.WriteLine("Menü");
            //Console.WriteLine("1 - Toplama");
            //Console.WriteLine("2 - Çıkarma");
            //Console.WriteLine("3 - Çarpma");
            //Console.WriteLine("4 - Bölme");
            //Console.Write("Seçiniz : ");
            //string kullaniciSecim = Console.ReadLine();

            //double sayi1 = 0;
            //double sayi2 = 0;

            //if (kullaniciSecim == "1" || kullaniciSecim == "2" || kullaniciSecim == "3" || kullaniciSecim == "4")
            //{
            //    Console.WriteLine("Sayı 1 değerini giriniz : ");
            //    string s1 = Console.ReadLine();

            //    Console.WriteLine("Sayı 2 değerini giriniz : ");
            //    string s2 = Console.ReadLine();

            //    sayi1 = Convert.ToDouble(s1);
            //    sayi2 = Convert.ToDouble(s2);
            //}

            //if (kullaniciSecim == "1")
            //{
            //    double toplam = sayi1 + sayi2;
            //    Console.WriteLine("Toplam : " + toplam);
            //}
            //else if (kullaniciSecim == "2")
            //{
            //    double cikartma = sayi1 - sayi2;
            //    Console.WriteLine("Çıkartma : " + cikartma);
            //}
            //else if (kullaniciSecim == "3")
            //{
            //    double carpma = sayi1 * sayi2;
            //    Console.WriteLine("Çarpma : " + carpma);
            //}
            //else if (kullaniciSecim == "4")
            //{
            //    if (sayi2 == 0)
            //    {
            //        Console.WriteLine("Bölen değer 0 olamaz...");
            //    }
            //    else
            //    {
            //        double bolum = sayi1 / sayi2;
            //        Console.WriteLine("Kalan : " + bolum);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Seçim dışı değer girişi yaptınız...");
            //}
            //Console.WriteLine("Uygulama sonu");
            
            #endregion

            #endregion

            #region Ödevler

            #region Ödev 1
            
            //Console.Write("Kullanıcı kodunuzu giriniz : ");
            //string kullaniciDeger = Console.ReadLine();
            //kullaniciDeger = kullaniciDeger.ToUpper();

            //if (kullaniciDeger == "ABC" || kullaniciDeger == "123" || kullaniciDeger == "236" || kullaniciDeger == "236")
            //{
            //    Console.WriteLine("Giriş işleminiz başarılı");
            //}
            //else if (kullaniciDeger == "HHH" || kullaniciDeger == "BBB" || kullaniciDeger == "MMM")
            //{
            //    Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı kullanıcı kodu");
            //}
            
            #endregion

            #region Ödev 2
           
            //Console.WriteLine("İsim ve Soyisim");
            //string isimSoyisim = Console.ReadLine();

            //Console.WriteLine("Not 1 : ");
            //string notStr1 = Console.ReadLine();

            //Console.WriteLine("Not 2 : ");
            //string notStr2 = Console.ReadLine();

            //Console.WriteLine("Not 3 : ");
            //string notStr3 = Console.ReadLine();

            //decimal not1 = Convert.ToDecimal(notStr1);
            //decimal not2 = Convert.ToDecimal(notStr2);
            //decimal not3 = Convert.ToDecimal(notStr3);

            //decimal ortalama = (not1 + not2 + not3) / 3;

            //if (ortalama < 45)
            //{
            //    Console.WriteLine("Kaldınız");
            //}
            //else if (ortalama >= 45 && ortalama < 70)
            //{
            //    Console.WriteLine("Orta ile geçtiniz");
            //}
            //else if (ortalama >= 70 && ortalama < 90)
            //{
            //    Console.WriteLine("İyi ile geçtiniz");
            //}
            //else if (ortalama >= 90 && ortalama <= 100)
            //{
            //    Console.WriteLine("Başarılı tebrikler");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen not değerlerinizi kontrol ediniz");
            //}
            //Console.WriteLine("Uygulama sonu");
           
            #endregion

            #endregion

        }
    }
}
