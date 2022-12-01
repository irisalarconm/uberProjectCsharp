using System;

namespace UberPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car uber1 = new UberX(license: "AMQ123", new Account(name: "Fernando Aguilar", document: "10212154"), brand: "Chevrolet", model: "2018");
            uber1.PrintDataCar();
        }
    }
}
