using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim
            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngülerde dizi kullanımı
            //klavyeden girilen n tane sayının ortaamasını hesaplayan program

            Console.WriteLine("eleman sayisini gir:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for(int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("{0}. sayıyı girin:",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;

            Console.WriteLine("ortalama: "+ toplam/diziUzunlugu);
        }
    }
}
