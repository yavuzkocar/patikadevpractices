using System;

namespace Enumlar
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Cumartesi);
            Console.WriteLine((int)Gunler.Cumartesi); // numerik olarak yazdirmak icin basina (int) koymaliyiz.
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            Console.WriteLine("*********** Hava Durumu ***************");

            int sicaklik = 3;

            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine(HavaDurumu.Soguk);
            else if (sicaklik <= (int)HavaDurumu.Sicak)
                Console.WriteLine(HavaDurumu.Normal);
            else if (sicaklik <= (int)HavaDurumu.CokSicak)
                Console.WriteLine(HavaDurumu.Sicak);
            else
                Console.WriteLine(HavaDurumu.CokSicak);
            
            
        }
    }

    enum Gunler
    {
        Pazartesi, // -> 0
        Sali, // -> 1
        Carsamba, // -> 2
        Persembe, // -> 3
        Cuma = 23, // degiskenin sira numarasini 4 -> 23 yaptik. Bu dedegisim bu degiskenden sonraki tum degiskenleri etkiler. Yani Cumartesi artık 24'e Pazar ise 25'e esit.
        Cumartesi, // -> 24
        Pazar // -> 25
    }


    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 35,
    }
}
