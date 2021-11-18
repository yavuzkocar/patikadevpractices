using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeList = new ArrayList();
            ArrayList nonPrimeList = new ArrayList();
            Console.WriteLine("Sayilari giriniz");

            for (int i = 0; i < 20; i++)
            {
                string input = Console.ReadLine();
                int value;

                if (int.TryParse(input, out value) && value >= 0)
                {
                    if (value == 1 || value == 2)
                    {
                        primeList.Add(value);
                    }
                    else
                    {
                        bool isPrime = true;
                        for (int j = 2; j < (value / 2) + 1; j++)
                        {
                            if (value % j == 0)
                            {
                                isPrime = false;
                                nonPrimeList.Add(value);
                                break;
                            }
                        }
                        if (isPrime)
                            primeList.Add(value);
                    }
                }
                else
                {
                    Console.WriteLine("Sembol veya 0'dan kucuk sayi girdiniz. Program sonlandiriliyor.");
                    Environment.Exit(0);
                }
            }

            nonPrimeList.Sort();
            nonPrimeList.Reverse();
            primeList.Sort();
            primeList.Reverse();

            Console.WriteLine("******* Prime List *********");
            int sum1 = 0;
            foreach (var item in primeList)
            {
                sum1 += (int)item;
                Console.WriteLine(item);
            }

            Console.WriteLine("******* Prime List Count *********");
            Console.WriteLine(primeList.Count);
            Console.WriteLine("******* Prime List Average *********");
            Console.WriteLine(sum1 / primeList.Count);

            /////////////////////////////////////////////////////////////////

            Console.WriteLine("******* non-Prime List *********");
            int sum2 = 0;
            foreach (var item in nonPrimeList)
            {
                sum2 += (int)item;
                Console.WriteLine(item);
            }

            Console.WriteLine("******* non-Prime Count *********");
            Console.WriteLine(nonPrimeList.Count);
            Console.WriteLine("******* non-Prime List Average *********");
            Console.WriteLine(sum2 / primeList.Count);
        }
    }
}
