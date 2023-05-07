using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            #region 10 elemanlı ( string ) Arraylist içindeki değerleri Z-A olacak şekilde sıralayın 
            
            //ArrayList OdevListe = new ArrayList();
            //OdevListe.Add("Zeynep");
            //OdevListe.Add("Özgür");
            //OdevListe.Add("Yakup");
            //OdevListe.Add("Ayşegül");
            //OdevListe.Add("Hakan");
            //OdevListe.Add("Cengiz");
            //OdevListe.Add("Mustafa");
            //OdevListe.Add("Lale");
            //OdevListe.Add("Gökhan");
            //OdevListe.Add("Selim");
            //OdevListe.Add("Nilüfer");

            //// Adım 1 : Tüm değerleri A-Z çevir. 
            //OdevListe.Sort();
            //OdevListe.Reverse();

            #endregion

            //int Capacity = 0;
            //int Count = 0;

            //string[] isimler = new string[10];

            //ArrayList A1 = new ArrayList();

            #region Tek Değer ekleme 
            
            //A1.Add("Cengiz ATİLLA");

            //Capacity = A1.Capacity;
            //Count = A1.Count;

            //A1.Add(100);
            
            #endregion

            #region Birden fazla değer ekleme işlemi. 
            
            //ArrayList A2 = new ArrayList();
            //A2.Add("Yakup");
            //A2.Add("Merve");
            //A2.Add("Utkan");
            //A1.AddRange(A2);
            
            #endregion

            #region Capacity & Count İnceleme
            
            //Capacity = A1.Capacity;
            //Count = A1.Count;
            
            #endregion

            #region Koleksiyon içindeki değere ulaşmak 
            
            //object O1 = A1[3];
            //string S1 = A1[3].ToString();
            //int I1 = (int)A1[1];

            //A1[3] = "Hamza Atilla";
            
            #endregion

            #region ArrayList Sıralama 

            //// Dizinin mevcut elemanlarını ters olarak sıralama 
            //A1.Remove(100);
            //A1.Reverse();
            //// A-Z Sıralama 
            //A1.Sort();

            #endregion

            #region Koleksiyonlar yardımcı komutları 

            //if (A1.Contains("Yakup"))
            //{
            //    int IndexDegeri = A1.IndexOf("Yakup");
            //    A1.RemoveAt(IndexDegeri);
            //}

            //bool Kontrol1 = A1.Contains("Utkan");
            //bool Kontrol2 = A1.Contains(900);

            //object[] D1 = A1.ToArray();

            //A1.Clear();
            //A1.TrimToSize();

            #endregion

            #region ArrayList koleksiyonu içerisindeki değeri silme

            //A1.RemoveAt(3);
            //A1.RemoveRange(2, 2);
            //A1.Remove("Hamza Atilla");

            #endregion

            #region ArrayList Ödev

            //string kullaniciSecim = string.Empty;
            //ArrayList degerListesi = new ArrayList();
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Menü");
            //    Console.WriteLine("1 - Değer Ekle");
            //    Console.WriteLine("2 - Değer Listele");
            //    Console.WriteLine("3 - Değer Ara");
            //    Console.WriteLine("4 - Değer Düzenle");
            //    Console.WriteLine("5 - Değer Sil");
            //    Console.WriteLine("6 - Uygulama Çıkış");
            //    Console.Write("Seçiniz: ");
            //    kullaniciSecim = Console.ReadLine();

            //    switch (kullaniciSecim)
            //    {
            //        case "1":
            //            Console.Write("Lütfen eklemek istediğiniz değeri giriniz : ");
            //            string kullaniciDeger = Console.ReadLine();
            //            degerListesi.Add(kullaniciDeger);
            //            Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
            //            System.Threading.Thread.Sleep(2000);
            //            break;
            //        case "2":
            //            for (int i = 0; i < degerListesi.Count; i++)
            //            {
            //                Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
            //            }
            //            Console.WriteLine("Devam etmek için bir tuşa basınız.");
            //            Console.ReadLine();
            //            break;
            //        case "3":
            //            Console.WriteLine("Aramak istediğiniz değeri giriniz");
            //            string kullaniciAramaDeger = Console.ReadLine();
            //            bool kontrol = degerListesi.Contains(kullaniciAramaDeger);
            //            if (kontrol)
            //            {
            //                int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDeger);
            //                string bulunanDeger = degerListesi[bulunanIndex].ToString();
            //                Console.WriteLine("Değeriniz Bulundu : index sırası :{0} - Değer : {1}", bulunanIndex, bulunanDeger);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Aradığınız kriterlerde bir deger bulunamadı");
            //                // Eğer aradığı kriterde değer bulamadı ise kullanıcıya bu değeri listeye ekleyelim mi olarak sorun eger kullanıcı E derse listeye ekleyin. 
            //            }
            //            System.Threading.Thread.Sleep(2000);
            //            break;
            //        case "4":

            //            Console.WriteLine("Güncellemek istediğiniz değeri giriniz : ");
            //            string kullaniciDuzenlenecekDeger = Console.ReadLine();

            //            Console.WriteLine("{0} değerini hangi değer ile güncellemek istiyorsunuz", kullaniciDuzenlenecekDeger);
            //            string kullaniciYeniDeger = Console.ReadLine();

            //            if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
            //            {
            //                int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
            //                degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
            //                Console.WriteLine("Değeriniz güncellendi");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Aradığınız değer liste içerisinde bulunamadı");
            //            }

            //            System.Threading.Thread.Sleep(2000);

            //            break;
            //        case "5":
            //            Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz (E/H)");
            //            string kullaniciSilCevap = Console.ReadLine();

            //            if (kullaniciSilCevap.ToUpper() == "E")
            //            {
            //                degerListesi.Clear();
            //                Console.WriteLine("Tüm değerler silindi");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Liste içerisinde silmek istediğiniz değeri giriniz");
            //                string kullaniciSilDeger = Console.ReadLine();
            //                if (degerListesi.Contains(kullaniciSilDeger))
            //                {
            //                    degerListesi.Remove(kullaniciSilDeger);
            //                    Console.WriteLine("Değeriniz Silindi");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Silmek istediğiniz değer liste içerisinde mevcut değil.");
            //                }
            //            }

            //            break;
            //        default:
            //            break;
            //    }
            //} while (kullaniciSecim != "6");

            #endregion

            #endregion

            #region HashTable

            //Hashtable H1 = new Hashtable();

            #region Yeni Değer ekleme

            //H1.Add("Car", "Araba");
            //H1.Add("House", "Ev");

            //H1.Add("Cars", "Araba");
            //// H1.Add("Cars", "Arabalar"); Key değeri benzersiz olmak zorundadır.

            #endregion

            #region Yardımcı metotlar 

            //bool Kontrol1 = H1.Contains("House");
            //bool Kontrol2 = H1.Contains("Door");

            //bool Kontrol3 = H1.ContainsKey("House");
            //bool Kontrol4 = H1.ContainsValue("Araba");

            //H1["House"] = "Villa";

            //H1.Remove("Cars");
            //int koleksiyonIcindekiToplamDeger = H1.Count;
            //H1.Clear(); // koleksiyon içerisindeki tüm datayı temizleriz.

            #endregion

            #region HashTable Ödev

            //// Hashtable içerisine ENG  - TR olarak data eklemeniz. 
            ///*
            // * Yeni kayıt eklemek istiyormusunuz E/H
            // * E : Yeni kayıt ekleme işlemi devam etsin, 
            // * H : Tüm listeyi yazdırın. 
            // * 
            // * Var olan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden ... şeklinde sistemimizde bulunmaktadır. 
            // * 
            // */

            //Hashtable sozlukVeriTabani = new Hashtable();

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız");
            //    Console.Write("EN :");
            //    string eng = Console.ReadLine();

            //    bool kontrol = sozlukVeriTabani.ContainsKey(eng);
            //    if (kontrol)
            //    {
            //        Console.WriteLine("Eklemek istediğiniz değer {0} sözlük içerisinde bulunmaktadır. {1} değerin türkçe karşılığıdır.", eng, sozlukVeriTabani[eng].ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} ingilizce değerin türkçe karşılığını yazınız", eng);
            //        string tr = Console.ReadLine();
            //        sozlukVeriTabani.Add(eng, tr);
            //        Console.WriteLine("Değer ekleme işlemi başarılı");
            //    }

            //    Console.WriteLine("Yeni değer eklemek istiyor musunuz ? ( E/H ) ");
            //}
            //while (Console.ReadLine().ToUpper() != "H");

            //// 1 : yöntem :
            //foreach (var item in sozlukVeriTabani.Keys)
            //{
            //    Console.WriteLine("ENG : {0} = TR : {1}", item, sozlukVeriTabani[item]);
            //}

            //// 2.Yöntem 
            //foreach (DictionaryEntry item in sozlukVeriTabani)
            //{
            //    // Console.WriteLine(item.GetType().Name);
            //    Console.WriteLine("ENG : {0} = TR : {1}", item.Key, item.Value);
            //}

            #endregion

            #endregion

            #region SortedList

            //SortedList SortedL = new SortedList();

            //SortedL.Add(100, "Yüz");
            //SortedL.Add(90, "Doksan");
            //SortedL.Add(1, "Bir");
            //SortedL.Add(9000, "Dokuzbin");
            //// SortedL.Add("A", "B");

            #endregion

            #region Stack

            //Stack S1 = new Stack();

            //S1.Push("Bir");
            //S1.Push("İki");
            //S1.Push("Üç");
            //S1.Push("Dört");

            //object O1 = S1.Pop();
            //object O2 = S1.Peek();

            #endregion

            #region Queue

            //Queue Q1 = new Queue();
            //Q1.Enqueue("Bir");
            //Q1.Enqueue("İki");
            //Q1.Enqueue("Üç");
            //Q1.Enqueue("Dört");

            //object O1 = Q1.Peek();
            //object O2 = Q1.Dequeue();

            #endregion
        }
    }
}
