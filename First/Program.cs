using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself-Kendini tekrarlama
            //Değer tutucu -alias
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is the end");

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.75;
            double dolarBugun = 7.75;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış oku");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku ");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }
            Console.WriteLine(kategoriEtiketi);

        } 
    }
}
