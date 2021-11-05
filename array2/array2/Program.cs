using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("******** Sirasiz dizi *********");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("******** Sirali dizi *********");

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            //Clear
            Console.WriteLine("******** Array Clear *********");
            Array.Clear(sayiDizisi, 2, 2);

            // sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemani 0'lar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("******** Array Reverse *********");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("******** Array IndexOf *********");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            Console.WriteLine("******** Array Resize *********");
            Array.Resize<int>(ref sayiDizisi, 10);
            sayiDizisi[8] = 99;
            sayiDizisi[9] = 123;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
