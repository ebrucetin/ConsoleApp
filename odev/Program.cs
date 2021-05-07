using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product skirt = new Product();
            skirt.gender = "female";
            skirt.size = 34;
            skirt.color = "green";
            skirt.price = 108;

            Product pants = new Product();
            pants.gender = "male";
            pants.size = 40;
            pants.color = "black";
            pants.price = 220;

            Product shoes = new Product();
            shoes.gender = "unisex";
            shoes.size = 39;
            shoes.color = "red";
            shoes.price = 300;


            Product[] product = new Product[]
            {
                skirt,pants,shoes
            };

            foreach (var prod in product)
            {
                Console.WriteLine("Product size : " + prod.size  + " Product Gender : " + prod.gender + 
                    " Product color :  " + prod.color + " Product price : " + prod.price);
            }
        }
    }


    class Product
    {
        public int size { get; set; }
        public string gender { get; set; }
        public string color { get; set; }
        public int price { get; set; }

    }












}
