using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            // tanimlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Kopek", "Kus", "Kokarca" };

            int[] dizi;
            dizi = new int[6];

            //deger atama

            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("Lutfen dizinin elelna sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lutfen {0}. sayisini giriniz : ", i + 1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama : " + toplam / diziUzunlugu);

        }
    }
}
