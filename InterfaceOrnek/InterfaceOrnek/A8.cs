using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    public class A8 : IOtomobil
    {
        public Marka OtomobilMarkasi()
        {
            return Marka.Audi;
        }

        public Renk StandartRenk()
        {
            return Renk.Siyah;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}
