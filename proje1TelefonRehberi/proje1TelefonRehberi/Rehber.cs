using System;
using System.Collections.Generic;
using System.Text;

namespace proje1TelefonRehberi
{
    class Rehber
    {
        List<Kisi> kisiler = new List<Kisi>();

        public Rehber()
        {
            kisiler.Add(new Kisi("Ahmet", "Uysal", 1111111));
            kisiler.Add(new Kisi("Metin", "Goren", 22222));
            kisiler.Add(new Kisi("Feyza", "Demir", 333));
            kisiler.Add(new Kisi("Ali", "Tukan", 444));
            kisiler.Add(new Kisi("Recep", "Sari", 5555));
        }

        public void YeniKisiEkle()
        {
            string isim, soyisim;
            int no;

            Console.Write("Lutfen isim giriniz :   ");
            isim = Console.ReadLine();

            Console.Write("Lutfen soyisim giriniz :   ");
            soyisim = Console.ReadLine();

            Console.Write("Lutfen telefon numarasi giriniz :   ");
            no = int.Parse(Console.ReadLine());

            kisiler.Add(new Kisi(isim, soyisim, no));
        }

        public void KisiSil()
        {
            Console.WriteLine("Lutfen silmek istediginiz kisinin adini ya da soyadini yazin :   ");
            string aranan = Console.ReadLine();

            foreach (var kisi in kisiler)
            {
                if (kisi.Isim == aranan || kisi.Soyisim == aranan)
                {
                    Console.Write("{0} isimli kisi rehberden silinmek uzere, onayliyor musunuz? (E/H) : ", aranan);
                    string secim = Console.ReadLine();
                    if (secim == "e" || secim == "E")
                    {
                        kisiler.Remove(kisi);
                        Console.WriteLine("Kisi silindi.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Menuye donuluyor");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }

        public void NumaraGuncelle()
        {
            Console.WriteLine("Lutfen guncellemek istediginiz kisinin adini ya da soyadini yazin :   ");
            string aranan = Console.ReadLine();
            int secim = 1;
            bool bulundu = false;
            foreach (var kisi in kisiler)
            {

                if (kisi.Isim == aranan || kisi.Soyisim == aranan)
                {
                    Console.WriteLine("Lutfen yeni numarayi giriniz :   ");
                    int yeniNo = int.Parse(Console.ReadLine());
                    kisi.TelNo = yeniNo;
                    Console.WriteLine("Numara guncellendi");
                    Console.ReadLine();
                    bulundu = true;
                    break;
                }
            }

            if (!bulundu)
            {
                Console.WriteLine("Aradiginiz kritere uygun kisi bulunamadi. Lutfen bir secim yapiniz : ");
                Console.WriteLine("*Yeniden denemek icin  :(1)");
                Console.WriteLine("*Güncellemeyi sonlandırmak için  herhangi bir tusa basiniz:");
                secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                    NumaraGuncelle();
            }

        }

        public void RehberiListele()
        {
            kisiler.Sort(delegate(Kisi k1,Kisi k2) { return k1.Isim.CompareTo(k2.Isim); }); // kisi listesini isime gore siraliyor.
            //kisiler.Reverse();



            Console.WriteLine("Listeleme formati (gecersiz bir giris yapmaniz durumunda A-Z formati kullanilacaktir) : ");
            Console.WriteLine("A-Z -> (1)");
            Console.WriteLine("Z-A -> (2)");
            int giris = int.Parse(Console.ReadLine());

            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*********************************");

            if (giris == 2)
                kisiler.Reverse();

            foreach (var kisi in kisiler)
            {
                Console.WriteLine("isim: {0}", kisi.Isim);
                Console.WriteLine("Soyisim: {0}", kisi.Soyisim);
                Console.WriteLine("Telefon Numarasi: {0}", kisi.TelNo);
                Console.WriteLine("-");
            }
            Console.ReadLine();
        }

        public void RehberdeAra()
        {
            Console.WriteLine("Arama yapmak istedigini tipi seciniz.");
            Console.WriteLine("*************************************");
            Console.WriteLine();

            Console.WriteLine("Isim veya soyisime gore arama yapmak icin:   (1)");
            Console.WriteLine("Telefon numarasina gore arama yapmak icin:   (2)");

            int secim = int.Parse(Console.ReadLine());


            if (secim == 1)
            {
                Console.WriteLine("Kisinin adini veya soyadini girin : ");
                string isimVeyaSoyisim = Console.ReadLine();
                bool bulundu = false;

                foreach (var kisi in kisiler)
                {
                    if (kisi.Isim == isimVeyaSoyisim || kisi.Soyisim == isimVeyaSoyisim)
                    {
                        Console.WriteLine("Isim :   {0}", kisi.Isim);
                        Console.WriteLine("Soyisim :   {0}", kisi.Soyisim);
                        Console.WriteLine("Telefon Numarasi :   {0}", kisi.TelNo);
                        Console.WriteLine("-");
                        bulundu = true;
                    }
                }

                if (!bulundu)
                {
                    Console.WriteLine("Aradiginiz kisi verisi bulunamadi.");
                    Console.WriteLine("Islemleri yeniden denemek icin (1)");
                    Console.WriteLine("Menuye donmek icin herhangi bir tusa basiniz");

                    int tercih = int.Parse(Console.ReadLine());

                    if (tercih == 1)
                        RehberdeAra();
                }
            }
            else if (secim == 2)
            {
                Console.WriteLine("Kisinin telefon numarasini girin : ");
                int num = int.Parse(Console.ReadLine());

                foreach (var kisi in kisiler)
                {
                    if (kisi.TelNo == num)
                    {
                        Console.WriteLine("Isim :   {0}", kisi.Isim);
                        Console.WriteLine("Soyisim :   {0}", kisi.Soyisim);
                        Console.WriteLine("Telefon Numarasi :   {0}", kisi.TelNo);
                        break;
                    }
                }
                Console.WriteLine("Kisi bulunamadi");

            }
            else
                Console.WriteLine("Boyle bir giris secenegi yok. Menuye donuyorsunuz.");

        }
    }
}
