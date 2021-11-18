
//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System;
using System.Collections.Generic;

namespace Kolekosiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            string sentece = Console.ReadLine();
            string t = "";

            for (int i = 0; i < sentece.Length; i++)
            {
                if (vowels.Contains(sentece[i]))
                {
                    t += sentece[i];
                }
            }

            char[] characters = t.ToCharArray();

            Array.Sort(characters);

            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i]);
            }


            
        }
    }
}
