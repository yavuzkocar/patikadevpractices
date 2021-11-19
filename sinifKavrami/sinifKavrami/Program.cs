using System;

namespace sinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan("Ahmet", "Boza", 1231, "IT");
            //calisan1.Ad = "Ahmet";
            //calisan1.Soyad = "Boza";
            //calisan1.No = 1231;
            //calisan1.Departman = "IT";

            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Yasir";
            calisan2.Soyad = "Yildiz";
            calisan2.No = 3453;
            calisan2.Departman = "Software Engineer";


            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan();
            calisan3.CalisanBilgileri();



            Calisan calisan4 = new Calisan("Ahmet", "Boza");
            calisan4.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan() { }

        public Calisan(string ad,string soyad, int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            no = No;
            departman = Departman;
        }

        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }




        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi:{0}", Ad);
            Console.WriteLine("Calisan Soyadi:{0}", Soyad);
            Console.WriteLine("Calisan No:{0}", No);
            Console.WriteLine("Calisan Departmani:{0}", Departman);


        }
    }
}
