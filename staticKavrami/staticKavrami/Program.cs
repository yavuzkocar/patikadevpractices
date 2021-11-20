using System;

namespace staticKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi = {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Heres", "Yemen", "Sultan");
            Console.WriteLine("Calisan Sayisi = {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Misa", "Makeb", "Sultan");
            Calisan calisan3 = new Calisan("Hakan", "Razih", "Lord");
            Console.WriteLine("Calisan Sayisi = {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama islemi = {0}" ,Islemler.Topla(123, 1));
            Console.WriteLine("Cikarma islemi = {0}" ,Islemler.Cikar(123, 1));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi{get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim,string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}

