using System;
using System.Collections.Generic;

namespace genericKoleksiyonlarVeListe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<T> class
            //t -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<String>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            
            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            
            //foreach ve list.foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            
            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            sayiListesi.RemoveAt(1);
            
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            
            //liste içerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu.");

            //eleman ile indexe erişim
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //diziyi listeye çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizleriz
            hayvanListesi.Clear();

            //liste içerisinde nesne tutmak
            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Asude";
            kullanici1.Soyisim = "Mor";
            kullanici1.Yas = 20;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Beyza";
            kullanici2.Soyisim = "Mor";
            kullanici2.Yas = 22;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
                Isim="Furkan",
                Soyisim="Mor",
                Yas = 26
            });

            foreach (var kullanici in kullanicilarListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yas: "+kullanici.Yas);
            }
            hayvanListesi.Clear();
        }
    }


    public class Kullanicilar{

        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{get => isim; set => isim = value;}
        public string Soyisim{get => soyisim; set => soyisim = value;}
        public int Yas{get => yas; set => yas = value;}
    }
}