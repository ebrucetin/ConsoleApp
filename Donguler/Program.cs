using System;

namespace Donguler
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Python";
            string kurs4 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            string[] kurslar = new string[]
            {"Yazılım geliştirici yetiştirme kampı","Programlamaya başlangıç için temel kurs",
            "Python","Java"  };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) //dizi elemanlarını tek tek yazmaya yarayan döngü 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu -- footer");
        }
    }
}
