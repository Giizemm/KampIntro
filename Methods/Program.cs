using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Detail = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Detail = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Detail);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("------------Metodlar-------------");

            //instance -örnek oluşturma
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}
