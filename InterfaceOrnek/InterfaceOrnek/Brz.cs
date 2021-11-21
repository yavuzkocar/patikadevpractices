using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    public class Brz : IOtomobil
    {
        public Marka OtomobilMarkasi()
        {
            return Marka.Subaru;
        }

        public Renk StandartRenk()
        {
            return Renk.Mavi;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}
