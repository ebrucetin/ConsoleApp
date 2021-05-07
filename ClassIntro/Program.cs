using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "ebru çetin";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.Egitmen = "Ruken göçmen";
            kurs3.IzlenmeOrani = 65;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "java";
            kurs4.Egitmen = "Duygu Emgin";
            kurs4.IzlenmeOrani = 69;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3,kurs4
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + "  İzlenme Oranı: " + kurs.IzlenmeOrani);
            }



        }
    }

    class Kurs 
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
 
}
