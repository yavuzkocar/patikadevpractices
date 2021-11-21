using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    public abstract class Otomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }

        public abstract Renk StandartRenk();

        public abstract Marka OtomobilMarkasi();

    }
}
