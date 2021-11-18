using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic

            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(0, "Beytullah Kalay");
            kullanicilar.Add(23, "Metin Senturk");
            kullanicilar.Add(51, "Kutup Yazar");
            kullanicilar.Add(11, "Sıtkı Sarraf");


            //Dizinin elemanlarina erisim
            Console.WriteLine("********** Elemanlara Erisim *********");
            Console.WriteLine(kullanicilar[51]);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);


            //Count
            Console.WriteLine();
            Console.WriteLine("********** Count *********");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine();
            Console.WriteLine("********** Contains *********");
            Console.WriteLine(kullanicilar.ContainsKey(12)); // 12 key'ine sahip eleman var mi?
            Console.WriteLine(kullanicilar.ContainsKey(0)); // 12 key'ine sahip eleman var mi?
            Console.WriteLine(kullanicilar.ContainsValue("Beytullah KALAY")); // Beytullah KALAY adinda bir eleman var mi?
            Console.WriteLine(kullanicilar.ContainsValue("Ahmet Metin")); // Ahmet Metin adinda bir eleman var mi?

            
            //Remove
            Console.WriteLine();
            Console.WriteLine("********** Remove *********");
            foreach (var item in kullanicilar)
                Console.WriteLine(item);
            
            kullanicilar.Remove(11);
            Console.WriteLine();

            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Keys
            Console.WriteLine();
            Console.WriteLine("********** Keys *********");
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Key);

            //Values
            Console.WriteLine();
            Console.WriteLine("********** Values *********");
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);


            //Console.WriteLine();

            //Dictionary<string, string> users = new Dictionary<string, string>();

            //users.Add("deneme", "A");

            //Console.WriteLine(users["deneme"]);

        }
    }
}
