/*

1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

*/

using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.soru
            Console.WriteLine("n degeri girin:");
            int n = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı girin:",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
                
                if(sayiDizisi[i]%2 == 0)
                    Console.WriteLine(sayiDizisi[i]);
            }
            */            
            /*
            //2.soru
            Console.WriteLine("n degeri girin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m degeri girin:");
            int m = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı girin:",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
                
                if(sayiDizisi[i]%m == 0 || sayiDizisi[i]==m)
                    Console.WriteLine(sayiDizisi[i]);
            }*/
            /*
            //3.soru
            Console.WriteLine("n degeri girin:");
            int n = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelimeyi girin:",i+1);
                kelimeler[i] = Console.ReadLine();
            }

            for (int j = 0; j < kelimeler.Length; j++)
            {
                Console.WriteLine(kelimeler[j]);                
            }*/
            //4.soru
            string cumle;
            Console.Write("Cumleyi Girin : ");
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime sayısı: "+kelimeler.Length);
            Console.WriteLine("Yukarıdaki ifade toplam {0} karakter içerir.", cumle.Length);
        }
    }
}
