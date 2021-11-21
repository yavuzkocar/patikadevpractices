using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Tohumlu Bitkiler **********");
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            //tohumluBitki.Beslen();
            //tohumluBitki.Solunum();
            //tohumluBitki.Bosaltim();
            //tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaCogalan();

            Console.WriteLine("******** Kuslar **********");
            Kuslar marti = new Kuslar();
            //marti.Beslen();
            //marti.Solunum();
            //marti.Bosaltim();
            //marti.Adaptasyon();
            marti.Ucmak();



        }
    }
}
