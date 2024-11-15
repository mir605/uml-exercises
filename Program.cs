using System.Security.Cryptography.X509Certificates;

namespace uml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departman departman = new Departman("agj", "Ankara");
            Calisan calisan = new Calisan("mert", "tekniker");

           
        }

    }

    //ORNEK-1.2
    class Kitap
    { 
    public string Baslik{get; set;}
    public string ISBN{get; set;}
   
      public Kitap(string baslik, string isbn) 
        {
            Baslik = baslik;
            ISBN = isbn;
        }


    }

    class Yazar
    {

        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle (Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }
    //**************************************

    //ORNEK-1.3
    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Departman Departman { get; set; }

        public Calisan(string ad, string pozisyon)
        {   Ad = ad;
            Pozisyon = pozisyon;
            

        }
        public void DepartmaAtama( Departman departman)
        {
            Departman = departman;
        }

        
    }

    class Departman
    {
        public string Ad { get; set; }
        public string Lokasyon { get; set; }


        public Departman(string ad, string lokasyon)
        {
            Ad = ad;
            Lokasyon = lokasyon;
        }

    }
    //**************************************

    //ORNEK-1.4
     
    class Urun
    {
        public string Ad { get; set; }
        private int fiyat;
        public Sipariss Siparis { get; set; }



        public int Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public Urun (string ad, int fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
           
       public void UrunBilgisi(Sipariss siparis)
        {
            Siparis = siparis;
        }

      
    }


    class Sipariss
    {
        public DateTime Tarih { get; set; }
        public decimal Toplam { get; set; }


        public Sipariss(DateTime tarih, decimal toplam)
        {
            Tarih = tarih;
            Toplam = toplam;
        }
    }

    //ORNEK-1.5******************************

    class Urunn
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public Siparis Siparis { get; set; }

        public Urunn( string ad, string telefon)
        {
            Ad = ad;
            Telefon = telefon;
        }
        public void UrunBilgisi(Siparis siparis)
        {
            Siparis = siparis;
        }
    }


    class Siparis
    {
    public DateTime Tarih { get; set; }
    public decimal Toplam { get; set; }

        public Siparis(DateTime tarih, decimal toplam)
        {
            Tarih = tarih;
            Toplam = toplam;
        }
    }

  //ORNEK-2.2********************************************



    class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; set; }

        public Doktor(string ad, string brans)
        {
            Ad = ad;
            Brans = brans;
            Hastalar = new List<Hasta>();
        }

        public void HastaEkle(Hasta hasta)
        {
            if (!Hastalar.Contains(hasta))
            {
                Hastalar.Add(hasta);
            }
        }


    }

    class Hasta
    {
        public string Ad { get; set; }
        public string TCno { get; set; }
        public Doktor Doktor { get; set; }

        public Hasta(string ad, string tcno)
        {
            Ad = ad;
            TCno = tcno;
         
        }


        public void DoktorAtama(Doktor doktor)
        {
            Doktor = doktor;
        }

    }


    //ORNEK-2.3************************************

    class Yazarr
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }


    }

    class Kitapp 
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
    }


    //ORNEK-2.4************************************
    class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar { get; set; }


        public Sirket(string ad, string konum)
        {
            Ad = ad;
            Konum = konum;
            Calisanlar = new List<Calisan>();
        }

        public void CocukEkle(Calisan calisan)
        {
            if (!Calisanlar.Contains(calisan))
            {
                Calisanlar.Add(calisan);
            }
        }
    }

    class Calisann
    {

        public string Baslik { get; set; }
        public string Pozisyon { get; set; }
        public Sirket Sirket { get; set; }

        public Calisann(string baslik,string pozisyon)
        {
            Baslik = baslik;
            Pozisyon = pozisyon;
           
           
        }
        public void SirketAtama(Sirket sirket)
        {
            Sirket = sirket;

        }
        
        
    }


    //ORNEK-2.5***********************************


    class Ebeveyn
    {

        public string Ad { get; set; }
        public int Yas{ get; set; }
        public List<Cocuk> Cocuklar { get; set; }


        public Ebeveyn(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
            Cocuklar = new List<Cocuk> ();
        }

        public void CocukEkle(Cocuk cocuk)
        {
            if (Cocuklar.Contains(cocuk))
            {
                Cocuklar.Add(cocuk);
            }
        }
    }

    class Cocuk
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; set; }

        public Cocuk(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;
        }
    }


    //ORNEK-3.2

    class Oda 
    {   
        
        public string Boyut { get; set; }
        public string Tip { get; set; }

        public Oda(string boyut, string tip)
        {
            Boyut = boyut;
            Tip = tip;
        }
        
    
    }
    class Ev
    {

        public string Ad { get; set; }
        public List<Oda> Odalar { get; set; }

        public Ev( string  ad)
        {
            Ad = ad;
            Odalar = new List<Oda>();
        }

        public void OdaEkle( Oda oda)
        {
            Odalar.Add(oda);
        
        }

    }



    //ORNEK-3.3****************************************



    class Sirkett
    {
        public string Ad { get; set; }
        public List<Calisaan> Calisanlar { get; set; }

        public Sirkett(string ad)
        {
            Ad = ad;
            Calisanlar = new List<Calisaan>();
        }

        public void CalisanEkle(Calisaan calisan)
        {
            if (Calisanlar.Contains(calisan))
            {
                Calisanlar.Add(calisan);
            }
        }
    }

    class Calisaan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }


        public Calisaan(string ad, string pozisyon)
      {
            Ad = ad;
            Pozisyon = pozisyon;

       }

        public void CalisanBilgisi()
        {
            Console.WriteLine($"çalışan adı: {Ad}, Pozisyonu: {Pozisyon}");
        }

    }

    //ORNEK-3.4******************************



    class Kutuphane
    {
        public string Ad { get; set; }
        public List<Kitappp> kitaplar { get; set; }

        public Kutuphane(string ad)
        {
            Ad = ad;
            kitaplar = new List<Kitappp>();
        }

        public void KitapEkle(Kitappp kitap)
        {
            if (kitaplar.Contains(kitap))
            {
                kitaplar.Add(kitap);
            }
        }
    }

    class Kitappp {

    public string Baslik { get; set; }
    public string Yazar { get; set; }

        public Kitappp(string baslik, string yazar)
        {
            Baslik= baslik;
            Yazar = yazar;
        }

        
    }


    //ORNEK-4.2
    class Bilgisayar
    {
        public string Model { get; set; }
        public Islemci Islemci { get; set; }
         
        public Bilgisayar(string model)
        {
            Model = model;
            
        }

        public void IslemciOlustur(Islemci islemci)
        {
            Islemci = islemci;
        }

    }
    
    class Islemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; }

        public Islemci(int cekirdekler, int frekans)
        {
            Cekirdekler = cekirdekler;
            Frekans = frekans;
        }

        public void IslemciBilgisi()
        {
            Console.WriteLine($"İşlemcinin çekirdek sayısı {Cekirdekler} frekansı: {Frekans}");
        }
    }

    //ORNEK_4.3**********************


    class Otomobil 
    {
        public string Marka { get; set; }
        public Motor Motor { get; set; }

        public Otomobil(string marka) 
        {
            Marka = marka;
        }


        public void MotorOlustur(Motor motor)
        {
            Motor = motor;
        }
    }



    class Motor 
    {

        private int Guc { get; set; }
        public string Tip { get; set; }

        public int guc
        {
            get { return guc; }
            set { guc = value; }
        }


        public Motor(int guc, string tip)
        {
            Guc = guc;
            Tip = tip;
        }

       public void MotorBilgisi(Motor motor)
        {
            Console.WriteLine($"motorun tipi{Tip} motorun gucu{Guc}");
        }
       
    }


    //ORNEK_4.4******************************************

    class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

        public Okul(string ad)
        {
            Ad = ad;
            Ogrenciler = new List<Ogrenci>();
        }

        public void OgrenciOlustur(Ogrenci ogrenci)
        {
            if (!Ogrenciler.Contains(ogrenci))
            {
                Ogrenciler.Add(ogrenci);
            }
        }
    }

    class Ogrenci
    {

        public string Ad { get; set; }
        private int Yas { get; set; }

        public int yas
        {
            get { return yas; }
            set { yas = value; }

        }

        public void OgrenciBilgisi(Ogrenci ogrenci)
        {
            Console.WriteLine($"Öğrencinin adı {Ad} Yaşı {yas}");
        }

    }
}
