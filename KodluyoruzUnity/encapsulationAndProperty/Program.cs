using System;

namespace encapsulationAndProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim="Asude";
            ogrenci.Soyisim="MOR";
            ogrenci.OgrenciNo = 1232;
            ogrenci.Sinif = 4;
            ogrenci.OgrenciBilgileriniGetir();
            
            ogrenci.SinifiAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.SinifiDusur();
            ogrenci1.SinifiDusur();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set 
            {
                if(value <1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else{sinif = value;}
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("------- Öğrenci Bilgileri -------");
            Console.WriteLine("Öğrenci Adı: {0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı: {0}",this.Soyisim);
            Console.WriteLine("Öğrenci No: {0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı: {0}",this.Sinif);
        }

        public void SinifiAtlat(){ this.Sinif++;}
        public void SinifiDusur(){ this.Sinif--;}
    }
}
