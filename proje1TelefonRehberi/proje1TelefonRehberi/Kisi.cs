using System;
using System.Collections.Generic;
using System.Text;

namespace proje1TelefonRehberi
{
    public class Kisi
    {
        private string isim;
        private string soyisim;
        private int no;

        public Kisi(string isim, string soyisim, int no)
        {
            Isim = isim;
            Soyisim = soyisim;
            TelNo = no;
        }

        public string Isim { get; set; }
        public string Soyisim { get;set; }
        public int TelNo { get; set; }
    }
}
