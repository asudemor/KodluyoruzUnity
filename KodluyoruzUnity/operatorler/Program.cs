using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //atama ve işlemeli atama
            int x = 3;
            int y = 4;
            y += 2;
            x *= 2;

            //mantıksal operatorler
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            //ilişkisel operatorler
            
            int a = 3;
            int b = 4;
            bool sonuc = a>b;

            //aritmetik operatorler

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            int sonuc2 = 20%3; //mod alir
            

        }
    }
}
