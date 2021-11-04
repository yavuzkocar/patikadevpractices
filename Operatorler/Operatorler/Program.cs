using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bilgisyar muhendisligi 4.sınıf ogrencisiyim bunları bildiğimi dusunuyorum o yuzden hepsini yapmıyorum.

            // testleri cozup geldim 2 yanlıs cıktı yine. kullanaMAYIZ ve tutaMAYIZ mıs :(

            //Umarim bunlara bakiyorsunuzdur :(

            // Atama ve islemli atama

            int x = 3;
            int y = 3;

            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);



            bool isSucces = true;
            bool isCompleted = false;

            if (isSucces && isCompleted)
                Console.WriteLine("Perfect");
            if (isSucces || isCompleted)
                Console.WriteLine("Great");
            if (isSucces && !isCompleted)
                Console.WriteLine("Fine");

            

        }
    }
}
