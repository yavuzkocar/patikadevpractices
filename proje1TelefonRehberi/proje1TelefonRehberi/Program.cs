using System;

namespace proje1TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber = new Rehber();
            MenuYaz();
            int input = Secim();

            while (true)
            {
                switch (input)
                {
                    case 1: // Yeni Kisi Ekle
                        rehber.YeniKisiEkle();
                        MenuYaz();
                        input = Secim();
                        break;
                    case 2: // Numara Sil
                        rehber.KisiSil();
                        MenuYaz();
                        input = Secim();
                        break;
                    case 3: // Telefon Num Guncelle
                        rehber.NumaraGuncelle();
                        MenuYaz();
                        input = Secim();
                        break;
                    case 4: // Rehberi Listele
                        rehber.RehberiListele();
                        MenuYaz();
                        input = Secim();
                        break;
                    case 5: // Rehberde Arama
                        rehber.RehberdeAra();
                        MenuYaz();
                        input = Secim();
                        break;
                    case 6: // cikis
                        Console.WriteLine("6");
                        Console.WriteLine("Cikis Yapiliyor...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Boyle bir secim yok! Cikis yapiliyor");
                        Environment.Exit(0);
                        break;
                }
            }

        }

        private static void MenuYaz()
        {
            Console.WriteLine();
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayi Silmek");
            Console.WriteLine("(3) Varolan Numarayi Guncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Cikis");
        }

        private static int Secim()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
