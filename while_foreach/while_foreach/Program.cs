using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while ile ortalama yazdir
            Console.WriteLine("Bir sayi gir");

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam / sayi);

            // 'a' dan 'z' ye tum harfleri yazdir.

            char character = 'a';
            while (character <'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("**** Foreach ******");
            string[] arabalar = { "araba1", "araba2", "araba3", "araba4" };
            foreach (string araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
