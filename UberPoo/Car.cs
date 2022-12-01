using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;

namespace UberPoo
{
    internal class Car
    {
        int id;
        string license;
        Account driver; // llamar de la clase driver account driver
        private int passenger;

        public Car(string license, Account driver) //Account driver)
        {
            this.license = license; //this.license hace referencia a la variable global y license es la variable local.
            this.driver = driver;
            passenger = 3;
            Console.WriteLine("Passenger: " + passenger);
        }

        public void PrintDataCar()
        {
            Console.WriteLine("License: " + license + " Driver: " + driver.name);
            
        }
    }
}
