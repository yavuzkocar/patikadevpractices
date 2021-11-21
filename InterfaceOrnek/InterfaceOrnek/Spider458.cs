using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    public class Spider458 : IOtomobil
    {
        public Marka OtomobilMarkasi()
        {
            return Marka.Ferrari;
        }

        public Renk StandartRenk()
        {
            return Renk.Kirmizi;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}
