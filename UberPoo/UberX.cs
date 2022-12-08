using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UberPoo
{
    internal class UberX : Car
    {
        string brand;
        string model;

        public UberX(string license, Account driver, string brand, string model) : base(license, driver)
        {
            this.brand = brand;
            this.model = model;
        }

        public override void PrintDataCar()
        {
            base.PrintDataCar();
            if (passenger != 0)
            {
                Console.WriteLine($"Marca : {brand} Modelo: {model}");
            }
        }
    }
}
