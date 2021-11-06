using System;

namespace recursive_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // rekrusif - oz yinelemeli
            // 3^4

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3,4));

            // Extension methods
            string ifade = "Beytullah Kalay";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());

            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeUpperCase());

            Console.WriteLine(ifade.MakeLoweCase());

            int[] dizi = { 5, 3, 2, 6, 3, 12, 36, 123, 15 };

            Console.WriteLine(dizi.SortArray());
            dizi.EkranaYazdir();

            int sayi = 8;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo (int sayi, int us)
        {
            if (us<2)
                return sayi;

            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extesion
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLoweCase(this string param)
        {
            return param.ToLower();
        }

        public static int []SortArray(this int[]dizi)
        {
            Array.Sort(dizi);
            return dizi;
        }

        public static void EkranaYazdir(this int[]param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
