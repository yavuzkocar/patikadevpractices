using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bitkiler : Canlilar
    {

        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki() // <- virtual olarak isaretlenen metodu
        {                                      // override ile yeniden yaziyoruz.
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler gunese tepki verir.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslen();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalan()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalir.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {

        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Beslen();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir.");
        }
    }
}
