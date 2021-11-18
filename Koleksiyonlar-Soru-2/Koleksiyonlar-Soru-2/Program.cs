

//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları
//ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int[] minArr = new int[3] { arr[0], arr[1], arr[2] };

            Array.Reverse(arr);

            int[] maxArr = new int[3] { arr[0], arr[1], arr[2] }; ;


            Console.WriteLine("******** Min Array **********");
            int sum1 = 0;
            for (int i = 0; i < minArr.Length; i++)
            {
                Console.WriteLine(minArr[i]);
                sum1 += minArr[i];
            }
            Console.WriteLine("******** Min Array Sum **********");
            Console.WriteLine(sum1);
            Console.WriteLine("******** Min Array Average**********");
            Console.WriteLine(sum1 / minArr.Length);

            ////////// **************************************************** /////////////////////////////

            Console.WriteLine("******** Max Array **********");
            int sum2 = 0;
            for (int i = 0; i < maxArr.Length; i++)
            {
                Console.WriteLine(maxArr[i]);
                sum2 += maxArr[i];
            }
            Console.WriteLine("******** Min Array Sum **********");
            Console.WriteLine(sum2);
            Console.WriteLine("******** Max Array Average**********");
            Console.WriteLine(sum2 / maxArr.Length);

        }
    }
}
