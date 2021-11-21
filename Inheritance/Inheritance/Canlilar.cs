using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslen()
        {
            Console.WriteLine("Canlilar beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlilar solunum yapar.");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlilar bosaltim yapar.");
        }

        public virtual void UyaranlaraTepki() // <- virtual olarak isaretli.
        {
            Console.WriteLine("Canlilar uyaranlara tepki verir.");
        }
    }
}
