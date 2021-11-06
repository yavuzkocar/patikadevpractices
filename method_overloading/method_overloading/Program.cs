using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            //out parameters
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Basarili!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Basarisiz!");
            }

            Methods instance = new Methods();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //method overloading
            int ifade = 2121;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Beytullah");


        }

        class Methods
        {
            public void Topla (int a, int b, out int toplam)
            {
                toplam = a + b;
            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
        }
    }
}
