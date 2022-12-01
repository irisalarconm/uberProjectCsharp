using System;
using System.Collections.Generic;
using System.Text;

namespace UberPoo
{
    internal class Card
    {
        int number;
        int cvv;
        string date;

        public Card(int number, int cvv, string date)
        {
            this.number = number;
            this.cvv = cvv;
            this.date = date;
        }
    }
}
