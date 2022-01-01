using System;
using System.Collections;

namespace soru2
{

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            //int[] dizi = new int[20];

            for(int i=0;i<20;i++){
                System.Console.WriteLine("Lütfen " + (i+1) +". sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                dizi.Add(sayi);

            }
            dizi.Sort();
            
            ArrayList enKucuk=new ArrayList();
            ArrayList enBuyuk=new ArrayList();
            int sayac=1;
            foreach (var item in dizi)
            {
                if(sayac==1 || sayac==2 || sayac==3){
                    enKucuk.Add(item);
                }

                else if(sayac==18|| sayac==19 || sayac==20){
                    enBuyuk.Add(item);
                }
                sayac++;

                
            }
            
            int toplam1=0,toplam2=0 ;
            System.Console.WriteLine("En Büyükler: " );
            foreach (var buyuk in enBuyuk)
            {
                System.Console.WriteLine(buyuk);
                toplam1=toplam1+Convert.ToInt32(buyuk);
            }
            System.Console.WriteLine("En Büyük Sayıların Ortalaması: " + (toplam1/3));

            System.Console.WriteLine("En Küçükler: ");
            foreach (var kucuk in enKucuk)
            {
                System.Console.WriteLine(kucuk);
                toplam2=toplam2+Convert.ToInt32(kucuk);
            }
            System.Console.WriteLine("En Küçük Sayıların Ortalaması: " + (toplam2/3));
        }
    }
}