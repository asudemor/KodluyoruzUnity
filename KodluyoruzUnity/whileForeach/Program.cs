using System;

namespace whileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak consoldan girilen sayıya kadar ortalama hesaplar.
            Console.WriteLine("sayı gir");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            //tüm harfleri ekrana yazdırır.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character ++;
            }

            //foreach
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach(var araba in arabalar)
                Console.WriteLine(araba);
        }
    }
}
