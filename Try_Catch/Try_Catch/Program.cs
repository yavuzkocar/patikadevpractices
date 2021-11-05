using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Bir sayi giriniz : ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girilen sayi: " + sayi);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message.ToString());
            //    //throw;
            //}
            //finally
            //{
            //    Console.WriteLine("Islem tamamlandi.");
            //}


            try
            {
                //int a = int.Parse("test");
                int b = int.Parse("-30000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Cok kucuk yada cok buyuk bir deger girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("islem basariyla tamamladi.");
            }

            int v = 20;
            decimal h = v;

        }
    }
}
