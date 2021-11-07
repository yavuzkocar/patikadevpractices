using System;

namespace method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);    // gunun tarihi getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());


            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(40));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // gunu sayi (22-25-12-31) olarak getirir
            Console.WriteLine(DateTime.Now.ToString("ddd")); // gunu kisa metin (sat - mon - wed) olarak getirir
            Console.WriteLine(DateTime.Now.ToString("dddd")); // gunu metin (saturday - monday - wednesday) olarak getirir

            Console.WriteLine(DateTime.Now.ToString("MM")); // ayi sayi (12-04-05-08) olarak getirir
            Console.WriteLine(DateTime.Now.ToString("MMM")); // ayi kisa metin (apr - jun - oct) olarak getirir
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // ayi metin (april - july - november) olarak getirir

            Console.WriteLine(DateTime.Now.ToString("yy")); // yili sayi (21-99-13-25) olarak getirir
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // yili uzun sayi (2021 - 2099 - 2025) olarak getirir


            Console.WriteLine("******** Math Lib *********");

            //Math

            Console.WriteLine(Math.Abs(-25)); // mutlak degerini alir
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));  // 22.3'ten buyuk en kucuk tam sayi doner -> 23
            Console.WriteLine(Math.Round(22.3));    // 22.3'e en yakın tam sayi doner -> 22
            Console.WriteLine(Math.Round(22.7));    // 22.7'e en yakın tam sayi doner -> 23
            Console.WriteLine(Math.Floor(22.7));    // 22.7'ten kucuk en buyuk tam sani doner -> 22

            Console.WriteLine(Math.Max(2, 6));  // buyuk olani donurur -> 6
            Console.WriteLine(Math.Min(2, 6));  // kucuk olani donurur -> 2

            Console.WriteLine(Math.Pow(2, 6));  // 2^6 dondurur -> 64
            Console.WriteLine(Math.Sqrt(25));   // karekokunu dondurur -> 5
            Console.WriteLine(Math.Log(9));     // 9'un e tabanindaki logaritmik karsiligini dondurur.
            Console.WriteLine(Math.Exp(3));     // e^3 dondurur.
            Console.WriteLine(Math.Log10(10));  // 10 sayisinin log 10 tabanindaki karsiligi doner.
        }
    }
}
