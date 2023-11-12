using System;
namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayiya kadr olan tek sayilari ekrana yazdir.
            Console.WriteLine("Lütfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                //komutlar
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("******");
            // 1 ile 1000 arasindaki tek ve cift sayilarin kendi iclerinde toplamlarini yazdir.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i; // tekToplam = tekToplam + i;
                }
                else
                {
                    ciftToplam += i; // ciftToplam = cifToplam + i;
                }
            }
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Cift Toplam: " + ciftToplam);
            Console.WriteLine("*****");
            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}