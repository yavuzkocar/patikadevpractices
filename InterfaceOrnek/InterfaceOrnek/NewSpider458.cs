using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    public class NewSpider458 : Otomobil
    {
        public override Marka OtomobilMarkasi()
        {
            return Marka.Ferrari;
        }

        public override Renk StandartRenk()
        {
            return Renk.Kirmizi;
        }
    }
}
