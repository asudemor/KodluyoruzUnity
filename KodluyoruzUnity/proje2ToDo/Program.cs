using System;
using System.Collections.Generic;

namespace proje2ToDo
{

    enum Buyukluk{
        XS,
        S,
        M,
        L,
        XL
    }

    enum Surec
    {
        TODO,
        INPROGRESS,
        DONE
    }

    class Kart
    {
        public int kartID;
        public string baslik;
        public string icerik;
        public int atananKisiID;
        public Buyukluk buyukluk;

        public Kart(int kartID,string baslik, string icerik, int atananKisiID, Buyukluk buyukluk)
        {
            this.kartID = kartID;
            this.baslik = baslik;
            this.icerik = icerik;
            this.atananKisiID = atananKisiID;
            this.buyukluk = buyukluk;
        }
    }

    class Tahta
    {
        
        List<Kart> karts = new List<Kart>();
        List<Surec> surecs = new List<Surec>();

        public Tahta(List<Kart> karts)
        {
            this.karts = karts;
            surecleriBaslat();
        }

        private void surecleriBaslat()
        {
            for (int i = 0; i < karts.Count; i++)
            {
                surecs.Add((Surec)(i%3));
            }
        }

        public bool kartIDKontrol(int kartId,out int index)
        {
            for (int i = 0; i < karts.Count; i++)
            {
                if (kartId == karts[i].kartID)
                {
                    index = i;
                    kartGoruntule(karts[i],surecs[i]);
                    return true;
                }
            }
            index = -1;
            return false;
        }

        public bool idGorevKontrol(int id)
        {
            for (int i = 0; i < karts.Count; i++)
            {
                if (id == karts[i].atananKisiID)
                {
                    return true;
                }
            }
            return false;
        }

        public void kartGuncelle(int index,Surec yeniSurec)
        {
            surecs[index] = yeniSurec;
        }

        public void kartEkle(Kart kart)
        {
            karts.Add(kart);
            surecs.Add(Surec.TODO);
        }

        public bool kartVarmi(string baslik,out int index)
        {
            for (int i = 0; i < karts.Count; i++)
            {
                if (baslik == karts[i].baslik)
                {
                    index = i;
                    return true;
                }
            }

            index = -1;
            return false;
        }

        public void kartSil(int index)
        {
            karts.RemoveAt(index);
            surecs.RemoveAt(index);
        }

        public void listele()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("******************");
            for (int i = 0; i < surecs.Count; i++)
            {
                if (surecs[i] == Surec.TODO)
                {
                    kartGoruntule(karts[i]);
                }
            }

            Console.WriteLine("In Progress Line");
            Console.WriteLine("******************");
            for (int i = 0; i < surecs.Count; i++)
            {
                if (surecs[i] == Surec.INPROGRESS)
                {
                    kartGoruntule(karts[i]);
                }
            }

            Console.WriteLine("DONE Line");
            Console.WriteLine("******************");
            for (int i = 0; i < surecs.Count; i++)
            {
                if (surecs[i] == Surec.DONE)
                {
                    kartGoruntule(karts[i]);
                }
            }
        }

