using System;

namespace kurucuFonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Asude","Mor",123,"yazılım");
            calisan1.CalisanBilgileri();
            
            Calisan calisan2 = new Calisan();
            calisan2.ad = "Beyza";
            calisan2.soyad = "Mor";
            calisan2.no = 12345;
            calisan2.departman = "yazılım";
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Furkan","Mor");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string ad="Bilgi Eksik";
        public string soyad="Bilgi Eksik";
        public int no=0;
        public string departman="Bilgi Eksik";

        public Calisan(string ad, string soyad, int no, string departman){
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }
        public Calisan(string ad, string soyad){
            this.ad = ad;
            this.soyad = soyad;        
        
        }

        public Calisan(){}        


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", ad);
            Console.WriteLine("Çalışan Soyadı:{0}", soyad);
            Console.WriteLine("Çalışan No:{0}", no);
            Console.WriteLine("Çalışan Departmanı:{0}", departman);
        }
    }
}