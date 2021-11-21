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

        public override void UyaranlaraTepki() // <- virtual olarak isaretlenen metodu
        {                                       // override ile yeniden yaziyoruz.
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
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
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar.");
        }
    }
}
