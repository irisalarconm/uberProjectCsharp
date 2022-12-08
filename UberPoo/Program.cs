using System;

namespace UberPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car uber1 = new UberX(license: "AMQ123", new Account(name: "Fernando Aguilar", document: "10212154"), brand: "Chevrolet", model: "2018");
            uber1.setPassenger(4);
            uber1.PrintDataCar();

            UberVan uberVan = new UberVan("XST456", new Account("Xiomara Penique", "21568432"));
            uberVan.setPassenger(6);
            uberVan.PrintDataCar();
        }
    }
}
