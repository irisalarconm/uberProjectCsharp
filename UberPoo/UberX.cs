using System;
using System.Collections.Generic;
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
    }
}
