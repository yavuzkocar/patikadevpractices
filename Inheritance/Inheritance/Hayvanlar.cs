using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {

        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte olabilir.");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Surungenler surunerek hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslen();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar.");
        }
    }
}
