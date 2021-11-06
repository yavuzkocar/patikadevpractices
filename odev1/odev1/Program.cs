using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            soru3();

        }

        public static void soru1()
        {
            // input al
            Console.WriteLine("Pozitif bir sayi girin: ");
            int n = int.Parse(Console.ReadLine());

            IsInputPositive(ref n);


            // diziyi doldur
            int[] dizi = new int[n];
            Console.WriteLine(n + " tane pozitif sayi  giriniz");
            for (int i = 0; i < n; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
                IsInputPositive(ref dizi[i]);
            }

            // ayikla ve yazdir.
            Console.WriteLine("********** Cift Sayilar **********");
            for (int i = 0; i < n; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.Write(dizi[i] + " ");
                }
            }
        }

        public static void soru2()
        {
            int n, m;
            Console.Write("Iki adet sayi giriniz : ");

            //2 degisken icin for kullanmak daha zahmetli geldi.
            n = int.Parse(Console.ReadLine());
            IsInputPositive(ref n);

            m = int.Parse(Console.ReadLine());
            IsInputPositive(ref m);


            Console.WriteLine(n + " adet pozitif sayi giriniz");
            int []dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
                IsInputPositive(ref dizi[i]);
            }

            Console.WriteLine(m + " sayisina tam bolunen sayilar:");
            for (int i = 0; i < n; i++)
            {
                if (dizi[i] % m == 0)
                {
                    Console.Write(dizi[i] + " ");
                }
            }


        }

        public static void soru3()
        {
            // input al
            Console.WriteLine("Pozitif bir sayi girin: ");
            int n = int.Parse(Console.ReadLine());

            // diziye koy
            Console.WriteLine(n + " adet kelime giriniz(her kelimeden enter)"); // bu kismin kirilabileceginin farkindayim ama gercekten yapmak hic icimden gelmedi.
            string[] dizi = new string[n];
            for (int i = 0; i < n; i++)
                dizi[i] = Console.ReadLine();


            // tersten yazdir
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);
            }

            
        }

        public static void IsInputPositive(ref int input)
        {
            while (input <= 0)
            {
                Console.Write("Lutfen pozitif bir sayi girin: ");
                input = int.Parse(Console.ReadLine());
            }
        }
    }
}
