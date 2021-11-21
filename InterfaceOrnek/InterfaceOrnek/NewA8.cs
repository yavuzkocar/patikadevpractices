using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    public class NewA8 : Otomobil
    {
        public override Marka OtomobilMarkasi()
        {
            return Marka.Audi;
        }

        public override Renk StandartRenk()
        {
            return Renk.Siyah;
        }
    }
}
