using System;

namespace sinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Asude";
            calisan1.soyad = "Mor";
            calisan1.no = 123;
            calisan1.departman = "yazılım";
            
            calisan1.CalisanBilgileri();
            
            Calisan calisan2 = new Calisan();
            calisan2.ad = "Beyza";
            calisan2.soyad = "Mor";
            calisan2.no = 12345;
            calisan2.departman = "yazılım";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", ad);
            Console.WriteLine("Çalışan Soyadı:{0}", soyad);
            Console.WriteLine("Çalışan No:{0}", no);
            Console.WriteLine("Çalışan Departmanı:{0}", departman);
        }
    }
}
