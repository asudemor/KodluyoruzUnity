﻿using System;

namespace staticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Asude","Mor","Yazılım");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan2 = new Calisan("Beyza","Mor","Diş Hekimi");
            Calisan calisan3 = new Calisan("Furkan","Mor","Mimar");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Topla(100,50));
        }
    }
    class Calisan
    {

        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;}
        private string isim;
        private string soyisim;
        private string departman;

        static Calisan(){
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
