﻿using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metodlar ornek = new Metodlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2 =  ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }

        // Call by value
        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;

        }
    }
}
