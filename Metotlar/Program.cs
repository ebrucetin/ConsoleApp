using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 18;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Çilek";
            urun2.Fiyati = 36;
            urun2.Aciklama = "Tatlı Çilek";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 70;
            urun3.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2,urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------");
            }

            Console.WriteLine("-------------Metotlar----------");
            //instance-örnek
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.ekle2("elma", "yeşil elma", 15);
            sepetmanager.ekle2("armut", "sarı armut", 14);
            sepetmanager.ekle2("karpuz", "diyarbakır karpuzu", 18);





        }
    }
} 
