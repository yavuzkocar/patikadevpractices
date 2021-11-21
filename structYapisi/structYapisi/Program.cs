using System;

namespace structYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 5;
            dikdortgen.UzunKenar = 6;
            Console.WriteLine("Class alan hesabi = {0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3,9);
            // Dikdortgen_Struct dikdortgen_struct;  <<<<<<<<<<<<<< Seklinde de kullanilabilir.
            Console.WriteLine("Struct alan hesabi = {0}", dikdortgen_struct.AlanHesapla());

        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kisaKenar,int uzunKenar )
        {
            this.KisaKenar = kisaKenar;
            this.UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
