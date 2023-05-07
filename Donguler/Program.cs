using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            #region For döngüsü genel kullanımı

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("Ben bir for döngüsüyüm");
            //}

            #endregion

            #region 1 ile 10 arasındaki değerleri yazdıralım

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i + ". tekrar !");
            //}

            #endregion

            #region 1 ile 100 arasındaki çift sayıları yazdıralım

            //for (int sayac = 1; sayac <= 100; sayac++)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        Console.WriteLine(sayac + " - çift sayıdır !");
            //    }
            //}

            #endregion

            #region Ödev : 1 ile 100 arasındaki çift sayıların toplamını yazdıralım

            //int toplam = 0;
            //for (int sayac = 1; sayac <= 100; sayac++)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        //toplam = toplam + sayac;
            //        toplam += sayac;
            //    }
            //}
            //Console.WriteLine("1 ile 100 arasındaki çift sayıların toplamı : {0}", toplam);

            #endregion

            #region Girilen sayının faktöriyelini bulma

            //string kullaniciGelenDeger = string.Empty;
            //int kullaniciGelenDegerInt = 0;
            //int faktoriyelHesapla = 1;

            //Console.WriteLine("Lütfen faktöriyel esabı yapmak istediğiniz değeri ekrana yazınız : ");
            //kullaniciGelenDeger = Console.ReadLine();
            //kullaniciGelenDegerInt = int.Parse(kullaniciGelenDeger);

            //for (int i = kullaniciGelenDegerInt; i > 1; i--)
            //{
            //    faktoriyelHesapla = faktoriyelHesapla + i;
            //    //faktoriyelHesapla *= i;
            //}
            //Console.WriteLine("{0} değerinin faktöriyel sonucu : {1}",kullaniciGelenDeger,faktoriyelHesapla);

            #endregion

            #region Sonsuz döngü oluşturmak

            //int sonsuzDonguSayac = 0;
            //for (; ; )
            //{
            //    sonsuzDonguSayac++;
            //    //break anahtar kelimesi
            //    //if(sonsuzDonguSayac == 2)
            //    //  break;
            //    //continue anahtar kelimesi
            //    if (sonsuzDonguSayac == 2)
            //        continue;

            //    Console.WriteLine(sonsuzDonguSayac);

            //    Console.WriteLine("Merhaba ben bir sonsuz döngüyüm");
            //}

            #endregion

            #region İç içe for döngüsü kullanımı

            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ödev : Çarpım Tablosu

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int y = 1; y <= 9; y++)
            //    {
            //        int carpimSonuc = i + y;
            //        Console.Write("{0}*{1}={2} \t", i, y, carpimSonuc);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region Foreach Döngüsü

            #region Genel Kullanımı

            //string[] isimler = new[] { "Sena Boyuktaş", "Zeynep Boyuktaş", "Hamza Boyuktaş" };
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Örnek Uygulamalar

            #region Uygulama 1 : int veri tipinde bir dizi oluşturalım , kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin, ve dizi içindeki alanlara değer ataması yapsın. Daha sonra dizi içerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran bir uygulama yazalım. 

            //Console.WriteLine("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu giriniz");
            //string uygulama1DiziUzunluk = Console.ReadLine();
            //int uygulamaDiziUzunlukInt = int.Parse(uygulama1DiziUzunluk);

            //int[] uygulama1Dizi = new int[uygulamaDiziUzunlukInt];

            //for (int uygulamaSayac = 0; uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
            //{
            //    Console.WriteLine("{0}. index e denk gelen değeri giriniz", uygulamaSayac);

            //    uygulama1Dizi[uygulamaSayac] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz");

            //Console.WriteLine("Dizi içerisindeki değerler, toplam ve ortalama değeri aşağıdaki gibidir.");

            //int uygulama1Toplam = 0, uygulama1Ortalama = 0;
            //foreach (int item in uygulama1Dizi)
            //{
            //    Console.WriteLine(item);
            //    uygulama1Toplam = uygulama1Toplam + item;
            //}
            //Console.WriteLine("+----------------------------");

            //Console.WriteLine(uygulama1Toplam);

            //Console.WriteLine("Dizi içerisindeki eleman sayısı : {0}", uygulama1Dizi.Length);
            //uygulama1Ortalama = uygulama1Toplam / uygulama1Dizi.Length;
            //Console.WriteLine("Ortalama : {0}", uygulama1Ortalama);
            //Console.ReadLine();

            #endregion

            #region Uygulama 2 : 20 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1 - 10 arasındaki değerler ile dolduralm. Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım. 

            //Random Rnd = new Random();

            //int[] uygulama2Dizi = new int[20];
            //for (int uygulama2Sayac = 0; uygulama2Sayac < uygulama2Dizi.Length; uygulama2Sayac++)
            //{
            //    uygulama2Dizi[uygulama2Sayac] = Rnd.Next(1, 10);
            //}

            //int uygulama2Bul = 0;

            //foreach (int item in uygulama2Dizi)
            //{
            //    Console.WriteLine(item);
            //    if (item == 4)
            //        uygulama2Bul++;
            //}

            //Console.WriteLine("Dizi içindeki 4 değeri {0} adettir.", uygulama2Bul);
            //Console.ReadLine();

            #endregion

            #endregion

            #endregion

            #region While Döngüsü

            #region While Döngüsü Genel Kullanımı

            //while (true) // Şartımız true olduğu süre boyunca döngümüz çalışmasına devam eder
            //{
            //    /*
            //     * 1 - While ( false )
            //     * 2 - Break;
            //     */
            //}

            #endregion

            #region Örnek Kullanım 1 : 10 a kadar olan sayıların değerlerini yazdıralım

            //int sayac = 1;
            //while(sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //}

            #endregion

            #region Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadarekrana yazalım

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //string kullanicidanGelenDeger = Console.ReadLine();
            //Console.WriteLine("---------------------------------------------");
            //int ornekKullanimSayac = int.Parse(kullanicidanGelenDeger);

            //while (ornekKullanimSayac != -1)
            //{
            //    Console.WriteLine(ornekKullanimSayac);
            //    ornekKullanimSayac = ornekKullanimSayac - 1;
            //    //ornekKullanimSayac--;
            //}

            //Console.WriteLine("Örnek 1 işlemi tamamlandı");

            #endregion

            #region Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0 dan kucuk bir değer girişi yapılırsa toplama işlemini bitirelim. ve ekrana toplam sonucu yazalım

            //Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz. ");
            //Console.WriteLine("Not : -1  değeri işlemlerinizi dururur.");

            //int ornekKullanimToplam = 0;
            //while (true)
            //{
            //    string Ornek2KullaniciGelenDeger = Console.ReadLine();
            //    int Ornek2KulGelenDegerInt = int.Parse(Ornek2KullaniciGelenDeger);
            //    if (Ornek2KulGelenDegerInt < 0)
            //        break;
            //    else
            //        ornekKullanimToplam = ornekKullanimToplam + Ornek2KulGelenDegerInt;
            //}

            //Console.WriteLine("Toplam Değer : {0}", ornekKullanimToplam);

            #endregion

            #region Ödev : Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım

            //int sistemUretSayi = 0;
            //int tahmminAdet = 1;
            //Random rnd = new Random();
            //sistemUretSayi = rnd.Next(1, 10);

            //while (true)
            //{

            //    Console.Write("{0} . deneme - Lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz :", tahmminAdet);
            //    string rndKullaniciGelen = Console.ReadLine();

            //    int rndKullaniciGelenInt = int.Parse(rndKullaniciGelen);

            //    //if (int.Parse(rndKullaniciGelen) == sistemUretSayi)
            //    if (rndKullaniciGelenInt == sistemUretSayi)
            //    {
            //        tahmminAdet++;
            //        Console.WriteLine("{0}. denemenizde değeri buldunuz Tebrikler !", tahmminAdet);
            //        break;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("{0} . denemeniz , Tahmin edemediniz lütfen yeniden deneyin ...", tahmminAdet);
            //        tahmminAdet++;
            //    }
            //}
            //Console.Clear();

            #endregion

            #endregion

            #region Do While Döngüsü

            #region Genel Kullanımı

            //while(true)
            //{
            //    // kodlarımız çalış
            //}

            //do
            //{

            //    Console.WriteLine("Merhaba Do While");
            //} while (1 == 2);

            // do while döngülerindeki en temel fark şartları ne olursa olsun 1 kere kesin çalışır. 

            #endregion

            #region Ödev 1 : Kullanıcıyı do while içerisine alın ve kullanıcı adı ve password sorun. Kullanıcı adı : Demo Şifre : Demo eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın. Eğer yanlış giriş yapıyorsa do while ile ilgili değerleri sormaya devam edin.

            //string kullaniciAdi = string.Empty;
            //string sifre = string.Empty;
            //int sayac = 0;

            //do
            //{
            //    // Sayaç ile kontrol etmemiz önemli bunun nedeni do while içerisinde herhangi bir if koşulu ile
            //    // şartlarımızı kontrol etmedik while (şart) bloğu içerisinde kontrollerimizi yapığımız için
            //    // değerin hatalı veya doğru olduğunu sayaç adındaki bu değişken üzerinden kontrol ettik.

            //    if (sayac > 0)
            //    {
            //        Console.WriteLine("Kullanıcı adı veya şifre değerlerinden biri hatalı");

            //        Console.WriteLine("Kullanıcı adınızı giriniz : ");
            //        kullaniciAdi = Console.ReadLine();

            //        Console.WriteLine("Şifre girişi yapınız : ");
            //        sifre = Console.ReadLine();

            //        sayac++;
            //    }

            //} while (kullaniciAdi.ToLower() != "demo" || sifre.ToLower() != "demo");
            //Console.WriteLine("Başarılı kullancı girişi");
            //Console.ReadLine();

            #endregion

            #region Odev 2 : Kullanıcıdan 1 ile X arasında bir sayı girmesini isteyin. Daha sonra sistem kullanıcının girmiş olduğu 1 ile X değerleri arasında bir sayı tahmini yapsın. Daha sonra kullanıcu sistemin tahmin etmiş olduğu sayıyı bulmaya çalışssın. Bulamaz ise yeniden yeniden sorsun. Ne zaman kullanıcı ilgili değeri bulursa Y kadar denediniz ve sonuca ulaştınız desin.

            //int odev2tahmin = 0;
            //int odev2uretilenSayi = 0;
            //int odev2sayac = 0;

            //Console.Write("Tahmin oyunu için en yüksek değeri giriniz : ");
            //int odev2kullaniciMaxValue = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //odev2uretilenSayi = rnd.Next(1, odev2kullaniciMaxValue);

            //do
            //{
            //    odev2sayac++;
            //    Console.Write("{0}. hakkınız üretilen sayıyı tahmin ediniz : ", odev2sayac);
            //    odev2tahmin = int.Parse(Console.ReadLine());

            //} while (odev2tahmin != odev2uretilenSayi);

            //Console.Write("Tebrikler {0}. hakkınızda sayıyı tahmin ettiniz", odev2sayac);
            //Console.ReadLine();

            #endregion

            #endregion
        }
    }
}
