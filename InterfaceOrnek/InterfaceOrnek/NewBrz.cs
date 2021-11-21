using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    public class NewBrz : Otomobil
    {
        public override Marka OtomobilMarkasi()
        {
            return Marka.Subaru;
        }

        public override Renk StandartRenk()
        {
            return Renk.Mavi;
        }
    }
}
