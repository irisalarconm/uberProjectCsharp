using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;

namespace UberPoo
{
    internal class Car
    {
        private int id;
        private string license;
        private Account driver; // llamar de la clase driver account driver
        protected int passenger;

        public Car(string license, Account driver) //Account driver)
        {
            this.license = license; //this.license hace referencia a la variable global y license es la variable local.
            this.driver = driver;
        }

        public virtual void PrintDataCar()
        {
            if (passenger != 0)
            {
                Console.WriteLine("License: " + license + " Driver: " + driver.name + " Passengers: " + passenger);
            }
        }

        public int getPassenger()
        {
            return passenger;
        }
        
        public virtual void setPassenger(int passenger)
        {
            if(passenger == 4)
            {
                this.passenger = passenger;
            }
            else
            {
                Console.WriteLine("Necesitas asignar 4 pasajeros");
            }
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public string getLicense()
        {
            return license;
        }
        public void setLicense(string license)
        {
            this.license = license;
        }
        public Account getDriver()
        {
            return driver;
        }
        public void setDriver(Account driver)
        {
            this.driver = driver;
        }
    }
}
