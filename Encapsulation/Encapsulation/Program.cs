using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Beytullah";
            ogrenci1.Soyisim = "KALAY";
            ogrenci1.No = 12314;
            ogrenci1.Sinif = 4;

            ogrenci1.OgrenciBilgisiGetir();
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgisiGetir();

            Ogrenci ogrenci2 = new Ogrenci("Ejder", "KIZIL", 246, 1);
            ogrenci2.OgrenciBilgisiGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgisiGetir();


        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if(value <= 1)
                {
                    Console.WriteLine("Sinif en az 1 olabilir.");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci() { }
        public Ogrenci(string isim,string soyisim,int no,int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            No = no;
            Sinif = sinif;
        }


        public void OgrenciBilgisiGetir()
        {
            Console.WriteLine("********* Ogrenci Bilgisi Getir *********");
            Console.WriteLine("Ogrenci Adi:     {0}", this.Isim);
            Console.WriteLine("Ogrenci Soyad:     {0}", this.Soyisim);
            Console.WriteLine("Ogrenci No:     {0}", this.No);
            Console.WriteLine("Ogrenci Sinif:     {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }

        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}
