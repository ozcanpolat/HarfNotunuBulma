using System;

namespace HarfNotunuBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ortalamaya göre
            // not aralığına karşılık gelen not bilgisini yazdırınız.


            // 0 -24  => 0
            // 25-44  => 1
            // 45-54  => 2
            // 55-69  => 3
            // 70-84  => 4
            // 85-100 => 5

            Console.Write("İlk yazılı notunuzu girin :");
            int yazili1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci yazılı notunuzu girin :");
            int yazili2 = int.Parse(Console.ReadLine());

            Console.Write("Sözlü notunuzu girin :");
            int sozlu = int.Parse(Console.ReadLine());

            int ortalama= ( yazili1 + yazili2 + sozlu ) / 3;

            if(ortalama<25)
            {
                Console.WriteLine("Harf notunuz : 0");
            }
            else if(ortalama>=25 && ortalama < 45)
            {
                Console.WriteLine("Harf notunuz : 1");
            }
            else if (ortalama >= 45 && ortalama < 55)
            {
                Console.WriteLine("Harf notunuz : 2");
            }
            else if (ortalama >= 55 && ortalama < 70)
            {
                Console.WriteLine("Harf notunuz : 3");
            }
            else if (ortalama >= 70 && ortalama < 85)
            {
                Console.WriteLine("Harf notunuz : 4");
            }
            else if (ortalama >= 85 && ortalama < 45)
            {
                Console.WriteLine("Harf notunuz : 5");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaotınız.");
            }

        }
    }
}
