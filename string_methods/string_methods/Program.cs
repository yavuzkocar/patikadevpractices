using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 = "CSharp";

            //Lenght
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower (hepsi buyuk/kucuk)
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat    (degiskeni girilen metin ile birleştir.)
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));


            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));   // degisken.lenght < degisken2.lenght ise 1 dondurur
                                                                // degisken.lenght = degisken2.lenght ise 0 dondurur
                                                                // degisken.lenght > degisken2.lenght ise -1 dondurur 

            Console.WriteLine(string.Compare(degisken, degisken2, true)); //true = buyuk/kucuk harfe duyarli
            Console.WriteLine(string.Compare(degisken, degisken2, false)); //false = buyuk/kucuk harfe duyarli degil

            //Contains
            Console.WriteLine(degisken.Contains(degisken2)); // eger degisken'in icinde degisken2 var ise true dondurur yoksa false

            //EndWith StartWith
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); // degisken "Hosgeldiniz!" ile bitiyorsa true dondurur değil ise false
            Console.WriteLine(degisken.EndsWith("Merhaba!"));   // degisken "Merhaba!" ile basliyorsa true dondurur değil ise false

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CSharp")); // degiskenin icinde "CSharp"'ı arar buldugu yerde ilk harfinin (C) indexini doner
            Console.WriteLine(degisken.IndexOf("Beytullah"));  // bulamazsa -1 doner
            Console.WriteLine(degisken.LastIndexOf("i"));   // dedgiskenin en sonundaki i'nin indexini getirir.

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! ")); // degiskenin 0.ci indexinden baslayarak "Merhaba! " ekler.


            //Padleft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); // degisken2'nin soluna, degisken2'nin karakter sayisi 30 olana kadar bosluk ekler. 
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*')); // degisken2'nin soluna, degisken2'nin karakter sayisi 30 olana kadar * ekler.
            Console.WriteLine(degisken.PadRight(50) + degisken2); // degisken'nin sagina, degisken'nin karakter sayisi 50 olana kadar bosluk ekler.
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2); // degisken'nin sagina, degisken'nin karakter sayisi 50 olana kadar - ekler.

            //Remove
            Console.WriteLine(degisken.Remove(10)); // degiskenin 10. indexinden sonrasini siler.
            Console.WriteLine(degisken.Remove(5,3)); // degiskenin 5. indexinden sonra 3 karakter siler.
            Console.WriteLine(degisken.Remove(0, 1)); // degiskenin ilk harfini siler.
            Console.WriteLine(degisken.Remove(degisken.Length-1, 1)); //degiskenin son karakterini siler

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#")); // degiskenin icindeki "CSharp"'i "C#" ile degistirir.
            Console.WriteLine(degisken.Replace(" ", "*")); // degiskenin icindeki boslukları * ile degistirir.


            //Split
            Console.WriteLine(degisken.Split(' ')[1]); // degiskeni bosluklardan boler ve bir diziye atar. Daha sonra dizinin 1.indexindeki kelimeyi dondurur.
            string[] str = degisken.Split(' '); // degiskeni bosluklardan boler ve str dizisine atar.
            foreach (string item in str)
                Console.WriteLine(item);

            //Substring
            Console.WriteLine(degisken.Substring(4)); //degiskenin 4.indexten baslayarak  tum karakterlerini getirir.
            Console.WriteLine(degisken.Substring(4,6)); //degiskenin 4.indexten baslayarak  6 karakterlerini getirir.
        }
    }
}
