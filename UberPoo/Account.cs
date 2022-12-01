using System;
using System.Collections.Generic;
using System.Text;

namespace UberPoo
{
    internal class Account
    {
        int id;
        public string name;
        string document;
        string email;
        string password;
        public Account(string name, string document)
        {
            this.name = name;
            this.document = document;
        }
    }
}
