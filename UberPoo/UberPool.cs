using System;
using System.Collections.Generic;
using System.Text;

namespace UberPoo
{
    internal class UberPool : Car
    {
        string brand;
        string model;

        public UberPool(string license, Account driver, string brand, string model) : base(license, driver)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
