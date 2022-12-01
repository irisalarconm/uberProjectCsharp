using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UberPoo
{
    internal class Paypal: Payment
    {
        string email;

        public Paypal(int id, string email) : base(id)
        {
            this.email = email;
        }
        
    }
}
