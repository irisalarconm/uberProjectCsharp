using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UberPoo
{
    internal class UberVan : Car
    {
        ArrayList typeCarAccepted = new ArrayList();
        ArrayList seatsMaterial = new ArrayList();

        public UberVan(string license, Account driver, ArrayList typeCarAccepted, ArrayList seatsMaterial) : base(license, driver)
        {
            this.typeCarAccepted = typeCarAccepted;
            this.seatsMaterial = seatsMaterial;
        }
    }
}
