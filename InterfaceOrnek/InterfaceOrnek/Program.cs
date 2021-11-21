using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Spider 458 ************");
            Spider458 spider = new Spider458();
            Console.WriteLine(spider.OtomobilMarkasi());
            Console.WriteLine(spider.StandartRenk());
            Console.WriteLine(spider.TekerlekSayisi());
            
            Console.WriteLine("************ A8 ************");
            A8 a8 = new A8();
            Console.WriteLine(a8.OtomobilMarkasi());
            Console.WriteLine(a8.StandartRenk());
            Console.WriteLine(a8.TekerlekSayisi());

            Console.WriteLine("************ Brz ************");
            Brz brz = new Brz();
            Console.WriteLine(brz.OtomobilMarkasi());
            Console.WriteLine(brz.StandartRenk());
            Console.WriteLine(brz.TekerlekSayisi());

            Console.WriteLine("************ New Spider 458 ************");
            NewSpider458 newSpider = new NewSpider458();
            Console.WriteLine(newSpider.OtomobilMarkasi());
            Console.WriteLine(newSpider.StandartRenk());
            Console.WriteLine(newSpider.TekerlekSayisi());

            Console.WriteLine("************ New A8 ************");
            NewA8 newA8 = new NewA8();
            Console.WriteLine(newA8.OtomobilMarkasi());
            Console.WriteLine(newA8.StandartRenk());
            Console.WriteLine(newA8.TekerlekSayisi());

            Console.WriteLine("************ New Brz ************");
            NewBrz newBrz = new NewBrz();
            Console.WriteLine(newBrz.OtomobilMarkasi());
            Console.WriteLine(newBrz.StandartRenk());
            Console.WriteLine(newBrz.TekerlekSayisi());
        }
    }
}