        public void kartGoruntule(Kart kart)
        {

            Console.WriteLine("-->ID:" + kart.kartID);
            Console.WriteLine("   Başlık     :" + kart.baslik);
            Console.WriteLine("   İçerik     :" + kart.icerik);
            Console.WriteLine("   Atanan Kişi:" + kart.atananKisiID);
            Console.WriteLine("   Büyüklük   :" + kart.buyukluk);
            Console.WriteLine();
        }
        public void kartGoruntule(Kart kart,Surec surec)
        {

            Console.WriteLine("-->ID:" + kart.kartID);
            Console.WriteLine("   Başlık     :" + kart.baslik);
            Console.WriteLine("   İçerik     :" + kart.icerik);
            Console.WriteLine("   Atanan Kişi:" + kart.atananKisiID);
            Console.WriteLine("   Büyüklük   :" + kart.buyukluk);
            Console.WriteLine("   Line   :" + surec);
            Console.WriteLine();
        }
    }

    class Kisi
    {
       public string adSoyad;

        public Kisi(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }
    }

    class Takim
    {
        public int takimID;
        public List<Kisi> kisiler = new List<Kisi>();

        public Takim(int takimID, List<Kisi> kisiler)
        {
            this.takimID = takimID;
            this.kisiler = kisiler;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Takımları oluşturdum
            List<Kisi> takim1_Uyeleri = new List<Kisi>();
            takim1_Uyeleri.Add(new Kisi("Selim Gezer"));
            takim1_Uyeleri.Add(new Kisi("Ayşe Yorulmaz"));
            takim1_Uyeleri.Add(new Kisi("Leyla Maggie"));
            Takim takim1 = new Takim(1000, takim1_Uyeleri);

            List<Kisi> takim2_Uyeleri = new List<Kisi>();
            takim2_Uyeleri.Add(new Kisi("Ferhat Kaçar"));
            takim2_Uyeleri.Add(new Kisi("Zeynep Tolun"));
            Takim takim2 = new Takim(2000, takim2_Uyeleri);

            List<Kisi> takim3_Uyeleri = new List<Kisi>();
            takim3_Uyeleri.Add(new Kisi("Ali Gün"));
            takim3_Uyeleri.Add(new Kisi("Çetin Çetinkaya"));
            Takim takim3 = new Takim(3000, takim3_Uyeleri);
            //////////
            
            //Kartları ekledim kartID,baslik,içerik,takimID,buyukluk
            List<Kart> karts = new List<Kart>();
            karts.Add(new Kart(0,"Yazılım","Yenileme methodu değiştirilecek.",1000,Buyukluk.M));
            karts.Add(new Kart(1,"Yazılım","Web sitesindeki search bar yenilenecek.",2000,Buyukluk.L));
            karts.Add(new Kart(2,"Tasarım","Yeni search bar tasarımı yapılacak.",3000,Buyukluk.S));
            karts.Add(new Kart(3,"Yazılım","Web servise yeni method eklenecektir.",4000,Buyukluk.S));

            int sonID = 3;//idleri manuel girdiğimden son id noya göre yeni kayıtların id sini belirliyorum 287.satırda

            Console.SetWindowSize(100, 40);//console büyüklüğü

            Tahta tahta = new Tahta(karts);
           
            while (true)
            {
                Console.WriteLine("Yapamak istediğiniz işlemi seçiniz.");
                Console.WriteLine("(1) Board Listele");
                Console.WriteLine("(2) Kart Ekle");
                Console.WriteLine("(3) Kart Sil");
                Console.WriteLine("(4) Kart Taşı");
                Console.WriteLine("(5) İşlem Sonlandır");
                
                try
                {
                    Console.Write("\nİşlem Seçiniz:");
                    int islemNo = Convert.ToInt16(Console.ReadLine());

                    if (islemNo == 5)
                    {
                        break;
                    }else if(islemNo<0 || islemNo > 5)
                    {
                        Console.WriteLine("Lütfen 1-5 arası bir işlem seçiniz.\n");
                    }

                    Console.Clear();

                    switch (islemNo)
                    {
                        case 1:
                            {
                                tahta.listele();
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Baslik Giriniz:");
                                string baslik = Console.ReadLine();
                                Console.Write("İçerik Giriniz:");
                                string icerik = Console.ReadLine();
                                Console.Write("Büyüklük Seçiniz XS(1),S(2),M(3),L(4),XL(5):");
                                int buyukluk= Convert.ToInt16(Console.ReadLine())-1;

                                while (true)
                                {
                                    Console.Write("Takım Id Seçiniz (1000'in katları şeklinde):");
                                    int takimID = Convert.ToInt16(Console.ReadLine());

                                    if (tahta.idGorevKontrol(takimID))
                                    {
                                        Console.WriteLine("Bu takım şuan için uygun değil.\n");
                                        continue;
                                    }
                                    else
                                    {
                                        Kart kart = new Kart(++sonID,baslik,icerik,takimID,(Buyukluk)buyukluk);
                                        Console.WriteLine("Kart ekleme işlemi başarı ile gerçekleştirildi.\n");
                                        tahta.kartEkle(kart);
                                        break;
                                    }
                                }  
                                break;
                            }
                        case 3:
                            {
                                while (true)
                                {
                                    Console.Write("Silinecek Kartın Başlığını Giriniz:");
                                    string baslik = Console.ReadLine();

                                    int index = -1;
                            
                                    while(!tahta.kartVarmi(baslik, out index))
                                    {

                                        Console.WriteLine("Aradığınız kriterlere uygun kart tahtada bulunamadı.Lütfen bir seçim yapınız.");
                                        Console.WriteLine(" *Silmeyi sonlandırmak için:(1)");
                                        Console.WriteLine(" *Yeniden denemek için:(2)");
                                        Console.Write("Seçiminiz:");
                                        int yeni = Convert.ToInt16(Console.ReadLine());

                                        if (yeni == 1)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write("Silinecek Kartın Başlığını Giriniz:");
                                            baslik = Console.ReadLine();
                                        }
                                    }

                                    while (tahta.kartVarmi(baslik, out index))
                                    {
                                        tahta.kartSil(index);
                                        Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
                                    }

                                    break;
                                }
                                break;
                            }
                        case 4:
                            {
                                while (true)
                                {
                                    Console.Write("Taşınacak kartın id'sini giriniz.");
                                    int id=Convert.ToInt16(Console.ReadLine());

                                    int index = -1;

                                    if (tahta.kartIDKontrol(id,out index))
                                    {
                                       
                                        Console.WriteLine("Taşımak istediğiniz Line'ı seçiniz.");
                                        Console.WriteLine(" *TODO (1)");
                                        Console.WriteLine(" *IN PROGRESS (2)");
                                        Console.WriteLine(" *DONE (3)\n");
                                        while (true)
                                        {
                                            Console.Write("Seçiminiz:");
                                            int secim= Convert.ToInt16(Console.ReadLine())-1;
                                            if(secim>=0 && secim <= 2)
                                            {
                                                tahta.kartGuncelle(index, (Surec)secim);
                                                Console.WriteLine("Line taşıma işlemi başarı ile gerçekleştirildi.\n");
                                                Console.Clear();
                                                tahta.listele();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lütfen doğru bir line değeri giriniz.\n");
                                            }
                                        }

                                        break;
                                    }
                                    else
                                    {
                                     Console.WriteLine("Lütfen geçerli bir id değeri giriniz.\n");
                                    }                    
                                }                    
                                break;
                            }
                    }
                }catch(FormatException e)
                {
                    Console.WriteLine("Hatalı Giriş Yapıldı.\n");
                }

                Console.WriteLine("\nYeni işlem için herhangi bir tuşa basınız!");
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}